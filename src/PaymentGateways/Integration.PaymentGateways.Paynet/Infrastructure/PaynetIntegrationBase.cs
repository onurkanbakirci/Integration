using System.Text;
using System.Text.Json;
using Integration.Hub;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration;
public class PaynetIntegrationBase : IntegrationBase
{
    public const string ProdBaseUrl = "https://api.paynet.com.tr/";
    public const string StageBaseUrl = "https://pts-api.paynet.com.tr/";
    protected readonly string _secretKey;
    protected readonly bool _isInProduction;

    public PaynetIntegrationBase(string secretKey, bool isInProduction = true)
    {
        _secretKey = secretKey ?? throw new ArgumentNullException(nameof(secretKey));
        _isInProduction = isInProduction;

        InitializeDefaultHeaders(new Dictionary<string, string>
        {
            { "Accept", "application/json" },
            { "Authorization", $"Basic {Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_secretKey}"))}"}
        });

        SetSerializerOptions(new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        });
    }

    public string GetBaseUrl() => _isInProduction ? ProdBaseUrl : StageBaseUrl;
}