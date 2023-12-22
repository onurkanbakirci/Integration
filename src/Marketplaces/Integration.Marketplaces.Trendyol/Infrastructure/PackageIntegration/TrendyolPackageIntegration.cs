using Integration.Hub;
using Integration.Marketplaces.Trendyol.Infrastructure.OrderIntegration;
using Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Request;
using Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Response;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration;
public class TrendyolPackageIntegration : TrendyolIntegrationBase, ITrendyolPackageIntegration, IMarketplaceIntegration
{
    private string GetShipmentPackagesUrl() => $"{GetBaseUrl()}suppliers/{_supplierId}/orders";
    private string GetUpdateTrackingNumberUrl(long shipmentPackageId) => $"{GetBaseUrl()}suppliers/{_supplierId}/{shipmentPackageId}/update-tracking-number";
    private string GetUpdatePackageUrl(long shipmentPackageId) => $"{GetBaseUrl()}suppliers/{_supplierId}//shipment-packages/{shipmentPackageId}";
    private string GetAddInvoiceLinkUrl() => $"{GetBaseUrl()}suppliers/{_supplierId}/supplier-invoice-links";
    private string GetDeleteInvoiceLinkUrl() => $"{GetBaseUrl()}suppliers/{_supplierId}/supplier-invoice-links/delete";
    private string GetSplitMultiPackageByQuantityUrl(long _shipmentPackageId) => $"{GetBaseUrl()}suppliers/{_supplierId}/shipment-packages/{_shipmentPackageId}/split-packages";
    private string GetSplitMultiShipmentPackageUrl(long _shipmentPackageId) => $"{GetBaseUrl()}suppliers/{_supplierId}/shipment-packages/{_shipmentPackageId}/split";
    private string GetSplitShipmentPackageUrl(long _shipmentPackageId) => $"{GetBaseUrl()}suppliers/{_supplierId}/shipment-packages/{_shipmentPackageId}/multi-split";
    private string GetSplitShipmentPackageByQuantityUrl(long _shipmentPackageId) => $"{GetBaseUrl()}suppliers/{_supplierId}/shipment-packages/{_shipmentPackageId}/quantity-split";
    private string GetUpdateBoxInfoUrl(long _shipmentPackageId) => $"{GetBaseUrl()}suppliers/{_supplierId}/shipment-packages/{_shipmentPackageId}/box-info";
    public TrendyolPackageIntegration(string supplierId, string apiKey, string apiSecret, bool isInProduction, string entegratorFirm) : base(supplierId, apiKey, apiSecret, isInProduction, entegratorFirm)
    {
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="filterQuery"></param>
    /// <returns><inheritdoc/></returns>
    public async Task<GetShipmentPackagesResponseModel?> GetShipmentPackagesAsync(string filterQuery)
    {
        return await InvokeRequestAsync<GetShipmentPackagesResponseModel?>((client) => client.GetAsync(GetShipmentPackagesUrl() + filterQuery));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="shipmentPackageId"><inheritdoc/></param>
    /// <param name="updateTrackingNumberRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> UpdateTrackingNumberAsync(long shipmentPackageId, UpdateTrackingNumberRequestModel updateTrackingNumberRequestModel)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PutAsync(GetUpdateTrackingNumberUrl(shipmentPackageId), requestBody), updateTrackingNumberRequestModel);

        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="shipmentPackageId"><inheritdoc/></param>
    /// <param name="updatePackageRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> UpdatePackageAsync(long shipmentPackageId, UpdatePackageRequestModel updatePackageRequestModel)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PutAsync(GetUpdatePackageUrl(shipmentPackageId), requestBody), updatePackageRequestModel);

        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="addInvoiceLinkRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> SendInvoiceLinkAsync(AddInvoiceLinkRequestModel addInvoiceLinkRequestModel)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetAddInvoiceLinkUrl(), requestBody), addInvoiceLinkRequestModel);

        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="deleteInvoiceLinkRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> DeleteInvoiceLinkAsync(DeleteInvoiceLinkRequestModel deleteInvoiceLinkRequestModel)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetDeleteInvoiceLinkUrl(), requestBody), deleteInvoiceLinkRequestModel);

        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="shipmentPackageId"><inheritdoc/></param>
    /// <param name="splitMultiPackageByQuantityRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> SplitMultiPackageByQuantityAsync(long shipmentPackageId, SplitMultiPackageByQuantityRequestModel splitMultiPackageByQuantityRequestModel)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetSplitMultiPackageByQuantityUrl(shipmentPackageId), requestBody), splitMultiPackageByQuantityRequestModel);

        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="shipmentPackageId"><inheritdoc/></param>
    /// <param name="splitMultiShipmentPackageRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> SplitMultiShipmentPackageAsync(long shipmentPackageId, SplitMultiShipmentPackageRequestModel splitMultiShipmentPackageRequestModel)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetSplitMultiShipmentPackageUrl(shipmentPackageId), requestBody), splitMultiShipmentPackageRequestModel);

        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="shipmentPackageId"><inheritdoc/></param>
    /// <param name="splitShipmentPackageRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> SplitShipmentPackageAsync(long shipmentPackageId, SplitShipmentPackageRequestModel splitShipmentPackageRequestModel)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetSplitShipmentPackageUrl(shipmentPackageId), requestBody), splitShipmentPackageRequestModel);

        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="shipmentPackageId"><inheritdoc/></param>
    /// <param name="splitMultiPackageByQuantityRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> SplitShipmentPackageByQuantityAsync(long shipmentPackageId, SplitMultiPackageByQuantityRequestModel splitMultiPackageByQuantityRequestModel)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetSplitShipmentPackageByQuantityUrl(shipmentPackageId), requestBody), splitMultiPackageByQuantityRequestModel);

        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="shipmentPackageId"><inheritdoc/></param>
    /// <param name="updateBoxInfoRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> UpdateBoxInfoAsync(long shipmentPackageId, UpdateBoxInfoRequestModel updateBoxInfoRequestModel)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetUpdateBoxInfoUrl(shipmentPackageId), requestBody), updateBoxInfoRequestModel);

        return true;
    }
}