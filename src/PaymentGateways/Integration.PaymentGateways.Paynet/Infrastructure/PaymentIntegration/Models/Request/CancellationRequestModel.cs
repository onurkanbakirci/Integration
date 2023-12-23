using Integration.Hub;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;
public class CancellationRequestModel : IRequestModel
{
    public CancellationRequestModel(string xactId, string? succeedUrl = null)
    {
        XactId = xactId;
        SucceedUrl = succeedUrl;
    }

    public string XactId { get; set; }

    public string? SucceedUrl { get; set; }
}
