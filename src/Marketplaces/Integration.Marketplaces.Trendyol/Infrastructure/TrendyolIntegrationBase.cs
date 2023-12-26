using System.Text;
using System.Text.Json;
using Integration.Hub;

namespace Integration.Marketplaces.Trendyol.Infrastructure;
public class TrendyolIntegrationBase : IntegrationBase
{
    public const string ProdBaseUrl = "https://api.trendyol.com/sapigw/";
    public const string StageBaseUrl = "https://stageapi.trendyol.com/stagesapigw/";
    protected readonly string _supplierId;
    protected readonly string _apiKey;
    protected readonly string _apiSecret;
    protected readonly string _entegratorFirm;
    protected readonly bool _isInProduction;

    public TrendyolIntegrationBase(string supplierId, string apiKey, string apiSecret, bool isInProduction = true, string entegratorFirm = "SelfIntegration")
    {
        _supplierId = supplierId ?? throw new ArgumentNullException(nameof(supplierId));
        _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        _apiSecret = apiSecret ?? throw new ArgumentNullException(nameof(apiSecret));
        _isInProduction = isInProduction;
        _entegratorFirm = entegratorFirm;

        InitializeDefaultHeaders(new Dictionary<string, string>
        {
            { "Accept", "application/json" },
            { "User-Agent", $"{_supplierId} - {_entegratorFirm}" },
            { "Authorization", $"Basic {Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_apiKey}:{_apiSecret}"))}"}
        });

        SetSerializerOptions(new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        });
    }

    public string GetBaseUrl() => _isInProduction ? ProdBaseUrl : StageBaseUrl;
}