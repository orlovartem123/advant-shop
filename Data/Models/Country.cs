using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Country
    {
        public Country()
        {
            Brand = new HashSet<Brand>();
            Contact = new HashSet<Contact>();
            PaymentCountry = new HashSet<PaymentCountry>();
            ShippingCountry = new HashSet<ShippingCountry>();
            ShippingCountryExcluded = new HashSet<ShippingCountryExcluded>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryIso2 { get; set; }
        public string CountryIso3 { get; set; }
        public bool? DisplayInPopup { get; set; }
        public int? SortOrder { get; set; }
        public int? DialCode { get; set; }

        public Country CountryNavigation { get; set; }
        public Country InverseCountryNavigation { get; set; }
        public ICollection<Brand> Brand { get; set; }
        public ICollection<Contact> Contact { get; set; }
        public ICollection<PaymentCountry> PaymentCountry { get; set; }
        public ICollection<ShippingCountry> ShippingCountry { get; set; }
        public ICollection<ShippingCountryExcluded> ShippingCountryExcluded { get; set; }
    }
}
