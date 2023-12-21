using Integration.Hub;
namespace Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Request;
public class UpdateBoxInfoRequestModel : IRequestModel
{
    public int BoxQuantity { get; set; }
    public double Deci { get; set; }
    public UpdateBoxInfoRequestModel(int boxQuantity, double deci)
    {
        BoxQuantity = boxQuantity;
        Deci = deci;
    }
}