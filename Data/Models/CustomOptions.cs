using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CustomOptions
    {
        public CustomOptions()
        {
            Options = new HashSet<Options>();
        }

        public int CustomOptionsId { get; set; }
        public string Title { get; set; }
        public bool IsRequired { get; set; }
        public int InputType { get; set; }
        public int? SortOrder { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public ICollection<Options> Options { get; set; }
    }
}
