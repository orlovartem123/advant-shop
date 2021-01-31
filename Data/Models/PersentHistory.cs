using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class PersentHistory
    {
        public int Id { get; set; }
        public Guid CardId { get; set; }
        public string GradeName { get; set; }
        public decimal BonusPersent { get; set; }
        public DateTime CreateOn { get; set; }
        public string ByAction { get; set; }

        public Card Card { get; set; }
    }
}
