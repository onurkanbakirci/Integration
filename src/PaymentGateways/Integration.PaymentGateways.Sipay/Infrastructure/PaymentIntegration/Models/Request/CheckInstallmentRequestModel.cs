using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;
public class CheckInstallmentRequestModel : IRequestModel
{
    public CheckInstallmentRequestModel(string creditCard, double amount, string currencyCode, string? commissionBy = null, bool? isRecurring = null, bool? is2d = null)
    {
        CreditCard = creditCard;
        Amount = amount;
        CurrencyCode = currencyCode;
        CommissionBy = commissionBy;
        IsRecurring = isRecurring;
        Is2d = is2d;
    }

    public string CreditCard { get; set; }
    public double Amount { get; set; }
    public string CurrencyCode { get; set; }
    public string MerchantKey { get; set; }
    public string? CommissionBy { get; set; }
    public bool? IsRecurring { get; set; }
    public bool? Is2d { get; set; }
}