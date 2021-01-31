using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Localization
    {
        public int LanguageId { get; set; }
        public string ResourceKey { get; set; }
        public string ResourceValue { get; set; }
    }
}
