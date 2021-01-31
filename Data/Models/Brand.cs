using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Product = new HashSet<Product>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandDescription { get; set; }
        public bool Enabled { get; set; }
        public int? CountryId { get; set; }
        public int? SortOrder { get; set; }
        public string UrlPath { get; set; }
        public string BrandBriefDescription { get; set; }
        public string BrandSiteUrl { get; set; }
        public bool? IsDemo { get; set; }
        public int? CountryOfManufactureId { get; set; }

        public Country Country { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
