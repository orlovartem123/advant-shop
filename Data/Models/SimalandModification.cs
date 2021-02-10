using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SimalandModification
    {
        public int ProductId { get; set; }
        public int ModificationId { get; set; }
        public int ModifierId { get; set; }
        public string Value { get; set; }
        public int SortOrder { get; set; }

        public SimalandModifier Modifier { get; set; }
        public Product Product { get; set; }
    }
}
