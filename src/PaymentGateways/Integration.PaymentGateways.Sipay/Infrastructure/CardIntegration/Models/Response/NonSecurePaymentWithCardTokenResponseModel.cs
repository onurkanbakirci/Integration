using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Response;
public class NonSecurePaymentWithCardTokenResponseModel : IResponseModel
{
    public int SipayStatus { get; set; }
    public string OrderNo { get; set; }
    public string OrderId { get; set; }
    public string InvoiceId { get; set; }
    public int SipayPaymentMethod { get; set; }
    public string CreditCardNo { get; set; }
    public string TransactionType { get; set; }
    public int PaymentStatus { get; set; }
    public int PaymentMethod { get; set; }
    public int ErrorCode { get; set; }
    public string Error { get; set; }
    public string HashKey { get; set; }
}