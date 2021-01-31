using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LandingEmailTemplate
    {
        public int Id { get; set; }
        public int BlockId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int SendingTime { get; set; }

        public LandingBlock Block { get; set; }
    }
}
