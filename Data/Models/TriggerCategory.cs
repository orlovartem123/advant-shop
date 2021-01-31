using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TriggerCategory
    {
        public TriggerCategory()
        {
            TriggerRule = new HashSet<TriggerRule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }

        public ICollection<TriggerRule> TriggerRule { get; set; }
    }
}
