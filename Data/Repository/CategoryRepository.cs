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
    }
}
