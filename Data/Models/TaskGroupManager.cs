using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TaskGroupManager
    {
        public int TaskGroupId { get; set; }
        public int ManagerId { get; set; }

        public Managers Manager { get; set; }
        public TaskGroup TaskGroup { get; set; }
    }
}
