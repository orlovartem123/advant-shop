using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LeadEvent
    {
        public int Id { get; set; }
        public int LeadId { get; set; }
        public int Type { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Title { get; set; }
        public int? TaskId { get; set; }
        public Guid? CreatedById { get; set; }

        public Lead Lead { get; set; }
        public Task Task { get; set; }
    }
}
