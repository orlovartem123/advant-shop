using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ReservationResourceTag
    {
        public ReservationResourceTag()
        {
            ReservationResourceTagsMap = new HashSet<ReservationResourceTagsMap>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }

        public ICollection<ReservationResourceTagsMap> ReservationResourceTagsMap { get; set; }
    }
}
