using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class BreakMessage
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
