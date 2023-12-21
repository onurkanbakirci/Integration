using Integration.Hub;
namespace Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Request;
public class SplitMultiPackageByQuantityRequestModel : IRequestModel
{
    public List<SplitMultiPackageByQuantitySplitPackageRequestModel> SplitPackages { get; set; }
}

public class SplitMultiPackageByQuantitySplitPackageRequestModel : IRequestModel
{
    public List<SplitMultiPackageByQuantityPackageDetailRequestModel> PackageDetails { get; set; }
}

public class SplitMultiPackageByQuantityPackageDetailRequestModel : IRequestModel
{
    public int OrderLineId { get; set; }
    public int Quantities { get; set; }
}