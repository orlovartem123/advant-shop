using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderTax
    {
        public int OrderId { get; set; }
        public int TaxId { get; set; }
        public string TaxName { get; set; }
        public double TaxSum { get; set; }
        public bool TaxShowInPrice { get; set; }
        public double TaxRate { get; set; }

        public Order Order { get; set; }
    }
}
