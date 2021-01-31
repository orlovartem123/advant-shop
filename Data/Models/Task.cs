using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Task
    {
        public Task()
        {
            LeadEvent = new HashSet<LeadEvent>();
            TaskManager = new HashSet<TaskManager>();
            TaskObserver = new HashSet<TaskObserver>();
            ViewedTask = new HashSet<ViewedTask>();
        }

        public int Id { get; set; }
        public int TaskGroupId { get; set; }
        public int? AppointedManagerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public int? LeadId { get; set; }
        public int? OrderId { get; set; }
        public Guid? CustomerId { get; set; }
        public string ResultShort { get; set; }
        public string ResultFull { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool Accepted { get; set; }
        public DateTime DateAppointed { get; set; }
        public bool IsAutomatic { get; set; }
        public bool IsDeferred { get; set; }
        public int? ReviewId { get; set; }
        public int? SortOrder { get; set; }
        public int? BindedTaskId { get; set; }
        public int? BindedObjectStatus { get; set; }
        public int Reminder { get; set; }
        public bool Reminded { get; set; }

        public Managers AppointedManager { get; set; }
        public Customer Customer { get; set; }
        public Lead Lead { get; set; }
        public Order Order { get; set; }
        public Review Review { get; set; }
        public TaskGroup TaskGroup { get; set; }
        public ICollection<LeadEvent> LeadEvent { get; set; }
        public ICollection<TaskManager> TaskManager { get; set; }
        public ICollection<TaskObserver> TaskObserver { get; set; }
        public ICollection<ViewedTask> ViewedTask { get; set; }
    }
}
