using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Request;

public class UpdateCardRequestModel : IRequestModel
{
    public UpdateCardRequestModel(string merchantKey, string cardToken, int customerNumber, int expiryMonth, int expiryYear, string hashKey)
    {
        MerchantKey = merchantKey;
        CardToken = cardToken;
        CustomerNumber = customerNumber;
        ExpiryMonth = expiryMonth;
        ExpiryYear = expiryYear;
        HashKey = hashKey;
    }

    public string MerchantKey { get; set; }
    public string CardToken { get; set; }
    public int CustomerNumber { get; set; }
    public int ExpiryMonth { get; set; }
    public int ExpiryYear { get; set; }
    public string HashKey { get; set; }
    public string CardHolderName { get; set; }
}