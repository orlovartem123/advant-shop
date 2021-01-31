using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ExportFeedSelectedCategories
    {
        public int ExportFeedId { get; set; }
        public int CategoryId { get; set; }
        public int? Status { get; set; }
        public bool? Opened { get; set; }

        public Category1 Category { get; set; }
        public ExportFeed ExportFeed { get; set; }
    }
}
