using AdvantShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.ViewModels
{
    public class CategoriesListViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public string CategoryName { get; set; }

        public CategoriesListViewModel(IEnumerable<Product> Products, string name)
        {
            this.Products = Products;
            CategoryName = name;
        }
    }
}
