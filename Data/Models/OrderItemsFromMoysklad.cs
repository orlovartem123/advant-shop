using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderItemsFromMoysklad
    {
        public string OfferExternalId { get; set; }
        public int OrderItemId { get; set; }

        public OrderItems OrderItem { get; set; }
    }
}
