using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvantShop.Data.Interfaces;
using AdvantShop.Data.Models;

namespace AdvantShop.Data.Repository
{
    public class CategoryRepository : IAllCategories
    {

        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Categories;
    }
}
