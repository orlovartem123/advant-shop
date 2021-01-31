using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Color
    {
        public Color()
        {
            Offer = new HashSet<Offer>();
            Photo = new HashSet<Photo>();
        }

        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public string ColorCode { get; set; }
        public int SortOrder { get; set; }

        public ICollection<Offer> Offer { get; set; }
        public ICollection<Photo> Photo { get; set; }
    }
}
