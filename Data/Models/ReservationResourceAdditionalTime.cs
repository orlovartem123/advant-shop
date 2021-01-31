﻿using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ReservationResourceAdditionalTime
    {
        public int Id { get; set; }
        public int AffiliateId { get; set; }
        public int ReservationResourceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsWork { get; set; }

        public Affiliate Affiliate { get; set; }
        public ReservationResource ReservationResource { get; set; }
    }
}