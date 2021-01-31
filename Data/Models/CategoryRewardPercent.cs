using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CategoryRewardPercent
    {
        public int CategoryId { get; set; }
        public double RewardPercent { get; set; }
        public DateTime DateAdded { get; set; }

        public Category1 Category { get; set; }
    }
}
