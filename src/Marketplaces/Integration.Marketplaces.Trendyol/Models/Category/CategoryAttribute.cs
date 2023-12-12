using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Models.Category;
public class CategoryAttribute : IModel
{
    public int CategoryId { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Required { get; set; }
    public bool AllowCustom { get; set; }
    public bool Varianter { get; set; }
    public bool Slicer { get; set; }
    public List<CategoryAttributeValue> AttributeValues { get; set; }
}