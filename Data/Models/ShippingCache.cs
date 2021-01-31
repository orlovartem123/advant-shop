using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ShippingCache
    {
        public int ShippingMethodId { get; set; }
        public int ParamHash { get; set; }
        public string Options { get; set; }
        public DateTime Created { get; set; }

        public ShippingMethod ShippingMethod { get; set; }
    }
}
