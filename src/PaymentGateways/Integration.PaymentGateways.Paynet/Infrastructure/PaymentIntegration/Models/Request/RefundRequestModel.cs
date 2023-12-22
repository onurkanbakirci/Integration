using Integration.Hub;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;

public class RefundRequestModel : IRequestModel
{
    public string XactId { get; set; }

    public string Amount { get; set; }

    public string SucceedUrl { get; set; }
}