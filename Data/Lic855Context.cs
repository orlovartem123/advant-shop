using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AdvantShop.Data.Models
{
    public partial class Lic855Context : DbContext
    {
        public Lic855Context()
        {
        }

        public Lic855Context(DbContextOptions<Lic855Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ActReport> ActReport { get; set; }
        public virtual DbSet<AdditionBonus> AdditionBonus { get; set; }
        public virtual DbSet<AdminComment> AdminComment { get; set; }
        public virtual DbSet<AdminInformer> AdminInformer { get; set; }
        public virtual DbSet<AdminNotification> AdminNotification { get; set; }
        public virtual DbSet<AdminNotifications> AdminNotifications { get; set; }
        public virtual DbSet<Affiliate> Affiliate { get; set; }
        public virtual DbSet<AffiliateAdditionalTime> AffiliateAdditionalTime { get; set; }
        public virtual DbSet<AffiliateAnalyticManager> AffiliateAnalyticManager { get; set; }
        public virtual DbSet<AffiliateCategory> AffiliateCategory { get; set; }
        public virtual DbSet<AffiliateManager> AffiliateManager { get; set; }
        public virtual DbSet<AffiliateReservationResource> AffiliateReservationResource { get; set; }
        public virtual DbSet<AffiliateService> AffiliateService { get; set; }
        public virtual DbSet<AffiliateSmsTemplate> AffiliateSmsTemplate { get; set; }
        public virtual DbSet<AffiliateTimeOfBooking> AffiliateTimeOfBooking { get; set; }
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<AppRestartLog> AppRestartLog { get; set; }
        public virtual DbSet<AspstateTempApplications> AspstateTempApplications { get; set; }
        public virtual DbSet<AspstateTempSessions> AspstateTempSessions { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<AuthorizeLog> AuthorizeLog { get; set; }
        public virtual DbSet<BindedCustomer> BindedCustomer { get; set; }
        public virtual DbSet<BizProcessRule> BizProcessRule { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<BookingCurrency> BookingCurrency { get; set; }
        public virtual DbSet<BookingItems> BookingItems { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<BreakMessage> BreakMessage { get; set; }
        public virtual DbSet<Call> Call { get; set; }
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<Carousel> Carousel { get; set; }
        public virtual DbSet<CategoriesAutoMapping> CategoriesAutoMapping { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Category1> Category1 { get; set; }
        public virtual DbSet<CategoryRewardPercent> CategoryRewardPercent { get; set; }
        public virtual DbSet<Certificate> Certificate { get; set; }
        public virtual DbSet<ChangeHistory> ChangeHistory { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ClientCode> ClientCode { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryRu> CountryRu { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<CouponCategories> CouponCategories { get; set; }
        public virtual DbSet<CouponCustomers> CouponCustomers { get; set; }
        public virtual DbSet<CouponProducts> CouponProducts { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerCertificate> CustomerCertificate { get; set; }
        public virtual DbSet<CustomerCoupon> CustomerCoupon { get; set; }
        public virtual DbSet<CustomerField> CustomerField { get; set; }
        public virtual DbSet<CustomerFieldValue> CustomerFieldValue { get; set; }
        public virtual DbSet<CustomerFieldValuesMap> CustomerFieldValuesMap { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroup { get; set; }
        public virtual DbSet<CustomerSegment> CustomerSegment { get; set; }
        public virtual DbSet<CustomerSegmentCustomer> CustomerSegmentCustomer { get; set; }
        public virtual DbSet<CustomOptions> CustomOptions { get; set; }
        public virtual DbSet<CustomRule> CustomRule { get; set; }
        public virtual DbSet<DealStatus> DealStatus { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<DownloadableContent> DownloadableContent { get; set; }
        public virtual DbSet<DpdCashCity> DpdCashCity { get; set; }
        public virtual DbSet<DpdParcelShops> DpdParcelShops { get; set; }
        public virtual DbSet<DpdTerminals> DpdTerminals { get; set; }
        public virtual DbSet<Error404> Error404 { get; set; }
        public virtual DbSet<ExportFeed> ExportFeed { get; set; }
        public virtual DbSet<ExportFeedExcludedProducts> ExportFeedExcludedProducts { get; set; }
        public virtual DbSet<ExportFeedSelectedCategories> ExportFeedSelectedCategories { get; set; }
        public virtual DbSet<FacebookMessage> FacebookMessage { get; set; }
        public virtual DbSet<FileLibrary> FileLibrary { get; set; }
        public virtual DbSet<GiftCertificateTaxes> GiftCertificateTaxes { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<ImportLog> ImportLog { get; set; }
        public virtual DbSet<InstagramMessage> InstagramMessage { get; set; }
        public virtual DbSet<InternalSettings> InternalSettings { get; set; }
        public virtual DbSet<Landing> Landing { get; set; }
        public virtual DbSet<LandingBlock> LandingBlock { get; set; }
        public virtual DbSet<LandingColorScheme> LandingColorScheme { get; set; }
        public virtual DbSet<LandingDeferredEmail> LandingDeferredEmail { get; set; }
        public virtual DbSet<LandingDomain> LandingDomain { get; set; }
        public virtual DbSet<LandingEmailTemplate> LandingEmailTemplate { get; set; }
        public virtual DbSet<LandingForm> LandingForm { get; set; }
        public virtual DbSet<LandingSettings> LandingSettings { get; set; }
        public virtual DbSet<LandingSite> LandingSite { get; set; }
        public virtual DbSet<LandingSiteProduct> LandingSiteProduct { get; set; }
        public virtual DbSet<LandingSiteSettings> LandingSiteSettings { get; set; }
        public virtual DbSet<LandingSubBlock> LandingSubBlock { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Lead> Lead { get; set; }
        public virtual DbSet<LeadCurrency> LeadCurrency { get; set; }
        public virtual DbSet<LeadEvent> LeadEvent { get; set; }
        public virtual DbSet<LeadField> LeadField { get; set; }
        public virtual DbSet<LeadFieldValue> LeadFieldValue { get; set; }
        public virtual DbSet<LeadFieldValuesMap> LeadFieldValuesMap { get; set; }
        public virtual DbSet<LeadItem> LeadItem { get; set; }
        public virtual DbSet<LegalEntity> LegalEntity { get; set; }
        public virtual DbSet<Localization> Localization { get; set; }
        public virtual DbSet<MailFormat> MailFormat { get; set; }
        public virtual DbSet<MailFormatType> MailFormatType { get; set; }
        public virtual DbSet<MailTemplate> MailTemplate { get; set; }
        public virtual DbSet<ManagerRole> ManagerRole { get; set; }
        public virtual DbSet<ManagerRolesMap> ManagerRolesMap { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<ManagerTask> ManagerTask { get; set; }
        public virtual DbSet<ManualEmailing> ManualEmailing { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MessageLog> MessageLog { get; set; }
        public virtual DbSet<MetaInfo> MetaInfo { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<ModuleSettings> ModuleSettings { get; set; }
        public virtual DbSet<NaturalPerson> NaturalPerson { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsCategory> NewsCategory { get; set; }
        public virtual DbSet<NewsProduct> NewsProduct { get; set; }
        public virtual DbSet<Offer> Offer { get; set; }
        public virtual DbSet<OkCatalog> OkCatalog { get; set; }
        public virtual DbSet<OkCatalogCategory> OkCatalogCategory { get; set; }
        public virtual DbSet<OkMessage> OkMessage { get; set; }
        public virtual DbSet<OkProduct> OkProduct { get; set; }
        public virtual DbSet<OnlineClientInfo> OnlineClientInfo { get; set; }
        public virtual DbSet<OptionPriceTypes> OptionPriceTypes { get; set; }
        public virtual DbSet<Options> Options { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderAdditionalData> OrderAdditionalData { get; set; }
        public virtual DbSet<OrderByRequest> OrderByRequest { get; set; }
        public virtual DbSet<OrderConfirmation> OrderConfirmation { get; set; }
        public virtual DbSet<OrderContact> OrderContact { get; set; }
        public virtual DbSet<OrderCurrency> OrderCurrency { get; set; }
        public virtual DbSet<OrderCustomer> OrderCustomer { get; set; }
        public virtual DbSet<OrderCustomOptions> OrderCustomOptions { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<OrderItemsFromMoysklad> OrderItemsFromMoysklad { get; set; }
        public virtual DbSet<OrderPickPoint> OrderPickPoint { get; set; }
        public virtual DbSet<OrderPriceDiscount> OrderPriceDiscount { get; set; }
        public virtual DbSet<OrderSendMoysklad> OrderSendMoysklad { get; set; }
        public virtual DbSet<OrderSource> OrderSource { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<OrderTax> OrderTax { get; set; }
        public virtual DbSet<OrderTrafficSource> OrderTrafficSource { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<PaymentCity> PaymentCity { get; set; }
        public virtual DbSet<PaymentCountry> PaymentCountry { get; set; }
        public virtual DbSet<PaymentDetails> PaymentDetails { get; set; }
        public virtual DbSet<PaymentDetails1> PaymentDetails1 { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<PaymentParam> PaymentParam { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<PayoutReport> PayoutReport { get; set; }
        public virtual DbSet<PersentHistory> PersentHistory { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategories> ProductCategories { get; set; }
        public virtual DbSet<ProductExt> ProductExt { get; set; }
        public virtual DbSet<ProductFile> ProductFile { get; set; }
        public virtual DbSet<ProductGifts> ProductGifts { get; set; }
        public virtual DbSet<ProductList> ProductList { get; set; }
        public virtual DbSet<ProductProductList> ProductProductList { get; set; }
        public virtual DbSet<ProductPropertyValue> ProductPropertyValue { get; set; }
        public virtual DbSet<ProductVideo> ProductVideo { get; set; }
        public virtual DbSet<ProfitPlan> ProfitPlan { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyGroup> PropertyGroup { get; set; }
        public virtual DbSet<PropertyGroupCategory> PropertyGroupCategory { get; set; }
        public virtual DbSet<PropertyValue> PropertyValue { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<Ranges> Ranges { get; set; }
        public virtual DbSet<Ratio> Ratio { get; set; }
        public virtual DbSet<RecentlyViewsData> RecentlyViewsData { get; set; }
        public virtual DbSet<Redirect> Redirect { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RelatedCategories> RelatedCategories { get; set; }
        public virtual DbSet<RelatedProducts> RelatedProducts { get; set; }
        public virtual DbSet<RelatedProperties> RelatedProperties { get; set; }
        public virtual DbSet<RelatedPropertyValues> RelatedPropertyValues { get; set; }
        public virtual DbSet<Reseller> Reseller { get; set; }
        public virtual DbSet<ReservationResource> ReservationResource { get; set; }
        public virtual DbSet<ReservationResourceAdditionalTime> ReservationResourceAdditionalTime { get; set; }
        public virtual DbSet<ReservationResourceService> ReservationResourceService { get; set; }
        public virtual DbSet<ReservationResourceTag> ReservationResourceTag { get; set; }
        public virtual DbSet<ReservationResourceTagsMap> ReservationResourceTagsMap { get; set; }
        public virtual DbSet<ReservationResourceTimeOfBooking> ReservationResourceTimeOfBooking { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<ReviewLikes> ReviewLikes { get; set; }
        public virtual DbSet<RoleAction> RoleAction { get; set; }
        public virtual DbSet<RuleLog> RuleLog { get; set; }
        public virtual DbSet<SaasData> SaasData { get; set; }
        public virtual DbSet<SalesFunnel> SalesFunnel { get; set; }
        public virtual DbSet<SalesFunnelDealStatus> SalesFunnelDealStatus { get; set; }
        public virtual DbSet<SalesFunnelLeadAutoCompleteCategory> SalesFunnelLeadAutoCompleteCategory { get; set; }
        public virtual DbSet<SalesFunnelLeadAutoCompleteProduct> SalesFunnelLeadAutoCompleteProduct { get; set; }
        public virtual DbSet<SalesFunnelManager> SalesFunnelManager { get; set; }
        public virtual DbSet<SearchStatistic> SearchStatistic { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Settings1> Settings1 { get; set; }
        public virtual DbSet<SettingsSearch> SettingsSearch { get; set; }
        public virtual DbSet<ShippingCache> ShippingCache { get; set; }
        public virtual DbSet<ShippingCategoryExcluded> ShippingCategoryExcluded { get; set; }
        public virtual DbSet<ShippingCity> ShippingCity { get; set; }
        public virtual DbSet<ShippingCityExcluded> ShippingCityExcluded { get; set; }
        public virtual DbSet<ShippingCountry> ShippingCountry { get; set; }
        public virtual DbSet<ShippingCountryExcluded> ShippingCountryExcluded { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethod { get; set; }
        public virtual DbSet<ShippingParam> ShippingParam { get; set; }
        public virtual DbSet<ShippingPayments> ShippingPayments { get; set; }
        public virtual DbSet<ShippingProductExcluded> ShippingProductExcluded { get; set; }
        public virtual DbSet<ShippingRegion> ShippingRegion { get; set; }
        public virtual DbSet<ShippingRegionExcluded> ShippingRegionExcluded { get; set; }
        public virtual DbSet<ShippingReplaceGeo> ShippingReplaceGeo { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCart { get; set; }
        public virtual DbSet<ShoppingCart1> ShoppingCart1 { get; set; }
        public virtual DbSet<SimalandModification> SimalandModification { get; set; }
        public virtual DbSet<SimalandModifier> SimalandModifier { get; set; }
        public virtual DbSet<SimalandSettings> SimalandSettings { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<SmsLog> SmsLog { get; set; }
        public virtual DbSet<SmsTemplate> SmsTemplate { get; set; }
        public virtual DbSet<SmsTemplate1> SmsTemplate1 { get; set; }
        public virtual DbSet<SmsTemplateOnOrderChanging> SmsTemplateOnOrderChanging { get; set; }
        public virtual DbSet<StaticBlock> StaticBlock { get; set; }
        public virtual DbSet<StaticPage> StaticPage { get; set; }
        public virtual DbSet<Subscription> Subscription { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Tag1> Tag1 { get; set; }
        public virtual DbSet<TagMap> TagMap { get; set; }
        public virtual DbSet<TagMap1> TagMap1 { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskGroup> TaskGroup { get; set; }
        public virtual DbSet<TaskGroupManager> TaskGroupManager { get; set; }
        public virtual DbSet<TaskGroupManagerRole> TaskGroupManagerRole { get; set; }
        public virtual DbSet<TaskManager> TaskManager { get; set; }
        public virtual DbSet<TaskObserver> TaskObserver { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<TelegramMessage> TelegramMessage { get; set; }
        public virtual DbSet<TemplatesDocx> TemplatesDocx { get; set; }
        public virtual DbSet<TemplateSettings> TemplateSettings { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<Transaction1> Transaction1 { get; set; }
        public virtual DbSet<TransactionCurrency> TransactionCurrency { get; set; }
        public virtual DbSet<TriggerAction> TriggerAction { get; set; }
        public virtual DbSet<TriggerCategory> TriggerCategory { get; set; }
        public virtual DbSet<TriggerDeferredData> TriggerDeferredData { get; set; }
        public virtual DbSet<TriggerRule> TriggerRule { get; set; }
        public virtual DbSet<TriggerSendOnceData> TriggerSendOnceData { get; set; }
        public virtual DbSet<ViewedTask> ViewedTask { get; set; }
        public virtual DbSet<VkCategory> VkCategory { get; set; }
        public virtual DbSet<VkCategoryCategory> VkCategoryCategory { get; set; }
        public virtual DbSet<VkMessage> VkMessage { get; set; }
        public virtual DbSet<VkOrderOrder> VkOrderOrder { get; set; }
        public virtual DbSet<VkProduct> VkProduct { get; set; }
        public virtual DbSet<VoiceTheme> VoiceTheme { get; set; }

        // Unable to generate entity type for table 'Order.OrderStatus1C'. Please see the warning messages.
        // Unable to generate entity type for table 'Customers.VkUser'. Please see the warning messages.
        // Unable to generate entity type for table 'Order.OrderPaymentInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'Order.OrderHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'Customers.TelegramUser'. Please see the warning messages.
        // Unable to generate entity type for table 'Shipping.DDeliveryOrders'. Please see the warning messages.
        // Unable to generate entity type for table 'Customers.InstagramUser'. Please see the warning messages.
        // Unable to generate entity type for table 'Customers.FacebookUser'. Please see the warning messages.
        // Unable to generate entity type for table 'Customers.OkUser'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AdminMessages'. Please see the warning messages.
        // Unable to generate entity type for table 'Catalog.ProductSuncMoysklad'. Please see the warning messages.
        // Unable to generate entity type for table 'Settings.GiftCertificatePayments'. Please see the warning messages.
        // Unable to generate entity type for table 'Order.DeferredMail'. Please see the warning messages.
        // Unable to generate entity type for table 'Catalog.AvitoProductProperties'. Please see the warning messages.
        // Unable to generate entity type for table 'Customers.SmsNotifications'. Please see the warning messages.
        // Unable to generate entity type for table 'Order.DeletedOrders'. Please see the warning messages.
        // Unable to generate entity type for table 'Catalog.DeletedProducts'. Please see the warning messages.
        // Unable to generate entity type for table 'Customers.CustomerRoleAction'. Please see the warning messages.
        // Unable to generate entity type for table 'Customers.ClientInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'Customers.ImapLetter'. Please see the warning messages.
        // Unable to generate entity type for table 'Shipping.SdekCities'. Please see the warning messages.
        // Unable to generate entity type for table 'Customers.OpenIdLinkCustomer'. Please see the warning messages.
        // Unable to generate entity type for table 'CRM.SalesChannelExcludedProduct'. Please see the warning messages.
        // Unable to generate entity type for table 'Settings.ExportFeedSettings'. Please see the warning messages.
        // Unable to generate entity type for table 'Vk.VkCategoryImport'. Please see the warning messages.
        // Unable to generate entity type for table 'Customers.Country_en'. Please see the warning messages.
        // Unable to generate entity type for table 'Order.StatusHistory'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source='LAPTOP-4UI9Q996\\SQLEXPRESS'; initial catalog='lic_adv_dev'; user id='sa'; password='123123'; Persist Security Info='True'; Connect Timeout='60'");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActReport>(entity =>
            {
                entity.ToTable("ActReport", "Partners");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.PeriodTo).HasColumnType("datetime");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.ActReport)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_ActReport_Partner");
            });

            modelBuilder.Entity<AdditionBonus>(entity =>
            {
                entity.ToTable("AdditionBonus", "Bonus");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.AdditionBonus)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK_AdditionBonus_Card");
            });

            modelBuilder.Entity<AdminComment>(entity =>
            {
                entity.ToTable("AdminComment", "CMS");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AdminInformer>(entity =>
            {
                entity.ToTable("AdminInformer", "Customers");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdminNotification>(entity =>
            {
                entity.ToTable("AdminNotification", "CMS");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IconPath).HasMaxLength(255);

                entity.Property(e => e.Tag).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<AdminNotifications>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AdminNotificationid });

                entity.ToTable("AdminNotifications", "Customers");

                entity.HasOne(d => d.AdminNotification)
                    .WithMany(p => p.AdminNotifications)
                    .HasForeignKey(d => d.AdminNotificationid)
                    .HasConstraintName("FK_AdminNotifications_AdminNotification");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AdminNotifications)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_AdminNotifications_Customer");
            });

            modelBuilder.Entity<Affiliate>(entity =>
            {
                entity.ToTable("Affiliate", "Booking");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.SmsTemplateBeforeStartBooiking).HasMaxLength(500);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Affiliate)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Affiliate_City");
            });

            modelBuilder.Entity<AffiliateAdditionalTime>(entity =>
            {
                entity.ToTable("AffiliateAdditionalTime", "Booking");

                entity.HasIndex(e => e.AffiliateId)
                    .HasName("IX_AffiliateAdditionalTime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliateAdditionalTime)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_AffiliateAdditionalTime_Affiliate");
            });

            modelBuilder.Entity<AffiliateAnalyticManager>(entity =>
            {
                entity.HasKey(e => new { e.AffiliateId, e.ManagerId });

                entity.ToTable("AffiliateAnalyticManager", "Booking");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliateAnalyticManager)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_AffiliateAnalyticManager_Affiliate");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.AffiliateAnalyticManager)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_AffiliateAnalyticManager_Managers");
            });

            modelBuilder.Entity<AffiliateCategory>(entity =>
            {
                entity.HasKey(e => new { e.AffiliateId, e.CategoryId });

                entity.ToTable("AffiliateCategory", "Booking");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliateCategory)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_AffiliateCategory_Affiliate");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AffiliateCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_AffiliateCategory_Category");
            });

            modelBuilder.Entity<AffiliateManager>(entity =>
            {
                entity.HasKey(e => new { e.AffiliateId, e.ManagerId });

                entity.ToTable("AffiliateManager", "Booking");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliateManager)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_AffiliateManager_Affiliate");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.AffiliateManager)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_AffiliateManager_Managers");
            });

            modelBuilder.Entity<AffiliateReservationResource>(entity =>
            {
                entity.HasKey(e => new { e.AffiliateId, e.ReservationResourceId });

                entity.ToTable("AffiliateReservationResource", "Booking");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliateReservationResource)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_AffiliateReservationResource_Affiliate");

                entity.HasOne(d => d.ReservationResource)
                    .WithMany(p => p.AffiliateReservationResource)
                    .HasForeignKey(d => d.ReservationResourceId)
                    .HasConstraintName("FK_AffiliateReservationResource_ReservationResource");
            });

            modelBuilder.Entity<AffiliateService>(entity =>
            {
                entity.HasKey(e => new { e.AffiliateId, e.ServiceId });

                entity.ToTable("AffiliateService", "Booking");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliateService)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_AffiliateService_Affiliate");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.AffiliateService)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_AffiliateService_Service");
            });

            modelBuilder.Entity<AffiliateSmsTemplate>(entity =>
            {
                entity.ToTable("AffiliateSmsTemplate", "Booking");

                entity.HasIndex(e => new { e.AffiliateId, e.Status })
                    .HasName("AffiliateStatus_AffiliateSmsTemplate");

                entity.Property(e => e.Text).HasMaxLength(500);

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliateSmsTemplate)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_AffiliateSmsTemplate_Affiliate");
            });

            modelBuilder.Entity<AffiliateTimeOfBooking>(entity =>
            {
                entity.ToTable("AffiliateTimeOfBooking", "Booking");

                entity.HasIndex(e => e.AffiliateId)
                    .HasName("IX_AffiliateTimeOfBooking");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliateTimeOfBooking)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_AffiliateTimeOfBooking_Affiliate");
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer", "Voice");

                entity.HasIndex(e => e.Fkidtheme)
                    .HasName("Answer_FKIDTheme");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Fkidtheme).HasColumnName("FKIDTheme");

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.FkidthemeNavigation)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.Fkidtheme)
                    .HasConstraintName("FK_Answer_VoiceTheme");
            });

            modelBuilder.Entity<AppRestartLog>(entity =>
            {
                entity.ToTable("AppRestartLog", "Internal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RestartDate).HasColumnType("datetime");

                entity.Property(e => e.ServerName).IsRequired();
            });

            modelBuilder.Entity<AspstateTempApplications>(entity =>
            {
                entity.HasKey(e => e.AppId);

                entity.ToTable("ASPStateTempApplications");

                entity.HasIndex(e => e.AppName)
                    .HasName("Index_AppName");

                entity.Property(e => e.AppId).ValueGeneratedNever();

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasMaxLength(280)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspstateTempSessions>(entity =>
            {
                entity.HasKey(e => e.SessionId);

                entity.ToTable("ASPStateTempSessions");

                entity.HasIndex(e => e.Expires)
                    .HasName("Index_Expires");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(88)
                    .ValueGeneratedNever();

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.LockDate).HasColumnType("datetime");

                entity.Property(e => e.LockDateLocal).HasColumnType("datetime");

                entity.Property(e => e.SessionItemLong).HasColumnType("image");

                entity.Property(e => e.SessionItemShort).HasMaxLength(7000);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("Attachment", "CMS");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AuthorizeLog>(entity =>
            {
                entity.ToTable("AuthorizeLog", "Settings");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.IsSuccess).HasColumnName("isSuccess");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserIp)
                    .IsRequired()
                    .HasColumnName("UserIP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BindedCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("BindedCustomer", "Partners");

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.CouponCode).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(500);

                entity.Property(e => e.UrlReferrer).HasMaxLength(500);

                entity.Property(e => e.UtmCampaign).HasMaxLength(500);

                entity.Property(e => e.UtmContent).HasMaxLength(500);

                entity.Property(e => e.UtmMedium).HasMaxLength(500);

                entity.Property(e => e.UtmSource).HasMaxLength(500);

                entity.Property(e => e.UtmTerm).HasMaxLength(500);

                entity.Property(e => e.VisitDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithOne(p => p.BindedCustomer)
                    .HasForeignKey<BindedCustomer>(d => d.CustomerId)
                    .HasConstraintName("FK_BindedCustomer_Customer");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.BindedCustomer)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_BindedCustomer_Partner");
            });

            modelBuilder.Entity<BizProcessRule>(entity =>
            {
                entity.ToTable("BizProcessRule", "CRM");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TaskCreateInterval).HasMaxLength(255);

                entity.Property(e => e.TaskDescription).IsRequired();

                entity.Property(e => e.TaskDueDateInterval).HasMaxLength(255);

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.TaskGroup)
                    .WithMany(p => p.BizProcessRule)
                    .HasForeignKey(d => d.TaskGroupId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BizProcessRule_TaskGroup");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("Booking", "Booking");

                entity.HasIndex(e => e.AffiliateId)
                    .HasName("Booking_Affiliate");

                entity.HasIndex(e => new { e.BeginDate, e.EndDate })
                    .HasName("Date_Booking");

                entity.Property(e => e.AdminComment).HasMaxLength(255);

                entity.Property(e => e.ArchivedPaymentName).HasMaxLength(255);

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(70);

                entity.Property(e => e.LastName).HasMaxLength(70);

                entity.Property(e => e.Patronymic).HasMaxLength(70);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_Booking_Affiliate");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Booking)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Booking_Managers");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Booking_Order");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Booking_PaymentMethod");

                entity.HasOne(d => d.ReservationResource)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.ReservationResourceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Booking_ReservationResource");
            });

            modelBuilder.Entity<BookingCurrency>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.ToTable("BookingCurrency", "Booking");

                entity.Property(e => e.BookingId).ValueGeneratedNever();

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.HasOne(d => d.Booking)
                    .WithOne(p => p.BookingCurrency)
                    .HasForeignKey<BookingCurrency>(d => d.BookingId)
                    .HasConstraintName("FK_BookingCurrency_Booking");
            });

            modelBuilder.Entity<BookingItems>(entity =>
            {
                entity.ToTable("BookingItems", "Booking");

                entity.HasIndex(e => e.BookingId)
                    .HasName("IX_BookingItems");

                entity.Property(e => e.ArtNo).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.BookingItems)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK_BookingItems_Booking");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.BookingItems)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BookingItems_Service");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand", "Catalog");

                entity.HasIndex(e => e.CountryId)
                    .HasName("Brand_CountryID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.BrandName).IsRequired();

                entity.Property(e => e.BrandSiteUrl).HasMaxLength(150);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryOfManufactureId).HasColumnName("CountryOfManufactureID");

                entity.Property(e => e.UrlPath).HasMaxLength(150);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Brand)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Brand_Country");
            });

            modelBuilder.Entity<BreakMessage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Call>(entity =>
            {
                entity.ToTable("Call", "Customers");

                entity.HasIndex(e => e.DstNum);

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_Customers_Call");

                entity.HasIndex(e => e.SrcNum);

                entity.Property(e => e.CallAnswerDate).HasColumnType("datetime");

                entity.Property(e => e.CallDate).HasColumnType("datetime");

                entity.Property(e => e.CallId)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DstNum)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.HangupStatus)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.OperatorType)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RecordLink).HasMaxLength(250);

                entity.Property(e => e.SrcNum)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Call)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Call_Managers");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("Card", "Bonus");

                entity.HasIndex(e => e.CreateOn)
                    .HasName("CreateOn_Card");

                entity.HasIndex(e => e.DateLastWipeBonus)
                    .HasName("DateLastWipeBonus_Card");

                entity.Property(e => e.CardId).ValueGeneratedNever();

                entity.Property(e => e.BonusAmount).HasColumnType("money");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.DateLastNotifyBonusWipe).HasColumnType("datetime");

                entity.Property(e => e.DateLastWipeBonus).HasColumnType("datetime");

                entity.HasOne(d => d.CardNavigation)
                    .WithOne(p => p.Card)
                    .HasForeignKey<Card>(d => d.CardId)
                    .HasConstraintName("FK_Card_Customer");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.Card)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Card_Grade");
            });

            modelBuilder.Entity<Carousel>(entity =>
            {
                entity.ToTable("Carousel", "CMS");

                entity.Property(e => e.CarouselId).HasColumnName("CarouselID");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<CategoriesAutoMapping>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.NewCategoryId });

                entity.ToTable("CategoriesAutoMapping", "Catalog");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category", "Booking");

                entity.Property(e => e.Image).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Category1>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Category", "Catalog");

                entity.HasIndex(e => e.CatLevel)
                    .HasName("Category_CatLevel");

                entity.HasIndex(e => e.ParentCategory)
                    .HasName("ParentCategory_ParentCategory");

                entity.HasIndex(e => new { e.UrlPath, e.CategoryId })
                    .HasName("Category_UrlPath");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.AutomapAction).HasDefaultValueSql("((0))");

                entity.Property(e => e.AvailableProductsCount).HasColumnName("Available_Products_Count");

                entity.Property(e => e.CatLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentProductsCount).HasColumnName("Current_Products_Count");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExternalId).HasMaxLength(50);

                entity.Property(e => e.HirecalEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProductsCount).HasColumnName("Products_Count");

                entity.Property(e => e.TotalProductsCount).HasColumnName("Total_Products_Count");

                entity.Property(e => e.UrlPath)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.ParentCategoryNavigation)
                    .WithMany(p => p.InverseParentCategoryNavigation)
                    .HasForeignKey(d => d.ParentCategory)
                    .HasConstraintName("FK_Category_Category");
            });

            modelBuilder.Entity<CategoryRewardPercent>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("CategoryRewardPercent", "Partners");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithOne(p => p.CategoryRewardPercent)
                    .HasForeignKey<CategoryRewardPercent>(d => d.CategoryId)
                    .HasConstraintName("FK_CategoryRewardPercent_Category");
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.ToTable("Certificate", "Order");

                entity.HasIndex(e => e.OrderId)
                    .HasName("Certificate_OrderID");

                entity.Property(e => e.CertificateId)
                    .HasColumnName("CertificateID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ApplyOrderNumber).HasMaxLength(50);

                entity.Property(e => e.CertificateCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ToEmail)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.ToName).IsRequired();

                entity.HasOne(d => d.CertificateNavigation)
                    .WithOne(p => p.InverseCertificateNavigation)
                    .HasForeignKey<Certificate>(d => d.CertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certificate_Certificate");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Certificate)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Certificate_Order");
            });

            modelBuilder.Entity<ChangeHistory>(entity =>
            {
                entity.ToTable("ChangeHistory", "CMS");

                entity.HasIndex(e => new { e.ObjId, e.ObjType })
                    .HasName("ChangeHistory_Obj");

                entity.Property(e => e.ChangedByName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModificationTime).HasColumnType("datetime");

                entity.Property(e => e.NewValue).IsRequired();

                entity.Property(e => e.OldValue).IsRequired();

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City", "Customers");

                entity.HasIndex(e => e.RegionId)
                    .HasName("City_RegionID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName).IsRequired();

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Zip).HasMaxLength(50);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_City_Region");
            });

            modelBuilder.Entity<ClientCode>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Code });

                entity.ToTable("ClientCode", "Customers");

                entity.Property(e => e.CreatedDate).HasColumnType("date");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("Color", "Catalog");

                entity.HasIndex(e => e.ColorName)
                    .HasName("IX_ColorName")
                    .IsUnique();

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.ColorCode)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.ColorName)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact", "Customers");

                entity.HasIndex(e => e.CountryId)
                    .HasName("Contact_CountryID");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("Contact_CustomerID");

                entity.HasIndex(e => e.RegionId)
                    .HasName("Contact_RegionID");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Apartment).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(70);

                entity.Property(e => e.Country).HasMaxLength(70);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.District).HasMaxLength(70);

                entity.Property(e => e.Entrance).HasMaxLength(10);

                entity.Property(e => e.Floor).HasMaxLength(10);

                entity.Property(e => e.House).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Street).HasMaxLength(255);

                entity.Property(e => e.Structure).HasMaxLength(10);

                entity.Property(e => e.Zip).HasMaxLength(70);

                entity.Property(e => e.Zone).HasMaxLength(70);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Contact_Country");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Contact_Customer");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Contact_Region");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "Customers");

                entity.HasIndex(e => e.CountryIso3)
                    .HasName("IX_Country");

                entity.HasIndex(e => e.CountryName)
                    .HasName("IX_Country_1");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CountryIso2)
                    .HasColumnName("CountryISO2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CountryIso3)
                    .HasColumnName("CountryISO3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.HasOne(d => d.CountryNavigation)
                    .WithOne(p => p.InverseCountryNavigation)
                    .HasForeignKey<Country>(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Country_Country");
            });

            modelBuilder.Entity<CountryRu>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("Country_ru", "Customers");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryIso2)
                    .HasColumnName("CountryISO2")
                    .HasMaxLength(2);

                entity.Property(e => e.CountryIso3)
                    .HasColumnName("CountryISO3")
                    .HasMaxLength(3);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.ToTable("Coupon", "Catalog");

                entity.HasIndex(e => e.Code)
                    .HasName("UNQ__Coupon__Code")
                    .IsUnique();

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.AddingDate).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyIso3).HasMaxLength(3);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.MinimalOrderPrice).HasColumnType("money");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CouponCategories>(entity =>
            {
                entity.HasKey(e => new { e.CouponId, e.CategoryId });

                entity.ToTable("CouponCategories", "Catalog");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CouponCategories");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CouponCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_CouponCategories_Category");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponCategories)
                    .HasForeignKey(d => d.CouponId)
                    .HasConstraintName("FK_CouponCategories_Coupon");
            });

            modelBuilder.Entity<CouponCustomers>(entity =>
            {
                entity.HasKey(e => new { e.CouponId, e.CustomerId });

                entity.ToTable("CouponCustomers", "Catalog");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("CouponCustomers_CustomerID");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponCustomers)
                    .HasForeignKey(d => d.CouponId)
                    .HasConstraintName("FK_CouponCustomers_Coupon");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CouponCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CouponCustomers_Customer");
            });

            modelBuilder.Entity<CouponProducts>(entity =>
            {
                entity.HasKey(e => new { e.CouponId, e.ProductId });

                entity.ToTable("CouponProducts", "Catalog");

                entity.HasIndex(e => e.ProductId)
                    .HasName("CouponProducts_ProductID");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponProducts)
                    .HasForeignKey(d => d.CouponId)
                    .HasConstraintName("FK_CouponProducts_Coupon");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CouponProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_CouponProduct_Product");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency", "Catalog");

                entity.HasIndex(e => e.CurrencyIso3)
                    .HasName("UQ__Currency__34DAA95504315AC5")
                    .IsUnique();

                entity.HasIndex(e => e.CurrencyNumIso3)
                    .HasName("UQ__Currency__32CE9928070DC770")
                    .IsUnique();

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.CurrencyIso3).HasMaxLength(3);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer", "Customers");

                entity.HasIndex(e => e.CustomerGroupId)
                    .HasName("Customer_CustomerGroupId");

                entity.HasIndex(e => e.Email)
                    .HasName("Customer_Email");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Avatar).HasMaxLength(100);

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(70);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.InnerId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Organization).HasMaxLength(250);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Patronymic).HasMaxLength(70);

                entity.Property(e => e.RegisteredFrom).HasMaxLength(500);

                entity.Property(e => e.RegistrationDateTime).HasColumnType("datetime");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CustomerGroup)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.CustomerGroupId)
                    .HasConstraintName("FK_Customer_CustomerGroup");
            });

            modelBuilder.Entity<CustomerCertificate>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CertificateId });

                entity.ToTable("CustomerCertificate", "Customers");

                entity.HasIndex(e => e.CertificateId)
                    .HasName("CustomerCertificate_CertificateID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CertificateId).HasColumnName("CertificateID");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.CustomerCertificate)
                    .HasForeignKey(d => d.CertificateId)
                    .HasConstraintName("FK_CustomerCertificate_Certificate");
            });

            modelBuilder.Entity<CustomerCoupon>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CouponId });

                entity.ToTable("CustomerCoupon", "Customers");

                entity.HasIndex(e => e.CouponId)
                    .HasName("CustomerCoupon_CouponID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CustomerCoupon)
                    .HasForeignKey(d => d.CouponId)
                    .HasConstraintName("FK_CustomerCoupon_Coupon");
            });

            modelBuilder.Entity<CustomerField>(entity =>
            {
                entity.ToTable("CustomerField", "Customers");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CustomerFieldValue>(entity =>
            {
                entity.ToTable("CustomerFieldValue", "Customers");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CustomerField)
                    .WithMany(p => p.CustomerFieldValue)
                    .HasForeignKey(d => d.CustomerFieldId)
                    .HasConstraintName("FK_CustomerFieldValue_CustomerField");
            });

            modelBuilder.Entity<CustomerFieldValuesMap>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CustomerFieldId });

                entity.ToTable("CustomerFieldValuesMap", "Customers");

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.CustomerField)
                    .WithMany(p => p.CustomerFieldValuesMap)
                    .HasForeignKey(d => d.CustomerFieldId)
                    .HasConstraintName("FK_CustomerFieldValues_CustomerField");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerFieldValuesMap)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerFieldValues_Customer");
            });

            modelBuilder.Entity<CustomerGroup>(entity =>
            {
                entity.ToTable("CustomerGroup", "Customers");

                entity.Property(e => e.CustomerGroupId).HasColumnName("CustomerGroupID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<CustomerSegment>(entity =>
            {
                entity.ToTable("CustomerSegment", "Customers");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Filter).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<CustomerSegmentCustomer>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.SegmentId });

                entity.ToTable("CustomerSegment_Customer", "Customers");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerSegmentCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerSegment_Customer_Customer");

                entity.HasOne(d => d.Segment)
                    .WithMany(p => p.CustomerSegmentCustomer)
                    .HasForeignKey(d => d.SegmentId)
                    .HasConstraintName("FK_CustomerSegment_Customer_CustomerSegment");
            });

            modelBuilder.Entity<CustomOptions>(entity =>
            {
                entity.ToTable("CustomOptions", "Catalog");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_CustomOptions");

                entity.Property(e => e.CustomOptionsId).HasColumnName("CustomOptionsID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomOptions)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_CustomOptions_Product");
            });

            modelBuilder.Entity<CustomRule>(entity =>
            {
                entity.HasKey(e => e.RuleType);

                entity.ToTable("CustomRule", "Bonus");

                entity.Property(e => e.RuleType).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<DealStatus>(entity =>
            {
                entity.ToTable("DealStatus", "CRM");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("Departments", "Customers");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DownloadableContent>(entity =>
            {
                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DcType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StringId)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DpdCashCity>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("DpdCashCity", "Shipping");

                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.Abbreviation).HasMaxLength(50);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DpdParcelShops>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("DpdParcelShops", "Shipping");

                entity.HasIndex(e => e.CityId)
                    .HasName("DpdParcelShops_CityId");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ExtraServices)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SelfDeliveryTimes).HasMaxLength(255);

                entity.Property(e => e.Services)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DpdTerminals>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("DpdTerminals", "Shipping");

                entity.HasIndex(e => e.CityId)
                    .HasName("DpdTerminals_CityId");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ExtraServices)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SelfDeliveryTimes).HasMaxLength(255);

                entity.Property(e => e.Services)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Error404>(entity =>
            {
                entity.ToTable("Error404", "Settings");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.UrlReferer).HasMaxLength(4000);
            });

            modelBuilder.Entity<ExportFeed>(entity =>
            {
                entity.ToTable("ExportFeed", "Settings");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.LastExport).HasColumnType("datetime");

                entity.Property(e => e.LastExportFileFullName).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ExportFeedExcludedProducts>(entity =>
            {
                entity.HasKey(e => new { e.ExportFeedId, e.ProductId });

                entity.ToTable("ExportFeedExcludedProducts", "Settings");

                entity.HasOne(d => d.ExportFeed)
                    .WithMany(p => p.ExportFeedExcludedProducts)
                    .HasForeignKey(d => d.ExportFeedId)
                    .HasConstraintName("FK_ExportFeedExcludedProducts_ExportFeed");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ExportFeedExcludedProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ExportFeedExcludedProducts_Product");
            });

            modelBuilder.Entity<ExportFeedSelectedCategories>(entity =>
            {
                entity.HasKey(e => new { e.ExportFeedId, e.CategoryId });

                entity.ToTable("ExportFeedSelectedCategories", "Settings");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Opened)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ExportFeedSelectedCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ExportFeedSelectedCategories_Category");

                entity.HasOne(d => d.ExportFeed)
                    .WithMany(p => p.ExportFeedSelectedCategories)
                    .HasForeignKey(d => d.ExportFeedId)
                    .HasConstraintName("FK_ExportFeedSelectedCategories_ExportFeed");
            });

            modelBuilder.Entity<FacebookMessage>(entity =>
            {
                entity.ToTable("FacebookMessage", "Customers");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.MessageId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FileLibrary>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("FileLibrary", "Catalog");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.FilePath)
                    .HasColumnName("filePath")
                    .HasMaxLength(100);

                entity.Property(e => e.ItemIcon).HasMaxLength(100);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ItemParentId).HasColumnName("ItemParentID");
            });

            modelBuilder.Entity<GiftCertificateTaxes>(entity =>
            {
                entity.HasKey(e => e.TaxId);

                entity.ToTable("GiftCertificateTaxes", "Settings");

                entity.Property(e => e.TaxId)
                    .HasColumnName("TaxID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Tax)
                    .WithOne(p => p.GiftCertificateTaxes)
                    .HasForeignKey<GiftCertificateTaxes>(d => d.TaxId)
                    .HasConstraintName("FK_GiftCertificateTaxes_Tax");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("Grade", "Bonus");

                entity.Property(e => e.BonusPercent).HasColumnType("money");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PurchaseBarrier).HasColumnType("money");
            });

            modelBuilder.Entity<ImportLog>(entity =>
            {
                entity.ToTable("ImportLog", "Catalog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.Mtype).HasColumnName("mtype");
            });

            modelBuilder.Entity<InstagramMessage>(entity =>
            {
                entity.ToTable("InstagramMessage", "Customers");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromUserPk).IsRequired();

                entity.Property(e => e.InstagramId).IsRequired();

                entity.Property(e => e.MediaPk).IsRequired();

                entity.Property(e => e.ThreadId).IsRequired();

                entity.Property(e => e.ToUserPk).IsRequired();
            });

            modelBuilder.Entity<InternalSettings>(entity =>
            {
                entity.ToTable("InternalSettings", "Settings");

                entity.HasIndex(e => e.SettingKey)
                    .HasName("IX_InternalSettings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasColumnName("settingKey")
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasColumnName("settingValue")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Landing>(entity =>
            {
                entity.ToTable("Landing", "CMS");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Template).IsRequired();

                entity.Property(e => e.Url).IsRequired();
            });

            modelBuilder.Entity<LandingBlock>(entity =>
            {
                entity.ToTable("LandingBlock", "CMS");

                entity.Property(e => e.ContentHtml).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Settings).IsRequired();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Landing)
                    .WithMany(p => p.LandingBlock)
                    .HasForeignKey(d => d.LandingId)
                    .HasConstraintName("FK_LandingPageBlock_Landing");
            });

            modelBuilder.Entity<LandingColorScheme>(entity =>
            {
                entity.ToTable("LandingColorScheme", "CMS");

                entity.Property(e => e.BackgroundColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.BackgroundColorAlt)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonBackgroundColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonBackgroundColorActive)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonBackgroundColorHover)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonBorderColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonBorderRadius)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonBorderWidth)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonSecondaryBackgroundColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonSecondaryBackgroundColorActive)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonSecondaryBackgroundColorHover)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonSecondaryBorderColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonSecondaryBorderRadius)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonSecondaryBorderWidth)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonSecondaryTextBold).HasMaxLength(30);

                entity.Property(e => e.ButtonSecondaryTextColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ButtonTextBold).HasMaxLength(30);

                entity.Property(e => e.ButtonTextColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DelimiterColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LinkColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LinkColorActive)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LinkColorHover)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubTitleBold)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SubTitleColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TextBold)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TextColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TitleBold)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TitleColor)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.LpBlock)
                    .WithMany(p => p.LandingColorScheme)
                    .HasForeignKey(d => d.LpBlockId)
                    .HasConstraintName("FK_LandingColorScheme_LandingBlock");
            });

            modelBuilder.Entity<LandingDeferredEmail>(entity =>
            {
                entity.ToTable("LandingDeferredEmail", "CMS");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.SendingDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).IsRequired();
            });

            modelBuilder.Entity<LandingDomain>(entity =>
            {
                entity.ToTable("LandingDomain", "CMS");

                entity.Property(e => e.DomainUrl).IsRequired();

                entity.HasOne(d => d.LandingSite)
                    .WithMany(p => p.LandingDomain)
                    .HasForeignKey(d => d.LandingSiteId)
                    .HasConstraintName("FK_LandingDomain_LandingSite");
            });

            modelBuilder.Entity<LandingEmailTemplate>(entity =>
            {
                entity.ToTable("LandingEmailTemplate", "CMS");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Subject).IsRequired();

                entity.HasOne(d => d.Block)
                    .WithMany(p => p.LandingEmailTemplate)
                    .HasForeignKey(d => d.BlockId)
                    .HasConstraintName("FK_LandingEmailTemplate_LandingBlock");
            });

            modelBuilder.Entity<LandingForm>(entity =>
            {
                entity.ToTable("LandingForm", "CMS");

                entity.Property(e => e.GaEventAction).HasMaxLength(50);

                entity.Property(e => e.GaEventCategory).HasMaxLength(50);

                entity.Property(e => e.PostMessageRedirectUrl).HasMaxLength(300);

                entity.Property(e => e.YaMetrikaEventName).HasMaxLength(50);

                entity.HasOne(d => d.Lp)
                    .WithMany(p => p.LandingForm)
                    .HasForeignKey(d => d.LpId)
                    .HasConstraintName("FK_LandingForm_Landing");
            });

            modelBuilder.Entity<LandingSettings>(entity =>
            {
                entity.ToTable("LandingSettings", "CMS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.Landing)
                    .WithMany(p => p.LandingSettings)
                    .HasForeignKey(d => d.LandingId)
                    .HasConstraintName("FK_LandingSettings_Landing");
            });

            modelBuilder.Entity<LandingSite>(entity =>
            {
                entity.ToTable("LandingSite", "CMS");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DomainUrl).IsRequired();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.ScreenShotDate).HasColumnType("datetime");

                entity.Property(e => e.Template).IsRequired();

                entity.Property(e => e.Url).IsRequired();
            });

            modelBuilder.Entity<LandingSiteProduct>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.LandingSiteId });

                entity.ToTable("LandingSite_Product", "CMS");

                entity.HasOne(d => d.LandingSite)
                    .WithMany(p => p.LandingSiteProduct)
                    .HasForeignKey(d => d.LandingSiteId)
                    .HasConstraintName("FK_LandingSite_Product_LandingSite");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.LandingSiteProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_LandingSite_Product_Product");
            });

            modelBuilder.Entity<LandingSiteSettings>(entity =>
            {
                entity.ToTable("LandingSiteSettings", "CMS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.LandingSite)
                    .WithMany(p => p.LandingSiteSettings)
                    .HasForeignKey(d => d.LandingSiteId)
                    .HasConstraintName("FK_LandingSiteSettings_LandingSite");
            });

            modelBuilder.Entity<LandingSubBlock>(entity =>
            {
                entity.ToTable("LandingSubBlock", "CMS");

                entity.Property(e => e.ContentHtml).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Settings).IsRequired();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.LandingBlock)
                    .WithMany(p => p.LandingSubBlock)
                    .HasForeignKey(d => d.LandingBlockId)
                    .HasConstraintName("FK_LandingSubBlock_LandingBlock");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language", "Settings");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.ToTable("Lead", "Order");

                entity.Property(e => e.City).HasMaxLength(70);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.Country).HasMaxLength(70);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTime).HasMaxLength(255);

                entity.Property(e => e.District).HasMaxLength(70);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsFromAdminArea).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.LeadStatus).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Organization).HasMaxLength(250);

                entity.Property(e => e.Patronymic).HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Region).HasMaxLength(70);

                entity.Property(e => e.ShippingName).HasMaxLength(255);

                entity.Property(e => e.Zip).HasMaxLength(70);
            });

            modelBuilder.Entity<LeadCurrency>(entity =>
            {
                entity.HasKey(e => e.LeadId);

                entity.ToTable("LeadCurrency", "Order");

                entity.Property(e => e.LeadId).ValueGeneratedNever();

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.HasOne(d => d.Lead)
                    .WithOne(p => p.LeadCurrency)
                    .HasForeignKey<LeadCurrency>(d => d.LeadId)
                    .HasConstraintName("FK_LeedCurrency_Leed");
            });

            modelBuilder.Entity<LeadEvent>(entity =>
            {
                entity.ToTable("LeadEvent", "Order");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadEvent)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_LeadEvents_Lead");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.LeadEvent)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_LeadEvent_Task");
            });

            modelBuilder.Entity<LeadField>(entity =>
            {
                entity.ToTable("LeadField", "CRM");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.SalesFunnel)
                    .WithMany(p => p.LeadField)
                    .HasForeignKey(d => d.SalesFunnelId)
                    .HasConstraintName("FK_LeadField_SalesFunnel");
            });

            modelBuilder.Entity<LeadFieldValue>(entity =>
            {
                entity.ToTable("LeadFieldValue", "CRM");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.LeadField)
                    .WithMany(p => p.LeadFieldValue)
                    .HasForeignKey(d => d.LeadFieldId)
                    .HasConstraintName("FK_LeadFieldValue_LeadField");
            });

            modelBuilder.Entity<LeadFieldValuesMap>(entity =>
            {
                entity.HasKey(e => new { e.LeadId, e.LeadFieldId });

                entity.ToTable("LeadFieldValuesMap", "CRM");

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.LeadField)
                    .WithMany(p => p.LeadFieldValuesMap)
                    .HasForeignKey(d => d.LeadFieldId)
                    .HasConstraintName("FK_LeadFieldValues_LeadField");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadFieldValuesMap)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_LeadFieldValues_Lead");
            });

            modelBuilder.Entity<LeadItem>(entity =>
            {
                entity.ToTable("LeadItem", "Order");

                entity.Property(e => e.ArtNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(300);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(300);

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.LeadItem)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_LeedItem_Leed");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.LeadItem)
                    .HasForeignKey(d => d.PhotoId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_LeedItem_Photo");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.LeadItem)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_LeedItem_Product");
            });

            modelBuilder.Entity<LegalEntity>(entity =>
            {
                entity.HasKey(e => e.PartnerId);

                entity.ToTable("LegalEntity", "Partners");

                entity.Property(e => e.PartnerId).ValueGeneratedNever();

                entity.Property(e => e.Accountant).HasMaxLength(250);

                entity.Property(e => e.ActualAddress).HasMaxLength(500);

                entity.Property(e => e.Bank).HasMaxLength(250);

                entity.Property(e => e.Bik)
                    .HasColumnName("BIK")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(250);

                entity.Property(e => e.ContactPerson).HasMaxLength(250);

                entity.Property(e => e.CorrespondentAccount).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Director).HasMaxLength(250);

                entity.Property(e => e.Inn)
                    .HasColumnName("INN")
                    .HasMaxLength(50);

                entity.Property(e => e.Kpp)
                    .HasColumnName("KPP")
                    .HasMaxLength(50);

                entity.Property(e => e.LegalAddress).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(70);

                entity.Property(e => e.PostAddress).HasMaxLength(500);

                entity.Property(e => e.SettlementAccount).HasMaxLength(50);

                entity.Property(e => e.Zip).HasMaxLength(50);

                entity.HasOne(d => d.Partner)
                    .WithOne(p => p.LegalEntity)
                    .HasForeignKey<LegalEntity>(d => d.PartnerId)
                    .HasConstraintName("FK_LegalEntity_Partner");
            });

            modelBuilder.Entity<Localization>(entity =>
            {
                entity.HasKey(e => new { e.LanguageId, e.ResourceKey });

                entity.ToTable("Localization", "Settings");

                entity.Property(e => e.ResourceKey).HasMaxLength(100);

                entity.Property(e => e.ResourceValue).IsRequired();
            });

            modelBuilder.Entity<MailFormat>(entity =>
            {
                entity.ToTable("MailFormat", "Settings");

                entity.Property(e => e.MailFormatId).HasColumnName("MailFormatID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.FormatName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.FormatText).IsRequired();

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.HasOne(d => d.MailFormatType)
                    .WithMany(p => p.MailFormat)
                    .HasForeignKey(d => d.MailFormatTypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_MailFormat_MailFormatType");
            });

            modelBuilder.Entity<MailFormatType>(entity =>
            {
                entity.ToTable("MailFormatType", "Settings");

                entity.Property(e => e.MailFormatTypeId).HasColumnName("MailFormatTypeID");

                entity.Property(e => e.MailType)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<MailTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("MailTemplate", "Settings");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ManagerRole>(entity =>
            {
                entity.ToTable("ManagerRole", "Customers");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ManagerRolesMap>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ManagerRoleId });

                entity.ToTable("ManagerRolesMap", "Customers");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ManagerRolesMap)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ManagerRolesMap_Customer");

                entity.HasOne(d => d.ManagerRole)
                    .WithMany(p => p.ManagerRolesMap)
                    .HasForeignKey(d => d.ManagerRoleId)
                    .HasConstraintName("FK_ManagerRolesMap_ManagerRole");
            });

            modelBuilder.Entity<Managers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Managers", "Customers");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_Managers")
                    .IsUnique();

                entity.Property(e => e.CustomerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ManagerId).ValueGeneratedOnAdd();

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithOne(p => p.Managers)
                    .HasForeignKey<Managers>(d => d.CustomerId)
                    .HasConstraintName("FK_Managers_Customer");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Managers_Departments");
            });

            modelBuilder.Entity<ManagerTask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("ManagerTask", "Customers");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ResultShort).HasMaxLength(255);

                entity.HasOne(d => d.AppointedManager)
                    .WithMany(p => p.ManagerTaskAppointedManager)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.AppointedManagerId)
                    .HasConstraintName("FK_ManagerTaskAppointedManagerId_Managers");

                entity.HasOne(d => d.AssignedManager)
                    .WithMany(p => p.ManagerTaskAssignedManager)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.AssignedManagerId)
                    .HasConstraintName("FK_ManagerTaskAssignedManagerId_Managers");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ManagerTask)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ManagerTask_Customer");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.ManagerTask)
                    .HasForeignKey(d => d.LeadId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ManagerTask_Lead");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ManagerTask)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ManagerTask_Order");
            });

            modelBuilder.Entity<ManualEmailing>(entity =>
            {
                entity.ToTable("ManualEmailing", "Customers");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.MenuItemId);

                entity.ToTable("Menu", "CMS");

                entity.Property(e => e.MenuItemId).HasColumnName("MenuItemID");

                entity.Property(e => e.MenuItemIcon).HasMaxLength(100);

                entity.Property(e => e.MenuItemName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MenuItemParentId).HasColumnName("MenuItemParentID");

                entity.Property(e => e.MenuItemUrlPath).IsRequired();
            });

            modelBuilder.Entity<MessageLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.MessageText).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MetaInfo>(entity =>
            {
                entity.HasKey(e => e.MetaId);

                entity.ToTable("MetaInfo", "SEO");

                entity.HasIndex(e => new { e.ObjId, e.Type })
                    .HasName("IX_MetaInfo");

                entity.Property(e => e.MetaId).HasColumnName("MetaID");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModuleStringId)
                    .IsRequired()
                    .HasColumnName("ModuleStringID")
                    .HasMaxLength(150);

                entity.Property(e => e.Version).HasMaxLength(20);
            });

            modelBuilder.Entity<ModuleSettings>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("ModuleSettings", "Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<NaturalPerson>(entity =>
            {
                entity.HasKey(e => e.PartnerId);

                entity.ToTable("NaturalPerson", "Partners");

                entity.Property(e => e.PartnerId).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(70);

                entity.Property(e => e.LastName).HasMaxLength(70);

                entity.Property(e => e.PassportNumber).HasMaxLength(50);

                entity.Property(e => e.PassportSeria).HasMaxLength(50);

                entity.Property(e => e.PassportWhenGive).HasColumnType("date");

                entity.Property(e => e.PassportWhoGive).HasMaxLength(250);

                entity.Property(e => e.Patronymic).HasMaxLength(70);

                entity.Property(e => e.PaymentAccountNumber).HasMaxLength(250);

                entity.Property(e => e.RegistrationAddress).HasMaxLength(500);

                entity.Property(e => e.Zip).HasMaxLength(50);

                entity.HasOne(d => d.Partner)
                    .WithOne(p => p.NaturalPerson)
                    .HasForeignKey<NaturalPerson>(d => d.PartnerId)
                    .HasConstraintName("FK_NaturalPerson_Partner");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("News", "Settings");

                entity.HasIndex(e => e.NewsCategoryId)
                    .HasName("News_NewsCategoryID");

                entity.HasIndex(e => e.UrlPath)
                    .HasName("News_UrlPath");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.AddingDate).HasColumnType("datetime");

                entity.Property(e => e.NewsCategoryId).HasColumnName("NewsCategoryID");

                entity.Property(e => e.TextAnnotation).IsRequired();

                entity.Property(e => e.TextToPublication).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UrlPath).HasMaxLength(150);

                entity.HasOne(d => d.NewsCategory)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.NewsCategoryId)
                    .HasConstraintName("FK_News_NewsCategory");
            });

            modelBuilder.Entity<NewsCategory>(entity =>
            {
                entity.ToTable("NewsCategory", "Settings");

                entity.Property(e => e.NewsCategoryId).HasColumnName("NewsCategoryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UrlPath).HasMaxLength(150);
            });

            modelBuilder.Entity<NewsProduct>(entity =>
            {
                entity.HasKey(e => new { e.NewsId, e.ProductId });

                entity.ToTable("NewsProduct", "CMS");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.NewsProduct)
                    .HasForeignKey(d => d.NewsId)
                    .HasConstraintName("FK_NewsProduct_News");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.NewsProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_NewsProduct_Product");
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.ToTable("Offer", "Catalog");

                entity.HasIndex(e => e.ArtNo)
                    .HasName("Offer_ArtNo")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("Offer_ProductID");

                entity.HasIndex(e => e.SizeId)
                    .HasName("Offer_Size");

                entity.HasIndex(e => new { e.OfferId, e.Main })
                    .HasName("Offer_Main");

                entity.HasIndex(e => new { e.ProductId, e.ColorId })
                    .HasName("Offer_ColorId");

                entity.Property(e => e.OfferId).HasColumnName("OfferID");

                entity.Property(e => e.ArtNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.Offer)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Offer_Color");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Offer)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Offer_Product");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Offer)
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Offer_Size");
            });

            modelBuilder.Entity<OkCatalog>(entity =>
            {
                entity.ToTable("OkCatalog", "Ok");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<OkCatalogCategory>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.OkCatalogId });

                entity.ToTable("OkCatalog_Category", "Ok");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.OkCatalogCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_OkCatalog_Category_Category");

                entity.HasOne(d => d.OkCatalog)
                    .WithMany(p => p.OkCatalogCategory)
                    .HasForeignKey(d => d.OkCatalogId)
                    .HasConstraintName("FK_OkCatalog_Category_OkCatalog");
            });

            modelBuilder.Entity<OkMessage>(entity =>
            {
                entity.ToTable("OkMessage", "Customers");

                entity.Property(e => e.ChatId).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromUser).IsRequired();

                entity.Property(e => e.MessageId).IsRequired();

                entity.Property(e => e.UserId).IsRequired();
            });

            modelBuilder.Entity<OkProduct>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ProductId });

                entity.ToTable("OkProduct", "Ok");

                entity.Property(e => e.PhotoIds).IsRequired();
            });

            modelBuilder.Entity<OnlineClientInfo>(entity =>
            {
                entity.HasKey(e => e.SessionId);

                entity.ToTable("OnlineClientInfo", "Catalog");

                entity.Property(e => e.SessionId)
                    .HasColumnName("sessionID")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CountryByGeoIp)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastAccessedPath)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Started).HasColumnType("datetime");

                entity.Property(e => e.UserAgentBrowser)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserAgentOs)
                    .IsRequired()
                    .HasColumnName("UserAgentOS")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OptionPriceTypes>(entity =>
            {
                entity.ToTable("OptionPriceTypes", "Catalog");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StringKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Options>(entity =>
            {
                entity.HasKey(e => e.OptionId);

                entity.ToTable("Options", "Catalog");

                entity.HasIndex(e => e.CustomOptionsId)
                    .HasName("Options_CustomOptionsID");

                entity.Property(e => e.OptionId).HasColumnName("OptionID");

                entity.Property(e => e.CustomOptionsId).HasColumnName("CustomOptionsID");

                entity.Property(e => e.PriceBc).HasColumnName("PriceBC");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CustomOptions)
                    .WithMany(p => p.Options)
                    .HasForeignKey(d => d.CustomOptionsId)
                    .HasConstraintName("FK_Options_CustomOptions");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order", "Order");

                entity.HasIndex(e => e.OrderStatusId)
                    .HasName("Order_OrderStatusID");

                entity.HasIndex(e => e.PaymentMethodId)
                    .HasName("Order_PaymentMethodID");

                entity.HasIndex(e => e.ShippingMethodId)
                    .HasName("Order_ShippingMethodID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.AffiliateId).HasColumnName("AffiliateID");

                entity.Property(e => e.BillingContactId).HasColumnName("BillingContactID");

                entity.Property(e => e.CertificateCode).HasMaxLength(50);

                entity.Property(e => e.CouponCode).HasMaxLength(50);

                entity.Property(e => e.Decremented)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTime).HasMaxLength(255);

                entity.Property(e => e.GroupName).HasMaxLength(255);

                entity.Property(e => e.IsSendedToGa).HasColumnName("IsSendedToGA");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.PayCode).HasMaxLength(20);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PaymentMethodName).HasMaxLength(255);

                entity.Property(e => e.PreviousStatus).HasMaxLength(100);

                entity.Property(e => e.ShippingContactId).HasColumnName("ShippingContactID");

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");

                entity.Property(e => e.ShippingMethodName).HasMaxLength(255);

                entity.Property(e => e.StatusComment).IsRequired();

                entity.Property(e => e.TrackNumber).HasMaxLength(255);

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.LeadId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Order_Lead");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Order)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Order_Managers");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_OrderStatus");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Order_PaymentMethod");

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ShippingMethodId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Order_ShippingMethod");
            });

            modelBuilder.Entity<OrderAdditionalData>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.Name });

                entity.ToTable("OrderAdditionalData", "Order");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderAdditionalData)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_AdditionalData_Order");
            });

            modelBuilder.Entity<OrderByRequest>(entity =>
            {
                entity.ToTable("OrderByRequest", "Order");

                entity.Property(e => e.ArtNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(64);

                entity.Property(e => e.CodeCreateDate).HasColumnType("datetime");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OfferId).HasColumnName("OfferID");

                entity.Property(e => e.Phone).IsRequired();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(140);
            });

            modelBuilder.Entity<OrderConfirmation>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("OrderConfirmation", "Order");

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderConfirmationData).IsRequired();
            });

            modelBuilder.Entity<OrderContact>(entity =>
            {
                entity.ToTable("OrderContact", "Order");

                entity.Property(e => e.OrderContactId).HasColumnName("OrderContactID");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(70);

                entity.Property(e => e.Country).HasMaxLength(70);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Zip).HasMaxLength(70);

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<OrderCurrency>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("OrderCurrency", "Order");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.OrderCurrency)
                    .HasForeignKey<OrderCurrency>(d => d.OrderId)
                    .HasConstraintName("FK_OrderCurrency_Order");
            });

            modelBuilder.Entity<OrderCustomer>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("OrderCustomer", "Order");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.Apartment).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(70);

                entity.Property(e => e.CustomField1).HasMaxLength(1000);

                entity.Property(e => e.CustomField2).HasMaxLength(1000);

                entity.Property(e => e.CustomField3).HasMaxLength(1000);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerIp)
                    .IsRequired()
                    .HasColumnName("CustomerIP")
                    .HasMaxLength(70);

                entity.Property(e => e.District).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(70);

                entity.Property(e => e.Entrance).HasMaxLength(10);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Floor).HasMaxLength(10);

                entity.Property(e => e.House).HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Organization).HasMaxLength(250);

                entity.Property(e => e.Patronymic).HasMaxLength(1000);

                entity.Property(e => e.Phone).HasMaxLength(70);

                entity.Property(e => e.Region).HasMaxLength(70);

                entity.Property(e => e.Street).HasMaxLength(1000);

                entity.Property(e => e.Structure).HasMaxLength(10);

                entity.Property(e => e.Zip).HasMaxLength(70);

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.OrderCustomer)
                    .HasForeignKey<OrderCustomer>(d => d.OrderId)
                    .HasConstraintName("FK_OrderCustomer_Order");
            });

            modelBuilder.Entity<OrderCustomOptions>(entity =>
            {
                entity.ToTable("OrderCustomOptions", "Order");

                entity.HasIndex(e => e.OrderedCartId)
                    .HasName("OrderCustomOptions_OrderedCartID");

                entity.Property(e => e.CustomOptionTitle)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OptionPriceBc)
                    .HasColumnName("OptionPriceBC")
                    .HasColumnType("money");

                entity.Property(e => e.OptionTitle)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OrderedCartId).HasColumnName("OrderedCartID");

                entity.HasOne(d => d.OrderedCart)
                    .WithMany(p => p.OrderCustomOptions)
                    .HasForeignKey(d => d.OrderedCartId)
                    .HasConstraintName("FK_OrderCustomOptions_OrderedCart");
            });

            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.HasKey(e => e.OrderItemId);

                entity.ToTable("OrderItems", "Order");

                entity.HasIndex(e => e.OrderId)
                    .HasName("OrderItems_OrderID");

                entity.HasIndex(e => e.PhotoId)
                    .HasName("OrderItems_PhotoID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("OrderItems_ProductID");

                entity.Property(e => e.OrderItemId)
                    .HasColumnName("OrderItemID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ArtNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Color).HasMaxLength(300);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentMethodType).HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentSubjectType).HasDefaultValueSql("((1))");

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Size).HasMaxLength(300);

                entity.Property(e => e.TaxName).HasMaxLength(50);

                entity.Property(e => e.TypeItem)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.BookingService)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.BookingServiceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_OrderItems_Service");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderedCart_Order");

                entity.HasOne(d => d.OrderItem)
                    .WithOne(p => p.InverseOrderItem)
                    .HasForeignKey<OrderItems>(d => d.OrderItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItems_OrderItems");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.PhotoId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_OrderItems_Photo");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_OrderItems_Product");
            });

            modelBuilder.Entity<OrderItemsFromMoysklad>(entity =>
            {
                entity.HasKey(e => new { e.OfferExternalId, e.OrderItemId });

                entity.ToTable("OrderItemsFromMoysklad", "Order");

                entity.Property(e => e.OfferExternalId).HasMaxLength(255);

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.OrderItemsFromMoysklad)
                    .HasForeignKey(d => d.OrderItemId)
                    .HasConstraintName("FK_OrderItemsFromMoysklad_OrderItems");
            });

            modelBuilder.Entity<OrderPickPoint>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("OrderPickPoint", "Order");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.PickPointAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PickPointId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.OrderPickPoint)
                    .HasForeignKey<OrderPickPoint>(d => d.OrderId)
                    .HasConstraintName("FK_OrderPickPoint_Order");
            });

            modelBuilder.Entity<OrderPriceDiscount>(entity =>
            {
                entity.ToTable("OrderPriceDiscount", "Order");

                entity.Property(e => e.OrderPriceDiscountId).HasColumnName("OrderPriceDiscountID");
            });

            modelBuilder.Entity<OrderSendMoysklad>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("OrderSendMoysklad", "Order");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsSendService)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.OrderSendMoysklad)
                    .HasForeignKey<OrderSendMoysklad>(d => d.OrderId)
                    .HasConstraintName("FK_OrderSendMoysklad_Order");
            });

            modelBuilder.Entity<OrderSource>(entity =>
            {
                entity.ToTable("OrderSource", "Order");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus", "Order");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.CommandId).HasColumnName("CommandID");

                entity.Property(e => e.IsCanceled)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderTax>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.TaxId });

                entity.ToTable("OrderTax", "Order");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.TaxName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderTax)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderTax_Order");
            });

            modelBuilder.Entity<OrderTrafficSource>(entity =>
            {
                entity.ToTable("OrderTrafficSource", "Order");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.GoogleClientId).HasMaxLength(50);

                entity.Property(e => e.UtmCampaign).HasColumnName("utm_campaign");

                entity.Property(e => e.UtmContent).HasColumnName("utm_content");

                entity.Property(e => e.UtmMedium).HasColumnName("utm_medium");

                entity.Property(e => e.UtmSource).HasColumnName("utm_source");

                entity.Property(e => e.UtmTerm).HasColumnName("utm_term");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.ToTable("Partner", "Partners");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.ContractNumber).HasMaxLength(250);

                entity.Property(e => e.ContractScan).HasMaxLength(250);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.Partner)
                    .HasForeignKey(d => d.CouponId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Partner_Coupon");
            });

            modelBuilder.Entity<PaymentCity>(entity =>
            {
                entity.HasKey(e => new { e.MethodId, e.CityId });

                entity.ToTable("PaymentCity", "Order");

                entity.HasIndex(e => e.CityId)
                    .HasName("PaymentCity_CityId");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.PaymentCity)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_PaymentCity_City");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.PaymentCity)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_PaymentCity_PaymentMethod");
            });

            modelBuilder.Entity<PaymentCountry>(entity =>
            {
                entity.HasKey(e => new { e.MethodId, e.CountryId });

                entity.ToTable("PaymentCountry", "Order");

                entity.HasIndex(e => e.CountryId)
                    .HasName("PaymentCountry_CountryId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PaymentCountry)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_PaymentCountry_Country");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.PaymentCountry)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_PaymentCountry_PaymentMethod");
            });

            modelBuilder.Entity<PaymentDetails>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("PaymentDetails", "Order");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Contract).HasMaxLength(255);

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasColumnName("INN")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.PaymentDetails)
                    .HasForeignKey<PaymentDetails>(d => d.OrderId)
                    .HasConstraintName("FK_PaymentDetails_Order");
            });

            modelBuilder.Entity<PaymentDetails1>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.ToTable("PaymentDetails", "Booking");

                entity.Property(e => e.BookingId).ValueGeneratedNever();

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Contract).HasMaxLength(255);

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasColumnName("INN")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.HasOne(d => d.Booking)
                    .WithOne(p => p.PaymentDetails1)
                    .HasForeignKey<PaymentDetails1>(d => d.BookingId)
                    .HasConstraintName("FK_PaymentDetails_Booking");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("PaymentMethod", "Order");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentType).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentParam>(entity =>
            {
                entity.HasKey(e => new { e.PaymentMethodId, e.Name });

                entity.ToTable("PaymentParam", "Order");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.PaymentParam)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_PaymentParam_PaymentMethod");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("PaymentType", "Partners");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PayoutReport>(entity =>
            {
                entity.ToTable("PayoutReport", "Partners");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PeriodTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<PersentHistory>(entity =>
            {
                entity.ToTable("PersentHistory", "Bonus");

                entity.Property(e => e.BonusPersent).HasColumnType("money");

                entity.Property(e => e.ByAction).HasMaxLength(250);

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.GradeName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.PersentHistory)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK_PersentHistory_Card");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.ToTable("Photo", "Catalog");

                entity.HasIndex(e => e.ColorId)
                    .HasName("Photo_ColorID");

                entity.HasIndex(e => e.ObjId)
                    .HasName("ProductPhoto_ObjId");

                entity.HasIndex(e => e.OriginName)
                    .HasName("ProductPhoto_OriginName");

                entity.HasIndex(e => e.Type)
                    .HasName("ProductPhoto_Type");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OriginName).HasMaxLength(255);

                entity.Property(e => e.PhotoName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PhotoNameSize1).HasMaxLength(255);

                entity.Property(e => e.PhotoNameSize2).HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Photo_Color");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "Catalog");

                entity.HasIndex(e => e.ArtNo)
                    .HasName("Product_ArtNo")
                    .IsUnique();

                entity.HasIndex(e => e.Bestseller)
                    .HasName("Product_Bestseller");

                entity.HasIndex(e => e.BrandId)
                    .HasName("Product_BrandID");

                entity.HasIndex(e => e.Discount)
                    .HasName("Product_Discount");

                entity.HasIndex(e => e.New)
                    .HasName("Product_New");

                entity.HasIndex(e => new { e.ProductId, e.Enabled })
                    .HasName("Product_Enabled");

                entity.HasIndex(e => new { e.UrlPath, e.ProductId })
                    .HasName("Product_UrlPath");

                entity.HasIndex(e => new { e.Enabled, e.New, e.CategoryEnabled })
                    .HasName("Product_New_Enabled");

                entity.HasIndex(e => new { e.Enabled, e.CategoryEnabled, e.Discount, e.DiscountAmount })
                    .HasName("ProductDiscountEnabled");

                entity.HasIndex(e => new { e.ProductId, e.Enabled, e.BrandId, e.CategoryEnabled })
                    .HasName("Product_Brand_Enabled");

                entity.Property(e => e.ArtNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BarCode).HasMaxLength(50);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CategoryEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CustomViewName).HasMaxLength(50);

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GoogleProductCategory).HasMaxLength(500);

                entity.Property(e => e.Gtin).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Multiplicity).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentMethodType).HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentSubjectType).HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesNote).HasMaxLength(50);

                entity.Property(e => e.ShippingPrice).HasColumnType("money");

                entity.Property(e => e.SortBestseller).HasDefaultValueSql("((0))");

                entity.Property(e => e.SortDiscount).HasDefaultValueSql("((0))");

                entity.Property(e => e.SortNew).HasDefaultValueSql("((0))");

                entity.Property(e => e.SortPopular).HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UrlPath).HasMaxLength(150);

                entity.Property(e => e.YandexDeliveryDays).HasMaxLength(5);

                entity.Property(e => e.YandexMarketCategory).HasMaxLength(500);

                entity.Property(e => e.YandexModel).HasMaxLength(500);

                entity.Property(e => e.YandexName).HasMaxLength(255);

                entity.Property(e => e.YandexProductDiscountCondition).HasMaxLength(10);

                entity.Property(e => e.YandexProductDiscountReason).HasMaxLength(3000);

                entity.Property(e => e.YandexSizeUnit).HasMaxLength(10);

                entity.Property(e => e.YandexTypePrefix).HasMaxLength(500);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Product_Brand");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Currency");
            });

            modelBuilder.Entity<ProductCategories>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.ProductId });

                entity.ToTable("ProductCategories", "Catalog");

                entity.HasIndex(e => e.Main)
                    .HasName("ProductCategories_Main");

                entity.HasIndex(e => new { e.CategoryId, e.Main, e.ProductId })
                    .HasName("ProductCategories_ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ProductCategories_Category");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductCategories_Product");
            });

            modelBuilder.Entity<ProductExt>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("ProductExt", "Catalog");

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.ProductExt)
                    .HasForeignKey<ProductExt>(d => d.ProductId)
                    .HasConstraintName("FK_ProductExt_Product");
            });

            modelBuilder.Entity<ProductFile>(entity =>
            {
                entity.ToTable("ProductFile", "Catalog");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductFile");

                entity.Property(e => e.ProductFileId)
                    .HasColumnName("ProductFileID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Filename).IsRequired();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductFile)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductFile_Product");
            });

            modelBuilder.Entity<ProductGifts>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.GiftOfferId });

                entity.ToTable("ProductGifts", "Catalog");

                entity.HasOne(d => d.GiftOffer)
                    .WithMany(p => p.ProductGifts)
                    .HasForeignKey(d => d.GiftOfferId)
                    .HasConstraintName("FK_ProductGifts_Offer");
            });

            modelBuilder.Entity<ProductList>(entity =>
            {
                entity.ToTable("ProductList", "Catalog");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ProductProductList>(entity =>
            {
                entity.HasKey(e => new { e.ListId, e.ProductId });

                entity.ToTable("Product_ProductList", "Catalog");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_Product_ProductList");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.ProductProductList)
                    .HasForeignKey(d => d.ListId)
                    .HasConstraintName("FK_Product_ProductList_ProductList");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductList)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Product_ProductList_Product");
            });

            modelBuilder.Entity<ProductPropertyValue>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.PropertyValueId });

                entity.ToTable("ProductPropertyValue", "Catalog");

                entity.HasIndex(e => new { e.ProductId, e.PropertyValueId })
                    .HasName("PropertyValueID_ProductId");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PropertyValueId).HasColumnName("PropertyValueID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPropertyValue)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_PropertyValueMappingOnProduct_Product");

                entity.HasOne(d => d.PropertyValue)
                    .WithMany(p => p.ProductPropertyValue)
                    .HasForeignKey(d => d.PropertyValueId)
                    .HasConstraintName("FK_PropertyValueMappingOnProduct_PropertyValue");
            });

            modelBuilder.Entity<ProductVideo>(entity =>
            {
                entity.ToTable("ProductVideo", "Catalog");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductVideo");

                entity.Property(e => e.ProductVideoId).HasColumnName("ProductVideoID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PlayerCode).IsRequired();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVideo)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductVideo_Product");
            });

            modelBuilder.Entity<ProfitPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("ProfitPlan", "Settings");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ProfitPlan1).HasColumnName("ProfitPlan");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.ToTable("Property", "Catalog");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Property");

                entity.HasIndex(e => e.SortOrder)
                    .HasName("IX_Property_2");

                entity.HasIndex(e => e.UseInFilter)
                    .HasName("IX_Property_1");

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameDisplayed)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Unit).HasMaxLength(25);

                entity.Property(e => e.UseInFilter).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PropertyGroup>(entity =>
            {
                entity.ToTable("PropertyGroup", "Catalog");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.GroupNameDisplayed)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PropertyGroupCategory>(entity =>
            {
                entity.HasKey(e => new { e.PropertyGroupId, e.CategoryId });

                entity.ToTable("PropertyGroupCategory", "Catalog");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("PropertyGroupCategory_CategoryId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PropertyGroupCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_PropertyGroup_Category_Category");

                entity.HasOne(d => d.PropertyGroup)
                    .WithMany(p => p.PropertyGroupCategory)
                    .HasForeignKey(d => d.PropertyGroupId)
                    .HasConstraintName("FK_PropertyGroup_Category_PropertyGroup");
            });

            modelBuilder.Entity<PropertyValue>(entity =>
            {
                entity.ToTable("PropertyValue", "Catalog");

                entity.HasIndex(e => e.PropertyId)
                    .HasName("PropertyValue_PropertyID");

                entity.HasIndex(e => e.UseInFilter)
                    .HasName("PropertyValue_UseInFilter");

                entity.HasIndex(e => e.Value)
                    .HasName("PropertyValue_Value");

                entity.Property(e => e.PropertyValueId).HasColumnName("PropertyValueID");

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyValue)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_ProductProperty_Property");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.ToTable("Purchase", "Bonus");

                entity.Property(e => e.AdditionBonusAmount).HasColumnType("money");

                entity.Property(e => e.AdditionBonusBalance).HasColumnType("money");

                entity.Property(e => e.CashAmount).HasColumnType("money");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.CreateOnCut).HasColumnType("date");

                entity.Property(e => e.MainBonusAmount).HasColumnType("money");

                entity.Property(e => e.MainBonusBalance).HasColumnType("money");

                entity.Property(e => e.NewBonusAmount).HasColumnType("money");

                entity.Property(e => e.PurchaseAmount).HasColumnType("money");

                entity.Property(e => e.PurchaseFullAmount).HasColumnType("money");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Purchase)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK_Purchase_Card");
            });

            modelBuilder.Entity<Ranges>(entity =>
            {
                entity.HasKey(e => e.RangeId);

                entity.ToTable("Ranges", "Settings");

                entity.Property(e => e.RangeId).HasColumnName("RangeID");

                entity.Property(e => e.Value).HasColumnType("money");
            });

            modelBuilder.Entity<Ratio>(entity =>
            {
                entity.ToTable("Ratio", "Catalog");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("Ratio_CustomerId");

                entity.HasIndex(e => e.ProductId)
                    .HasName("Ratio_ProductID");

                entity.Property(e => e.RatioId).HasColumnName("RatioID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.RatioNavigation)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Ratio_Product");
            });

            modelBuilder.Entity<RecentlyViewsData>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ProductId });

                entity.ToTable("RecentlyViewsData", "Customers");

                entity.HasIndex(e => e.ProductId)
                    .HasName("RecentlyViewsData_ProductID");

                entity.HasIndex(e => e.ViewDate)
                    .HasName("RecentlyViewsData_ViewDate");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ViewDate).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.RecentlyViewsData)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_RecentlyViewsData_Product1");
            });

            modelBuilder.Entity<Redirect>(entity =>
            {
                entity.ToTable("Redirect", "Settings");

                entity.HasIndex(e => e.RedirectFrom)
                    .HasName("IX_RedirectFrom")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Edited).HasColumnType("datetime");

                entity.Property(e => e.ProductArtNo).HasMaxLength(50);

                entity.Property(e => e.RedirectTo).HasMaxLength(450);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region", "Customers");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_Region");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.RegionCode).HasMaxLength(50);

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<RelatedCategories>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.RelatedCategoryId, e.RelatedType });

                entity.ToTable("RelatedCategories", "Catalog");
            });

            modelBuilder.Entity<RelatedProducts>(entity =>
            {
                entity.HasKey(e => e.RelatedProductId);

                entity.ToTable("RelatedProducts", "Catalog");

                entity.Property(e => e.RelatedProductId).HasColumnName("RelatedProductID");

                entity.Property(e => e.LinkedProductId).HasColumnName("LinkedProductID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<RelatedProperties>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.PropertyId, e.RelatedType });

                entity.ToTable("RelatedProperties", "Catalog");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("RelatedProperties_CategoryId");

                entity.HasIndex(e => e.PropertyId)
                    .HasName("RelatedProperties_PropertyId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.RelatedProperties)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_RelatedProperties_Category");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.RelatedProperties)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_RelatedProperties_Property");
            });

            modelBuilder.Entity<RelatedPropertyValues>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.PropertyValueId, e.RelatedType });

                entity.ToTable("RelatedPropertyValues", "Catalog");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.RelatedPropertyValues)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_RelatedPropertyValues_Category");

                entity.HasOne(d => d.PropertyValue)
                    .WithMany(p => p.RelatedPropertyValues)
                    .HasForeignKey(d => d.PropertyValueId)
                    .HasConstraintName("FK_RelatedPropertyValues_PropertyValue");
            });

            modelBuilder.Entity<Reseller>(entity =>
            {
                entity.ToTable("Reseller", "Settings");

                entity.Property(e => e.ResellerId)
                    .HasColumnName("ResellerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReservationResource>(entity =>
            {
                entity.ToTable("ReservationResource", "Booking");

                entity.Property(e => e.Image).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.ReservationResource)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ReservationResource_Managers");
            });

            modelBuilder.Entity<ReservationResourceAdditionalTime>(entity =>
            {
                entity.ToTable("ReservationResourceAdditionalTime", "Booking");

                entity.HasIndex(e => new { e.AffiliateId, e.ReservationResourceId })
                    .HasName("AffiliateAndRR_ReservationResourceAdditionalTime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.ReservationResourceAdditionalTime)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_ReservationResourceAdditionalTime_Affiliate");

                entity.HasOne(d => d.ReservationResource)
                    .WithMany(p => p.ReservationResourceAdditionalTime)
                    .HasForeignKey(d => d.ReservationResourceId)
                    .HasConstraintName("FK_ReservationResourceAdditionalTime_ReservationResource");
            });

            modelBuilder.Entity<ReservationResourceService>(entity =>
            {
                entity.HasKey(e => new { e.AffiliateId, e.ReservationResourceId, e.ServiceId });

                entity.ToTable("ReservationResourceService", "Booking");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.ReservationResourceService)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_ReservationResourceService_Affiliate");

                entity.HasOne(d => d.ReservationResource)
                    .WithMany(p => p.ReservationResourceService)
                    .HasForeignKey(d => d.ReservationResourceId)
                    .HasConstraintName("FK_ReservationResourceService_ReservationResource");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ReservationResourceService)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_ReservationResourceService_Service");
            });

            modelBuilder.Entity<ReservationResourceTag>(entity =>
            {
                entity.ToTable("ReservationResourceTag", "Booking");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ReservationResourceTagsMap>(entity =>
            {
                entity.HasKey(e => new { e.ReservationResourceId, e.ReservationResourceTagId });

                entity.ToTable("ReservationResourceTagsMap", "Booking");

                entity.HasOne(d => d.ReservationResource)
                    .WithMany(p => p.ReservationResourceTagsMap)
                    .HasForeignKey(d => d.ReservationResourceId)
                    .HasConstraintName("FK_ReservationResourceTagsMap_ReservationResource");

                entity.HasOne(d => d.ReservationResourceTag)
                    .WithMany(p => p.ReservationResourceTagsMap)
                    .HasForeignKey(d => d.ReservationResourceTagId)
                    .HasConstraintName("FK_ReservationResourceTagsMap_ReservationResourceTag");
            });

            modelBuilder.Entity<ReservationResourceTimeOfBooking>(entity =>
            {
                entity.ToTable("ReservationResourceTimeOfBooking", "Booking");

                entity.HasIndex(e => new { e.AffiliateId, e.ReservationResourceId })
                    .HasName("AffiliateAndRR_ReservationResourceTimeOfBooking");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.ReservationResourceTimeOfBooking)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_ReservationResourceTimeOfBooking_Affiliate");

                entity.HasOne(d => d.ReservationResource)
                    .WithMany(p => p.ReservationResourceTimeOfBooking)
                    .HasForeignKey(d => d.ReservationResourceId)
                    .HasConstraintName("FK_ReservationResourceTimeOfBooking_ReservationResource");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Review", "CMS");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<ReviewLikes>(entity =>
            {
                entity.ToTable("ReviewLikes", "CMS");

                entity.HasIndex(e => new { e.ReviewId, e.CustomerId })
                    .HasName("Likes_ReviewCustomer")
                    .IsUnique();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.HasOne(d => d.Review)
                    .WithMany(p => p.ReviewLikes)
                    .HasForeignKey(d => d.ReviewId)
                    .HasConstraintName("FK_ReviewLikes_Review");
            });

            modelBuilder.Entity<RoleAction>(entity =>
            {
                entity.ToTable("RoleAction", "Customers");

                entity.Property(e => e.RoleActionId).HasColumnName("RoleActionID");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RuleLog>(entity =>
            {
                entity.HasKey(e => new { e.CardId, e.Created, e.RuleType });

                entity.ToTable("RuleLog", "Bonus");

                entity.Property(e => e.Created).HasColumnType("date");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.RuleLog)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK_RuleLog_Card");

                entity.HasOne(d => d.RuleTypeNavigation)
                    .WithMany(p => p.RuleLog)
                    .HasForeignKey(d => d.RuleType)
                    .HasConstraintName("FK_RuleLog_CustomRule");
            });

            modelBuilder.Entity<SaasData>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SalesFunnel>(entity =>
            {
                entity.ToTable("SalesFunnel", "CRM");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<SalesFunnelDealStatus>(entity =>
            {
                entity.HasKey(e => new { e.SalesFunnelId, e.DealStatusId });

                entity.ToTable("SalesFunnel_DealStatus", "CRM");

                entity.HasOne(d => d.DealStatus)
                    .WithMany(p => p.SalesFunnelDealStatus)
                    .HasForeignKey(d => d.DealStatusId)
                    .HasConstraintName("FK_SalesFunnelDealStatus_DealStatus");

                entity.HasOne(d => d.SalesFunnel)
                    .WithMany(p => p.SalesFunnelDealStatus)
                    .HasForeignKey(d => d.SalesFunnelId)
                    .HasConstraintName("FK_SalesFunnelDealStatus_SalesFunnel");
            });

            modelBuilder.Entity<SalesFunnelLeadAutoCompleteCategory>(entity =>
            {
                entity.HasKey(e => new { e.SalesFunnelId, e.CategoryId });

                entity.ToTable("SalesFunnel_LeadAutoCompleteCategory", "CRM");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SalesFunnelLeadAutoCompleteCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_SalesFunnel_LeadAutoCompleteCategory_Category");

                entity.HasOne(d => d.SalesFunnel)
                    .WithMany(p => p.SalesFunnelLeadAutoCompleteCategory)
                    .HasForeignKey(d => d.SalesFunnelId)
                    .HasConstraintName("FK_SalesFunnel_LeadAutoCompleteCategory_SalesFunnel");
            });

            modelBuilder.Entity<SalesFunnelLeadAutoCompleteProduct>(entity =>
            {
                entity.HasKey(e => new { e.SalesFunnelId, e.ProductId });

                entity.ToTable("SalesFunnel_LeadAutoCompleteProduct", "CRM");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SalesFunnelLeadAutoCompleteProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SalesFunnel_LeadAutoCompleteProduct_Product");

                entity.HasOne(d => d.SalesFunnel)
                    .WithMany(p => p.SalesFunnelLeadAutoCompleteProduct)
                    .HasForeignKey(d => d.SalesFunnelId)
                    .HasConstraintName("FK_SalesFunnel_LeadAutoCompleteProduct_SalesFunnel");
            });

            modelBuilder.Entity<SalesFunnelManager>(entity =>
            {
                entity.HasKey(e => new { e.SalesFunnelId, e.ManagerId });

                entity.ToTable("SalesFunnel_Manager", "CRM");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.SalesFunnelManager)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_SalesFunnel_Manager_Managers");

                entity.HasOne(d => d.SalesFunnel)
                    .WithMany(p => p.SalesFunnelManager)
                    .HasForeignKey(d => d.SalesFunnelId)
                    .HasConstraintName("FK_SalesFunnel_Manager_SalesFunnel");
            });

            modelBuilder.Entity<SearchStatistic>(entity =>
            {
                entity.ToTable("SearchStatistic", "Statistic");

                entity.HasIndex(e => e.Date)
                    .HasName("SearchStatistic_Date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(250);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Request).IsRequired();

                entity.Property(e => e.SearchTerm).HasMaxLength(250);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service", "Booking");

                entity.HasIndex(e => e.ArtNo)
                    .HasName("ArtNo_Service")
                    .IsUnique();

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_Service_Category");

                entity.Property(e => e.ArtNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Image).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_Currency");
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("Settings", "SEO");

                entity.HasIndex(e => e.ParamName)
                    .HasName("IX_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.ParamName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParamValue).IsRequired();
            });

            modelBuilder.Entity<Settings1>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("Settings", "Settings");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ_Settings_Name");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<SettingsSearch>(entity =>
            {
                entity.ToTable("SettingsSearch", "Settings");

                entity.HasIndex(e => e.Title)
                    .HasName("IX_SettingsSearch")
                    .IsUnique();

                entity.Property(e => e.KeyWords).HasMaxLength(1000);

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ShippingCache>(entity =>
            {
                entity.HasKey(e => new { e.ShippingMethodId, e.ParamHash });

                entity.ToTable("ShippingCache", "Order");

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Options).IsRequired();

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.ShippingCache)
                    .HasForeignKey(d => d.ShippingMethodId)
                    .HasConstraintName("FK_ShippingCache_ShippingMethod");
            });

            modelBuilder.Entity<ShippingCategoryExcluded>(entity =>
            {
                entity.HasKey(e => new { e.MethodId, e.CategoryId });

                entity.ToTable("ShippingCategoryExcluded", "Order");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ShippingCategoryExcluded)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ShippingCategoryExcluded_Category");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.ShippingCategoryExcluded)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_ShippingCategoryExcluded_ShippingMethod");
            });

            modelBuilder.Entity<ShippingCity>(entity =>
            {
                entity.HasKey(e => new { e.MethodId, e.CityId });

                entity.ToTable("ShippingCity", "Order");

                entity.HasIndex(e => e.CityId)
                    .HasName("ShippingCity_CityId");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ShippingCity)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_ShippingCity_City");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.ShippingCity)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_ShippingCity_ShippingMethod");
            });

            modelBuilder.Entity<ShippingCityExcluded>(entity =>
            {
                entity.HasKey(e => new { e.MethodId, e.CityId });

                entity.ToTable("ShippingCityExcluded", "Order");

                entity.HasIndex(e => e.CityId)
                    .HasName("ShippingCityExcluded_CityId");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ShippingCityExcluded)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_ShippingCityExcluded_City");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.ShippingCityExcluded)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_ShippingCityExcluded_ShippingMethod");
            });

            modelBuilder.Entity<ShippingCountry>(entity =>
            {
                entity.HasKey(e => new { e.MethodId, e.CountryId });

                entity.ToTable("ShippingCountry", "Order");

                entity.HasIndex(e => e.CountryId)
                    .HasName("ShippingCountry_CountryId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ShippingCountry)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_ShippingCountry_Country");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.ShippingCountry)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_ShippingCountry_ShippingMethod");
            });

            modelBuilder.Entity<ShippingCountryExcluded>(entity =>
            {
                entity.HasKey(e => new { e.MethodId, e.CountryId });

                entity.ToTable("ShippingCountryExcluded", "Order");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ShippingCountryExcluded)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_ShippingCountryExcluded_Country");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.ShippingCountryExcluded)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_ShippingCountryExcluded_ShippingMethod");
            });

            modelBuilder.Entity<ShippingMethod>(entity =>
            {
                entity.ToTable("ShippingMethod", "Order");

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");

                entity.Property(e => e.ModuleStringId).HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingType).HasMaxLength(50);

                entity.Property(e => e.ZeroPriceMessage).HasMaxLength(255);
            });

            modelBuilder.Entity<ShippingParam>(entity =>
            {
                entity.ToTable("ShippingParam", "Order");

                entity.HasIndex(e => e.ShippingMethodId)
                    .HasName("ShippingParam_ShippingMethodID");

                entity.Property(e => e.ShippingParamId).HasColumnName("ShippingParamID");

                entity.Property(e => e.ParamName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ParamValue).IsRequired();

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.ShippingParam)
                    .HasForeignKey(d => d.ShippingMethodId)
                    .HasConstraintName("FK_ShippingParam_ShippingMethod");
            });

            modelBuilder.Entity<ShippingPayments>(entity =>
            {
                entity.ToTable("ShippingPayments", "Order");

                entity.HasIndex(e => e.PaymentMethodId)
                    .HasName("ShippingPayments_PaymentMethodID");

                entity.HasIndex(e => e.ShippingMethodId)
                    .HasName("ShippingPayments_ShippingMethodID");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.ShippingPayments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_ShippingPayments_Payment");

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.ShippingPayments)
                    .HasForeignKey(d => d.ShippingMethodId)
                    .HasConstraintName("FK_ShippingPayments_ShippingMethod");
            });

            modelBuilder.Entity<ShippingProductExcluded>(entity =>
            {
                entity.HasKey(e => new { e.MethodId, e.ProductId });

                entity.ToTable("ShippingProductExcluded", "Order");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.ShippingProductExcluded)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_ShippingProductExcluded_ShippingMethod");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShippingProductExcluded)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ShippingProductExcluded_Product");
            });

            modelBuilder.Entity<ShippingRegion>(entity =>
            {
                entity.HasKey(e => new { e.MethodId, e.RegionId });

                entity.ToTable("ShippingRegion", "Order");

                entity.HasIndex(e => e.RegionId)
                    .HasName("ShippingRegion_RegionId");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.ShippingRegion)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_ShippingRegion_ShippingMethod");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.ShippingRegion)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_ShippingRegion_Region");
            });

            modelBuilder.Entity<ShippingRegionExcluded>(entity =>
            {
                entity.HasKey(e => new { e.MethodId, e.RegionId });

                entity.ToTable("ShippingRegionExcluded", "Order");

                entity.HasIndex(e => e.RegionId)
                    .HasName("ShippingRegionExcluded_RegionId");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.ShippingRegionExcluded)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_ShippingRegionExcluded_ShippingMethod");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.ShippingRegionExcluded)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_ShippingRegionExcluded_Region");
            });

            modelBuilder.Entity<ShippingReplaceGeo>(entity =>
            {
                entity.ToTable("ShippingReplaceGeo", "Order");

                entity.HasIndex(e => e.ShippingType)
                    .HasName("ShippingReplaceGeo_ShippingType");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.InCityName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.InCountryIso2)
                    .IsRequired()
                    .HasColumnName("InCountryISO2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.InCountryName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.InDistrict)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.InRegionName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.InZip)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.OutCityName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OutCountryName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.OutDistrict)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OutRegionName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.OutZip)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.ShippingType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.HasKey(e => e.ShoppingCartItemId);

                entity.ToTable("ShoppingCart", "Booking");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("ShoppingCart_Customer");

                entity.HasIndex(e => e.ReservationResourceId)
                    .HasName("ShoppingCart_ReservationResource");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.ShoppingCart)
                    .HasForeignKey(d => d.AffiliateId)
                    .HasConstraintName("FK_ShoppingCart_Affiliate");

                entity.HasOne(d => d.ReservationResource)
                    .WithMany(p => p.ShoppingCart)
                    .HasForeignKey(d => d.ReservationResourceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ShoppingCart_ReservationResource");
            });

            modelBuilder.Entity<ShoppingCart1>(entity =>
            {
                entity.HasKey(e => e.ShoppingCartItemId);

                entity.ToTable("ShoppingCart", "Catalog");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("ShoppingCart_CustomerId");

                entity.HasIndex(e => e.OfferId)
                    .HasName("ShoppingCart_OfferId");

                entity.Property(e => e.AttributesXml).IsRequired();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModuleKey).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.ShoppingCart1)
                    .HasForeignKey(d => d.OfferId)
                    .HasConstraintName("FK_ShoppingCart_Offer");
            });

            modelBuilder.Entity<SimalandModification>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("SimalandModification", "Module");

                entity.HasIndex(e => e.ModificationId);

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Modifier)
                    .WithMany(p => p.SimalandModification)
                    .HasForeignKey(d => d.ModifierId)
                    .HasConstraintName("FK_SimalandModification_SimalandModifier");

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.SimalandModification)
                    .HasForeignKey<SimalandModification>(d => d.ProductId)
                    .HasConstraintName("FK_SimalandModification_Product");
            });

            modelBuilder.Entity<SimalandModifier>(entity =>
            {
                entity.ToTable("SimalandModifier", "Module");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SimalandSettings>(entity =>
            {
                entity.ToTable("SimalandSettings", "Module");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("Size", "Catalog");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.Property(e => e.SizeName)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<SmsLog>(entity =>
            {
                entity.ToTable("SmsLog", "Bonus");

                entity.Property(e => e.Created).HasColumnType("datetime");
            });

            modelBuilder.Entity<SmsTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("SmsTemplate", "Settings");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<SmsTemplate1>(entity =>
            {
                entity.HasKey(e => e.SmsTypeId);

                entity.ToTable("SmsTemplate", "Bonus");

                entity.Property(e => e.SmsTypeId).ValueGeneratedNever();

                entity.Property(e => e.SmsBody).HasMaxLength(500);
            });

            modelBuilder.Entity<SmsTemplateOnOrderChanging>(entity =>
            {
                entity.ToTable("SmsTemplateOnOrderChanging", "Settings");

                entity.Property(e => e.SmsText).IsRequired();

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.SmsTemplateOnOrderChanging)
                    .HasForeignKey(d => d.OrderStatusId)
                    .HasConstraintName("FK_SmsTemplateOnOrderChanging_OrderStatus");
            });

            modelBuilder.Entity<StaticBlock>(entity =>
            {
                entity.ToTable("StaticBlock", "CMS");

                entity.HasIndex(e => e.Key)
                    .HasName("IX_StaticBlock");

                entity.Property(e => e.StaticBlockId).HasColumnName("StaticBlockID");

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.InnerName).HasMaxLength(255);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<StaticPage>(entity =>
            {
                entity.ToTable("StaticPage", "CMS");

                entity.Property(e => e.StaticPageId).HasColumnName("StaticPageID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PageText).IsRequired();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UrlPath).HasMaxLength(150);
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.ToTable("Subscription", "Customers");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubscribeDate).HasColumnType("datetime");

                entity.Property(e => e.UnsubscribeDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag", "Catalog");

                entity.HasIndex(e => e.UrlPath)
                    .HasName("IX_Tag")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UrlPath).IsRequired();
            });

            modelBuilder.Entity<Tag1>(entity =>
            {
                entity.ToTable("Tag", "Customers");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<TagMap>(entity =>
            {
                entity.HasKey(e => new { e.ObjId, e.TagId, e.Type });

                entity.ToTable("TagMap", "Catalog");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TagMap1>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.TagId });

                entity.ToTable("TagMap", "Customers");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TagMap1)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_TagMap_Customer");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagMap1)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_TagMap_Tag");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task", "Customers");

                entity.Property(e => e.DateAppointed)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ResultShort).HasMaxLength(255);

                entity.HasOne(d => d.AppointedManager)
                    .WithMany(p => p.Task)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.AppointedManagerId)
                    .HasConstraintName("FK_TaskAppointedManagerId_Managers");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Task_Customer");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.LeadId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Task_Lead");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Task_Order");

                entity.HasOne(d => d.Review)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.ReviewId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Task_Review");

                entity.HasOne(d => d.TaskGroup)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.TaskGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_TaskGroup");
            });

            modelBuilder.Entity<TaskGroup>(entity =>
            {
                entity.ToTable("TaskGroup", "Customers");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TaskGroupManager>(entity =>
            {
                entity.HasKey(e => new { e.TaskGroupId, e.ManagerId });

                entity.ToTable("TaskGroupManager", "Customers");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.TaskGroupManager)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_TaskGroupManager_Managers");

                entity.HasOne(d => d.TaskGroup)
                    .WithMany(p => p.TaskGroupManager)
                    .HasForeignKey(d => d.TaskGroupId)
                    .HasConstraintName("FK_TaskGroupManager_TaskGroup");
            });

            modelBuilder.Entity<TaskGroupManagerRole>(entity =>
            {
                entity.HasKey(e => new { e.TaskGroupId, e.ManagerRoleId });

                entity.ToTable("TaskGroupManagerRole", "Customers");

                entity.HasOne(d => d.ManagerRole)
                    .WithMany(p => p.TaskGroupManagerRole)
                    .HasForeignKey(d => d.ManagerRoleId)
                    .HasConstraintName("FK_TaskGroupManagerRole_ManagerRole");

                entity.HasOne(d => d.TaskGroup)
                    .WithMany(p => p.TaskGroupManagerRole)
                    .HasForeignKey(d => d.TaskGroupId)
                    .HasConstraintName("FK_TaskGroupManagerRole_TaskGroup");
            });

            modelBuilder.Entity<TaskManager>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.ManagerId });

                entity.ToTable("TaskManager", "Customers");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.TaskManager)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_TaskManager_Managers");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskManager)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskManager_Task");
            });

            modelBuilder.Entity<TaskObserver>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.ManagerId });

                entity.ToTable("TaskObserver", "Customers");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.TaskObserver)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_TaskObserver_Managers");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskObserver)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskObserver_Task");
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.ToTable("Tax", "Catalog");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShowInPrice)
                    .IsRequired()
                    .HasDefaultValueSql("('true')");
            });

            modelBuilder.Entity<TelegramMessage>(entity =>
            {
                entity.ToTable("TelegramMessage", "Customers");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TemplatesDocx>(entity =>
            {
                entity.ToTable("TemplatesDocx", "CMS");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TemplateSettings>(entity =>
            {
                entity.HasKey(e => new { e.Template, e.Name });

                entity.ToTable("TemplateSettings", "Settings");

                entity.Property(e => e.Template).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction", "Bonus");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.Basis).HasMaxLength(500);

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.CreateOnCut).HasColumnType("date");

                entity.HasOne(d => d.AdditionalBonus)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.AdditionalBonusId)
                    .HasConstraintName("FK_Transaction_AdditionBonus");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_Card");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Transaction_Purchase");
            });

            modelBuilder.Entity<Transaction1>(entity =>
            {
                entity.ToTable("Transaction", "Partners");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.Basis).HasMaxLength(500);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.RewardPeriodTo).HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Transaction1)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Transaction_Customer");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Transaction1)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Transaction_Order");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Transaction1)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_Partner");
            });

            modelBuilder.Entity<TransactionCurrency>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("TransactionCurrency", "Partners");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.HasOne(d => d.Transaction)
                    .WithOne(p => p.TransactionCurrency)
                    .HasForeignKey<TransactionCurrency>(d => d.TransactionId)
                    .HasConstraintName("FK_Partners_TransactionCurrency_Transaction");
            });

            modelBuilder.Entity<TriggerAction>(entity =>
            {
                entity.ToTable("TriggerAction", "CRM");

                entity.Property(e => e.SmartCallsCampaignId).HasColumnName("SmartCallsCampaignID");

                entity.HasOne(d => d.TriggerRule)
                    .WithMany(p => p.TriggerAction)
                    .HasForeignKey(d => d.TriggerRuleId)
                    .HasConstraintName("FK_TriggerAction_TriggerRule");
            });

            modelBuilder.Entity<TriggerCategory>(entity =>
            {
                entity.ToTable("TriggerCategory", "CRM");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TriggerDeferredData>(entity =>
            {
                entity.ToTable("TriggerDeferredData", "CRM");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.TriggerAction)
                    .WithMany(p => p.TriggerDeferredData)
                    .HasForeignKey(d => d.TriggerActionId)
                    .HasConstraintName("FK_TriggerDeferredData_TriggerAction");
            });

            modelBuilder.Entity<TriggerRule>(entity =>
            {
                entity.ToTable("TriggerRule", "CRM");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("Category_TriggerRule");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TriggerRule)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_TriggerRule_TriggerCategory");
            });

            modelBuilder.Entity<TriggerSendOnceData>(entity =>
            {
                entity.HasKey(e => new { e.TriggerId, e.EntityId });

                entity.ToTable("TriggerSendOnceData", "CRM");

                entity.HasOne(d => d.Trigger)
                    .WithMany(p => p.TriggerSendOnceData)
                    .HasForeignKey(d => d.TriggerId)
                    .HasConstraintName("FK_TriggerSendOnceData_TriggerRule");
            });

            modelBuilder.Entity<ViewedTask>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.ManagerId });

                entity.ToTable("ViewedTask", "Customers");

                entity.Property(e => e.ViewDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.ViewedTask)
                    .HasPrincipalKey(p => p.ManagerId)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_ViewedTask_Managers");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ViewedTask)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_ViewedTask_Task");
            });

            modelBuilder.Entity<VkCategory>(entity =>
            {
                entity.ToTable("VkCategory", "Vk");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<VkCategoryCategory>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.VkCategoryId });

                entity.ToTable("VkCategory_Category", "Vk");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.VkCategoryCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_VkCategory_Category_Category");

                entity.HasOne(d => d.VkCategory)
                    .WithMany(p => p.VkCategoryCategory)
                    .HasForeignKey(d => d.VkCategoryId)
                    .HasConstraintName("FK_VkCategory_Category_VkCategory");
            });

            modelBuilder.Entity<VkMessage>(entity =>
            {
                entity.ToTable("VkMessage", "Customers");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<VkOrderOrder>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.VkOrderId });

                entity.ToTable("VkOrder_Order", "Vk");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.VkOrderOrder)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_VkOrder_Order_Order");
            });

            modelBuilder.Entity<VkProduct>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ProductId });

                entity.ToTable("VkProduct", "Vk");

                entity.Property(e => e.PhotoIds).IsRequired();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.VkProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_VkProduct_Product");
            });

            modelBuilder.Entity<VoiceTheme>(entity =>
            {
                entity.ToTable("VoiceTheme", "Voice");

                entity.Property(e => e.VoiceThemeId).HasColumnName("VoiceThemeID");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Psyid).HasColumnName("PSYID");
            });
        }
    }
}
