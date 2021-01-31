using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Error404
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string UrlReferer { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
