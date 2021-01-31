using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Carousel
    {
        public int CarouselId { get; set; }
        public string Url { get; set; }
        public int SortOrder { get; set; }
        public bool Enabled { get; set; }
        public bool DisplayInOneColumn { get; set; }
        public bool DisplayInTwoColumns { get; set; }
        public bool DisplayInMobile { get; set; }
        public bool Blank { get; set; }
    }
}
