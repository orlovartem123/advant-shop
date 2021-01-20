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

        public ProductsController(IAllProducts allProducts)
        {
            this.allProducts = allProducts;
        }

       
        public ViewResult Index()
        {
            ProductsListViewModel obj = new ProductsListViewModel(allProducts.AllProducts, allProducts.HitProducts, allProducts.NoveltyProducts);
            return View(obj);
        }
    }
}
