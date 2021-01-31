using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CategoriesAutoMapping
    {
        public int CategoryId { get; set; }
        public int NewCategoryId { get; set; }
        public bool Main { get; set; }
        public int Id { get; set; }
    }
}
