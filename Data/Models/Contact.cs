using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Contact
    {
        public Guid ContactId { get; set; }
        public Guid? CustomerId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Zone { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public int? CountryId { get; set; }
        public int? RegionId { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public string Structure { get; set; }
        public string Entrance { get; set; }
        public string Floor { get; set; }

        public Country CountryNavigation { get; set; }
        public Customer Customer { get; set; }
        public Region Region { get; set; }
    }
}
