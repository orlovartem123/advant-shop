using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SearchStatistic
    {
        public int Id { get; set; }
        public string Request { get; set; }
        public int ResultCount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string SearchTerm { get; set; }
        public string CustomerId { get; set; }
    }
}
