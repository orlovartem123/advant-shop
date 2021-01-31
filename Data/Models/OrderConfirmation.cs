using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderConfirmation
    {
        public Guid CustomerId { get; set; }
        public string OrderConfirmationData { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
