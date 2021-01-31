using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ShippingMethod
    {
        public ShippingMethod()
        {
            Order = new HashSet<Order>();
            ShippingCache = new HashSet<ShippingCache>();
            ShippingCategoryExcluded = new HashSet<ShippingCategoryExcluded>();
            ShippingCity = new HashSet<ShippingCity>();
            ShippingCityExcluded = new HashSet<ShippingCityExcluded>();
            ShippingCountry = new HashSet<ShippingCountry>();
            ShippingCountryExcluded = new HashSet<ShippingCountryExcluded>();
            ShippingParam = new HashSet<ShippingParam>();
            ShippingPayments = new HashSet<ShippingPayments>();
            ShippingProductExcluded = new HashSet<ShippingProductExcluded>();
            ShippingRegion = new HashSet<ShippingRegion>();
            ShippingRegionExcluded = new HashSet<ShippingRegionExcluded>();
        }

        public int ShippingMethodId { get; set; }
        public string ShippingType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public int SortOrder { get; set; }
        public bool? DisplayCustomFields { get; set; }
        public bool ShowInDetails { get; set; }
        public string ZeroPriceMessage { get; set; }
        public bool? DisplayIndex { get; set; }
        public int? TaxId { get; set; }
        public int? ExtrachargeType { get; set; }
        public double? Extracharge { get; set; }
        public bool? ExtrachargeFromOrder { get; set; }
        public int? ExtraDeliveryTime { get; set; }

        public ICollection<Order> Order { get; set; }
        public ICollection<ShippingCache> ShippingCache { get; set; }
        public ICollection<ShippingCategoryExcluded> ShippingCategoryExcluded { get; set; }
        public ICollection<ShippingCity> ShippingCity { get; set; }
        public ICollection<ShippingCityExcluded> ShippingCityExcluded { get; set; }
        public ICollection<ShippingCountry> ShippingCountry { get; set; }
        public ICollection<ShippingCountryExcluded> ShippingCountryExcluded { get; set; }
        public ICollection<ShippingParam> ShippingParam { get; set; }
        public ICollection<ShippingPayments> ShippingPayments { get; set; }
        public ICollection<ShippingProductExcluded> ShippingProductExcluded { get; set; }
        public ICollection<ShippingRegion> ShippingRegion { get; set; }
        public ICollection<ShippingRegionExcluded> ShippingRegionExcluded { get; set; }
    }
}
