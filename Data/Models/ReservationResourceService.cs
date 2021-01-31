using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ReservationResourceService
    {
        public int AffiliateId { get; set; }
        public int ReservationResourceId { get; set; }
        public int ServiceId { get; set; }

        public Affiliate Affiliate { get; set; }
        public ReservationResource ReservationResource { get; set; }
        public Service Service { get; set; }
    }
}
