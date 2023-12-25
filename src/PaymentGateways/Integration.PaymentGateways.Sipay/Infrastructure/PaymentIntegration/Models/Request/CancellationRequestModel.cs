using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Response;
public class CancellationRequestModel : IRequestModel
{
    public CancellationRequestModel(string invoiceId, string hashKey, string refundTransactionId, string? refundWebhookKey = null)
    {
        InvoiceId = invoiceId;
        HashKey = hashKey;
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
}