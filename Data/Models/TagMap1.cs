using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TagMap1
    {
        public Guid CustomerId { get; set; }
        public int TagId { get; set; }
        public int SortOrder { get; set; }

        public Customer Customer { get; set; }
        public Tag1 Tag { get; set; }
    }
}
