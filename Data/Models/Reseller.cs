using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Reseller
    {
        public Guid ResellerId { get; set; }
        public string Name { get; set; }
        public double PurchaseDiscount { get; set; }
        public double RecommendedPriceMargin { get; set; }
        public bool ExportOnlyActiveProducts { get; set; }
    }
}
