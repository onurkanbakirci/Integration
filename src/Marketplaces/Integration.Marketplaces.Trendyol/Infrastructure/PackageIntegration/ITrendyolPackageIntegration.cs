using Integration.Marketplaces.Trendyol.Dtos.Invoice;
using Integration.Marketplaces.Trendyol.Dtos.Package;
namespace Integration.Marketplaces.Trendyol.Infrastructure.OrderIntegration;

public interface ITrendyolPackageIntegration
{
    Task<GetShipmentPackagesDto?> GetShipmentPackagesAsync(string filterQuery);
    Task<bool> UpdateTrackingNumberAsync(long shipmentPackageId, UpdateTrackingNumberDto updateTrackingNumberDto);
    Task<bool> UpdatePackageAsync(long shipmentPackageId, UpdatePackageDto updatePackageDto);
    Task<bool> SendInvoiceLinkAsync(AddInvoiceLinkDto addInvoiceLinkDto);
    Task<bool> DeleteInvoiceLinkAsync(DeleteInvoiceLinkDto deleteInvoiceLinkDto);
    Task<bool> SplitMultiPackageByQuantityAsync(long shipmentPackageId, SplitMultiPackageByQuantityDto splitMultiPackageByQuantityDto);
    Task<bool> SplitMultiShipmentPackageAsync(long shipmentPackageId, SplitMultiShipmentPackageDto splitMultiShipmentPackageDto);
    Task<bool> SplitShipmentPackageAsync(long shipmentPackageId, SplitShipmentPackageDto splitShipmentPackageDto);
    Task<bool> SplitShipmentPackageByQuantityAsync(long shipmentPackageId, SplitShipmentPackageByQuantityDto splitShipmentPackageByQuantityDto);
    Task<bool> UpdateBoxInfoAsync(long shipmentPackageId, UpdateBoxInfoDto updateBoxInfoDto);
}