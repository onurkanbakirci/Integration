using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Dtos.Package;
public class UpdateTrackingNumberDto : IDto
{
    public string TrackingNumber { get; set; }
    public UpdateTrackingNumberDto(string trackingNumber)
    {
        TrackingNumber = trackingNumber;
    }
}