using AdvantShop.Data.Interfaces;
using AdvantShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> allProducts { get; set; }

        public IEnumerable<Product> hitProducts { get; set; }

        public IEnumerable<Product> noveltyProducts { get; set; }

        public ProductsListViewModel(IAllProducts allProducts)
        {
            this.allProducts = allProducts.AllProducts;
            this.hitProducts = allProducts.HitProducts;
            this.noveltyProducts = allProducts.NoveltyProducts;
        }

    }
}
