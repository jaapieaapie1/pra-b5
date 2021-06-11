using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCashRegister.Domain.Models
{
    public class Config
    {
        public int LengtePincode { get; set; }
        public string ConnectionString { get; set; }
        public bool BevestigAfsluiten { get; set; }
    }
}
