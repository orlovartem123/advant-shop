using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Category
    {
        public Category()
        {
            AffiliateCategory = new HashSet<AffiliateCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
        public bool Enabled { get; set; }

        public ICollection<AffiliateCategory> AffiliateCategory { get; set; }
    }
}
