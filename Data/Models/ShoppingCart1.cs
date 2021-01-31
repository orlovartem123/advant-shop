using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ShoppingCart1
    {
        public int ShoppingCartItemId { get; set; }
        public int ShoppingCartType { get; set; }
        public Guid CustomerId { get; set; }
        public int OfferId { get; set; }
        public string AttributesXml { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool? IsGift { get; set; }
        public string ModuleKey { get; set; }
        public bool AddedByRequest { get; set; }
        public double? CustomPrice { get; set; }

        public Offer Offer { get; set; }
    }
}
