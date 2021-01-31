using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class DownloadableContent
    {
        public int Id { get; set; }
        public string StringId { get; set; }
        public bool IsInstall { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public bool Active { get; set; }
        public string Version { get; set; }
        public string DcType { get; set; }
    }
}
