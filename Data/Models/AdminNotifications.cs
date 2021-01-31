using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class AdminNotifications
    {
        public Guid CustomerId { get; set; }
        public int AdminNotificationid { get; set; }

        public AdminNotification AdminNotification { get; set; }
        public Customer Customer { get; set; }
    }
}
