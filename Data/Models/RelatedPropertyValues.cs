using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class RelatedPropertyValues
    {
        public int CategoryId { get; set; }
        public int PropertyValueId { get; set; }
        public int RelatedType { get; set; }

        public Category1 Category { get; set; }
        public PropertyValue PropertyValue { get; set; }
    }
}
