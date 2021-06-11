using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCashRegister.Domain.Models
{
    public class OrderProduct : Product
    {
        public int Aantal { get; set; }
        public decimal TotaalPrijs => Aantal * Stuksprijs;

        // dummies tbv binding via bindingsource <--> datagrid
        public string Plus => "+";
        public string Min => "-";

        public static OrderProduct CopyToSkyfilterClient(Product product)
        {
            return new OrderProduct
            {
                Id = product.Id,
                Naam = product.Naam,
                Beschrijving = product.Beschrijving,
                Stuksprijs = product.Stuksprijs,
                IsActief = product.IsActief,

            };
        }
    }
}
