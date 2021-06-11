using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCashRegister.Domain.Models
{
    public class Order
    {
        public Order()
        {
        }
        public decimal TotaalPrijs => Producten.Select(p => p.TotaalPrijs).Sum();
        public BindingList<OrderProduct> Producten { get; set; } = new BindingList<OrderProduct>();
        public bool Betaald { get; set; }
        public Korting ActieveKorting { get; set; }
    }
}
