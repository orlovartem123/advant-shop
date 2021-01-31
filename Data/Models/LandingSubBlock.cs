using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LandingSubBlock
    {
        public int Id { get; set; }
        public int LandingBlockId { get; set; }
        public string Name { get; set; }
        public string ContentHtml { get; set; }
        public string Type { get; set; }
        public string Settings { get; set; }
        public int SortOrder { get; set; }

        public LandingBlock LandingBlock { get; set; }
    }
}
