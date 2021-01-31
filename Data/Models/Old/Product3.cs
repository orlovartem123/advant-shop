using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.Data.Models
{
    public class Product3
    {
        public int Id { get; set; }

        public string Img { get; set; }

        public string Desc { get; set; }

        public int CategoryId { get; set; }

        public int Stars { get; set; }

        public bool Availiable { get; set; }

        public bool Hit { get; set; }

        public bool Novelty { get; set; }

        public ulong Price { get; set; }

        public virtual Category2 Category { get; set; }
    }
}
