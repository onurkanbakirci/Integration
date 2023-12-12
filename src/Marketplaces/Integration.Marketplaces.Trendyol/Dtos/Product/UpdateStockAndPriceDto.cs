using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Dtos.Product;

public class UpdateStockAndPriceDto : IDto
{
    public string Barcode { get; set; }
    public int Quantity { get; set; }
    public double SalePrice { get; set; }
    public double ListPrice { get; set; }
}