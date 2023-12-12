using Integration.Core;
using Integration.Marketplaces.Trendyol.Models.Product;

namespace Integration.Marketplaces.Trendyol.Dtos.Product;

public class AddProductDto : IDto
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

    public AddProductDto(string barcode, string title, string productMainId, int brandId, int categoryId, int quantity, string stockCode, int dimensionalWeight, string description, string currencyType, double listPrice, double salePrice, int vatRate, int cargoCompanyId, int? shipmentAddressId, int? returningAddressId, int? deliveryDuration)
    {
        Barcode = barcode;
        Title = title;
        ProductMainId = productMainId;
        BrandId = brandId;
        CategoryId = categoryId;
        Quantity = quantity;
        StockCode = stockCode;
        DimensionalWeight = dimensionalWeight;
        Description = description;
        CurrencyType = currencyType;
        ListPrice = listPrice;
        SalePrice = salePrice;
        VatRate = vatRate;
        CargoCompanyId = cargoCompanyId;
        ShipmentAddressId = shipmentAddressId;
        ReturningAddressId = returningAddressId;
        DeliveryDuration = deliveryDuration;
    }

    public AddProductDto SetDeliveryOption(int? deliveryDuration, string fastDeliveryType)
    {
        DeliveryOption = new ProductDeliveryOption(deliveryDuration, fastDeliveryType);
        return this;
    }

    public AddProductDto AddProductImage(string url)
    {
        if (!Images.Any())
            Images = new List<ProductImage>();

        Images.Add(new ProductImage(url));
        return this;
    }

    public AddProductDto AddProductCategoryAttribute(int attributeId, int? attributeValueId, string? customAttributeValue)
    {
        if (!Attributes.Any())
            Attributes = new List<AddProductCategoryAttributeDto>();

        Attributes.Add(new AddProductCategoryAttributeDto(attributeId, attributeValueId, customAttributeValue));
        return this;
    }
}