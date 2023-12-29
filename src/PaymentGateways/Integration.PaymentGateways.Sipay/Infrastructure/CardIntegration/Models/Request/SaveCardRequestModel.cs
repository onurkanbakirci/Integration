using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Request;
public class SaveCardRequestModel : IRequestModel
{
    public SaveCardRequestModel(string merchantKey, string cardHolderName, long cardNumber, int expiryMonth, int expiryYear, int customerNumber, string hashKey)
    {
        MerchantKey = merchantKey;
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        ExpiryMonth = expiryMonth;
        ExpiryYear = expiryYear;
        CustomerNumber = customerNumber;
        HashKey = hashKey;
    }

    public string MerchantKey { get; set; }
    public string CardHolderName { get; set; }
    public long CardNumber { get; set; }
    public int ExpiryMonth { get; set; }
    public int ExpiryYear { get; set; }
    public int CustomerNumber { get; set; }
    public string HashKey { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public long CustomerPhone { get; set; }
}