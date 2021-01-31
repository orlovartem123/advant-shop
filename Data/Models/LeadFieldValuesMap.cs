using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LeadFieldValuesMap
    {
        public int LeadId { get; set; }
        public int LeadFieldId { get; set; }
        public string Value { get; set; }

        public Lead Lead { get; set; }
        public LeadField LeadField { get; set; }
    }
}
