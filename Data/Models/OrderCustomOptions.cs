using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderCustomOptions
    {
        public int OrderCustomOptionsId { get; set; }
        public int CustomOptionId { get; set; }
        public int OptionId { get; set; }
        public string CustomOptionTitle { get; set; }
        public string OptionTitle { get; set; }
        public decimal OptionPriceBc { get; set; }
        public int OptionPriceType { get; set; }
        public int OrderedCartId { get; set; }

        public OrderItems OrderedCart { get; set; }
    }
}
