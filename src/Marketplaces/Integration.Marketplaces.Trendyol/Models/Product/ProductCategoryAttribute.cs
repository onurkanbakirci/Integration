using Integration.Core;

public class ProductCategoryAttribute : IModel
{
    public int AttributeId { get; set; }
    public string AttributeName { get; set; }
    public int? AttributeValueId { get; set; }
    public string? AttributeValue { get; set; }
}