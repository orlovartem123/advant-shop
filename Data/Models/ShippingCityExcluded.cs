using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ShippingCityExcluded
    {
        public int MethodId { get; set; }
        public int CityId { get; set; }

        public City City { get; set; }
        public ShippingMethod Method { get; set; }
    }
}
