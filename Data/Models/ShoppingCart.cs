using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ShoppingCart
    {
        public int ShoppingCartItemId { get; set; }
        public Guid CustomerId { get; set; }
        public int AffiliateId { get; set; }
        public int? ReservationResourceId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Services { get; set; }

        public Affiliate Affiliate { get; set; }
        public ReservationResource ReservationResource { get; set; }
    }
}
