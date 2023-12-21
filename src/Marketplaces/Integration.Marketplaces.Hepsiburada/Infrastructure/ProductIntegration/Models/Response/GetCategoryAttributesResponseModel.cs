using Integration.Core;

namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;

public class GetCategoryAttributesResponseModel : HepsiburadaBaseResponseModel
{
    public List<GetCategoryAttributesMappingResponseModel> Data { get; set; }
}

public class GetCategoryAttributesMappingResponseModel : IResponseModel
{
    public List<GetCategoryAttributeResponseModel> BaseAttributes { get; set; }
    public List<GetCategoryAttributeResponseModel> Attributes { get; set; }
    public List<GetCategoryAttributeResponseModel> VariantAttributes { get; set; }
}

public class GetCategoryAttributeResponseModel : IResponseModel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public bool Mandatory { get; set; }
    public string Type { get; set; }
    public bool MultiValue { get; set; }
}