using AdvantShop.Data.Interfaces;
using AdvantShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts allProducts;

        private readonly IAllCategories allCategories;

        public ProductsController(IAllProducts allProducts,IAllCategories allCategories)
        {
            this.allProducts = allProducts;
            this.allCategories = allCategories;
        }

        public ViewResult Index()
        {
            var categoriesView = new CategoriesListViewModel("catalog",allProducts,allCategories,null,0);
            var productsView = new ProductsListViewModel(allProducts);
            CategoriesAndProductsViewModel obj = new CategoriesAndProductsViewModel(categoriesView, productsView);
            return View(obj);
        }
    }
}
