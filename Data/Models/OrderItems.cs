using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class OrderItems
    {
        public OrderItems()
        {
            OrderCustomOptions = new HashSet<OrderCustomOptions>();
            OrderItemsFromMoysklad = new HashSet<OrderItemsFromMoysklad>();
        }

        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public string ArtNo { get; set; }
        public double SupplyPrice { get; set; }
        public double Weight { get; set; }
        public bool IsCouponApplied { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double DecrementedAmount { get; set; }
        public int? PhotoId { get; set; }
        public bool IgnoreOrderDiscount { get; set; }
        public bool AccrueBonuses { get; set; }
        public int? TaxId { get; set; }
        public string TaxName { get; set; }
        public int? TaxType { get; set; }
        public double? TaxRate { get; set; }
        public bool? TaxShowInPrice { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public int PaymentSubjectType { get; set; }
        public int PaymentMethodType { get; set; }
        public bool? IsGift { get; set; }
        public int? BookingServiceId { get; set; }
        public string TypeItem { get; set; }

        public Service BookingService { get; set; }
        public Order Order { get; set; }
        public OrderItems OrderItem { get; set; }
        public Photo Photo { get; set; }
        public Product Product { get; set; }
        public OrderItems InverseOrderItem { get; set; }
        public ICollection<OrderCustomOptions> OrderCustomOptions { get; set; }
        public ICollection<OrderItemsFromMoysklad> OrderItemsFromMoysklad { get; set; }
    }
}
