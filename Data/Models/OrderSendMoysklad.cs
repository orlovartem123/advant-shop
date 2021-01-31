using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderSendMoysklad
    {
        public int OrderId { get; set; }
        public bool? IsSendService { get; set; }

        public Order Order { get; set; }
    }
}
