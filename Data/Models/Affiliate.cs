using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Affiliate
    {
        public Affiliate()
        {
            AffiliateAdditionalTime = new HashSet<AffiliateAdditionalTime>();
            AffiliateAnalyticManager = new HashSet<AffiliateAnalyticManager>();
            AffiliateCategory = new HashSet<AffiliateCategory>();
            AffiliateManager = new HashSet<AffiliateManager>();
            AffiliateReservationResource = new HashSet<AffiliateReservationResource>();
            AffiliateService = new HashSet<AffiliateService>();
            AffiliateSmsTemplate = new HashSet<AffiliateSmsTemplate>();
            AffiliateTimeOfBooking = new HashSet<AffiliateTimeOfBooking>();
            Booking = new HashSet<Booking>();
            ReservationResourceAdditionalTime = new HashSet<ReservationResourceAdditionalTime>();
            ReservationResourceService = new HashSet<ReservationResourceService>();
            ReservationResourceTimeOfBooking = new HashSet<ReservationResourceTimeOfBooking>();
            ShoppingCart = new HashSet<ShoppingCart>();
        }

        public int Id { get; set; }
        public int? CityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int BookingIntervalMinutes { get; set; }
        public int SortOrder { get; set; }
        public bool Enabled { get; set; }
        public bool AccessForAll { get; set; }
        public bool IsActiveSmsNotification { get; set; }
        public int? ForHowManyMinutesToSendSms { get; set; }
        public string SmsTemplateBeforeStartBooiking { get; set; }
        public bool AnalyticsAccessForAll { get; set; }
        public bool AccessToViewBookingForResourceManagers { get; set; }
        public int? CancelUnpaidViaMinutes { get; set; }

        public City City { get; set; }
        public ICollection<AffiliateAdditionalTime> AffiliateAdditionalTime { get; set; }
        public ICollection<AffiliateAnalyticManager> AffiliateAnalyticManager { get; set; }
        public ICollection<AffiliateCategory> AffiliateCategory { get; set; }
        public ICollection<AffiliateManager> AffiliateManager { get; set; }
        public ICollection<AffiliateReservationResource> AffiliateReservationResource { get; set; }
        public ICollection<AffiliateService> AffiliateService { get; set; }
        public ICollection<AffiliateSmsTemplate> AffiliateSmsTemplate { get; set; }
        public ICollection<AffiliateTimeOfBooking> AffiliateTimeOfBooking { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<ReservationResourceAdditionalTime> ReservationResourceAdditionalTime { get; set; }
        public ICollection<ReservationResourceService> ReservationResourceService { get; set; }
        public ICollection<ReservationResourceTimeOfBooking> ReservationResourceTimeOfBooking { get; set; }
        public ICollection<ShoppingCart> ShoppingCart { get; set; }
    }
}
