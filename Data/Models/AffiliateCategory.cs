using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class AffiliateCategory
    {
        public int AffiliateId { get; set; }
        public int CategoryId { get; set; }

        public Affiliate Affiliate { get; set; }
        public Category Category { get; set; }
    }
}
