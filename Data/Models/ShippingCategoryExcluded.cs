using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ShippingCategoryExcluded
    {
        public int MethodId { get; set; }
        public int CategoryId { get; set; }

        public Category1 Category { get; set; }
        public ShippingMethod Method { get; set; }
    }
}
