using Integration.Core;
namespace Integration.Marketplaces.Trendyol.Dtos.Claim;
public class ApproveClaimLineItemsDto : IDto
{
    public List<string> ClaimLineItemIdList { get; set; }
    public object Params { get; set; }//TODO: Check this
}