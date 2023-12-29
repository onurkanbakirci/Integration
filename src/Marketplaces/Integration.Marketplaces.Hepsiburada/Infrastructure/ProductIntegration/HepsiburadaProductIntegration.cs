using System.Text.Json;
using Integration.Hub;
using Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Request;
using Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;
using Integration.Marketplaces.Trendyol.Infrastructure;

namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration;

public class HepsiburadaProductIntegration : HepsiburadaIntegrationBase, IHepsiburadaProductIntegration, IMarketplaceIntegration
{
    private string GetCategoriesUrl() => $"{GetBaseUrl()}product/api/categories/get-all-categories";
    private string GetCategoryAttributesUrl(int categoryId) => $"{GetBaseUrl()}product/api/categories/{categoryId}/attributes";
    private string GetCategoryAttributeValueUrl(int categoryId, string attributeId) => $"{GetBaseUrl()}product/api/categories/{categoryId}/attribute/{attributeId}/v";
    private string GetRejectPrematchUrl() => $"{GetBaseUrl()}product/api/products/reject-prematch";
    private string GetCreateProductUrl() => $"{GetBaseUrl()}product/api/products/import";
    private string GetFastListingUrl() => $"{GetBaseUrl()}product/api/products/fastlisting";
    private string GetCheckProductStatusUrl() => $"{GetBaseUrl()}product/api/products/check-product-status";
    private string GetApprovePrematchUrl() => $"{GetBaseUrl()}product/api/products/approve-prematch";
    private string GetTrackingIdHistoryUrl() => $"{GetBaseUrl()}product/api/products/trackingId-history";
    private string GetCheckProductStatusByTrackingIdUrl(string trackingId) => $"{GetBaseUrl()}product/api/products/status/{trackingId}";
    private string GetProductsByStatusUrl(string merchantId, string productStatus) => $"{GetBaseUrl()}product/api/products/products-by-merchant-and-status?merchantId={merchantId}&productStatus={productStatus}";
    private string GetCheckDeleteProductProcessUrl(string trackingId) => $"{GetBaseUrl()}product/api/products/delete-process/{trackingId}";
    private string GetMerchatProductsUrl(string merchantId) => $"{GetBaseUrl()}product/api/products/all-products-of-merchant/{merchantId}";

    public HepsiburadaProductIntegration(string username, string password, bool isInProduction = true) : base(username, password, isInProduction)
    {
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<List<GetCategoriesResponseModel>>> GetCategoriesAsync()
    {
        return await InvokeRequestAsync<HepsiburadaBaseResponseModel<List<GetCategoriesResponseModel>>>((client) => client.GetAsync(GetCategoriesUrl()));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="categoryId"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<List<GetCategoryAttributesResponseModel>>> GetCategoryAttributesAsync(int categoryId)
    {
        return await InvokeRequestAsync<HepsiburadaBaseResponseModel<List<GetCategoryAttributesResponseModel>>>((client) => client.GetAsync(GetCategoryAttributesUrl(categoryId)));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="categoryId"><inheritdoc/></param>
    /// <param name="attributeId"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<List<GetCategoryAttributeValuesResponseModel>>> GetCategoryAttributeValuesAsync(int categoryId, string attributeId)
    {
        return await InvokeRequestAsync<HepsiburadaBaseResponseModel<List<GetCategoryAttributeValuesResponseModel>>>((client) => client.GetAsync(GetCategoryAttributeValueUrl(categoryId, attributeId)));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="rejectPrematchRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<RejectPrematchResponseModel>> GetCategoryAttributeValuesAsync(RejectPrematchRequestModel rejectPrematchRequestModel)
    {
        return await InvokeRequestAsync<RejectPrematchRequestModel, HepsiburadaBaseResponseModel<RejectPrematchResponseModel>>((client, requestBody) => client.PostAsync(GetRejectPrematchUrl(), requestBody), rejectPrematchRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="createProductRequestModels"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<CreateProductResponseModel>> CreateProductsAsync(BulkModel<CreateProductRequestModel> createProductRequestModels)
    {
        var requestString = JsonSerializer.Serialize(createProductRequestModels);
        //Todo copy request string to json file
        return await InvokeRequestAsync<BulkModel<CreateProductRequestModel>, HepsiburadaBaseResponseModel<CreateProductResponseModel>>((client, requestBody) => client.PostAsync(GetCreateProductUrl(), requestBody), createProductRequestModels);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="fastListingRequestModels"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<List<FastListingResponseModel>>> FastListingAsync(BulkModel<FastListingRequestModel> fastListingRequestModels)
    {
        return await InvokeRequestAsync<BulkModel<FastListingRequestModel>, HepsiburadaBaseResponseModel<List<FastListingResponseModel>>>((client, requestBody) => client.PostAsync(GetFastListingUrl(), requestBody), fastListingRequestModels);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="checkProductStatusRequestModels"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<CheckProductStatusResponseModel>> CheckProductStatusAsync(BulkModel<CheckProductStatusRequestModel> checkProductStatusRequestModels)
    {
        return await InvokeRequestAsync<BulkModel<CheckProductStatusRequestModel>, HepsiburadaBaseResponseModel<CheckProductStatusResponseModel>>((client, requestBody) => client.PostAsync(GetCheckProductStatusUrl(), requestBody), checkProductStatusRequestModels);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="approvePrematchRequestModels"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<ApprovePrematchResponseModel>> ApprovePrematchAsync(BulkModel<ApprovePrematchRequestModel> approvePrematchRequestModels)
    {
        return await InvokeRequestAsync<BulkModel<ApprovePrematchRequestModel>, HepsiburadaBaseResponseModel<ApprovePrematchResponseModel>>((client, requestBody) => client.PostAsync(GetApprovePrematchUrl(), requestBody), approvePrematchRequestModels);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<List<GetTrackingIdHistoriesResponseModel>>> GetTrackingIdHistoryAsync()
    {
        return await InvokeRequestAsync<HepsiburadaBaseResponseModel<List<GetTrackingIdHistoriesResponseModel>>>((client) => client.GetAsync(GetTrackingIdHistoryUrl()));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="trackingId"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<CheckProductStatusByTrackingIdResponseModel>> GetProductStatusByTrackingIdAsync(string trackingId)
    {
        return await InvokeRequestAsync<HepsiburadaBaseResponseModel<CheckProductStatusByTrackingIdResponseModel>>((client) => client.GetAsync(GetCheckProductStatusByTrackingIdUrl(trackingId)));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="merchantId"><inheritdoc/></param>
    /// <param name="productStatus"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<List<GetProductByStatusResponseModel>>> GetProductsByStatusAsync(string merchantId, string productStatus)
    {
        return await InvokeRequestAsync<HepsiburadaBaseResponseModel<List<GetProductByStatusResponseModel>>>((client) => client.GetAsync(GetProductsByStatusUrl(merchantId, productStatus)));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="trackingId"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<CheckDeleteProductProcessResponseModel>> CheckDeleteProductProcessAsync(string trackingId)
    {
        return await InvokeRequestAsync<HepsiburadaBaseResponseModel<CheckDeleteProductProcessResponseModel>>((client) => client.GetAsync(GetCheckDeleteProductProcessUrl(trackingId)));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="merchantId"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<HepsiburadaBaseResponseModel<List<GetMerchantProductResponseModel>>> GetMerchantProductsAsync(string merchantId)
    {
        return await InvokeRequestAsync<HepsiburadaBaseResponseModel<List<GetMerchantProductResponseModel>>>((client) => client.GetAsync(GetMerchatProductsUrl(merchantId)));
    }
}