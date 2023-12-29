using Integration.Hub;

namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;
public class GetProductByStatusResponseModel : IResponseModel
{
    public string MerchantSku { get; set; }
    public string Barcode { get; set; }
    public string HbSku { get; set; }
    public string VariantGroupId { get; set; }
    public string ProductName { get; set; }
    public string ProductStatus { get; set; }
    public List<GetProductsByStatusTaskResponseModel> TaskDetails { get; set; }
    public List<GetProductsByStatusValidationResultResponseModel> ValidationResults { get; set; }
    public List<GetProductsByStatusMatchedHbProductInfoResponseModel> MatchedHbProductInfo { get; set; }
    public string RejectReasonsMessages { get; set; }
    public string VideoStatus { get; set; }
}

public class GetProductsByStatusTaskResponseModel : IResponseModel
{
    public string Reason { get; set; }
    public string Url { get; set; }
    public List<GetProductsByStatusTaskListCommentResponseModel> CommentList { get; set; }
}

public class GetProductsByStatusTaskListCommentResponseModel : IResponseModel
{
    public string Message { get; set; }
    public string User { get; set; }
}

public class GetProductsByStatusValidationResultResponseModel : IResponseModel
{
    public string AttributeName { get; set; }
    public string Message { get; set; }
}

public class GetProductsByStatusMatchedHbProductInfoResponseModel : IResponseModel
{
    public string HbSku { get; set; }
    public string ProductName { get; set; }
    public string Brand { get; set; }
    public List<string> Images { get; set; }
    public List<GetProductsByStatusVariantTypeAttributeResponseModel> VariantTypeAttributes { get; set; }
}

public class GetProductsByStatusVariantTypeAttributeResponseModel : IResponseModel
{
    public string Name { get; set; }
    public string Value { get; set; }
}