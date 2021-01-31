using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ImportLog
    {
        public int Id { get; set; }
        public int Mtype { get; set; }
        public string Message { get; set; }
    }
}
