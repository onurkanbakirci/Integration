using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Request;

public class CreateProductRequestModel : IRequestModel
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

    public ProductDeliveryOptionRequestModel? DeliveryOption { get; set; }

    public List<ProductImageRequestModel> Images { get; set; }

    public List<CreateProductCategoryAttributeRequestModel> Attributes { get; set; }

    public CreateProductRequestModel(string barcode, string title, string productMainId, int brandId, int categoryId, int quantity, string stockCode, int dimensionalWeight, string description, string currencyType, double listPrice, double salePrice, int vatRate, int cargoCompanyId, int? shipmentAddressId, int? returningAddressId, int? deliveryDuration)
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

    public CreateProductRequestModel SetDeliveryOption(int? deliveryDuration, string fastDeliveryType)
    {
        DeliveryOption = new ProductDeliveryOptionRequestModel(deliveryDuration, fastDeliveryType);
        return this;
    }

    public CreateProductRequestModel AddProductImage(string url)
    {
        if (!Images.Any())
            Images = new List<ProductImageRequestModel>();

        Images.Add(new ProductImageRequestModel(url));
        return this;
    }

    public CreateProductRequestModel AddProductCategoryAttribute(int attributeId, int? attributeValueId, string? customAttributeValue)
    {
        if (!Attributes.Any())
            Attributes = new List<CreateProductCategoryAttributeRequestModel>();

        Attributes.Add(new CreateProductCategoryAttributeRequestModel(attributeId, attributeValueId, customAttributeValue));
        return this;
    }
}

public class ProductDeliveryOptionRequestModel : IRequestModel
{
    public int? DeliveryDuration { get; set; }
    public string FastDeliveryType { get; set; }
    public ProductDeliveryOptionRequestModel(int? deliveryDuration, string fastDeliveryType)
    {
        DeliveryDuration = deliveryDuration;
        FastDeliveryType = fastDeliveryType;
    }
}

public class ProductImageRequestModel : IRequestModel
{
    public string Url { get; set; }

    public ProductImageRequestModel(string url)
    {
        Url = url;
    }
}

public class CreateProductCategoryAttributeRequestModel : IRequestModel
{
    public int AttributeId { get; set; }
    public int? AttributeValueId { get; set; }
    public string? CustomAttributeValue { get; set; }
    public CreateProductCategoryAttributeRequestModel(int attributeId, int? attributeValueId, string? customAttributeValue)
    {
        AttributeId = attributeId;
        AttributeValueId = attributeValueId;
        CustomAttributeValue = customAttributeValue;
    }
}