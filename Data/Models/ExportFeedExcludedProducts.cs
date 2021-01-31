using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ExportFeedExcludedProducts
    {
        public int ExportFeedId { get; set; }
        public int ProductId { get; set; }

        public ExportFeed ExportFeed { get; set; }
        public Product Product { get; set; }
    }
}
