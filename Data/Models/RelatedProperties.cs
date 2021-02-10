using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class RelatedProperties
    {
        public int CategoryId { get; set; }
        public int PropertyId { get; set; }
        public int RelatedType { get; set; }
        public bool? IsSame { get; set; }

        public Category1 Category { get; set; }
        public Property Property { get; set; }
    }
}
