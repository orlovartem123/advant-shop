using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderContact
    {
        public int OrderContactId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Zone { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Address { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
    }
}
