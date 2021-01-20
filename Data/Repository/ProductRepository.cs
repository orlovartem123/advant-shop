using AdvantShop.Data.Interfaces;
using AdvantShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.Data.Repository
{
    public class ProductRepository : IAllProducts
    {

        private readonly AppDBContent appDBContent;

        public ProductRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Product> AllProducts => appDBContent.Products.Include(c => c.Category);

        public IEnumerable<Product> HitProducts => appDBContent.Products.Where(p => p.Hit).Include(c => c.Category);

        public IEnumerable<Product> NoveltyProducts => appDBContent.Products.Where(p => p.Novelty).Include(c => c.Category);

        public Product GetProduct(int productId) => appDBContent.Products.FirstOrDefault(p=>p.Id==productId);
       
    }
}
