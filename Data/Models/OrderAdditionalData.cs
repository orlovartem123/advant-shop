using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderAdditionalData
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public Order Order { get; set; }
    }
}
