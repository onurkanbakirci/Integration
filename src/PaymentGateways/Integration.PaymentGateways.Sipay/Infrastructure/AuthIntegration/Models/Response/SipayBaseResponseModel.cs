using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Response;
public class SipayBaseResponseModel<TResponse> : IResponseModel
{
    public int StatusCode { get; set; }
    public string StatusDescription { get; set; }
    public TResponse Data { get; set; }
}