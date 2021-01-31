using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LandingSiteProduct
    {
        public int ProductId { get; set; }
        public int LandingSiteId { get; set; }

        public LandingSite LandingSite { get; set; }
        public Product Product { get; set; }
    }
}
