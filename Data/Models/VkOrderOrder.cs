using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class VkOrderOrder
    {
        public int OrderId { get; set; }
        public int VkOrderId { get; set; }

        public Order Order { get; set; }
    }
}
