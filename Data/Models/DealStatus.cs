using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class DealStatus
    {
        public DealStatus()
        {
            SalesFunnelDealStatus = new HashSet<SalesFunnelDealStatus>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public string Color { get; set; }
        public int? Status { get; set; }

        public ICollection<SalesFunnelDealStatus> SalesFunnelDealStatus { get; set; }
    }
}
