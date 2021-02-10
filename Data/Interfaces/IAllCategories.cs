using AdvantShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.Data.Interfaces
{
    public interface IAllCategories
    {
        IEnumerable<Category1> AllCategories { get; }

        Stack<Category1> buildPathByUrl(string UrlPath);
    }
}
