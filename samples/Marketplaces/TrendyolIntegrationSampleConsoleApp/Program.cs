using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration;
using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Helpers;

var trendyolProductIntegration = new TrendyolProductIntegration("supplierId", "apiKey", "apiSecret", false, "entegratorFirm");

//Get All Categories
var categories = trendyolProductIntegration.GetCategoryTreeAsync();

//Get All Brands
var brands = trendyolProductIntegration.GetBrandsUrl();

//Filter products
var productFilter = new ProductFilterBuilder()
    .AddApprovalStatus(true)
    .AddBarcode("barcode")
    .AddStartDate(0)
    .AddEndDate(0)
    .AddPage(1)
    .AddSize(10)
    .AddSupplierId(0)
    .Build();

var products = trendyolProductIntegration.FilterProductsAsync(productFilter);