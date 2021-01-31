using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Modules
    {
        public int ModuleId { get; set; }
        public string ModuleStringId { get; set; }
        public bool IsInstall { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public string Version { get; set; }
        public bool Active { get; set; }
        public bool NeedUpdate { get; set; }
    }
}
