using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Response;
public class SipayBaseResponseModel<TResponse> : IResponseModel
{
    public bool StatusCode { get; set; }
    public int StatusDescription { get; set; }
    public TResponse Data { get; set; }
}