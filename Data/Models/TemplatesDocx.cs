﻿using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TemplatesDocx
    {
        public int Id { get; set; }
        public byte Type { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool? DebugMode { get; set; }
    }
}