using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderTrafficSource
    {
        public int Id { get; set; }
        public int ObjId { get; set; }
        public int ObjType { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? CreateOn { get; set; }
        public string Referrer { get; set; }
        public string Url { get; set; }
        public string UtmSource { get; set; }
        public string UtmMedium { get; set; }
        public string UtmCampaign { get; set; }
        public string UtmContent { get; set; }
        public string UtmTerm { get; set; }
        public string GoogleClientId { get; set; }
    }
}
