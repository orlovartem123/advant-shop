using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Booking
    {
        public Booking()
        {
            BookingItems = new HashSet<BookingItems>();
        }

        public int Id { get; set; }
        public int AffiliateId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte Status { get; set; }
        public double Sum { get; set; }
        public DateTime DateAdded { get; set; }
        public Guid? CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Patronymic { get; set; }
        public long? StandardPhone { get; set; }
        public int? ReservationResourceId { get; set; }
        public int? ManagerId { get; set; }
        public int OrderSourceId { get; set; }
        public bool IsSendedSmsBeforeStart { get; set; }
        public double? BookingDiscount { get; set; }
        public double? BookingDiscountValue { get; set; }
        public double? DiscountCost { get; set; }
        public DateTime? PaymentDate { get; set; }
        public double? PaymentCost { get; set; }
        public int? PaymentMethodId { get; set; }
        public string ArchivedPaymentName { get; set; }
        public int? OrderId { get; set; }

        public Affiliate Affiliate { get; set; }
        public Managers Manager { get; set; }
        public Order Order { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ReservationResource ReservationResource { get; set; }
        public BookingCurrency BookingCurrency { get; set; }
        public PaymentDetails1 PaymentDetails1 { get; set; }
        public ICollection<BookingItems> BookingItems { get; set; }
    }
}
