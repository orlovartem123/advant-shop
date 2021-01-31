using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ProductExt
    {
        public int ProductId { get; set; }
        public int? CountPhoto { get; set; }
        public int? PhotoId { get; set; }
        public bool VideosAvailable { get; set; }
        public double? MaxAvailable { get; set; }
        public bool NotSamePrices { get; set; }
        public double? MinPrice { get; set; }
        public string Colors { get; set; }
        public bool? AmountSort { get; set; }
        public int? OfferId { get; set; }
        public int? Comments { get; set; }
        public int? CategoryId { get; set; }
        public double? PriceTemp { get; set; }
        public bool? Gifts { get; set; }

        public Product Product { get; set; }
    }
}
