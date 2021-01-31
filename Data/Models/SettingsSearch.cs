using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SettingsSearch
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string KeyWords { get; set; }
        public int SortOrder { get; set; }
    }
}
