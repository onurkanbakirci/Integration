using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration;
public interface ISipayAuthIntegration : IAuthIntegration
{
    Task<GetAuthTokenResponseModel> GetAuthTokenAsync(GetAuthTokenRequestModel requestModel);
}