using Integration.Hub;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;
public class SecurePaymentChargeRequestModel : IRequestModel
{
    public string SessionId { get; set; }

    public string TokenId { get; set; }

    public int? TransactionType { get; set; }
}

