using Integration.Hub;
namespace Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Request;
public class UpdateTrackingNumberRequestModel : IRequestModel
{
    public string TrackingNumber { get; set; }
    public UpdateTrackingNumberRequestModel(string trackingNumber)
    {
        TrackingNumber = trackingNumber;
    }
}