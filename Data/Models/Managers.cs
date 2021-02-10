using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Managers
    {
        public Managers()
        {
            AffiliateAnalyticManager = new HashSet<AffiliateAnalyticManager>();
            AffiliateManager = new HashSet<AffiliateManager>();
            Booking = new HashSet<Booking>();
            Call = new HashSet<Call>();
            ManagerTaskAppointedManager = new HashSet<ManagerTask>();
            ManagerTaskAssignedManager = new HashSet<ManagerTask>();
            Order = new HashSet<Order>();
            ReservationResource = new HashSet<ReservationResource>();
            SalesFunnelManager = new HashSet<SalesFunnelManager>();
            Task = new HashSet<Task>();
            TaskGroupManager = new HashSet<TaskGroupManager>();
            TaskManager = new HashSet<TaskManager>();
            TaskObserver = new HashSet<TaskObserver>();
            ViewedTask = new HashSet<ViewedTask>();
        }

        public int ManagerId { get; set; }
        public Guid CustomerId { get; set; }
        public int? DepartmentId { get; set; }
        public string Position { get; set; }
        public bool? Active { get; set; }
        public string Sign { get; set; }

        public Customer Customer { get; set; }
        public Departments Department { get; set; }
        public ICollection<AffiliateAnalyticManager> AffiliateAnalyticManager { get; set; }
        public ICollection<AffiliateManager> AffiliateManager { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<Call> Call { get; set; }
        public ICollection<ManagerTask> ManagerTaskAppointedManager { get; set; }
        public ICollection<ManagerTask> ManagerTaskAssignedManager { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<ReservationResource> ReservationResource { get; set; }
        public ICollection<SalesFunnelManager> SalesFunnelManager { get; set; }
        public ICollection<Task> Task { get; set; }
        public ICollection<TaskGroupManager> TaskGroupManager { get; set; }
        public ICollection<TaskManager> TaskManager { get; set; }
        public ICollection<TaskObserver> TaskObserver { get; set; }
        public ICollection<ViewedTask> ViewedTask { get; set; }
    }
}
