using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Offer
    {
        public Offer()
        {
            ProductGifts = new HashSet<ProductGifts>();
            ShoppingCart1 = new HashSet<ShoppingCart1>();
        }

        public int OfferId { get; set; }
        public int ProductId { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public double SupplyPrice { get; set; }
        public int? ColorId { get; set; }
        public int? SizeId { get; set; }
        public string ArtNo { get; set; }
        public bool Main { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }

        public Color Color { get; set; }
        public Product Product { get; set; }
        public Size Size { get; set; }
        public ICollection<ProductGifts> ProductGifts { get; set; }
        public ICollection<ShoppingCart1> ShoppingCart1 { get; set; }
    }
}
