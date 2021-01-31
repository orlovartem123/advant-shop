using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Purchase
    {
        public Purchase()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public Guid CardId { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime CreateOnCut { get; set; }
        public decimal PurchaseAmount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal MainBonusAmount { get; set; }
        public decimal AdditionBonusAmount { get; set; }
        public decimal NewBonusAmount { get; set; }
        public string Comment { get; set; }
        public decimal MainBonusBalance { get; set; }
        public decimal AdditionBonusBalance { get; set; }
        public int Status { get; set; }
        public decimal PurchaseFullAmount { get; set; }
        public int? OrderId { get; set; }

        public Card Card { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
