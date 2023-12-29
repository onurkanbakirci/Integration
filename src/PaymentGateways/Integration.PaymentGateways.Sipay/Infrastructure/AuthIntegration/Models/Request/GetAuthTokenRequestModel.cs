using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Request;

public class GetAuthTokenRequestModel : IRequestModel
{
    public string AppId { get; set; }
    public string AppSecret { get; set; }
    public GetAuthTokenRequestModel(string appId, string appSecret)
    {
        AppId = appId;
        AppSecret = appSecret;
    }
}