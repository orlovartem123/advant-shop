using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class BizProcessRule
    {
        public int Id { get; set; }
        public int EventType { get; set; }
        public int ObjectType { get; set; }
        public int? EventObjId { get; set; }
        public int Priority { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskDueDateInterval { get; set; }
        public string TaskCreateInterval { get; set; }
        public string ManagerFilter { get; set; }
        public string Filter { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int TaskPriority { get; set; }
        public int? TaskGroupId { get; set; }

        public TaskGroup TaskGroup { get; set; }
    }
}
