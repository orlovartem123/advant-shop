using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ProductCategories
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public int SortOrder { get; set; }
        public bool Main { get; set; }

        public Category1 Category { get; set; }
        public Product Product { get; set; }
    }
}
