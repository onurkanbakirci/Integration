using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Request;

public class DeleteCardRequestModel : IRequestModel
{
    public DeleteCardRequestModel(string merchantKey, string cardToken, int customerNumber, string hashKey)
    {
        MerchantKey = merchantKey;
        CardToken = cardToken;
        CustomerNumber = customerNumber;
        HashKey = hashKey;
    }

    public string MerchantKey { get; set; }
    public string CardToken { get; set; }
    public int CustomerNumber { get; set; }
    public string HashKey { get; set; }
}