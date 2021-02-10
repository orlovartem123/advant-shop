using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Lead
    {
        public Lead()
        {
            LeadEvent = new HashSet<LeadEvent>();
            LeadFieldValuesMap = new HashSet<LeadFieldValuesMap>();
            LeadItem = new HashSet<LeadItem>();
            ManagerTask = new HashSet<ManagerTask>();
            Order = new HashSet<Order>();
            Task = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string LeadStatus { get; set; }
        public string Comment { get; set; }
        public string AdminComment { get; set; }
        public Guid? CustomerId { get; set; }
        public int? ManagerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public double? Discount { get; set; }
        public int OrderSourceId { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Description { get; set; }
        public double? Sum { get; set; }
        public int? DealStatusId { get; set; }
        public double? DiscountValue { get; set; }
        public bool? IsFromAdminArea { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public int? ShippingMethodId { get; set; }
        public string ShippingName { get; set; }
        public double ShippingCost { get; set; }
        public string ShippingPickPoint { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int SortOrder { get; set; }
        public int? SalesFunnelId { get; set; }
        public string Organization { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string District { get; set; }

        public LeadCurrency LeadCurrency { get; set; }
        public ICollection<LeadEvent> LeadEvent { get; set; }
        public ICollection<LeadFieldValuesMap> LeadFieldValuesMap { get; set; }
        public ICollection<LeadItem> LeadItem { get; set; }
        public ICollection<ManagerTask> ManagerTask { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Task> Task { get; set; }
    }
}
