using Integration.Core;

public class AddProductCategoryAttributeDto : IDto
{
    public int AttributeId { get; set; }
    public int? AttributeValueId { get; set; }
    public string? CustomAttributeValue { get; set; }
    public AddProductCategoryAttributeDto(int attributeId, int? attributeValueId, string? customAttributeValue)
    {
        AttributeId = attributeId;
        AttributeValueId = attributeValueId;
        CustomAttributeValue = customAttributeValue;
    }
}