using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class PropertyGroupCategory
    {
        public int PropertyGroupId { get; set; }
        public int CategoryId { get; set; }

        public Category1 Category { get; set; }
        public PropertyGroup PropertyGroup { get; set; }
    }
}
