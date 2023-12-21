using Integration.Hub;

namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;

public class GetCategoriesResponseModel : HepsiburadaBaseResponseModel
{
    public List<GetCategoryResponseModel> Data { get; set; }
}

public class GetCategoryResponseModel : IResponseModel
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public int ParentCategoryId { get; set; }
    public List<string> Paths { get; set; }
    public bool Leaf { get; set; }
    public string Status { get; set; }
    public string Type { get; set; }
    public string SortId { get; set; }
    public bool Available { get; set; }
    public List<GetCategoryProductTypeResponseModel> ProductTypes { get; set; }
    public bool Merge { get; set; }
}

public class GetCategoryProductTypeResponseModel : IResponseModel
{
    public string Name { get; set; }
    public int ProductTypeId { get; set; }
}