using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ManagerTask
    {
        public int TaskId { get; set; }
        public int? AssignedManagerId { get; set; }
        public int? AppointedManagerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int? OrderId { get; set; }
        public Guid? CustomerId { get; set; }
        public int? LeadId { get; set; }
        public string ResultShort { get; set; }
        public string ResultFull { get; set; }

        public Managers AppointedManager { get; set; }
        public Managers AssignedManager { get; set; }
        public Customer Customer { get; set; }
        public Lead Lead { get; set; }
        public Order Order { get; set; }
    }
}
