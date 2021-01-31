using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SalesFunnelLeadAutoCompleteCategory
    {
        public int SalesFunnelId { get; set; }
        public int CategoryId { get; set; }

        public Category1 Category { get; set; }
        public SalesFunnel SalesFunnel { get; set; }
    }
}
