using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CouponCustomers
    {
        public int CouponId { get; set; }
        public Guid CustomerId { get; set; }

        public Coupon Coupon { get; set; }
        public Customer Customer { get; set; }
    }
}
