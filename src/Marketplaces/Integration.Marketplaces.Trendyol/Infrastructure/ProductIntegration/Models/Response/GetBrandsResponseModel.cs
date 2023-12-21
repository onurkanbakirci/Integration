using Integration.Hub;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Response;

public class GetBrandsResponseModel : IResponseModel
{
    public List<BrandResponseModel> Brands { get; set; }
}

public class BrandResponseModel: IResponseModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}