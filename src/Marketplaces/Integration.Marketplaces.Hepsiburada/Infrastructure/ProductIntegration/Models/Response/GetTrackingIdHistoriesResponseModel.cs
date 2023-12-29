using Integration.Hub;
namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;
public class GetTrackingIdHistoriesResponseModel : IResponseModel
{
    public string CreatedDate { get; set; }
    public string TrackingId { get; set; }
}

