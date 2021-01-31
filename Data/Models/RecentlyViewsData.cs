using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class RecentlyViewsData
    {
        public Guid CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime ViewDate { get; set; }

        public Product Product { get; set; }
    }
}
