using System.Text;
using System.Text.Json;
using Integration.Hub;

namespace Integration.Marketplaces.Trendyol.Infrastructure;
public class HepsiburadaIntegrationBase : IntegrationBase
{
    public const string ProdBaseUrl = "https://mpop-sit.hepsiburada.com/";
    public const string StageBaseUrl = "https://mpop-sit.hepsiburada.com/";
    protected readonly string _username;
    protected readonly string _password;
    protected readonly bool _isInProduction;

    public HepsiburadaIntegrationBase(string username, string password, bool isInProduction = true)
    {
        _username = username ?? throw new ArgumentNullException(nameof(username));
        _password = password ?? throw new ArgumentNullException(nameof(password));
        _isInProduction = isInProduction;

        InitializeDefaultHeaders(new Dictionary<string, string>
        {
            { "Accept", "application/json" },
            { "Authorization", $"Basic {Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_username}:{_password}"))}"}
        });

        SetSerializerOptions(new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        });
    }

    public string GetBaseUrl() => _isInProduction ? ProdBaseUrl : StageBaseUrl;
}