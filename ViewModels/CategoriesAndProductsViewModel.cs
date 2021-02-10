using AdvantShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.ViewModels
{
    public class CategoriesAndProductsViewModel
    {
        public CategoriesListViewModel categoriesListView;

        public ProductsListViewModel productsListView;

        public CategoriesAndProductsViewModel(CategoriesListViewModel categoriesListView, ProductsListViewModel productsListView)
        {
            this.categoriesListView = categoriesListView;
            this.productsListView = productsListView;
            this.productsListView.hitProducts = this.productsListView.allProducts.Where(n => n.Bestseller == true);
            this.productsListView.noveltyProducts = this.productsListView.allProducts.Where(n => n.New == true);
        }
    }
}
