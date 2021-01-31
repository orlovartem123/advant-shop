using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OkProduct
    {
        public long Id { get; set; }
        public int ProductId { get; set; }
        public string PhotoIds { get; set; }
        public long CatalogId { get; set; }
    }
}
