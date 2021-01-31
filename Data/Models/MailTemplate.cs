using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class MailTemplate
    {
        public int TemplateId { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public int SortOrder { get; set; }
        public bool Active { get; set; }
    }
}
