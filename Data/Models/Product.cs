using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            CouponProducts = new HashSet<CouponProducts>();
            CustomOptions = new HashSet<CustomOptions>();
            ExportFeedExcludedProducts = new HashSet<ExportFeedExcludedProducts>();
            LandingSiteProduct = new HashSet<LandingSiteProduct>();
            LeadItem = new HashSet<LeadItem>();
            NewsProduct = new HashSet<NewsProduct>();
            Offer = new HashSet<Offer>();
            OrderItems = new HashSet<OrderItems>();
            ProductCategories = new HashSet<ProductCategories>();
            ProductFile = new HashSet<ProductFile>();
            ProductProductList = new HashSet<ProductProductList>();
            ProductPropertyValue = new HashSet<ProductPropertyValue>();
            ProductVideo = new HashSet<ProductVideo>();
            RatioNavigation = new HashSet<Ratio>();
            RecentlyViewsData = new HashSet<RecentlyViewsData>();
            SalesFunnelLeadAutoCompleteProduct = new HashSet<SalesFunnelLeadAutoCompleteProduct>();
            ShippingProductExcluded = new HashSet<ShippingProductExcluded>();
            VkProduct = new HashSet<VkProduct>();
        }

        public int ProductId { get; set; }
        public string ArtNo { get; set; }
        public string Name { get; set; }
        public double Ratio { get; set; }
        public double? Discount { get; set; }
        public double? Weight { get; set; }
        public string BriefDescription { get; set; }
        public string Description { get; set; }
        public bool? Enabled { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Recomended { get; set; }
        public bool? New { get; set; }
        public bool? Bestseller { get; set; }
        public bool? OnSale { get; set; }
        public int? BrandId { get; set; }
        public bool? AllowPreOrder { get; set; }
        public int? SortBestseller { get; set; }
        public int? SortNew { get; set; }
        public int? SortDiscount { get; set; }
        public string UrlPath { get; set; }
        public bool? CategoryEnabled { get; set; }
        public string Unit { get; set; }
        public decimal? ShippingPrice { get; set; }
        public double? MinAmount { get; set; }
        public double? MaxAmount { get; set; }
        public double Multiplicity { get; set; }
        public bool HasMultiOffer { get; set; }
        public string SalesNote { get; set; }
        public string GoogleProductCategory { get; set; }
        public string Gtin { get; set; }
        public bool Adult { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public int CurrencyId { get; set; }
        public bool ActiveView360 { get; set; }
        public string YandexMarketCategory { get; set; }
        public bool? ManufacturerWarranty { get; set; }
        public string CustomViewName { get; set; }
        public string ModifiedBy { get; set; }
        public string YandexTypePrefix { get; set; }
        public string YandexModel { get; set; }
        public string BarCode { get; set; }
        public double? Bid { get; set; }
        public double? Fee { get; set; }
        public double? DiscountAmount { get; set; }
        public bool? AccrueBonuses { get; set; }
        public int? TaxId { get; set; }
        public bool? IsDemo { get; set; }
        public string YandexSizeUnit { get; set; }
        public string YandexName { get; set; }
        public bool? Cpa { get; set; }
        public string YandexDeliveryDays { get; set; }
        public string CreatedBy { get; set; }
        public int PaymentSubjectType { get; set; }
        public int PaymentMethodType { get; set; }
        public bool Hidden { get; set; }
        public double? ManualRatio { get; set; }
        public int? SortPopular { get; set; }
        public bool? YandexProductDiscounted { get; set; }
        public string YandexProductDiscountCondition { get; set; }
        public string YandexProductDiscountReason { get; set; }

        public Brand Brand { get; set; }
        public Currency Currency { get; set; }
        public ProductExt ProductExt { get; set; }
        public SimalandModification SimalandModification { get; set; }
        public ICollection<CouponProducts> CouponProducts { get; set; }
        public ICollection<CustomOptions> CustomOptions { get; set; }
        public ICollection<ExportFeedExcludedProducts> ExportFeedExcludedProducts { get; set; }
        public ICollection<LandingSiteProduct> LandingSiteProduct { get; set; }
        public ICollection<LeadItem> LeadItem { get; set; }
        public ICollection<NewsProduct> NewsProduct { get; set; }
        public ICollection<Offer> Offer { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
        public ICollection<ProductCategories> ProductCategories { get; set; }
        public ICollection<ProductFile> ProductFile { get; set; }
        public ICollection<ProductProductList> ProductProductList { get; set; }
        public ICollection<ProductPropertyValue> ProductPropertyValue { get; set; }
        public ICollection<ProductVideo> ProductVideo { get; set; }
        public ICollection<Ratio> RatioNavigation { get; set; }
        public ICollection<RecentlyViewsData> RecentlyViewsData { get; set; }
        public ICollection<SalesFunnelLeadAutoCompleteProduct> SalesFunnelLeadAutoCompleteProduct { get; set; }
        public ICollection<ShippingProductExcluded> ShippingProductExcluded { get; set; }
        public ICollection<VkProduct> VkProduct { get; set; }
    }
}
