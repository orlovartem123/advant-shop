using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class StaticBlock
    {
        public int StaticBlockId { get; set; }
        public string Key { get; set; }
        public string InnerName { get; set; }
        public string Content { get; set; }
        public DateTime Added { get; set; }
        public DateTime Modified { get; set; }
        public bool? Enabled { get; set; }
    }
}
