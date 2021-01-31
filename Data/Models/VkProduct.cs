using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class VkProduct
    {
        public long Id { get; set; }
        public int ProductId { get; set; }
        public long MainPhotoId { get; set; }
        public string PhotoIds { get; set; }
        public long AlbumId { get; set; }
        public string PhotosMapIds { get; set; }

        public Product Product { get; set; }
    }
}
