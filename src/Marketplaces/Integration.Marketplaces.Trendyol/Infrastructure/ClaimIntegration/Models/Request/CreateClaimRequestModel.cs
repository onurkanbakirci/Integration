using Integration.Core;
using Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration.Constants;
namespace Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration.Models.Request;
public class CreateClaimRequestModel : IRequestModel
{
    public int CustomerId { get; set; }
    public bool ExcludeListing { get; set; }
    public bool ForcePackageCreation { get; set; }
    public string OrderNumber { get; set; }
    public int ShipmentCompanyId { get; set; }
    public List<CreateClaimClaimItemRequestModel> ClaimItems { get; set; }
}

public class CreateClaimClaimItemRequestModel : IRequestModel
{
    public string Barcode { get; set; }
    public string CustomerNote { get; set; }
    public int Quantity { get; set; }
    public int ReasonId { get; set; }
    public CreateClaimClaimItemRequestModel(string barcode, string customerNote, int quantity, int reasonId)
    {
        Barcode = barcode;
        CustomerNote = customerNote;
        Quantity = quantity;

        if (ClaimReasons.GetClaimReasonById(reasonId) is null)
            throw new Exception($"Claim reason id {reasonId} is not valid.");

        ReasonId = reasonId;
    }
}