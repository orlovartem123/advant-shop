using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ProductList
    {
        public ProductList()
        {
            ProductProductList = new HashSet<ProductProductList>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public bool Enabled { get; set; }
        public string Description { get; set; }
        public bool? ShuffleList { get; set; }

        public ICollection<ProductProductList> ProductProductList { get; set; }
    }
}
