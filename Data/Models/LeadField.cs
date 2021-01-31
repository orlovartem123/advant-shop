using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LeadField
    {
        public LeadField()
        {
            LeadFieldValue = new HashSet<LeadFieldValue>();
            LeadFieldValuesMap = new HashSet<LeadFieldValuesMap>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FieldType { get; set; }
        public int SortOrder { get; set; }
        public bool Required { get; set; }
        public bool Enabled { get; set; }
        public int SalesFunnelId { get; set; }

        public SalesFunnel SalesFunnel { get; set; }
        public ICollection<LeadFieldValue> LeadFieldValue { get; set; }
        public ICollection<LeadFieldValuesMap> LeadFieldValuesMap { get; set; }
    }
}
