using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ViewedTask
    {
        public int TaskId { get; set; }
        public int ManagerId { get; set; }
        public DateTime ViewDate { get; set; }

        public Managers Manager { get; set; }
        public Task Task { get; set; }
    }
}
