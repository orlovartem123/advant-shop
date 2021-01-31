using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ProductFile
    {
        public Guid ProductFileId { get; set; }
        public int ProductId { get; set; }
        public string Filename { get; set; }

        public Product Product { get; set; }
    }
}
