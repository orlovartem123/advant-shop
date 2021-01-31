using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class RoleAction
    {
        public int RoleActionId { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public bool Enabled { get; set; }
        public string Category { get; set; }
        public int SortOrder { get; set; }
    }
}
