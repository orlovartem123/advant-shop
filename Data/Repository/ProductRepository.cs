using AdvantShop.Data.Interfaces;
using AdvantShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly Lic855Context lic855Context;

        public ProductRepository(Lic855Context lic855Context)
        {
            this.lic855Context = lic855Context;
        }

        public IEnumerable<Product> AllProducts => lic855Context.Product;

        public IEnumerable<Photo> Photos => lic855Context.Photo;

        public IEnumerable<Product> HitProducts => lic855Context.Product.Where(p => p.Bestseller == true);

        public IEnumerable<Product> NoveltyProducts => lic855Context.Product.Where(p => p.New == true);

        public IEnumerable<ProductExt> ProductExts => lic855Context.ProductExt;

        public IEnumerable<Currency> Currencies => lic855Context.Currency;

        public IEnumerable<ProductCategories> ProductsCategories => lic855Context.ProductCategories.Include(cat => cat.Product).Include(cat => cat.Category);

        public Product GetProduct(int productId) => lic855Context.Product.FirstOrDefault(p => p.ProductId == productId);

        public Category1 GetCategory(int productId) => lic855Context.ProductCategories.FirstOrDefault(i => i.ProductId == productId).Category;

        public int? GetCategoryIdByUrl(string categoryUrlName)
        {
            return lic855Context.Category1.FirstOrDefault(c => c.UrlPath.Equals(categoryUrlName))?.CategoryId;
        }

        public IEnumerable<Product> getProductsByCategory(List<Product> list, Category1 category,
            int page, int productsOnPage, ref int skiped)
        {
            if (list.Count() >= productsOnPage) return list.Take(productsOnPage); 
            var result = list;
            int productsByCategoryCount = ProductsCategories.Where(cat => cat.CategoryId == category.CategoryId).Count();
            int needSkip = (page - 1) * productsOnPage;
            if (skiped == needSkip)
            {
                result.AddRange(ProductsCategories.Where(cat =>
                cat.CategoryId == category.CategoryId).Select(p => p.Product).Take(productsOnPage - result.Count()));
            }
            else
            {
                skiped += productsByCategoryCount;
                if (skiped > needSkip)
                {
                    result.AddRange(ProductsCategories.Where(cat =>
                    cat.CategoryId == category.CategoryId).Skip(needSkip - (skiped - productsByCategoryCount)).Select(p =>
                        p.Product).Take(productsOnPage - result.Count()));
                    skiped = needSkip;
                }
            }
            foreach (var cat in lic855Context.Category1.Where(c => c.ParentCategory == category.CategoryId))
            {
                getProductsByCategory(result, cat, page, productsOnPage, ref skiped);
            }
            return result;
        }
    }
}
