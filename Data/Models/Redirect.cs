using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Redirect
    {
        public int Id { get; set; }
        public string RedirectFrom { get; set; }
        public string RedirectTo { get; set; }
        public string ProductArtNo { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
    }
}
