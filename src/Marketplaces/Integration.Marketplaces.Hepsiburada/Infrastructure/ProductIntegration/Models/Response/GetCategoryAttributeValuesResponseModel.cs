using Integration.Hub;

namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;

public class GetCategoryAttributeValuesResponseModel : HepsiburadaBaseResponseModel
{
    public List<GetCategoryAttributeValueResponseModel> Data { get; set; }
}

public class GetCategoryAttributeValueResponseModel : IResponseModel
{
    public string Value { get; set; }
}