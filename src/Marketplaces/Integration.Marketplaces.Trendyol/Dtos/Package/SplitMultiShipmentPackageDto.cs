using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Dtos.Package;
public class SplitMultiShipmentPackageDto : IDto
{
    public List<SplitGroup> SplitGroups { get; set; }
}

public class SplitGroup : IDto
{
    public List<int> OrderLineIds { get; set; }
}