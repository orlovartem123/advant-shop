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

        IEnumerable<ProductCategories> ProductsCategories { get; }

        IEnumerable<Photo> Photos { get; }

        IEnumerable<ProductExt> ProductExts { get; }

        IEnumerable<Currency> Currencies { get; }

        IEnumerable<Product> HitProducts { get; }

        IEnumerable<Product> NoveltyProducts { get; }

        IEnumerable<Product> getProductsByCategory(List<Product> list, Category1 category, int page, int productsOnPage, ref int skiped);

        Category1 GetCategory(int productId);

        int? GetCategoryIdByUrl(string categoryUrlName);

        Product GetProduct(int productId);
    }
}
