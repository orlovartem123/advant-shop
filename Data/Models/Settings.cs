using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Settings
    {
        public int SettingId { get; set; }
        public string ParamName { get; set; }
        public string ParamValue { get; set; }
    }
}
