using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class PaymentParam
    {
        public int PaymentMethodId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
    }
}
