using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CustomRule
    {
        public CustomRule()
        {
            RuleLog = new HashSet<RuleLog>();
        }

        public int RuleType { get; set; }
        public bool? Enabled { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public ICollection<RuleLog> RuleLog { get; set; }
    }
}
