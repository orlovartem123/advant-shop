using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Options
    {
        public int OptionId { get; set; }
        public int CustomOptionsId { get; set; }
        public string Title { get; set; }
        public double PriceBc { get; set; }
        public int PriceType { get; set; }
        public int? SortOrder { get; set; }

        public CustomOptions CustomOptions { get; set; }
    }
}
