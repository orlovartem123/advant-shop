using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Call
    {
        public int Id { get; set; }
        public string CallId { get; set; }
        public string Type { get; set; }
        public string SrcNum { get; set; }
        public string DstNum { get; set; }
        public string Extension { get; set; }
        public DateTime CallDate { get; set; }
        public DateTime? CallAnswerDate { get; set; }
        public int Duration { get; set; }
        public string RecordLink { get; set; }
        public bool CalledBack { get; set; }
        public string HangupStatus { get; set; }
        public string OperatorType { get; set; }
        public int? ManagerId { get; set; }
        public string Phone { get; set; }
        public bool IsComplete { get; set; }

        public Managers Manager { get; set; }
    }
}
