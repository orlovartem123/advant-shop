using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderPriceDiscount
    {
        public int OrderPriceDiscountId { get; set; }
        public double PriceRange { get; set; }
        public double PercentDiscount { get; set; }
    }
}
