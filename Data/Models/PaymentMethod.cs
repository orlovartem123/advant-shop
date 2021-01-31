using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Booking = new HashSet<Booking>();
            Order = new HashSet<Order>();
            PaymentCity = new HashSet<PaymentCity>();
            PaymentCountry = new HashSet<PaymentCountry>();
            PaymentParam = new HashSet<PaymentParam>();
            ShippingPayments = new HashSet<ShippingPayments>();
        }

        public int PaymentMethodId { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public int SortOrder { get; set; }
        public string Description { get; set; }
        public string PaymentType { get; set; }
        public double? Extracharge { get; set; }
        public int? ExtrachargeType { get; set; }
        public int? CurrencyId { get; set; }
        public int? TaxId { get; set; }

        public ICollection<Booking> Booking { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<PaymentCity> PaymentCity { get; set; }
        public ICollection<PaymentCountry> PaymentCountry { get; set; }
        public ICollection<PaymentParam> PaymentParam { get; set; }
        public ICollection<ShippingPayments> ShippingPayments { get; set; }
    }
}
