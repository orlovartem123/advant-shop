using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class AffiliateReservationResource
    {
        public int AffiliateId { get; set; }
        public int ReservationResourceId { get; set; }
        public int? BookingIntervalMinutes { get; set; }

        public Affiliate Affiliate { get; set; }
        public ReservationResource ReservationResource { get; set; }
    }
}
