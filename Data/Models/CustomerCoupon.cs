using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CustomerCoupon
    {
        public Guid CustomerId { get; set; }
        public int CouponId { get; set; }

        public Coupon Coupon { get; set; }
    }
}
