using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string BriefDescription { get; set; }
        public string Description { get; set; }
        public string UrlPath { get; set; }
        public int? SortOrder { get; set; }
        public bool? VisibilityForUsers { get; set; }
    }
}
