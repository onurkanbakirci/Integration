using Integration.Hub;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Response;

public class GetCategoryTreeResponseModel : IResponseModel
{
    public List<CategoryResponseModel> Categories { get; set; }
}

public class CategoryResponseModel : IResponseModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ParentId { get; set; }
    public List<CategoryResponseModel> SubCategories { get; set; }
}