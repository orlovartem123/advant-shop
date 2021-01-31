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

        private readonly Lic855Context lic855Context;

        public ProductRepository(Lic855Context lic855Context)
        {
            this.lic855Context = lic855Context;
        }

        public IEnumerable<Product> AllProducts => lic855Context.Product;

        public IEnumerable<Product> HitProducts => lic855Context.Product.Where(p=>p.Bestseller==true);

        public IEnumerable<Product> NoveltyProducts => lic855Context.Product.Where(p => p.New == true);

        public Product GetProduct(int productId) => lic855Context.Product.FirstOrDefault(p=>p.ProductId==productId);
       
    }
}
