using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class VkCategoryCategory
    {
        public int CategoryId { get; set; }
        public int VkCategoryId { get; set; }

        public Category1 Category { get; set; }
        public VkCategory VkCategory { get; set; }
    }
}
