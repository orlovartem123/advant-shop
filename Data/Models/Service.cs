using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Service
    {
        public Service()
        {
            AffiliateService = new HashSet<AffiliateService>();
            BookingItems = new HashSet<BookingItems>();
            OrderItems = new HashSet<OrderItems>();
            ReservationResourceService = new HashSet<ReservationResourceService>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Enabled { get; set; }
        public long? Duration { get; set; }
        public string ArtNo { get; set; }

        public Currency Currency { get; set; }
        public ICollection<AffiliateService> AffiliateService { get; set; }
        public ICollection<BookingItems> BookingItems { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
        public ICollection<ReservationResourceService> ReservationResourceService { get; set; }
    }
}
