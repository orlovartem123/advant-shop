using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ExportFeed
    {
        public ExportFeed()
        {
            ExportFeedExcludedProducts = new HashSet<ExportFeedExcludedProducts>();
            ExportFeedSelectedCategories = new HashSet<ExportFeedSelectedCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime? LastExport { get; set; }
        public string LastExportFileFullName { get; set; }

        public ICollection<ExportFeedExcludedProducts> ExportFeedExcludedProducts { get; set; }
        public ICollection<ExportFeedSelectedCategories> ExportFeedSelectedCategories { get; set; }
    }
}
