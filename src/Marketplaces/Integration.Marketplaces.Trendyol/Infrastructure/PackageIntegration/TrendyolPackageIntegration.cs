using Integration.Core;
using Integration.Marketplaces.Trendyol.Dtos.Invoice;
using Integration.Marketplaces.Trendyol.Dtos.Package;
using Integration.Marketplaces.Trendyol.Infrastructure.OrderIntegration;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration;
public class TrendyolPackageIntegration : TrendyolIntegrationBase, ITrendyolPackageIntegration, IMarketplaceIntegration
{
    public string GetShipmentPackagesUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/orders";
    public string GetUpdateTrackingNumberUrl(long shipmentPackageId) => $"{GetBaseUrl}suppliers/{_supplierId}/{shipmentPackageId}/update-tracking-number";
    public string GetUpdatePackageUrl(long shipmentPackageId) => $"{GetBaseUrl}suppliers/{_supplierId}//shipment-packages/{shipmentPackageId}";
    public string GetAddInvoiceLinkUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/supplier-invoice-links";
    public string GetDeleteInvoiceLinkUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/supplier-invoice-links/delete";
    public string GetSplitMultiPackageByQuantityUrl(long _shipmentPackageId) => $"{GetBaseUrl}suppliers/{_supplierId}/shipment-packages/{_shipmentPackageId}/split-packages";
    public string GetSplitMultiShipmentPackageUrl(long _shipmentPackageId) => $"{GetBaseUrl}suppliers/{_supplierId}/shipment-packages/{_shipmentPackageId}/split";
    public string GetSplitShipmentPackageUrl(long _shipmentPackageId) => $"{GetBaseUrl}suppliers/{_supplierId}/shipment-packages/{_shipmentPackageId}/multi-split";
    public string GetSplitShipmentPackageByQuantityUrl(long _shipmentPackageId) => $"{GetBaseUrl}suppliers/{_supplierId}/shipment-packages/{_shipmentPackageId}/quantity-split";
    public string GetUpdateBoxInfoUrl(long _shipmentPackageId) => $"{GetBaseUrl}suppliers/{_supplierId}/shipment-packages/{_shipmentPackageId}/box-info";
    public TrendyolPackageIntegration(string supplierId, string apiKey, string apiSecret, bool isInProduction, string entegratorFirm) : base(supplierId, apiKey, apiSecret, isInProduction, entegratorFirm)
    {
    }

    public async Task<GetShipmentPackagesDto?> GetShipmentPackagesAsync(string filterQuery)
    {
        return await InvokeRequestAsync<GetShipmentPackagesDto?>((client) => client.GetAsync(GetShipmentPackagesUrl() + filterQuery));
    }

    public async Task<bool> UpdateTrackingNumberAsync(long shipmentPackageId, UpdateTrackingNumberDto updateTrackingNumberDto)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PutAsync(GetUpdateTrackingNumberUrl(shipmentPackageId), requestBody), updateTrackingNumberDto);

        return true;
    }

    public async Task<bool> UpdatePackageAsync(long shipmentPackageId, UpdatePackageDto updatePackageDto)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PutAsync(GetUpdatePackageUrl(shipmentPackageId), requestBody), updatePackageDto);

        return true;
    }

    public async Task<bool> SendInvoiceLinkAsync(AddInvoiceLinkDto addInvoiceLinkDto)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetAddInvoiceLinkUrl(), requestBody), addInvoiceLinkDto);

        return true;
    }

    public async Task<bool> DeleteInvoiceLinkAsync(DeleteInvoiceLinkDto deleteInvoiceLinkDto)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetDeleteInvoiceLinkUrl(), requestBody), deleteInvoiceLinkDto);

        return true;
    }

    public async Task<bool> SplitMultiPackageByQuantityAsync(long shipmentPackageId, SplitMultiPackageByQuantityDto splitMultiPackageByQuantityDto)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetSplitMultiPackageByQuantityUrl(shipmentPackageId), requestBody), splitMultiPackageByQuantityDto);

        return true;
    }
    public async Task<bool> SplitMultiShipmentPackageAsync(long shipmentPackageId, SplitMultiShipmentPackageDto splitMultiShipmentPackageDto)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetSplitMultiShipmentPackageUrl(shipmentPackageId), requestBody), splitMultiShipmentPackageDto);

        return true;
    }

    public async Task<bool> SplitShipmentPackageAsync(long shipmentPackageId, SplitShipmentPackageDto splitShipmentPackageDto)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetSplitShipmentPackageUrl(shipmentPackageId), requestBody), splitShipmentPackageDto);

        return true;
    }

    public async Task<bool> SplitShipmentPackageByQuantityAsync(long shipmentPackageId, SplitShipmentPackageByQuantityDto splitShipmentPackageByQuantityDto)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetSplitShipmentPackageByQuantityUrl(shipmentPackageId), requestBody), splitShipmentPackageByQuantityDto);

        return true;
    }

    public async Task<bool> UpdateBoxInfoAsync(long shipmentPackageId, UpdateBoxInfoDto updateBoxInfoDto)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetUpdateBoxInfoUrl(shipmentPackageId), requestBody), updateBoxInfoDto);

        return true;
    }
}