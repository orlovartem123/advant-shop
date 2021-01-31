using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TriggerRule
    {
        public TriggerRule()
        {
            TriggerAction = new HashSet<TriggerAction>();
            TriggerSendOnceData = new HashSet<TriggerSendOnceData>();
        }

        public int Id { get; set; }
        public int EventType { get; set; }
        public int ObjectType { get; set; }
        public int? EventObjId { get; set; }
        public string Name { get; set; }
        public string Filter { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool Enabled { get; set; }
        public bool WorksOnlyOnce { get; set; }
        public int? EventObjValue { get; set; }
        public int ProcessType { get; set; }
        public string TriggerParams { get; set; }
        public int? PreferredHour { get; set; }
        public int? CategoryId { get; set; }

        public TriggerCategory Category { get; set; }
        public ICollection<TriggerAction> TriggerAction { get; set; }
        public ICollection<TriggerSendOnceData> TriggerSendOnceData { get; set; }
    }
}
