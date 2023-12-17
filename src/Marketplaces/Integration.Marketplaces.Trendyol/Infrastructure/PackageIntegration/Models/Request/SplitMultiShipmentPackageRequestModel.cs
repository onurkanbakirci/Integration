using Integration.Core;
namespace Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Request;
public class SplitMultiShipmentPackageRequestModel : IRequestModel
{
    public List<SplitMultiShipmentPackageSplitGroupRequestModel> SplitGroups { get; set; }
}

public class SplitMultiShipmentPackageSplitGroupRequestModel : IRequestModel
{
    public List<int> OrderLineIds { get; set; }
}