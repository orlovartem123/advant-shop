using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class AdminInformer
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int ObjId { get; set; }
        public Guid? CustomerId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Link { get; set; }
        public int Count { get; set; }
        public bool Seen { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? PrivateCustomerId { get; set; }
        public int? EntityId { get; set; }
    }
}
