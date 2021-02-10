using AdvantShop.Data.Interfaces;
using AdvantShop.Data.Models;
using AdvantShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IAllCategories allCategories;

        private readonly IAllProducts allProducts;

        public CategoriesController(IAllCategories allCategories, IAllProducts allProducts)
        {
            this.allCategories = allCategories;
            this.allProducts = allProducts;
        }

        [Route("Categories/List/catalog")]
        public ViewResult Catalog()
        {
            return View(new CatalogViewModel(allCategories));
        }

        [Route("Categories/List")]
        [Route("Categories/List/{category}")]
        public ViewResult List(string category)
        {
            return View(new CategoriesListViewModel(category, allProducts, allCategories,
                allCategories.buildPathByUrl(category), 1));
        }

        [Route("Categories/List/{category}/{page}")]
        public ViewResult List(string category, int page)
        {
            return View(new CategoriesListViewModel(category, allProducts, allCategories,
                allCategories.buildPathByUrl(category), page));
        }
    }
}
