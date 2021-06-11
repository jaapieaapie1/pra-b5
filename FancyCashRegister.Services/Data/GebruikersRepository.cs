using FancyCashRegister.Domain.Models;
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
    public class GebruikersRepository : BaseDbRepository
    {
        protected const string VELD_ROL_ROL_ID = "rol_id";
        protected const string VELD_ROL_NAAM = "naam";
        protected const string VELD_ROL_BESCHRIJVING = "beschrijving";
        protected const string VELD_ROL_IS_ACTIEF = "is_actief";

        protected const string VELD_GEBRUIKER_GEBRUIKER_ID = "gebruiker_id";
        protected const string VELD_GEBRUIKER_ROL_ID = "rol_id";
        protected const string VELD_GEBRUIKER_GEBRUIKERSNAAM = "gebruikersnaam";
        protected const string VELD_GEBRUIKER_VOLLEDIGE_NAAM = "volledige_naam";
        protected const string VELD_GEBRUIKER_PINCODE = "pincode";
        protected const string VELD_GEBRUIKER_IS_ACTIEF = "is_actief";


        public GebruikersRepository() : base()
        {
        }

        public IEnumerable<Rol> Rollen => RollenTable.AsEnumerable().Select(r => new Rol
        {
            Id = r.Field<int>(VELD_ROL_ROL_ID),
            Naam = r.Field<string>(VELD_ROL_NAAM),
            Beschrijving = r.Field<string>(VELD_ROL_BESCHRIJVING),
            IsActief = r.Field<bool>(VELD_ROL_IS_ACTIEF),
        });

        public IEnumerable<Gebruiker> Gebruikers => GebruikersTable.AsEnumerable().Select(g => new Gebruiker
        {
            Id = g.Field<int>(VELD_GEBRUIKER_GEBRUIKER_ID),
            RolId = g.Field<int>(VELD_GEBRUIKER_ROL_ID),
            Rol = Rollen.Where(r => r.Id == g.Field<int>(VELD_GEBRUIKER_ROL_ID)).FirstOrDefault(),
            Gebruikersnaam = g.Field<string>(VELD_GEBRUIKER_GEBRUIKERSNAAM),
            Pincode = g.Field<string>(VELD_GEBRUIKER_PINCODE),
            VolledigeNaam = g.Field<string>(VELD_GEBRUIKER_VOLLEDIGE_NAAM),
            IsActief = g.Field<bool>(VELD_GEBRUIKER_IS_ACTIEF),
        });

        public bool UpdateGebruiker(Gebruiker gebruiker)
        {
            var paramGebruikerId = "@gebruikerId";
            var paramRolId = "@rolId";
            var paramGebruikersnaam = "@gebruikersnaam";
            var paramVolledigeNaam = "@volledigeNaam";
            var paramPincode = "@pincode";
            var paramIsActief = "@isActief";

            var qry = $@"update gebruikers 
set
    {VELD_GEBRUIKER_ROL_ID} = {paramRolId},
    {VELD_GEBRUIKER_GEBRUIKERSNAAM} = {paramGebruikersnaam},
    {VELD_GEBRUIKER_VOLLEDIGE_NAAM} = {paramVolledigeNaam},
    {VELD_GEBRUIKER_PINCODE} = {(string.IsNullOrWhiteSpace(gebruiker.Pincode) ? "pincode" : $"{paramPincode}")},
    {VELD_GEBRUIKER_IS_ACTIEF} = {paramIsActief}
where {VELD_GEBRUIKER_GEBRUIKER_ID} = {paramGebruikerId}
";
            var parameters = new[] {
                new MySqlParameter(paramGebruikerId, gebruiker.Id),
                new MySqlParameter(paramRolId, gebruiker.RolId),
                new MySqlParameter(paramGebruikersnaam, gebruiker.Gebruikersnaam),
                new MySqlParameter(paramVolledigeNaam, gebruiker.VolledigeNaam),
                new MySqlParameter(paramPincode, gebruiker.Pincode),
                new MySqlParameter(paramIsActief, gebruiker.IsActief),
            };

            return UpdateQuery(qry, parameters);
        }

        public bool DeleteGebruiker(Gebruiker gebruiker)
        {
            var paramGebruikerId = "@gebruikerId";

            var qry = $@"delete 
from gebruikers 
where {VELD_GEBRUIKER_GEBRUIKER_ID} = {paramGebruikerId}";

            return DeleteQuery(qry, new MySqlParameter(paramGebruikerId, gebruiker.Id));
        }

        protected DataTable RollenTable
        {
            get
            {
                var qry = $@"select
    {VELD_ROL_ROL_ID},
    {VELD_ROL_NAAM},
    {VELD_ROL_BESCHRIJVING},
    {VELD_ROL_IS_ACTIEF}
    from rollen
order by {VELD_ROL_ROL_ID}";

                return GetDataTableForQuery(qry);
            }
        }

        protected DataTable GebruikersTable
        {
            get
            {
                var qry = $@"select 
    {VELD_GEBRUIKER_GEBRUIKER_ID},
    {VELD_GEBRUIKER_ROL_ID},
    {VELD_GEBRUIKER_GEBRUIKERSNAAM},
    {VELD_GEBRUIKER_VOLLEDIGE_NAAM},
    {VELD_GEBRUIKER_PINCODE},
    {VELD_GEBRUIKER_IS_ACTIEF}
from gebruikers
order by {VELD_GEBRUIKER_GEBRUIKER_ID};";

                return GetDataTableForQuery(qry);
            }
        }

        
        private Gebruiker GetGebruikerFromDataRow(DataRow gebruikerRow) => new()
        {
            Id = (int)gebruikerRow[VELD_GEBRUIKER_GEBRUIKER_ID],
            RolId = (int)gebruikerRow[VELD_GEBRUIKER_ROL_ID],
            Gebruikersnaam = gebruikerRow[VELD_GEBRUIKER_GEBRUIKERSNAAM] as string,
            VolledigeNaam = gebruikerRow[VELD_GEBRUIKER_VOLLEDIGE_NAAM] as string,
            Pincode = gebruikerRow[VELD_GEBRUIKER_PINCODE] as string,
            IsActief = (bool)gebruikerRow[VELD_GEBRUIKER_IS_ACTIEF]
        };

        private DataTable GetGebruikerTableByGebruikersnaam(string gebruikersnaam)
        {
            var paramGebruikersnaam = "@gebruikersNaam";

            var qry = $@"select 
    {VELD_GEBRUIKER_GEBRUIKER_ID},
    {VELD_GEBRUIKER_ROL_ID},
    {VELD_GEBRUIKER_GEBRUIKERSNAAM},
    {VELD_GEBRUIKER_VOLLEDIGE_NAAM},
    {VELD_GEBRUIKER_PINCODE},
    {VELD_GEBRUIKER_IS_ACTIEF}
from gebruikers
where gebruikersnaam = {paramGebruikersnaam}
order by {VELD_GEBRUIKER_GEBRUIKER_ID};";

            return GetDataTableForQuery(qry, new MySqlParameter(paramGebruikersnaam, gebruikersnaam));
        }
    }
}
