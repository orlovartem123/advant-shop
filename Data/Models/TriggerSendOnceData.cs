using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TriggerSendOnceData
    {
        public int TriggerId { get; set; }
        public int EntityId { get; set; }
        public Guid? CustomerId { get; set; }

        public TriggerRule Trigger { get; set; }
    }
}
