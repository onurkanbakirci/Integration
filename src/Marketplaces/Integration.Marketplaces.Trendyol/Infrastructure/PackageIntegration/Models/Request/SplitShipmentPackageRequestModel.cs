using Integration.Hub;
namespace Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Request;
public class SplitShipmentPackageRequestModel : IRequestModel
{
    public List<int> OrderLineIds { get; set; }
}