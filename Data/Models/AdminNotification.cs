using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class AdminNotification
    {
        public AdminNotification()
        {
            AdminNotifications = new HashSet<AdminNotifications>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Tag { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string IconPath { get; set; }
        public string Data { get; set; }

        public ICollection<AdminNotifications> AdminNotifications { get; set; }
    }
}
