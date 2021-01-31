﻿using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class MailFormatType
    {
        public MailFormatType()
        {
            MailFormat = new HashSet<MailFormat>();
        }

        public int MailFormatTypeId { get; set; }
        public string TypeName { get; set; }
        public int? SortOrder { get; set; }
        public string Comment { get; set; }
        public string MailType { get; set; }

        public ICollection<MailFormat> MailFormat { get; set; }
    }
}
