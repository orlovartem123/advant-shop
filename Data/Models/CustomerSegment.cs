using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CustomerSegment
    {
        public CustomerSegment()
        {
            CustomerSegmentCustomer = new HashSet<CustomerSegmentCustomer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Filter { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<CustomerSegmentCustomer> CustomerSegmentCustomer { get; set; }
    }
}
