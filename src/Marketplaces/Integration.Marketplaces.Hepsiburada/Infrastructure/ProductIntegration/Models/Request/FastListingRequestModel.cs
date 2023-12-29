using Integration.Hub;
namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Request;
public class FastListingRequestModel : IRequestModel
{
    public FastListingRequestModel(string merchant, string merchantSku, string productName, string barcode, string? stock = null, string? price = null, long? itemOrderId = null)
    {
        Merchant = merchant;
        MerchantSku = merchantSku;
        ProductName = productName;
        Barcode = barcode;
        Stock = stock;
        Price = price;
        ItemOrderId = itemOrderId;
    }

    public string Merchant { get; set; }
    public string MerchantSku { get; set; }
    public string ProductName { get; set; }
    public string Barcode { get; set; }
    public string? Stock { get; set; }
    public string? Price { get; set; }
    public long? ItemOrderId { get; set; }
}