using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class ReviewLikes
    {
        public int Id { get; set; }
        public int ReviewId { get; set; }
        public bool IsLike { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime AddDate { get; set; }

        public Review Review { get; set; }
    }
}
