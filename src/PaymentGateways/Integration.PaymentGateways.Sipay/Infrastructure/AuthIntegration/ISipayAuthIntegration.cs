using Integration.Hub;
using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Response;

namespace Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration;
public interface ISipayAuthIntegration : IAuthIntegration
{
    public Task<SipayBaseResponseModel<GetAuthTokenResponseModel>> GetAuthTokenAsync(GetAuthTokenRequestModel requestModel);
}