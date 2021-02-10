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

        IEnumerable<Product> ProductsByCategoryOnPage(string categoryUrlName, int page, int productsOnPage);

        Category1 GetCategory(int productId);

        int? GetCategoryIdByUrl(string categoryUrlName);

        Product GetProduct(int productId);
    }
}
