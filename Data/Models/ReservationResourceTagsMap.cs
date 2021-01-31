using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ReservationResourceTagsMap
    {
        public int ReservationResourceId { get; set; }
        public int ReservationResourceTagId { get; set; }

        public ReservationResource ReservationResource { get; set; }
        public ReservationResourceTag ReservationResourceTag { get; set; }
    }
}
