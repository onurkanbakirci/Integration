using Integration.Core;
using Integration.Marketplaces.Trendyol.Models.Category;

namespace Integration.Marketplaces.Trendyol.Dtos.Category;
public class GetCategoryAttribute : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public List<CategoryAttribute> CategoryAttributes { get; set; }
}