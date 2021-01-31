using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Menu
    {
        public int MenuItemId { get; set; }
        public int? MenuItemParentId { get; set; }
        public string MenuItemName { get; set; }
        public string MenuItemIcon { get; set; }
        public string MenuItemUrlPath { get; set; }
        public int MenuItemUrlType { get; set; }
        public int SortOrder { get; set; }
        public int ShowMode { get; set; }
        public bool Enabled { get; set; }
        public bool Blank { get; set; }
        public bool NoFollow { get; set; }
        public int MenuType { get; set; }
    }
}
