using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ReservationResource
    {
        public ReservationResource()
        {
            AffiliateReservationResource = new HashSet<AffiliateReservationResource>();
            Booking = new HashSet<Booking>();
            ReservationResourceAdditionalTime = new HashSet<ReservationResourceAdditionalTime>();
            ReservationResourceService = new HashSet<ReservationResourceService>();
            ReservationResourceTagsMap = new HashSet<ReservationResourceTagsMap>();
            ReservationResourceTimeOfBooking = new HashSet<ReservationResourceTimeOfBooking>();
            ShoppingCart = new HashSet<ShoppingCart>();
        }

        public int Id { get; set; }
        public int? ManagerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Enabled { get; set; }
        public int SortOrder { get; set; }

        public Managers Manager { get; set; }
        public ICollection<AffiliateReservationResource> AffiliateReservationResource { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<ReservationResourceAdditionalTime> ReservationResourceAdditionalTime { get; set; }
        public ICollection<ReservationResourceService> ReservationResourceService { get; set; }
        public ICollection<ReservationResourceTagsMap> ReservationResourceTagsMap { get; set; }
        public ICollection<ReservationResourceTimeOfBooking> ReservationResourceTimeOfBooking { get; set; }
        public ICollection<ShoppingCart> ShoppingCart { get; set; }
    }
}
