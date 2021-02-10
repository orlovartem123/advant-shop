using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderSource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public bool Main { get; set; }
        public string Type { get; set; }
        public int? ObjId { get; set; }
    }
}
