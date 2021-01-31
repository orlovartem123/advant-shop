using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class News
    {
        public News()
        {
            NewsProduct = new HashSet<NewsProduct>();
        }

        public int NewsId { get; set; }
        public int NewsCategoryId { get; set; }
        public string Title { get; set; }
        public string TextToPublication { get; set; }
        public string TextToEmail { get; set; }
        public string TextAnnotation { get; set; }
        public bool ShowOnMainPage { get; set; }
        public DateTime AddingDate { get; set; }
        public string UrlPath { get; set; }
        public bool Enabled { get; set; }

        public NewsCategory NewsCategory { get; set; }
        public ICollection<NewsProduct> NewsProduct { get; set; }
    }
}
