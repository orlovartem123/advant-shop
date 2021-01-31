using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CouponCategories
    {
        public int CouponId { get; set; }
        public int CategoryId { get; set; }

        public Category1 Category { get; set; }
        public Coupon Coupon { get; set; }
    }
}
