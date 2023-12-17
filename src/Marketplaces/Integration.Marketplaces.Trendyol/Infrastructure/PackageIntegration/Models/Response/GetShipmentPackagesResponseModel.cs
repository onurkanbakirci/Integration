using Integration.Core;
using Integration.Marketplaces.Trendyol.Infrastructure.OrderIntegration.Constants;
namespace Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Response;
public class GetShipmentPackagesResponseModel : PaginationModel
{
    public List<GetShipmentPackagePackageResponseModel> Contents { get; set; }

}
public class GetShipmentPackagePackageFastDeliveryOptionResponseModel : IResponseModel
{
    public DeliveryOption Type { get; set; }
}
public class GetShipmentPackagePackageDiscountDetailResponseModel : IResponseModel
{
    public double LineItemPrice { get; set; }
    public double LineItemDiscount { get; set; }
    public double LineItemTyDiscount { get; set; }
}
public class GetShipmentPackagePackageLineResponseModel : IResponseModel
{
    public int Quantity { get; set; }
    public int SalesCampaignId { get; set; }
    public string ProductSize { get; set; }
    public string MerchantSku { get; set; }
    public string ProductName { get; set; }
    public int ProductCode { get; set; }
    public string ProductOrigin { get; set; }
    public int MerchantId { get; set; }
    public double Amount { get; set; }
    public double Discount { get; set; }
    public double TyDiscount { get; set; }
    public List<GetShipmentPackagePackageDiscountDetailResponseModel> DiscountDetails { get; set; }
    public List<GetShipmentPackagePackageFastDeliveryOptionResponseModel> FastDeliveryOptions { get; set; }
    public string CurrencyCode { get; set; }
    public string ProductColor { get; set; }
    public int Id { get; set; }
    public string Sku { get; set; }
    public int VatBaseAmount { get; set; }
    public string Barcode { get; set; }
    public string OrderLineItemStatusName { get; set; }
    public double Price { get; set; }
}
public class GetShipmentPackageShipmentAddressResponseModel : IResponseModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public int CityCode { get; set; }
    public string District { get; set; }
    public int DistrictId { get; set; }
    public string PostalCode { get; set; }
    public string CountryCode { get; set; }
    public int NeighborhoodId { get; set; }
    public string Neighborhood { get; set; }
    public object Phone { get; set; }
    public string FullName { get; set; }
    public string FullAddress { get; set; }
}
public class GetShipmentPackageInvoiceAddressResponseModel : IResponseModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public int DistrictId { get; set; }
    public string PostalCode { get; set; }
    public string CountryCode { get; set; }
    public int NeighborhoodId { get; set; }
    public string Neighborhood { get; set; }
    public object Phone { get; set; }
    public string FullName { get; set; }
    public string FullAddress { get; set; }
    public string TaxOffice { get; set; }
    public string TaxNumber { get; set; }
}
public class GetShipmentPackagesPackageHistoryResponseModel : IResponseModel
{
    public double CreatedDate { get; set; }
    public PackageStatus Status { get; set; }
}
public class GetShipmentPackagePackageResponseModel : IResponseModel
{
    public GetShipmentPackageShipmentAddressResponseModel ShipmentAddress { get; set; }
    public string OrderNumber { get; set; }
    public double GrossAmount { get; set; }
    public double TotalDiscount { get; set; }
    public double TotalTyDiscount { get; set; }
    public object TaxNumber { get; set; }
    public GetShipmentPackageInvoiceAddressResponseModel InvoiceAddress { get; set; }
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
    public List<GetShipmentPackagesPackageHistoryResponseModel> PackageHistories { get; set; }
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