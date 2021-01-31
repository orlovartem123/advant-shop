using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Category1
    {
        public Category1()
        {
            CouponCategories = new HashSet<CouponCategories>();
            ExportFeedSelectedCategories = new HashSet<ExportFeedSelectedCategories>();
            InverseParentCategoryNavigation = new HashSet<Category1>();
            OkCatalogCategory = new HashSet<OkCatalogCategory>();
            ProductCategories = new HashSet<ProductCategories>();
            PropertyGroupCategory = new HashSet<PropertyGroupCategory>();
            RelatedProperties = new HashSet<RelatedProperties>();
            RelatedPropertyValues = new HashSet<RelatedPropertyValues>();
            SalesFunnelLeadAutoCompleteCategory = new HashSet<SalesFunnelLeadAutoCompleteCategory>();
            ShippingCategoryExcluded = new HashSet<ShippingCategoryExcluded>();
            VkCategoryCategory = new HashSet<VkCategoryCategory>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int? ParentCategory { get; set; }
        public string Description { get; set; }
        public int ProductsCount { get; set; }
        public int SortOrder { get; set; }
        public bool Enabled { get; set; }
        public int TotalProductsCount { get; set; }
        public bool DisplayChildProducts { get; set; }
        public string UrlPath { get; set; }
        public bool? HirecalEnabled { get; set; }
        public bool DisplayBrandsInMenu { get; set; }
        public bool DisplaySubCategoriesInMenu { get; set; }
        public int? CatLevel { get; set; }
        public string BriefDescription { get; set; }
        public int Sorting { get; set; }
        public int DisplayStyle { get; set; }
        public bool Hidden { get; set; }
        public bool? IsDemo { get; set; }
        public string ExternalId { get; set; }
        public int AvailableProductsCount { get; set; }
        public int CurrentProductsCount { get; set; }
        public int? AutomapAction { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateAdded { get; set; }
        public string ModifiedBy { get; set; }

        public Category1 ParentCategoryNavigation { get; set; }
        public CategoryRewardPercent CategoryRewardPercent { get; set; }
        public ICollection<CouponCategories> CouponCategories { get; set; }
        public ICollection<ExportFeedSelectedCategories> ExportFeedSelectedCategories { get; set; }
        public ICollection<Category1> InverseParentCategoryNavigation { get; set; }
        public ICollection<OkCatalogCategory> OkCatalogCategory { get; set; }
        public ICollection<ProductCategories> ProductCategories { get; set; }
        public ICollection<PropertyGroupCategory> PropertyGroupCategory { get; set; }
        public ICollection<RelatedProperties> RelatedProperties { get; set; }
        public ICollection<RelatedPropertyValues> RelatedPropertyValues { get; set; }
        public ICollection<SalesFunnelLeadAutoCompleteCategory> SalesFunnelLeadAutoCompleteCategory { get; set; }
        public ICollection<ShippingCategoryExcluded> ShippingCategoryExcluded { get; set; }
        public ICollection<VkCategoryCategory> VkCategoryCategory { get; set; }
    }
}
