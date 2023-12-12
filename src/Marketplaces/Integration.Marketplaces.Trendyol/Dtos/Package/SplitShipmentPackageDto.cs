using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Dtos.Package;
public class SplitShipmentPackageDto : IDto
{
    public List<int> OrderLineIds { get; set; }
}