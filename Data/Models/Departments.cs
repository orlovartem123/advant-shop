using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Managers = new HashSet<Managers>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public bool Enabled { get; set; }

        public ICollection<Managers> Managers { get; set; }
    }
}
