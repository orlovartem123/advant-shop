using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Review
    {
        public Review()
        {
            ReviewLikes = new HashSet<ReviewLikes>();
            Task = new HashSet<Task>();
        }

        public int ReviewId { get; set; }
        public int ParentId { get; set; }
        public int EntityId { get; set; }
        public int Type { get; set; }
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public DateTime AddDate { get; set; }
        public bool Checked { get; set; }
        public string Ip { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
        public int RatioByLikes { get; set; }

        public ICollection<ReviewLikes> ReviewLikes { get; set; }
        public ICollection<Task> Task { get; set; }
    }
}
