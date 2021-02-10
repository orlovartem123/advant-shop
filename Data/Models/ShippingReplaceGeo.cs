using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ShippingReplaceGeo
    {
        public int Id { get; set; }
        public string ShippingType { get; set; }
        public string InCountryName { get; set; }
        public string InCountryIso2 { get; set; }
        public string InRegionName { get; set; }
        public string InCityName { get; set; }
        public string InDistrict { get; set; }
        public string OutCountryName { get; set; }
        public string OutRegionName { get; set; }
        public string OutCityName { get; set; }
        public string OutDistrict { get; set; }
        public bool OutDistrictClear { get; set; }
        public bool Enabled { get; set; }
        public int Sort { get; set; }
        public string InZip { get; set; }
        public string OutZip { get; set; }
        public string Comment { get; set; }
    }
}
