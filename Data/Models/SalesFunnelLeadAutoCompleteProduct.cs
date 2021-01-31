using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SalesFunnelLeadAutoCompleteProduct
    {
        public int SalesFunnelId { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public SalesFunnel SalesFunnel { get; set; }
    }
}
