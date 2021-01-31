using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class AffiliateSmsTemplate
    {
        public int Id { get; set; }
        public int AffiliateId { get; set; }
        public byte Status { get; set; }
        public string Text { get; set; }
        public bool Enabled { get; set; }

        public Affiliate Affiliate { get; set; }
    }
}
