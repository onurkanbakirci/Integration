using Integration.Hub;
namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Response;
public class GetBatchRequestResultResponseModel : IResponseModel
{
    public string BatchRequestId { get; set; }
    public List<BatchRequestResultResponseModel> Items { get; set; }
    public string Status { get; set; }
    public long CreationDate { get; set; }
    public long LastModification { get; set; }
    public string SourceType { get; set; }
    public int ItemCount { get; set; }
}

public class BatchRequestResultResponseModel : IResponseModel
{
    public string Status { get; set; }
}