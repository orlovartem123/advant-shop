using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ManualEmailing
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public int TotalCount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
