using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Dtos.Product;

public class DeleteProductDto : IDto
{
    public string Barcode { get; set; }
}