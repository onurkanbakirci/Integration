using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;
public class CheckInstallmentRequestModel : IRequestModel
{
    public CheckInstallmentRequestModel(string creaditCard, double amount, string currenyCode, string? commissionBy = null, bool? isRecurring = null, bool? is_2d = null)
    {
        CreaditCard = creaditCard;
        Amount = amount;
        CurrenyCode = currenyCode;
        CommissionBy = commissionBy;
        IsRecurring = isRecurring;
        Is_2d = is_2d;
    }

    public string CreaditCard { get; set; }
    public double Amount { get; set; }
    public string CurrenyCode { get; set; }
    public string MerchantKey { get; set; }
    public string? CommissionBy { get; set; }
    public bool? IsRecurring { get; set; }
    public bool? Is_2d { get; set; }
}