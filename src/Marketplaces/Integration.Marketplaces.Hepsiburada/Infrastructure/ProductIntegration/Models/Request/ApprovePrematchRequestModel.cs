using Integration.Hub;
namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Request;
public class ApprovePrematchRequestModel : IRequestModel
{
    public ApprovePrematchRequestModel(string merchant, List<string> merchantSkuList)
    {
        Merchant = merchant;
        MerchantSkuList = merchantSkuList;
    }

    public string Merchant { get; set; }
    public List<string> MerchantSkuList { get; set; }
}