using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ProductGifts
    {
        public int ProductId { get; set; }
        public int GiftOfferId { get; set; }
        public int ProductCount { get; set; }

        public Offer GiftOffer { get; set; }
    }
}
