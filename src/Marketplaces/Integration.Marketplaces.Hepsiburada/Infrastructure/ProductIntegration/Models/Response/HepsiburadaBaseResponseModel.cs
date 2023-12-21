using Integration.Hub;

namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;
public class HepsiburadaBaseResponseModel : IResponseModel
{
    public bool Success { get; set; }
    public int Code { get; set; }
    public int Version { get; set; }
    public string Message { get; set; }
}