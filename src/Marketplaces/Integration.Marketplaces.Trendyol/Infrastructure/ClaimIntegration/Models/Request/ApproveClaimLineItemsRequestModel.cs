using Integration.Core;
namespace Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration.Models.Request;
public class ApproveClaimLineItemsRequestModel : IRequestModel
{
    public List<string> ClaimLineItemIdList { get; set; }
    public object Params { get; set; }//TODO: Check this
}