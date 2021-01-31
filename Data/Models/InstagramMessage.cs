using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class InstagramMessage
    {
        public int Id { get; set; }
        public string ThreadId { get; set; }
        public string MediaPk { get; set; }
        public string InstagramId { get; set; }
        public string FromUserPk { get; set; }
        public string ToUserPk { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ItemType { get; set; }
        public string Title { get; set; }
    }
}
