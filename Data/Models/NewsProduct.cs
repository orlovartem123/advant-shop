using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class NewsProduct
    {
        public int NewsId { get; set; }
        public int ProductId { get; set; }
        public int? SortOrder { get; set; }

        public News News { get; set; }
        public Product Product { get; set; }
    }
}
