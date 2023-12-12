using Integration.Core;
using Integration.Marketplaces.Trendyol.Models.Address;
namespace Integration.Marketplaces.Trendyol.Models.Package;
public class Package : IModel
{
    public ShipmentAddress ShipmentAddress { get; set; }
    public string OrderNumber { get; set; }
    public double GrossAmount { get; set; }
    public double TotalDiscount { get; set; }
    public double TotalTyDiscount { get; set; }
    public object TaxNumber { get; set; }
    public InvoiceAddress InvoiceAddress { get; set; }
    public string CustomerFirstName { get; set; }
    public string CustomerEmail { get; set; }
    public int CustomerId { get; set; }
    public string CustomerLastName { get; set; }
    public int Id { get; set; }
    public long CargoTrackingNumber { get; set; }
    public string CargoTrackingLink { get; set; }
    public string CargoSenderNumber { get; set; }
    public string CargoProviderName { get; set; }
    public string Lines { get; set; }
    public long OrderDate { get; set; }
    public string TcIdentityNumber { get; set; }
    public string CurrencyCode { get; set; }
    public List<PackageHistory> PackageHistories { get; set; }
    public string ShipmentPackageStatus { get; set; }
    public string Status { get; set; }
    public string DeliveryType { get; set; }
    public int TimeSlotId { get; set; }
    public string ScheduledDeliveryStoreId { get; set; }
    public long EstimatedDeliveryStartDate { get; set; }
    public long EstimatedDeliveryEndDate { get; set; }
    public double TotalPrice { get; set; }
    public string DeliveryAddressType { get; set; }
    public long AgreedDeliveryDate { get; set; }
    public bool AgreedDeliveryDateExtendible { get; set; }
    public long ExtendedAgreedDeliveryDate { get; set; }
    public long AgreedDeliveryExtensionStartDate { get; set; }
    public long AgreedDeliveryExtensionEndDate { get; set; }
    public string InvoiceLink { get; set; }
    public bool FastDelivery { get; set; }
    public string FastDeliveryType { get; set; }
    public long OriginShipmentDate { get; set; }
    public long LastModifiedDate { get; set; }
    public bool Commercial { get; set; }
    public bool DeliveredByService { get; set; }
    public bool Micro { get; set; }
    public bool GiftBoxRequested { get; set; }
}