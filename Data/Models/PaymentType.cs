using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class PaymentType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
    }
}
