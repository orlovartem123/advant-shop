using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ProductVideo
    {
        public int ProductVideoId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string PlayerCode { get; set; }
        public string Description { get; set; }
        public int? VideoSortOrder { get; set; }

        public Product Product { get; set; }
    }
}
