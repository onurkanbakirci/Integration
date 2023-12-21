namespace Integration.Hub;
public class BulkModel<T> : IRequestModel, IResponseModel
{
    public List<T> Items { get; set; }
}