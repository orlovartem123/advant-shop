using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class AdminComment
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int ObjId { get; set; }
        public string Type { get; set; }
        public Guid? CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool Deleted { get; set; }
    }
}
