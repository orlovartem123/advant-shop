using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class BindedCustomer
    {
        public int PartnerId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UrlReferrer { get; set; }
        public string UtmSource { get; set; }
        public string UtmMedium { get; set; }
        public string UtmCampaign { get; set; }
        public string UtmTerm { get; set; }
        public string UtmContent { get; set; }
        public string Url { get; set; }
        public string CouponCode { get; set; }
        public bool Enabled { get; set; }
        public DateTime? VisitDate { get; set; }

        public Customer Customer { get; set; }
        public Partner Partner { get; set; }
    }
}
