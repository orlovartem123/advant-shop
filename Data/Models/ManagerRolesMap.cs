using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ManagerRolesMap
    {
        public Guid CustomerId { get; set; }
        public int ManagerRoleId { get; set; }

        public Customer Customer { get; set; }
        public ManagerRole ManagerRole { get; set; }
    }
}
