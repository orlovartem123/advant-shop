using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TagMap
    {
        public int ObjId { get; set; }
        public int TagId { get; set; }
        public string Type { get; set; }
        public int SortOrder { get; set; }
    }
}
