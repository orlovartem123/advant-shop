using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LandingDomain
    {
        public int Id { get; set; }
        public int LandingSiteId { get; set; }
        public string DomainUrl { get; set; }
        public bool IsMain { get; set; }

        public LandingSite LandingSite { get; set; }
    }
}
