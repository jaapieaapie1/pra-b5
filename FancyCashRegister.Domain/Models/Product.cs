using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCashRegister.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategorieId { get; set; }
        public ProductCategorie Categorie { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public decimal Stuksprijs { get; set; }
        public bool IsActief { get; set; }

    }
}
