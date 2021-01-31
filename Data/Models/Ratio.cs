using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Ratio
    {
        public int RatioId { get; set; }
        public int ProductId { get; set; }
        public int ProductRatio { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime AddDate { get; set; }

        public Product Product { get; set; }
    }
}
