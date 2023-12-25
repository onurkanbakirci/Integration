using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration;
public class GetAuthTokenRequestModel : IRequestModel
{
    public GetAuthTokenRequestModel(string appId, string appSecret)
    {
        AppId = appId;
        AppSecret = appSecret;
    }

    public string AppId { get; set; }
    public string AppSecret { get; set; }
}