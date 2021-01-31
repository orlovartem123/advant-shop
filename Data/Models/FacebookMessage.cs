using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class FacebookMessage
    {
        public int Id { get; set; }
        public string MessageId { get; set; }
        public string FromId { get; set; }
        public string ToId { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int Type { get; set; }
        public string PostId { get; set; }
        public string ConversationId { get; set; }
    }
}
