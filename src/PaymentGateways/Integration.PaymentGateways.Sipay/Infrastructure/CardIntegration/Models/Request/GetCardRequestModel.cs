using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Request;
public class GetCardRequestModel : IRequestModel
{
    public GetCardRequestModel(string merchantKey, int customerNumber)
    {
        MerchantKey = merchantKey;
        CustomerNumber = customerNumber;
    }

    public string MerchantKey { get; set; }
    public int CustomerNumber { get; set; }
}