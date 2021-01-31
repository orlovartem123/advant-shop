using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SmsTemplate
    {
        public int TemplateId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public int SortOrder { get; set; }
        public bool Active { get; set; }
    }
}
