using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ChangeHistory
    {
        public int Id { get; set; }
        public int ObjId { get; set; }
        public int ObjType { get; set; }
        public string ParameterName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public int ParameterType { get; set; }
        public int? ParameterId { get; set; }
        public string ChangedByName { get; set; }
        public Guid? ChangedById { get; set; }
        public DateTime ModificationTime { get; set; }
    }
}
