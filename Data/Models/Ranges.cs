using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Ranges
    {
        public int RangeId { get; set; }
        public double Bound { get; set; }
        public decimal Value { get; set; }
        public int Type { get; set; }
    }
}
