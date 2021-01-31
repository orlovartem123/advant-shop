using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ManagerRole
    {
        public ManagerRole()
        {
            ManagerRolesMap = new HashSet<ManagerRolesMap>();
            TaskGroupManagerRole = new HashSet<TaskGroupManagerRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }

        public ICollection<ManagerRolesMap> ManagerRolesMap { get; set; }
        public ICollection<TaskGroupManagerRole> TaskGroupManagerRole { get; set; }
    }
}
