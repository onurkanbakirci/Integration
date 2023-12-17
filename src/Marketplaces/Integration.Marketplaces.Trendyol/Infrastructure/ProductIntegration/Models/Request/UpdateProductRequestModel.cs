using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Request;

public class UpdateProductRequestModel : IRequestModel
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

    public UpdateProductDeliveryOptionRequestModel? DeliveryOption { get; set; }

    public List<UpdateProductImageRequestModel> Images { get; set; }

    public List<UpdateProductCategoryAttributeRequestModel> Attributes { get; set; }
}

public class UpdateProductDeliveryOptionRequestModel : IRequestModel
{
    public int? DeliveryDuration { get; set; }
    public string FastDeliveryType { get; set; }
    public UpdateProductDeliveryOptionRequestModel(int? deliveryDuration, string fastDeliveryType)
    {
        DeliveryDuration = deliveryDuration;
        FastDeliveryType = fastDeliveryType;
    }
}

public class UpdateProductImageRequestModel : IRequestModel
{
    public string Url { get; set; }

    public UpdateProductImageRequestModel(string url)
    {
        Url = url;
    }
}

public class UpdateProductCategoryAttributeRequestModel : IRequestModel
{
    public int AttributeId { get; set; }
    public int? AttributeValueId { get; set; }
    public string? CustomAttributeValue { get; set; }
    public UpdateProductCategoryAttributeRequestModel(int attributeId, int? attributeValueId, string? customAttributeValue)
    {
        AttributeId = attributeId;
        AttributeValueId = attributeValueId;
        CustomAttributeValue = customAttributeValue;
    }
}