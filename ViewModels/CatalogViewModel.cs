using AdvantShop.Data.Interfaces;
using AdvantShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.ViewModels
{
    public class CatalogViewModel
    {
        public IEnumerable<Category1> Categories { get; set; }

        public CatalogViewModel(IAllCategories allCategories)
        {
            Categories = allCategories.AllCategories;
        }
    }
}
