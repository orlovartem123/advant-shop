using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SmsTemplateOnOrderChanging
    {
        public int Id { get; set; }
        public int OrderStatusId { get; set; }
        public string SmsText { get; set; }
        public bool Enabled { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }
}
