using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class DpdTerminals
    {
        public string Code { get; set; }
        public long CityId { get; set; }
        public string CityName { get; set; }
        public string RegionName { get; set; }
        public string CountryCode { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsSelfPickup { get; set; }
        public bool IsSelfDelivery { get; set; }
        public string SelfDeliveryTimes { get; set; }
        public string ExtraServices { get; set; }
        public string Services { get; set; }
        public string AddressDescription { get; set; }
    }
}
