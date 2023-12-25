using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;
public class SecurePaymentChargeRequestModel : IRequestModel
{
    public SecurePaymentChargeRequestModel(string invoiceId, string orderId, string status, string hashKey)
    {
        InvoiceId = invoiceId;
        OrderId = orderId;
        Status = status;
        HashKey = hashKey;
    }

    public string MerchantKey { get; set; }
    public string InvoiceId { get; set; }
    public string OrderId { get; set; }
    public string Status { get; set; }
    public string HashKey { get; set; }
}