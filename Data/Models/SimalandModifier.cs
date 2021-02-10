using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SimalandModifier
    {
        public SimalandModifier()
        {
            SimalandModification = new HashSet<SimalandModification>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPicture { get; set; }

        public ICollection<SimalandModification> SimalandModification { get; set; }
    }
}
