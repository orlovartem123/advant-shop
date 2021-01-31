using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ModuleSettings
    {
        public int SettingId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string ModuleName { get; set; }
    }
}
