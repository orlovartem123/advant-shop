using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Tax
    {
        public int TaxId { get; set; }
        public string Name { get; set; }
        public bool? Enabled { get; set; }
        public bool? ShowInPrice { get; set; }
        public double Rate { get; set; }
        public int TaxType { get; set; }

        public GiftCertificateTaxes GiftCertificateTaxes { get; set; }
    }
}
