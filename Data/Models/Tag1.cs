using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Tag1
    {
        public Tag1()
        {
            TagMap1 = new HashSet<TagMap1>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public int? SortOrder { get; set; }

        public ICollection<TagMap1> TagMap1 { get; set; }
    }
}
