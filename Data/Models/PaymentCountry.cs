using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class PaymentCountry
    {
        public int MethodId { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
        public PaymentMethod Method { get; set; }
    }
}
