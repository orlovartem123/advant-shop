using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class City
    {
        public City()
        {
            Affiliate = new HashSet<Affiliate>();
            PaymentCity = new HashSet<PaymentCity>();
            ShippingCity = new HashSet<ShippingCity>();
            ShippingCityExcluded = new HashSet<ShippingCityExcluded>();
        }

        public int CityId { get; set; }
        public int RegionId { get; set; }
        public string CityName { get; set; }
        public int CitySort { get; set; }
        public bool DisplayInPopup { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string Zip { get; set; }

        public Region Region { get; set; }
        public ICollection<Affiliate> Affiliate { get; set; }
        public ICollection<PaymentCity> PaymentCity { get; set; }
        public ICollection<ShippingCity> ShippingCity { get; set; }
        public ICollection<ShippingCityExcluded> ShippingCityExcluded { get; set; }
    }
}
