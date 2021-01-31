using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class MetaInfo
    {
        public int MetaId { get; set; }
        public string Title { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public int? ObjId { get; set; }
        public string Type { get; set; }
        public string H1 { get; set; }
    }
}
