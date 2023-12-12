using Integration.Core;
namespace Integration.Marketplaces.Trendyol.Models.Category;
public class Category : IModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ParentId { get; set; }
    public List<Category> SubCategories { get; set; }
}