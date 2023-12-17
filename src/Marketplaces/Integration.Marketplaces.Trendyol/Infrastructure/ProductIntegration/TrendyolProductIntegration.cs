using Integration.Core;
using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Constants;
using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Request;
using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Response;
using Integration.Marketplaces.Trendyol.Models.Provider;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration;
public class TrendyolProductIntegration : TrendyolIntegrationBase, ITrendyolProductIntegration, IMarketplaceIntegration
{
    private string GetCreateProducsUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/v2/products";
    private string GetSupplierAddressUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/addresses";
    private string GetBrandsUrl() => $"{GetBaseUrl}brands";
    private string GetCategoryTreeUrl() => $"{GetBaseUrl}product-categories";
    private string GetCategoryAttributesUrl(int categoryId) => $"{GetBaseUrl}product-categories/{categoryId}/attributes";
    private string GetUpdateProductUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/v2/products";
    private string GetUpdatePriceAndStockUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/products/price-and-inventory";
    private string GetDeleteProductUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/v2/products";
    private string GetBatchRequestResultUrl(string batchRequestId) => $"{GetBaseUrl}suppliers/{_supplierId}/products/batch-requests/{batchRequestId}";
    private string GetFilterProductsUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/products";
    public TrendyolProductIntegration(string supplierId, string apiKey, string apiSecret, bool isInProduction, string entegratorFirm) : base(supplierId, apiKey, apiSecret, isInProduction, entegratorFirm)
    {
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="products"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> CreateProductsV2Async(BulkModel<CreateProductRequestModel> products)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetCreateProducsUrl(), requestBody), products);

        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="products"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> DeleteProductsAsync(BulkModel<DeleteProductRequestModel> products)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetDeleteProductUrl(), requestBody), products);

        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="filterQuery"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<FilterProductsResponseModel?> FilterProductsAsync(string filterQuery)
    {
        return await InvokeRequestAsync<FilterProductsResponseModel>((client) => client.GetAsync(GetFilterProductsUrl() + filterQuery));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="batchRequestId"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<GetBatchRequestResultResponseModel> GetBatchRequestResultAsync(string batchRequestId)
    {
        return await InvokeRequestAsync<GetBatchRequestResultResponseModel>((client) => client.GetAsync(GetBatchRequestResultUrl(batchRequestId)));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns><inheritdoc/></returns>
    public async Task<GetBrandsResponseModel?> GetBrandsAsync()
    {
        return await InvokeRequestAsync<GetBrandsResponseModel>((client) => client.GetAsync(GetBrandsUrl()));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="categoryId"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<GetCategoryAttributesResponseModel?> GetCategoryAttributes(int categoryId)
    {
        return await InvokeRequestAsync<GetCategoryAttributesResponseModel>((client) => client.GetAsync(GetCategoryAttributesUrl(categoryId)));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns><inheritdoc/></returns>
    public async Task<GetCategoryTreeResponseModel?> GetCategoryTreeAsync()
    {
        return await InvokeRequestAsync<GetCategoryTreeResponseModel>((client) => client.GetAsync(GetCategoryTreeUrl()));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns><inheritdoc/></returns>
    public List<GetProviderResponseModel> GetProviders()
    {
        return Providers.GetProviders();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns><inheritdoc/></returns>
    public async Task<GetSuppliersAddressesResponseModel?> GetSuppliersAddressesAsync()
    {
        return await InvokeRequestAsync<GetSuppliersAddressesResponseModel>((client) => client.GetAsync(GetSupplierAddressUrl()));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="products"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> UpdatePriceAndInventoryAsync(BulkModel<UpdateStockAndPriceRequestModel> products)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PutAsync(GetUpdatePriceAndStockUrl(), requestBody), products);

        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="products"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> UpdateProductAsync(BulkModel<UpdateProductRequestModel> products)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PutAsync(GetUpdateProductUrl(), requestBody), products);

        return true;
    }
}