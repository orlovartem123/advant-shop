using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class VkCategory
    {
        public VkCategory()
        {
            VkCategoryCategory = new HashSet<VkCategoryCategory>();
        }

        public int Id { get; set; }
        public long VkId { get; set; }
        public long VkCategoryId { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }

        public ICollection<VkCategoryCategory> VkCategoryCategory { get; set; }
    }
}
