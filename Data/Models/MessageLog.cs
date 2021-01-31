using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class MessageLog
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public string Title { get; set; }
        public string MessageText { get; set; }
    }
}
