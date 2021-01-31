using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ShippingProductExcluded
    {
        public int MethodId { get; set; }
        public int ProductId { get; set; }

        public ShippingMethod Method { get; set; }
        public Product Product { get; set; }
    }
}
