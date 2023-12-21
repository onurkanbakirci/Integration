using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration;
using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Helpers;

var trendyolProductIntegration = new TrendyolProductIntegration(
        supplierId: "supplierId",
        apiKey: "apiKey",
        apiSecret: "apiSecret",
        isInProduction: false,
        entegratorFirm: "entegratorFirm");

//Get All Categories
var categories = await trendyolProductIntegration.GetCategoryTreeAsync();

//Get All Brands
var brands = await trendyolProductIntegration.GetBrandsAsync();

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

var products = await trendyolProductIntegration.FilterProductsAsync(productFilter);