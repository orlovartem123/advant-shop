using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Card
    {
        public Card()
        {
            AdditionBonus = new HashSet<AdditionBonus>();
            PersentHistory = new HashSet<PersentHistory>();
            Purchase = new HashSet<Purchase>();
            RuleLog = new HashSet<RuleLog>();
            Transaction = new HashSet<Transaction>();
        }

        public Guid CardId { get; set; }
        public long CardNumber { get; set; }
        public decimal BonusAmount { get; set; }
        public DateTime CreateOn { get; set; }
        public long Blocked { get; set; }
        public int GradeId { get; set; }
        public DateTime? DateLastWipeBonus { get; set; }
        public bool ManualGrade { get; set; }
        public DateTime? DateLastNotifyBonusWipe { get; set; }

        public Customer CardNavigation { get; set; }
        public Grade Grade { get; set; }
        public ICollection<AdditionBonus> AdditionBonus { get; set; }
        public ICollection<PersentHistory> PersentHistory { get; set; }
        public ICollection<Purchase> Purchase { get; set; }
        public ICollection<RuleLog> RuleLog { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
