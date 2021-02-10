using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Product = new HashSet<Product>();
            Service = new HashSet<Service>();
        }

        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double CurrencyValue { get; set; }
        public string CurrencyIso3 { get; set; }
        public bool IsCodeBefore { get; set; }
        public int? CurrencyNumIso3 { get; set; }
        public double? RoundNumbers { get; set; }
        public bool? EnablePriceRounding { get; set; }

        public ICollection<Product> Product { get; set; }
        public ICollection<Service> Service { get; set; }
    }
}
