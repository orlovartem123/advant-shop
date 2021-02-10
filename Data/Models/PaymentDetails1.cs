using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class PaymentDetails1
    {
        public int BookingId { get; set; }
        public string CompanyName { get; set; }
        public string Inn { get; set; }
        public string Phone { get; set; }
        public string Contract { get; set; }
        public bool? IsCashOnDeliveryPayment { get; set; }
        public bool? IsPickPointPayment { get; set; }

        public Booking Booking { get; set; }
    }
}
