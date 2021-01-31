using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class BookingItems
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int? ServiceId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public string ArtNo { get; set; }

        public Booking Booking { get; set; }
        public Service Service { get; set; }
    }
}
