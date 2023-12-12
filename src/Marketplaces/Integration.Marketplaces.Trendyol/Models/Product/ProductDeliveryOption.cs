using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Models.Product;
public class ProductDeliveryOption : IModel
{
    public int? DeliveryDuration { get; set; }
    public string FastDeliveryType { get; set; }
    public ProductDeliveryOption(int? deliveryDuration, string fastDeliveryType)
    {
        DeliveryDuration = deliveryDuration;
        FastDeliveryType = fastDeliveryType;
    }
}