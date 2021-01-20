using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool isFavourite { get; set; }

        public string Img { get; set; }

        public List<Product> products { get; set; }
    }
}
