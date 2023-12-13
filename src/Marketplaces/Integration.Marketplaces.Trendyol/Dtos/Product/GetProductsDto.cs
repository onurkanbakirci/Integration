using Integration.Core;
using ProductModel = Integration.Marketplaces.Trendyol.Models.Product.Product;

namespace Integration.Marketplaces.Trendyol.Dtos.Product;

public class GetProductsDto : PaginationDto
{
    public List<ProductModel> Contents { get; set; }
}