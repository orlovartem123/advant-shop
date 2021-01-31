using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Transaction1
    {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public decimal Balance { get; set; }
        public decimal Amount { get; set; }
        public string Basis { get; set; }
        public Guid? CustomerId { get; set; }
        public int? OrderId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsRewardPayout { get; set; }
        public DateTime? RewardPeriodTo { get; set; }
        public string DetailsJson { get; set; }

        public Customer Customer { get; set; }
        public Order Order { get; set; }
        public Partner Partner { get; set; }
        public TransactionCurrency TransactionCurrency { get; set; }
    }
}
