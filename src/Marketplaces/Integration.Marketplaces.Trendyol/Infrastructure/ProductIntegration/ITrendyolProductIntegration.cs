using Integration.Core;
using Integration.Marketplaces.Trendyol.Dtos.Category;
using Integration.Marketplaces.Trendyol.Dtos.Product;
using Integration.Marketplaces.Trendyol.Dtos.Supplier;
using Integration.Marketplaces.Trendyol.Models.Brand;
using Integration.Marketplaces.Trendyol.Models.Category;
using Integration.Marketplaces.Trendyol.Models.Provider;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration;

public interface ITrendyolProductIntegration
{
    public Task<List<GetSupplierDto>?> GetSuppliersAddressesAsync();
    public List<Provider> GetProviders();
    public Task<List<Brand>?> GetBrandsAsync();
    public Task<List<Category>?> GetCategoryTreeAsync();
    public Task<GetCategoryAttribute?> GetCategoryAttributes(int categoryId);
    public Task<bool> CreateProductsV2Async(BulkDto<AddProductDto> products);
    public Task<bool> UpdateProductAsync(BulkDto<UpdateProductDto> products);
    public Task<bool> UpdatePriceAndInventoryAsync(BulkDto<UpdateStockAndPriceDto> products);
    public Task<bool> DeleteProductsAsync(BulkDto<DeleteProductDto> products);
    public Task<GetBatchRequestResultDto> GetBatchRequestResultAsync(string batchRequestId);
    public Task<GetProductsDto?> FilterProductsAsync(string filterQuery);
}