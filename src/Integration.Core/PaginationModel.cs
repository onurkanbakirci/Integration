namespace Integration.Core;
public class PaginationModel : IResponseModel
{
    public int TotalElements { get; set; }
    public int TotalPages { get; set; }
    public int Page { get; set; }
    public int Size { get; set; }
}