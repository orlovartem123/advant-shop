using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Attachment
    {
        public int Id { get; set; }
        public int ObjId { get; set; }
        public string Type { get; set; }
        public string FileName { get; set; }
        public int SortOrder { get; set; }
        public int FileSize { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
