using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class AuthorizeLog
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public bool IsAdmin { get; set; }
        public string UserIp { get; set; }
        public bool IsSuccess { get; set; }
        public DateTime AddDate { get; set; }
    }
}
