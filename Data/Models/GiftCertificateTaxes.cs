using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class GiftCertificateTaxes
    {
        public int TaxId { get; set; }

        public Tax Tax { get; set; }
    }
}
