using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ShippingPayments
    {
        public int ShippingMethodId { get; set; }
        public int PaymentMethodId { get; set; }
        public int Id { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
    }
}
