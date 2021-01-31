using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class NewsCategory
    {
        public NewsCategory()
        {
            News = new HashSet<News>();
        }

        public int NewsCategoryId { get; set; }
        public string Name { get; set; }
        public int? SortOrder { get; set; }
        public string UrlPath { get; set; }

        public ICollection<News> News { get; set; }
    }
}
