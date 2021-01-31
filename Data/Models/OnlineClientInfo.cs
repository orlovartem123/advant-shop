using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OnlineClientInfo
    {
        public string SessionId { get; set; }
        public string Address { get; set; }
        public string UserAgentBrowser { get; set; }
        public string LastAccessedPath { get; set; }
        public DateTime Started { get; set; }
        public string UserAgentOs { get; set; }
        public string CountryByGeoIp { get; set; }
    }
}
