using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderPickPoint
    {
        public int OrderId { get; set; }
        public string PickPointId { get; set; }
        public string PickPointAddress { get; set; }
        public string AdditionalData { get; set; }

        public Order Order { get; set; }
    }
}
