using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Subscription
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool Subscribe { get; set; }
        public DateTime SubscribeDate { get; set; }
        public DateTime? UnsubscribeDate { get; set; }
        public string UnsubscribeReason { get; set; }
    }
}
