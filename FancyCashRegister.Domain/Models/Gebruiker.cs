using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCashRegister.Domain.Models
{
    public class Gebruiker
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
        public string Gebruikersnaam { get; set; }
        public string VolledigeNaam { get; set; }
        public string Pincode { get; set; }
        public bool IsActief { get; set; }
    }
}
