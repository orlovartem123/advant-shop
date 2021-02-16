using AdvantShop.Data.Interfaces;
using AdvantShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.ViewModels
{
    public class ProductCartViewModel
    {
        public IEnumerable<Category1> Categories { get; set; }

        public IAllCategories allCategories { get; set; }

        public Product Product { get; set; }

        public string ProductImg { get; set; }

        public double? ProductPrice { get; set; }

        public string ProductCurrency { get; set; }

        public ProductCartViewModel(Product Product, IAllCategories allCategories, IAllProducts allProducts)
        {
            this.Product = Product;
            var currCategory = allProducts.ProductsCategories.FirstOrDefault(p => p.ProductId == Product.ProductId).Category;
            Categories = allCategories.AllCategories.Where(cat => cat.ParentCategory == currCategory.ParentCategory && cat.CategoryId != 0);
            this.allCategories = allCategories;
            ProductImg = allProducts.Photos.FirstOrDefault(photo => photo.ObjId == Product.ProductId && photo.Type.Equals("Product")).PhotoName;
            ProductPrice = allProducts.ProductExts.FirstOrDefault(exts => exts.ProductId == Product.ProductId).PriceTemp;
            ProductCurrency = allProducts.Currencies.FirstOrDefault(cur => cur.CurrencyId == Product.CurrencyId).Code;
        }
    }
}
