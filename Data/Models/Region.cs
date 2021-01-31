using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Region
    {
        public Region()
        {
            City = new HashSet<City>();
            Contact = new HashSet<Contact>();
            ShippingRegion = new HashSet<ShippingRegion>();
            ShippingRegionExcluded = new HashSet<ShippingRegionExcluded>();
        }

        public int RegionId { get; set; }
        public int CountryId { get; set; }
        public string RegionName { get; set; }
        public string RegionCode { get; set; }
        public int? RegionSort { get; set; }

        public ICollection<City> City { get; set; }
        public ICollection<Contact> Contact { get; set; }
        public ICollection<ShippingRegion> ShippingRegion { get; set; }
        public ICollection<ShippingRegionExcluded> ShippingRegionExcluded { get; set; }
    }
}
