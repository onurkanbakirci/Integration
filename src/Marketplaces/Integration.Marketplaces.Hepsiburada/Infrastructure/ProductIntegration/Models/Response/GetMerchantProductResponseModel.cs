using Integration.Hub;
namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;
public class GetMerchantProductResponseModel : IResponseModel
{
    public string MerchantSku { get; set; }
    public string Barcode { get; set; }
    public string HbSku { get; set; }
    public string VariantGroupId { get; set; }
    public string ProductName { get; set; }
    public string Brand { get; set; }
    public List<string> Images { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Tax { get; set; }
    public string Price { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public List<GetMerchantProductBaseAttributeResponseModel> BaseAttributes { get; set; }
    public List<GetMerchantProductVariantTypeAttributeResponseModel> VariantTypeAttributes { get; set; }
    public List<GetMerchantProductProductAttributeResponseModel> ProductAttributes { get; set; }
    public List<GetMerchantProductValidationResultResponseModel> ValidationResults { get; set; }
    public string RejectReasons { get; set; }
}

public class GetMerchantProductBaseAttributeResponseModel : IResponseModel
{
    public string Name { get; set; }
    public string Value { get; set; }
    public bool Mandatory { get; set; }
}

public class GetMerchantProductVariantTypeAttributeResponseModel : IResponseModel
{
    public string Name { get; set; }
    public string Value { get; set; }
    public bool Mandatory { get; set; }
}

public class GetMerchantProductProductAttributeResponseModel : IResponseModel
{
    public string Name { get; set; }
    public string Value { get; set; }
    public bool Mandatory { get; set; }
}

public class GetMerchantProductValidationResultResponseModel : IResponseModel
{
    public string AttributeName { get; set; }
    public string Message { get; set; }
}