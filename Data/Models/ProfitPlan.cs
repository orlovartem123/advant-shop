using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ProfitPlan
    {
        public int PlanId { get; set; }
        public int SalesPlan { get; set; }
        public double ProfitPlan1 { get; set; }
        public DateTime Date { get; set; }
    }
}
