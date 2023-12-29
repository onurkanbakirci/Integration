using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Response;
public class GetAuthTokenResponseModel : IResponseModel
{
    public string Token { get; set; }
    public int Is3D { get; set; }
    public string ExpiresAt { get; set; }
}