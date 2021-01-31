using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LandingBlock
    {
        public LandingBlock()
        {
            LandingColorScheme = new HashSet<LandingColorScheme>();
            LandingEmailTemplate = new HashSet<LandingEmailTemplate>();
            LandingSubBlock = new HashSet<LandingSubBlock>();
        }

        public int Id { get; set; }
        public int LandingId { get; set; }
        public string Name { get; set; }
        public string ContentHtml { get; set; }
        public string Type { get; set; }
        public string Settings { get; set; }
        public int SortOrder { get; set; }
        public bool Enabled { get; set; }
        public bool ShowOnAllPages { get; set; }
        public bool NoCache { get; set; }

        public Landing Landing { get; set; }
        public ICollection<LandingColorScheme> LandingColorScheme { get; set; }
        public ICollection<LandingEmailTemplate> LandingEmailTemplate { get; set; }
        public ICollection<LandingSubBlock> LandingSubBlock { get; set; }
    }
}
