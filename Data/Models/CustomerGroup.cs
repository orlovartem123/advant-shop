using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CustomerGroup
    {
        public CustomerGroup()
        {
            Customer = new HashSet<Customer>();
        }

        public int CustomerGroupId { get; set; }
        public string GroupName { get; set; }
        public double GroupDiscount { get; set; }
        public double MinimumOrderPrice { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
