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

        private readonly Lic855Context lic855Context;

        public CategoryRepository(Lic855Context lic855Context)
        {
            this.lic855Context = lic855Context;
        }

        public IEnumerable<Category1> AllCategories => lic855Context.Category1;

        public Stack<Category1> buildPathByUrl(string UrlPath)
        {
            Stack<Category1> result = new Stack<Category1>();
            var currCategory = AllCategories.FirstOrDefault(c => c.UrlPath.Equals(UrlPath));
            if (currCategory == null) { return null; }
            int id = currCategory.CategoryId;
            while (id != 0)
            {
                result.Push(currCategory);
                currCategory = AllCategories.FirstOrDefault(c => c.CategoryId == currCategory.ParentCategory);
                id = (currCategory == null) ? 0 : currCategory.CategoryId;
            }
            return result;
        }
    }
}
