using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SmsLog
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string State { get; set; }
        public long Phone { get; set; }
        public DateTime Created { get; set; }
    }
}
