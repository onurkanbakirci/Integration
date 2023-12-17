using Integration.Core;
namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Request;
public class DeleteProductRequestModel : IRequestModel
{
    public string Barcode { get; set; }
}