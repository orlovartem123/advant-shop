using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ClientCode
    {
        public Guid UserId { get; set; }
        public int Code { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
