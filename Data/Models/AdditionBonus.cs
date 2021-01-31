using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class AdditionBonus
    {
        public AdditionBonus()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public Guid CardId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public bool? NotifiedAboutExpiry { get; set; }

        public Card Card { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
