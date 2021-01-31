using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ShippingRegionExcluded
    {
        public int MethodId { get; set; }
        public int RegionId { get; set; }

        public ShippingMethod Method { get; set; }
        public Region Region { get; set; }
    }
}
