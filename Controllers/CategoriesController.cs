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

        [Route("Categories/List")]
        [Route("Categories/List/{category}")]
        public ViewResult List(string category)
        {
            IEnumerable<Product> products = null;
            string currCategory = "";
            //switch (category)
            //{
            //    case "clothes":
            //        products = allProducts.AllProducts.Where(i=>i.Category.Name.Equals("Одежда"));
            //        currCategory = "Одежда";
            //        break;
            //    case "furniture":
            //        products = allProducts.AllProducts.Where(i => i.Category.Name.Equals("Мебель"));
            //        currCategory = "Мебель";
            //        break;
            //    case "appliances":
            //        products = allProducts.AllProducts.Where(i => i.Category.Name.Equals("Бытовая техника"));
            //        currCategory = "Бытовая техника";
            //        break;
            //    case "sport":
            //        products = allProducts.AllProducts.Where(i => i.Category.Name.Equals("Спортивные товары"));
            //        currCategory = "Спортивные товары";
            //        break;
            //    case "cosmetics":
            //        products = allProducts.AllProducts.Where(i => i.Category.Name.Equals("Косметика"));
            //        currCategory = "Косметика";
            //        break;
            //    case "garden-tech":
            //        products = allProducts.AllProducts.Where(i => i.Category.Name.Equals("Садовая техника"));
            //        currCategory = "Садовая техника";
            //        break;
            //    case "plumbing":
            //        products = allProducts.AllProducts.Where(i => i.Category.Name.Equals("Сантехника"));
            //        currCategory = "Сантехника";
            //        break;
            //    case "constracting":
            //        products = allProducts.AllProducts.Where(i => i.Category.Name.Equals("Строительные материалы"));
            //        currCategory = "Строительные материалы";
            //        break;
            //    case "auto":
            //        products = allProducts.AllProducts.Where(i => i.Category.Name.Equals("Автотехника"));
            //        currCategory = "Автотехника";
            //        break;
            //    case "food":
            //        products = allProducts.AllProducts.Where(i => i.Category.Name.Equals("Еда"));
            //        currCategory = "Еда";
            //        break;
            //    case "sites":
            //        products = allProducts.AllProducts.Where(i => i.Category.Name.Equals("Разработка сайтов"));
            //        currCategory = "Разработка сайтов";
            //        break;
            //    default:
            //        products = allProducts.AllProducts;
            //        currCategory = "Все товары";
            //        break;
            //}
            //return View(new CategoriesListViewModel(products, currCategory));
            return View();
        }
    }
}
