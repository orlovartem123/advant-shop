using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class RelatedProducts
    {
        public int RelatedProductId { get; set; }
        public int ProductId { get; set; }
        public int LinkedProductId { get; set; }
        public int RelatedType { get; set; }
        public int SortOrder { get; set; }
    }
}
