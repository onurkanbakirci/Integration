using Integration.Core;
using Integration.Marketplaces.Trendyol.Dtos.Category;
using Integration.Marketplaces.Trendyol.Dtos.Product;
using Integration.Marketplaces.Trendyol.Dtos.Supplier;
using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Constants;
using Integration.Marketplaces.Trendyol.Models.Brand;
using Integration.Marketplaces.Trendyol.Models.Category;
using Integration.Marketplaces.Trendyol.Models.Provider;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration;
public class TrendyolProductIntegration : TrendyolIntegrationBase, ITrendyolProductIntegration, IMarketplaceIntegration
{
    public string GetCreateProducsUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/v2/products";
    public string GetSupplierAddressUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/addresses";
    public string GetBrandsUrl() => $"{GetBaseUrl}brands";
    public string GetCategoryTreeUrl() => $"{GetBaseUrl}product-categories";
    public string GetCategoryAttributesUrl(int categoryId) => $"{GetBaseUrl}product-categories/{categoryId}/attributes";
    public string GetUpdateProductUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/v2/products";
    public string GetUpdatePriceAndStockUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/products/price-and-inventory";
    public string GetDeleteProductUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/v2/products";
    public string GetBatchRequestResultUrl(string batchRequestId) => $"{GetBaseUrl}suppliers/{_supplierId}/products/batch-requests/{batchRequestId}";
    public string GetFilterProductsUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/products";
    public TrendyolProductIntegration(string supplierId, string apiKey, string apiSecret, bool isInProduction, string entegratorFirm) : base(supplierId, apiKey, apiSecret, isInProduction, entegratorFirm)
    {
    }

    public async Task<bool> CreateProductsV2Async(BulkDto<AddProductDto> products)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetCreateProducsUrl(), requestBody), products);

        return true;
    }

    public async Task<bool> DeleteProductsAsync(BulkDto<DeleteProductDto> products)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetDeleteProductUrl(), requestBody), products);

        return true;
    }

    public async Task<GetProductsDto?> FilterProductsAsync(string filterQuery)
    {
        return await InvokeRequestAsync<GetProductsDto>((client) => client.GetAsync(GetFilterProductsUrl() + filterQuery));
    }

    public async Task<GetBatchRequestResultDto> GetBatchRequestResultAsync(string batchRequestId)
    {
        return await InvokeRequestAsync<GetBatchRequestResultDto>((client) => client.GetAsync(GetBatchRequestResultUrl(batchRequestId)));
    }

    public async Task<List<Brand>?> GetBrandsAsync()
    {
        return await InvokeRequestAsync<List<Brand>>((client) => client.GetAsync(GetBrandsUrl()));
    }

    public async Task<GetCategoryAttribute?> GetCategoryAttributes(int categoryId)
    {
        return await InvokeRequestAsync<GetCategoryAttribute>((client) => client.GetAsync(GetCategoryAttributesUrl(categoryId)));
    }

    public async Task<List<Category>?> GetCategoryTreeAsync()
    {
        return await InvokeRequestAsync<List<Category>>((client) => client.GetAsync(GetCategoryTreeUrl()));
    }

    public List<Provider> GetProviders()
    {
        return Providers.GetProviders();
    }

    public async Task<List<GetSupplierDto>?> GetSuppliersAddressesAsync()
    {
        return await InvokeRequestAsync<List<GetSupplierDto>>((client) => client.GetAsync(GetSupplierAddressUrl()));
    }

    public async Task<bool> UpdatePriceAndInventoryAsync(BulkDto<UpdateStockAndPriceDto> products)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PutAsync(GetUpdatePriceAndStockUrl(), requestBody), products);

        return true;
    }

    public async Task<bool> UpdateProductAsync(BulkDto<UpdateProductDto> products)
    {
        var response = await InvokeRequestAsync((client, requestBody) => client.PutAsync(GetUpdateProductUrl(), requestBody), products);

        return true;
    }
}