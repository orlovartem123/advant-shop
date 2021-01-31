using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CustomerFieldValuesMap
    {
        public Guid CustomerId { get; set; }
        public int CustomerFieldId { get; set; }
        public string Value { get; set; }

        public Customer Customer { get; set; }
        public CustomerField CustomerField { get; set; }
    }
}
