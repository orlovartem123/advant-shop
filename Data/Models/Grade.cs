using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Card = new HashSet<Card>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BonusPercent { get; set; }
        public int SortOrder { get; set; }
        public decimal PurchaseBarrier { get; set; }

        public ICollection<Card> Card { get; set; }
    }
}
