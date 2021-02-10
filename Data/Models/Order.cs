using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Order
    {
        public Order()
        {
            Booking = new HashSet<Booking>();
            Certificate = new HashSet<Certificate>();
            ManagerTask = new HashSet<ManagerTask>();
            OrderAdditionalData = new HashSet<OrderAdditionalData>();
            OrderItems = new HashSet<OrderItems>();
            OrderTax = new HashSet<OrderTax>();
            Task = new HashSet<Task>();
            Transaction1 = new HashSet<Transaction1>();
            VkOrderOrder = new HashSet<VkOrderOrder>();
        }

        public int OrderId { get; set; }
        public string Number { get; set; }
        public int? ShippingMethodId { get; set; }
        public int? PaymentMethodId { get; set; }
        public int? AffiliateId { get; set; }
        public double? OrderDiscount { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string GroupName { get; set; }
        public double? GroupDiscount { get; set; }
        public string CustomerComment { get; set; }
        public string StatusComment { get; set; }
        public string AdditionalTechInfo { get; set; }
        public string AdminOrderComment { get; set; }
        public bool? Decremented { get; set; }
        public double ShippingCost { get; set; }
        public double TaxCost { get; set; }
        public double SupplyTotal { get; set; }
        public double Sum { get; set; }
        public int OrderStatusId { get; set; }
        public int ShippingContactId { get; set; }
        public int BillingContactId { get; set; }
        public string PaymentMethodName { get; set; }
        public string ShippingMethodName { get; set; }
        public string CertificateCode { get; set; }
        public double? CertificatePrice { get; set; }
        public string CouponCode { get; set; }
        public int? CouponType { get; set; }
        public double? CouponValue { get; set; }
        public double? PaymentCost { get; set; }
        public double? BonusCost { get; set; }
        public double? DiscountCost { get; set; }
        public bool? UseIn1C { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid Code { get; set; }
        public bool ManagerConfirmed { get; set; }
        public int? ManagerId { get; set; }
        public string PreviousStatus { get; set; }
        public long? BonusCardNumber { get; set; }
        public int OrderSourceId { get; set; }
        public string CustomData { get; set; }
        public string TrackNumber { get; set; }
        public bool? IsDraft { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public bool? IsFromAdminArea { get; set; }
        public double? OrderDiscountValue { get; set; }
        public int? LeadId { get; set; }
        public int? ShippingTaxType { get; set; }
        public int? LpId { get; set; }
        public bool IsSendedToGa { get; set; }
        public string PayCode { get; set; }
        public double? TotalWeight { get; set; }
        public double? TotalLength { get; set; }
        public double? TotalWidth { get; set; }
        public double? TotalHeight { get; set; }
        public bool? AvailablePaymentCashOnDelivery { get; set; }
        public bool? AvailablePaymentPickPoint { get; set; }

        public Lead Lead { get; set; }
        public Managers Manager { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public OrderCurrency OrderCurrency { get; set; }
        public OrderCustomer OrderCustomer { get; set; }
        public OrderPickPoint OrderPickPoint { get; set; }
        public OrderSendMoysklad OrderSendMoysklad { get; set; }
        public PaymentDetails PaymentDetails { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<Certificate> Certificate { get; set; }
        public ICollection<ManagerTask> ManagerTask { get; set; }
        public ICollection<OrderAdditionalData> OrderAdditionalData { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
        public ICollection<OrderTax> OrderTax { get; set; }
        public ICollection<Task> Task { get; set; }
        public ICollection<Transaction1> Transaction1 { get; set; }
        public ICollection<VkOrderOrder> VkOrderOrder { get; set; }
    }
}
