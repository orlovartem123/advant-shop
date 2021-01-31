using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class RuleLog
    {
        public Guid CardId { get; set; }
        public int RuleType { get; set; }
        public DateTime Created { get; set; }

        public Card Card { get; set; }
        public CustomRule RuleTypeNavigation { get; set; }
    }
}
