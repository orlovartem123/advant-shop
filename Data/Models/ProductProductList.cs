using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ProductProductList
    {
        public int ListId { get; set; }
        public int ProductId { get; set; }
        public int SortOrder { get; set; }

        public ProductList List { get; set; }
        public Product Product { get; set; }
    }
}
