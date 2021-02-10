using AdvantShop.Data.Interfaces;
using AdvantShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.ViewModels
{
    public class CategoriesListViewModel
    {
        public IEnumerable<Product> ProductsByCategory { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Category1> AllCategories { get; set; }

        public Category1 CurrentCategory { get; set; }

        public IEnumerable<Category1> Categories { get; set; }

        public IEnumerable<Photo> Photos { get; set; }

        public IEnumerable<ProductExt> ProductExts { get; set; }

        public IEnumerable<ProductCategories> ProductsCategories { get; set; }

        public IEnumerable<Currency> Currencies { get; set; }

        public Stack<Category1> categoriesPath { get; set; }

        public int Page { get; set; }

        public int ProductsOnPage { get; set; }

        public string getProductImg(int productID)
        {
            return Photos.FirstOrDefault(photo => photo.ObjId == productID && photo.Type.Equals("Product")).PhotoName;
        }

        public double? getProductPrice(int productID)
        {
            return ProductExts.FirstOrDefault(exts => exts.ProductId == productID).PriceTemp;
        }

        public string getProductCurrency(int currencyID)
        {
            return Currencies.FirstOrDefault(cur => cur.CurrencyId == currencyID).Code;
        }

        //private IEnumerable<Product> getProductsByCategory(List<Product> list, Category1 category)
        //{
        //    List<Product> result = list;
        //    result.AddRange(ProductsCategories.Where(cat => cat.CategoryId == category.CategoryId).Select(p => p.Product));
        //    foreach (var cat in AllCategories.Where(c => c.ParentCategory == category.CategoryId))
        //    {
        //        getProductsByCategory(result, cat);
        //    }
        //    return result;
        //}

        public CategoriesListViewModel(string urlPath, IAllProducts allProducts,
    IAllCategories allCategories, Stack<Category1> categoriesPath, int Page)
        {
            this.Page = Page;
            ProductsOnPage = 18;
            Products = allProducts.AllProducts;
            AllCategories = allCategories.AllCategories;
            CurrentCategory = allCategories.AllCategories.FirstOrDefault(cat => cat.UrlPath.Equals(urlPath));
            Photos = allProducts.Photos;
            ProductExts = allProducts.ProductExts;
            Currencies = allProducts.Currencies;
            Categories = allCategories.AllCategories.Where(cat => cat.ParentCategory == CurrentCategory.CategoryId && cat.CategoryId != 0);
            this.categoriesPath = categoriesPath;
            ProductsCategories = allProducts.ProductsCategories;
            if (!urlPath.Equals("catalog"))
                ProductsByCategory = allProducts.ProductsByCategoryOnPage(urlPath, Page, ProductsOnPage);
        }
    }
}
