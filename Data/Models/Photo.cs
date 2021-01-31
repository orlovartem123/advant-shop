using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Photo
    {
        public Photo()
        {
            LeadItem = new HashSet<LeadItem>();
            OrderItems = new HashSet<OrderItems>();
        }

        public int PhotoId { get; set; }
        public int ObjId { get; set; }
        public string Type { get; set; }
        public string PhotoName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Description { get; set; }
        public int? PhotoSortOrder { get; set; }
        public bool Main { get; set; }
        public string OriginName { get; set; }
        public int? ColorId { get; set; }
        public string PhotoNameSize1 { get; set; }
        public string PhotoNameSize2 { get; set; }

        public Color Color { get; set; }
        public ICollection<LeadItem> LeadItem { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
