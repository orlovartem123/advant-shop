using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ShippingParam
    {
        public int ShippingParamId { get; set; }
        public int ShippingMethodId { get; set; }
        public string ParamName { get; set; }
        public string ParamValue { get; set; }

        public ShippingMethod ShippingMethod { get; set; }
    }
}
