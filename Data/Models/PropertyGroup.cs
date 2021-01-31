using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class PropertyGroup
    {
        public PropertyGroup()
        {
            PropertyGroupCategory = new HashSet<PropertyGroupCategory>();
        }

        public int PropertyGroupId { get; set; }
        public string GroupName { get; set; }
        public int GroupSortOrder { get; set; }
        public string GroupNameDisplayed { get; set; }

        public ICollection<PropertyGroupCategory> PropertyGroupCategory { get; set; }
    }
}
