using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;
public class SecurePaymentChargeRequestModel : IRequestModel
{
    public SecurePaymentChargeRequestModel(string invoiceId, string orderId, string status)
    {
        InvoiceId = invoiceId;
        OrderId = orderId;
        Status = status;
    }
    public string MerchantKey { get; set; }
    public string InvoiceId { get; set; }
    public string OrderId { get; set; }
    public string Status { get; set; }
    public string HashKey { get; set; }
    public SecurePaymentChargeRequestModel SetMerchantKey(string merchantKey)
    {
        MerchantKey = merchantKey;
        return this;
    }
}