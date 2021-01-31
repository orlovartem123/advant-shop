using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Property
    {
        public Property()
        {
            PropertyValue = new HashSet<PropertyValue>();
            RelatedProperties = new HashSet<RelatedProperties>();
        }

        public int PropertyId { get; set; }
        public string Name { get; set; }
        public bool? UseInFilter { get; set; }
        public int? SortOrder { get; set; }
        public bool? Expanded { get; set; }
        public bool? UseInDetails { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public int Type { get; set; }
        public int? GroupId { get; set; }
        public bool? UseInBrief { get; set; }
        public string NameDisplayed { get; set; }

        public ICollection<PropertyValue> PropertyValue { get; set; }
        public ICollection<RelatedProperties> RelatedProperties { get; set; }
    }
}
