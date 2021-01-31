using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LandingSiteSettings
    {
        public int Id { get; set; }
        public int LandingSiteId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public LandingSite LandingSite { get; set; }
    }
}
