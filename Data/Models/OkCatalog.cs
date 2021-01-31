using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OkCatalog
    {
        public OkCatalog()
        {
            OkCatalogCategory = new HashSet<OkCatalogCategory>();
        }

        public int Id { get; set; }
        public long OkCatalogId { get; set; }
        public string Name { get; set; }

        public ICollection<OkCatalogCategory> OkCatalogCategory { get; set; }
    }
}
