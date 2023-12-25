using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration;

namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration;
public class SipayPaymentIntegration : SipayIntegrationBase, ISipayAuthIntegration
{
    private string GetTokentUrl() => $"{GetBaseUrl()}api/token";

    public SipayPaymentIntegration(string merchantKey, string appKey, string appSecret, int merchantId, bool isInProduction = true) : base(merchantKey, appKey, appSecret, merchantId, isInProduction)
    {
    }

    public async Task<GetAuthTokenResponseModel> GetAuthTokenAsync(GetAuthTokenRequestModel requestModel)
    {
        return await InvokeRequestAsync<GetAuthTokenResponseModel>((client, requestBody) => client.PostAsync(GetTokentUrl(), requestBody), requestModel);
    }
}