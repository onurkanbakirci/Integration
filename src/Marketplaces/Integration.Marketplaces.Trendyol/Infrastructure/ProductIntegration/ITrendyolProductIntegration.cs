using Integration.Core;
using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Request;
using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Response;
using Integration.Marketplaces.Trendyol.Models.Provider;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration;

public interface ITrendyolProductIntegration
{
    public Task<GetSuppliersAddressesResponseModel?> GetSuppliersAddressesAsync();
    public List<GetProviderResponseModel> GetProviders();
    public Task<GetBrandsResponseModel?> GetBrandsAsync();
    public Task<GetCategoryTreeResponseModel?> GetCategoryTreeAsync();
    public Task<GetCategoryAttributesResponseModel?> GetCategoryAttributes(int categoryId);
    public Task<bool> CreateProductsV2Async(BulkModel<CreateProductRequestModel> products);
    public Task<bool> UpdateProductAsync(BulkModel<UpdateProductRequestModel> products);
    public Task<bool> UpdatePriceAndInventoryAsync(BulkModel<UpdateStockAndPriceRequestModel> products);
    public Task<bool> DeleteProductsAsync(BulkModel<DeleteProductRequestModel> products);
    public Task<GetBatchRequestResultResponseModel> GetBatchRequestResultAsync(string batchRequestId);
    public Task<FilterProductsResponseModel?> FilterProductsAsync(string filterQuery);
}