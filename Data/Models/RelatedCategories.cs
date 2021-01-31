using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class RelatedCategories
    {
        public int CategoryId { get; set; }
        public int RelatedCategoryId { get; set; }
        public int RelatedType { get; set; }
    }
}
