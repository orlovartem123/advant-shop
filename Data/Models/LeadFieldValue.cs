using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LeadFieldValue
    {
        public int Id { get; set; }
        public int LeadFieldId { get; set; }
        public string Value { get; set; }
        public int SortOrder { get; set; }

        public LeadField LeadField { get; set; }
    }
}
