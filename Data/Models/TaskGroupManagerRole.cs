using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TaskGroupManagerRole
    {
        public int TaskGroupId { get; set; }
        public int ManagerRoleId { get; set; }

        public ManagerRole ManagerRole { get; set; }
        public TaskGroup TaskGroup { get; set; }
    }
}
