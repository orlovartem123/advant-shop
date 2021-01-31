using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TaskGroup
    {
        public TaskGroup()
        {
            BizProcessRule = new HashSet<BizProcessRule>();
            Task = new HashSet<Task>();
            TaskGroupManager = new HashSet<TaskGroupManager>();
            TaskGroupManagerRole = new HashSet<TaskGroupManagerRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Enabled { get; set; }
        public bool IsPrivateComments { get; set; }

        public ICollection<BizProcessRule> BizProcessRule { get; set; }
        public ICollection<Task> Task { get; set; }
        public ICollection<TaskGroupManager> TaskGroupManager { get; set; }
        public ICollection<TaskGroupManagerRole> TaskGroupManagerRole { get; set; }
    }
}
