using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Partner
    {
        public Partner()
        {
            ActReport = new HashSet<ActReport>();
            BindedCustomer = new HashSet<BindedCustomer>();
            Transaction1 = new HashSet<Transaction1>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int SendMessages { get; set; }
        public string AdminComment { get; set; }
        public bool Enabled { get; set; }
        public decimal Balance { get; set; }
        public int Type { get; set; }
        public int? CouponId { get; set; }
        public double RewardPercent { get; set; }
        public bool ContractConcluded { get; set; }
        public string ContractNumber { get; set; }
        public DateTime? ContractDate { get; set; }
        public string ContractScan { get; set; }

        public Coupon Coupon { get; set; }
        public LegalEntity LegalEntity { get; set; }
        public NaturalPerson NaturalPerson { get; set; }
        public ICollection<ActReport> ActReport { get; set; }
        public ICollection<BindedCustomer> BindedCustomer { get; set; }
        public ICollection<Transaction1> Transaction1 { get; set; }
    }
}
