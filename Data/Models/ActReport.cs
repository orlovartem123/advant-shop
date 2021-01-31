using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ActReport
    {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public string FileName { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public DateTime DateCreated { get; set; }

        public Partner Partner { get; set; }
    }
}
