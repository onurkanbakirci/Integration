using PackageModel = Integration.Marketplaces.Trendyol.Models.Package.Package;

namespace Integration.Marketplaces.Trendyol.Dtos.Package;

public class GetShipmentPackagesDto : PaginationDto
{
    public List<PackageModel> Contents { get; set; }
}