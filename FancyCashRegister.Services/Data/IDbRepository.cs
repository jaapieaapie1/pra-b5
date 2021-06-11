using MySql.Data.MySqlClient;

namespace FancyCashRegister.Services.Data
{
    public interface IDbRepository
    {
        string LastError { get; }

        void Close();
        void Dispose();
        void Open();
    }
}