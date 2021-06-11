using System;

namespace FancyCashRegister.Domain.Models
{
    public class Korting
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public bool IsActief { get; set; }
        public DateTimeOffset GeldigVan { get; set; }
        public DateTimeOffset GeldigTot { get; set; }
    }
}