using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SalesFunnelDealStatus
    {
        public int SalesFunnelId { get; set; }
        public int DealStatusId { get; set; }

        public DealStatus DealStatus { get; set; }
        public SalesFunnel SalesFunnel { get; set; }
    }
}
