using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SalesFunnelManager
    {
        public int SalesFunnelId { get; set; }
        public int ManagerId { get; set; }

        public Managers Manager { get; set; }
        public SalesFunnel SalesFunnel { get; set; }
    }
}
