using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TelegramMessage
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public int FromId { get; set; }
        public int? ToId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public long? ChatId { get; set; }
        public string Type { get; set; }
    }
}
