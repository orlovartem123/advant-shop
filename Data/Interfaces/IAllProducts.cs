using AdvantShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> AllProducts { get; }

        IEnumerable<Product> HitProducts { get; }

        IEnumerable<Product> NoveltyProducts { get; }

        Product GetProduct(int productId);
    }
}
