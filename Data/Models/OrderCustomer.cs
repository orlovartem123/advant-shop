using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderCustomer
    {
        public int OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public string CustomerIp { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Patronymic { get; set; }
        public long? StandardPhone { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Street { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public string Structure { get; set; }
        public string Entrance { get; set; }
        public string Floor { get; set; }
        public string Organization { get; set; }
        public string District { get; set; }

        public Order Order { get; set; }
    }
}
