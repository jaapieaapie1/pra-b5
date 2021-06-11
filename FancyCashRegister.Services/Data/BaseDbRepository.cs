using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCashRegister.Services.Data
{
    public abstract class BaseDbRepository : IDisposable, IDbRepository
    {
        private bool _disposedValue;

        protected readonly MySqlConnection _connection;

        public string LastError { get; private set; }


        public BaseDbRepository()
        {
            _connection = new MySqlConnection(new ConfigRepository().GetAppConfig().ConnectionString);
            LastError = string.Empty;
        }

        public void Open()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public void Close()
        {
            _connection?.Close();
        }

        protected DataTable GetDataTableForQuery(string qry, params MySqlParameter[] parameters)
        {
            var dataAdapter = new MySqlDataAdapter(qry, _connection);
            dataAdapter.SelectCommand.Parameters.AddRange(parameters);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        protected (bool success, int insertedId) InsertQuery(string qry, params MySqlParameter[] parameters)
        {
            var (rowsAffected, lastInsertedId) = executeNonQuery(qry, parameters);
            return (rowsAffected > 0, (int)lastInsertedId);

        }

        protected bool UpdateQuery(string qry, params MySqlParameter[] parameters)
        {
            return executeNonQuery(qry, parameters).rowsAffected > 0;
        }

        protected bool DeleteQuery(string qry, params MySqlParameter[] parameters)
        {
            return executeNonQuery(qry, parameters).rowsAffected > 0;
        }

        private (int rowsAffected, long lastInsertedId) executeNonQuery(string qry, params MySqlParameter[] parameters)
        {
            var cmd = new MySqlCommand(qry, _connection)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddRange(parameters);

            // TODO: logging en functionele fouten teruggeven naar boven -->
            try
            {
                if (_connection.State != ConnectionState.Open) Open();

                var rowsAffected = cmd.ExecuteNonQuery();

                return (rowsAffected, cmd.LastInsertedId); ;
            }
            catch (MySqlException mse)
            {
                LastError = $"Database fout opgetreden bij uitvoeren sql statement: {mse.Message}";
                return (-1, -1);
            }
            catch (Exception ex)
            {
                LastError = $"Onverwachte out opgetreden bij uitvoeren sql statement: {ex.Message}";
                return (-1, -1);
            }
        }

        //
        // dispose pattern -->
        //
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _connection?.Close();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BaseRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        //
        // <-- end dispose pattern
        //
    }
}
