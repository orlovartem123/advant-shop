using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CustomerSegmentCustomer
    {
        public Guid CustomerId { get; set; }
        public int SegmentId { get; set; }

        public Customer Customer { get; set; }
        public CustomerSegment Segment { get; set; }
    }
}
