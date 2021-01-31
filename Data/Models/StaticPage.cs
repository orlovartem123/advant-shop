using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class StaticPage
    {
        public int StaticPageId { get; set; }
        public string PageName { get; set; }
        public string PageText { get; set; }
        public int? SortOrder { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public bool? IndexAtSiteMap { get; set; }
        public int? ParentId { get; set; }
        public string Comment { get; set; }
        public bool? Enabled { get; set; }
        public string UrlPath { get; set; }
    }
}
