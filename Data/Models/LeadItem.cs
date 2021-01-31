using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LeadItem
    {
        public int LeadItemId { get; set; }
        public int LeadId { get; set; }
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public string ArtNo { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int? PhotoId { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public string CustomOptionsJson { get; set; }

        public Lead Lead { get; set; }
        public Photo Photo { get; set; }
        public Product Product { get; set; }
    }
}
