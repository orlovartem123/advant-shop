using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class VkMessage
    {
        public int Id { get; set; }
        public long MessageId { get; set; }
        public long UserId { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
        public long? ChatId { get; set; }
        public long? FromId { get; set; }
        public string Type { get; set; }
        public long? PostId { get; set; }
    }
}
