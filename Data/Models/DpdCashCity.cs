using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class DpdCashCity
    {
        public long CityId { get; set; }
        public string CityName { get; set; }
        public string RegionName { get; set; }
        public string CountryCode { get; set; }
        public string Abbreviation { get; set; }
    }
}
