using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public Guid CardId { get; set; }
        public decimal Amount { get; set; }
        public string Basis { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime CreateOnCut { get; set; }
        public short OperationType { get; set; }
        public decimal Balance { get; set; }
        public int? PurchaseId { get; set; }
        public int? AdditionalBonusId { get; set; }

        public AdditionBonus AdditionalBonus { get; set; }
        public Card Card { get; set; }
        public Purchase Purchase { get; set; }
    }
}
