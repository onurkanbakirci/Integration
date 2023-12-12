using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Dtos.Package;
public class SplitMultiPackageByQuantityDto : IDto
{
    public List<SplitPackages> SplitPackages { get; set; }
}

public class SplitPackages : IDto
{
    public List<PackageDetail> PackageDetails { get; set; }
}

public class PackageDetail : IDto
{
    public int OrderLineId { get; set; }
    public int Quantities { get; set; }
}