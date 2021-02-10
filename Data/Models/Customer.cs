using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            AdminNotifications = new HashSet<AdminNotifications>();
            Contact = new HashSet<Contact>();
            CouponCustomers = new HashSet<CouponCustomers>();
            CustomerFieldValuesMap = new HashSet<CustomerFieldValuesMap>();
            CustomerSegmentCustomer = new HashSet<CustomerSegmentCustomer>();
            ManagerRolesMap = new HashSet<ManagerRolesMap>();
            ManagerTask = new HashSet<ManagerTask>();
            TagMap1 = new HashSet<TagMap1>();
            Task = new HashSet<Task>();
            Transaction1 = new HashSet<Transaction1>();
        }

        public Guid CustomerId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public string Email { get; set; }
        public int? CustomerGroupId { get; set; }
        public int? CustomerRole { get; set; }
        public string Patronymic { get; set; }
        public long? BonusCardNumber { get; set; }
        public string AdminComment { get; set; }
        public int? ManagerId { get; set; }
        public int Rating { get; set; }
        public long? StandardPhone { get; set; }
        public string Avatar { get; set; }
        public bool Enabled { get; set; }
        public Guid? HeadCustomerId { get; set; }
        public DateTime? BirthDay { get; set; }
        public string City { get; set; }
        public int InnerId { get; set; }
        public int? SortOrder { get; set; }
        public string Organization { get; set; }
        public int? ClientStatus { get; set; }
        public string RegisteredFrom { get; set; }

        public CustomerGroup CustomerGroup { get; set; }
        public BindedCustomer BindedCustomer { get; set; }
        public Card Card { get; set; }
        public Managers Managers { get; set; }
        public ICollection<AdminNotifications> AdminNotifications { get; set; }
        public ICollection<Contact> Contact { get; set; }
        public ICollection<CouponCustomers> CouponCustomers { get; set; }
        public ICollection<CustomerFieldValuesMap> CustomerFieldValuesMap { get; set; }
        public ICollection<CustomerSegmentCustomer> CustomerSegmentCustomer { get; set; }
        public ICollection<ManagerRolesMap> ManagerRolesMap { get; set; }
        public ICollection<ManagerTask> ManagerTask { get; set; }
        public ICollection<TagMap1> TagMap1 { get; set; }
        public ICollection<Task> Task { get; set; }
        public ICollection<Transaction1> Transaction1 { get; set; }
    }
}
