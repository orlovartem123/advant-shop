using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class AffiliateAnalyticManager
    {
        public int AffiliateId { get; set; }
        public int ManagerId { get; set; }

        public Affiliate Affiliate { get; set; }
        public Managers Manager { get; set; }
    }
}
