using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class InternalSettings
    {
        public int Id { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
    }
}
