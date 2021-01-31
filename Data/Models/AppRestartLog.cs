using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class AppRestartLog
    {
        public int Id { get; set; }
        public DateTime RestartDate { get; set; }
        public string ServerName { get; set; }
    }
}
