using Integration.Core;
using Integration.Marketplaces.Trendyol.Models.Product;

namespace Integration.Marketplaces.Trendyol.Dtos.Product;
public class UpdateProductDto : IDto
{
    public string Barcode { get; set; }

    public string Title { get; set; }

    public string ProductMainId { get; set; }

    public int BrandId { get; set; }

    public int CategoryId { get; set; }

    public int Quantity { get; set; }

    public string StockCode { get; set; }

    public int DimensionalWeight { get; set; }

    public string Description { get; set; }

    public string CurrencyType { get; set; }

    public double ListPrice { get; set; }

    public double SalePrice { get; set; }

    public int VatRate { get; set; }

    public int CargoCompanyId { get; set; }

    public int? ShipmentAddressId { get; set; }

    public int? ReturningAddressId { get; set; }

    public int? DeliveryDuration { get; set; }

    public ProductDeliveryOption? DeliveryOption { get; set; }

    public List<ProductImage> Images { get; set; }

    public List<AddProductCategoryAttributeDto> Attributes { get; set; }
}