using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TriggerDeferredData
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int TriggerActionId { get; set; }
        public int TriggerObjectType { get; set; }
        public DateTime DateCreated { get; set; }

        public TriggerAction TriggerAction { get; set; }
    }
}
