using System.Text.Json;
using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration;
public class SipayIntegrationBase : IntegrationBase
{
    public const string ProdBaseUrl = "https://app.sipay.com.tr/ccpayment/";
    public const string StageBaseUrl = "https://provisioning.sipay.com.tr/ccpayment/";
    protected readonly string _merchantKey;
    protected readonly string _appKey;
    protected readonly string _appSecret;
    protected readonly int _merchantId;
    protected readonly bool _isInProduction;

    public SipayIntegrationBase(string merchantKey, string appKey, string appSecret, int merchantId, bool isInProduction = true)
    {
        _merchantKey = merchantKey ?? throw new ArgumentNullException(nameof(merchantKey));
        _appKey = appKey ?? throw new ArgumentNullException(nameof(appKey));
        _appSecret = appSecret ?? throw new ArgumentNullException(nameof(appSecret));
        _merchantId = merchantId;
        _isInProduction = isInProduction;

        InitializeDefaultHeaders(new Dictionary<string, string>
        {
            { "Accept", "application/json" },
        });

        SetSerializerOptions(new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        });
    }

    public string GetBaseUrl() => _isInProduction ? ProdBaseUrl : StageBaseUrl;
}