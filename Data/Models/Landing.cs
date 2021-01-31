using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Landing
    {
        public Landing()
        {
            LandingBlock = new HashSet<LandingBlock>();
            LandingForm = new HashSet<LandingForm>();
            LandingSettings = new HashSet<LandingSettings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string Template { get; set; }
        public string Url { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LandingSiteId { get; set; }
        public bool IsMain { get; set; }
        public int? PageType { get; set; }
        public int? ProductId { get; set; }

        public ICollection<LandingBlock> LandingBlock { get; set; }
        public ICollection<LandingForm> LandingForm { get; set; }
        public ICollection<LandingSettings> LandingSettings { get; set; }
    }
}
