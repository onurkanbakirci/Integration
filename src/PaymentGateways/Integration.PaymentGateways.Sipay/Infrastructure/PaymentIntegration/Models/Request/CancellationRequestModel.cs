using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Response;
public class CancellationRequestModel : IRequestModel
{
    public CancellationRequestModel(string invoiceId, string refundTransactionId, string? refundWebhookKey = null)
    {
        InvoiceId = invoiceId;
        RefundTransactionId = refundTransactionId;
        RefundWebhookKey = refundWebhookKey;
    }

    public string InvoiceId { get; set; }
    public string AppId { get; set; }
    public string AppSecret { get; set; }
    public string MerchantKey { get; set; }
    public string HashKey { get; set; }
    public string RefundTransactionId { get; set; }
    public string? RefundWebhookKey { get; set; }

    public CancellationRequestModel SetMerchantKey(string merchantKey)
    {
        MerchantKey = merchantKey;
        return this;
    }
    public CancellationRequestModel SetAppSecret(string appSecret)
    {
        AppSecret = appSecret;
        return this;
    }
    public CancellationRequestModel SetAppId(string appId)
    {
        AppId = appId;
        return this;
    }
}