using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Response;

public class GetCategoryAttributesResponseModel : IResponseModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public List<CategoryAttributeResponseModel> CategoryAttributes { get; set; }
}

public class CategoryAttributeResponseModel : IResponseModel
{
    public int CategoryId { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Required { get; set; }
    public bool AllowCustom { get; set; }
    public bool Varianter { get; set; }
    public bool Slicer { get; set; }
    public List<CategoryAttributeValueResponseModel> AttributeValues { get; set; }
}

public class CategoryAttributeValueResponseModel : IResponseModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}