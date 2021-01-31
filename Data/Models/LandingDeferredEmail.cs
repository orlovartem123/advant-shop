using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LandingDeferredEmail
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SendingDate { get; set; }
    }
}
