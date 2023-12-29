using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration;
using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Response;

namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration;
public class SipayAuthIntegration : SipayIntegrationBase, ISipayAuthIntegration
{
    private string GetTokentUrl() => $"{GetBaseUrl()}api/token";

    public SipayAuthIntegration(string merchantKey, string appKey, string appSecret, int merchantId, bool isInProduction = true) : base(merchantKey, appKey, appSecret, merchantId, isInProduction)
    {
    }

    public async Task<SipayBaseResponseModel<GetAuthTokenResponseModel>> GetAuthTokenAsync(GetAuthTokenRequestModel requestModel)
    {
        return await InvokeRequestAsync<GetAuthTokenRequestModel, SipayBaseResponseModel<GetAuthTokenResponseModel>>((client, requestBody) => client.PostAsync(GetTokentUrl(), requestBody), requestModel);
    }
}