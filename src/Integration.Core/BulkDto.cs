namespace Integration.Core;
public class BulkDto<T> : IDto
{
    public List<T> Items { get; set; }
}