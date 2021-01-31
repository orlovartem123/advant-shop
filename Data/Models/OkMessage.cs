using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OkMessage
    {
        public int Id { get; set; }
        public string MessageId { get; set; }
        public string ChatId { get; set; }
        public string UserId { get; set; }
        public string FromUser { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
