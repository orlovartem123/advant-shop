using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OkCatalogCategory
    {
        public int CategoryId { get; set; }
        public int OkCatalogId { get; set; }

        public Category1 Category { get; set; }
        public OkCatalog OkCatalog { get; set; }
    }
}
