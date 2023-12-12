using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Models.Product;
public class ProductImage : IModel
{
    public string Url { get; set; }

    public ProductImage(string url)
    {
        Url = url;
    }
}