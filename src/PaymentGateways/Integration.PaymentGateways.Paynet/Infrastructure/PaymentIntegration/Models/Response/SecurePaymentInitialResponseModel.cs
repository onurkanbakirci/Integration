using Integration.Hub;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Response;

public class SecurePaymentInitialResponseModel : IResponseModel
{
    public string TokenId { get; set; }
    public string SessionId { get; set; }
    public string PostUrl { get; set; }
    public string HtmlContent { get; set; }
    public string ObjectName { get; set; }
    public int Code { get; set; }
    public string Message { get; set; }
}