using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LandingSettings
    {
        public int Id { get; set; }
        public int LandingId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public Landing Landing { get; set; }
    }
}
