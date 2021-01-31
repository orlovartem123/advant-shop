using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class PropertyValue
    {
        public PropertyValue()
        {
            ProductPropertyValue = new HashSet<ProductPropertyValue>();
            RelatedPropertyValues = new HashSet<RelatedPropertyValues>();
        }

        public int PropertyValueId { get; set; }
        public int PropertyId { get; set; }
        public string Value { get; set; }
        public int? SortOrder { get; set; }
        public bool? UseInFilter { get; set; }
        public bool? UseInDetails { get; set; }
        public double RangeValue { get; set; }
        public bool? UseInBrief { get; set; }

        public Property Property { get; set; }
        public ICollection<ProductPropertyValue> ProductPropertyValue { get; set; }
        public ICollection<RelatedPropertyValues> RelatedPropertyValues { get; set; }
    }
}
