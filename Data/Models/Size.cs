using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Size
    {
        public Size()
        {
            Offer = new HashSet<Offer>();
        }

        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public int SortOrder { get; set; }

        public ICollection<Offer> Offer { get; set; }
    }
}
