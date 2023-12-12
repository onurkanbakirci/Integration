using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Dtos.Product;
public class GetBatchRequestResultDto : IDto
{
    public string BatchRequestId { get; set; }
    public List<GetBatchRequestResultItemDto> Items { get; set; }
    public string Status { get; set; }
    public long CreationDate { get; set; }
    public long LastModification { get; set; }
    public string SourceType { get; set; }
    public int ItemCount { get; set; }
}

public class GetBatchRequestResultItemDto
{
    public string Status { get; set; }
}