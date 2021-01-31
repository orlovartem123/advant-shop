using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class FileLibrary
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int? ItemParentId { get; set; }
        public string ItemIcon { get; set; }
        public int ItemType { get; set; }
        public string FilePath { get; set; }
        public bool Enabled { get; set; }
        public int SortOrder { get; set; }
    }
}
