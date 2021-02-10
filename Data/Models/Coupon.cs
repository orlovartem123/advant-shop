using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Coupon
    {
        public Coupon()
        {
            CouponCategories = new HashSet<CouponCategories>();
            CouponCustomers = new HashSet<CouponCustomers>();
            CouponProducts = new HashSet<CouponProducts>();
            CustomerCoupon = new HashSet<CustomerCoupon>();
            Partner = new HashSet<Partner>();
        }

        public int CouponId { get; set; }
        public string Code { get; set; }
        public int Type { get; set; }
        public double Value { get; set; }
        public DateTime AddingDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int PossibleUses { get; set; }
        public int ActualUses { get; set; }
        public bool Enabled { get; set; }
        public decimal? MinimalOrderPrice { get; set; }
        public string CurrencyIso3 { get; set; }
        public int? TriggerId { get; set; }
        public int? Mode { get; set; }
        public int? TriggerActionId { get; set; }
        public int? Days { get; set; }
        public Guid? CustomerId { get; set; }
        public DateTime? StartDate { get; set; }
        public bool ForFirstOrder { get; set; }
        public int? EntityId { get; set; }
        public bool? IsMinimalOrderPriceFromAllCart { get; set; }

        public ICollection<CouponCategories> CouponCategories { get; set; }
        public ICollection<CouponCustomers> CouponCustomers { get; set; }
        public ICollection<CouponProducts> CouponProducts { get; set; }
        public ICollection<CustomerCoupon> CustomerCoupon { get; set; }
        public ICollection<Partner> Partner { get; set; }
    }
}
