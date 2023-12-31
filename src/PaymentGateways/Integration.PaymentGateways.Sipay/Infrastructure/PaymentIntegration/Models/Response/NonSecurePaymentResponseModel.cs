using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;
public class NonSecurePaymentResponseModel : IResponseModel
{
    public int Status { get; set; }
    public string OrderNo { get; set; }
    public string InvoiceId { get; set; }
    public int StatusCode { get; set; }
    public string StatusDescription { get; set; }
    public int PaymentMethod { get; set; }
    public string TransactionType { get; set; }
    public int ErrorCode { get; set; }
    public string Error { get; set; }
    public string HashKey { get; set; }
}