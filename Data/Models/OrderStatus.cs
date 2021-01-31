using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Order = new HashSet<Order>();
            SmsTemplateOnOrderChanging = new HashSet<SmsTemplateOnOrderChanging>();
        }

        public int OrderStatusId { get; set; }
        public string StatusName { get; set; }
        public byte CommandId { get; set; }
        public bool IsDefault { get; set; }
        public bool? IsCanceled { get; set; }
        public string Color { get; set; }
        public int SortOrder { get; set; }
        public bool IsCompleted { get; set; }
        public bool? Hidden { get; set; }
        public bool CancelForbidden { get; set; }

        public ICollection<Order> Order { get; set; }
        public ICollection<SmsTemplateOnOrderChanging> SmsTemplateOnOrderChanging { get; set; }
    }
}
