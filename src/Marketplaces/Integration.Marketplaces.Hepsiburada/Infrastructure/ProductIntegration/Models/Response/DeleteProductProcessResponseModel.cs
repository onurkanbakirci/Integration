using Integration.Hub;
namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;
public class CheckDeleteProductProcessResponseModel : IResponseModel
{
    public string Id { get; set; }
    public string CreatedBy { get; set; }
    public string ModifiedBy { get; set; }
    public string TrackingId { get; set; }
    public List<CheckDeleteProductProcessDeletedProductResponseModel> DeletedProductList { get; set; }
    public bool Completed { get; set; }
}

public class CheckDeleteProductProcessDeletedProductResponseModel : IResponseModel
{
    public string Merchant { get; set; }
    public string MerchantSku { get; set; }
    public bool Deleted { get; set; }
    public string ErrorMessage { get; set; }
}