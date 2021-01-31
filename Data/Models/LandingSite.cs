using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LandingSite
    {
        public LandingSite()
        {
            LandingDomain = new HashSet<LandingDomain>();
            LandingSiteProduct = new HashSet<LandingSiteProduct>();
            LandingSiteSettings = new HashSet<LandingSiteSettings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string Template { get; set; }
        public string Url { get; set; }
        public string DomainUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ProductId { get; set; }
        public int? AdditionalSalesProductId { get; set; }

        public ICollection<LandingDomain> LandingDomain { get; set; }
        public ICollection<LandingSiteProduct> LandingSiteProduct { get; set; }
        public ICollection<LandingSiteSettings> LandingSiteSettings { get; set; }
    }
}
