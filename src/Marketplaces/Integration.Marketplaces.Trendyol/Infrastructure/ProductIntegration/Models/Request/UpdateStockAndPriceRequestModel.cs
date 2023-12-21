using Integration.Hub;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Request;

public class UpdateStockAndPriceRequestModel : IRequestModel
{
    public string Barcode { get; set; }
    public int Quantity { get; set; }
    public double SalePrice { get; set; }
    public double ListPrice { get; set; }
}