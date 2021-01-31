using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ProductPropertyValue
    {
        public int ProductId { get; set; }
        public int PropertyValueId { get; set; }

        public Product Product { get; set; }
        public PropertyValue PropertyValue { get; set; }
    }
}
