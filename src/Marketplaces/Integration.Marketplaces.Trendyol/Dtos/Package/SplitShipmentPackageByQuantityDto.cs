using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Dtos.Package;
public class SplitShipmentPackageByQuantityDto : IDto
{
    public List<QuantitySplit> QuantitySplit { get; set; }
}

public class QuantitySplit : IDto
{
    public int OrderLineId { get; set; }
    public List<int> Quantities { get; set; }
}