using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class PayoutReport
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public DateTime PeriodTo { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
