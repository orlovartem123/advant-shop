using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CouponProducts
    {
        public int CouponId { get; set; }
        public int ProductId { get; set; }

        public Coupon Coupon { get; set; }
        public Product Product { get; set; }
    }
}
