using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CustomerFieldValue
    {
        public int Id { get; set; }
        public int CustomerFieldId { get; set; }
        public string Value { get; set; }
        public int SortOrder { get; set; }

        public CustomerField CustomerField { get; set; }
    }
}
