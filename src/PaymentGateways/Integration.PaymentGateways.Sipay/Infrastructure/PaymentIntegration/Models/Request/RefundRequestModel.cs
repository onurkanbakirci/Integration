using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Response;
public class RefundRequestModel : IRequestModel
{
    public RefundRequestModel(string invoiceId, double amount, string refundTransactionId, string? refundWebhookKey = null)
    {
        InvoiceId = invoiceId;
        Amount = amount;
        RefundTransactionId = refundTransactionId;
        RefundWebhookKey = refundWebhookKey;
    }

    public string InvoiceId { get; set; }
    public double Amount { get; set; }
    public string AppId { get; set; }
    public string AppSecret { get; set; }
    public string MerchantKey { get; set; }
    public string HashKey { get; set; }
    public string RefundTransactionId { get; set; }
    public string? RefundWebhookKey { get; set; }


    public RefundRequestModel SetMerchantKey(string merchantKey)
    {
        MerchantKey = merchantKey;
        return this;
    }
    public RefundRequestModel SetAppSecret(string appSecret)
    {
        AppSecret = appSecret;
        return this;
    }
    public RefundRequestModel SetAppId(string appId)
    {
        AppId = appId;
        return this;
    }
}