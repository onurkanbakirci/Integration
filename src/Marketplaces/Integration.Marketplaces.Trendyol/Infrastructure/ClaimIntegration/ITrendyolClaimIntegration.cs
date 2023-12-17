using Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration.Models.Request;
using Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration.Models.Response;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration;
public interface ITrendyolClaimIntegration
{
    public Task<GetClaimsResponseModel?> GetClaimsAsync(string filterQuery);

    public Task<bool> CreateClaimAsync(CreateClaimRequestModel createClaimRequestModel);

    public Task<bool> ApproveClaimLineItemsAsync(ApproveClaimLineItemsRequestModel approveClaimLineItemsRequestModel, string claimId);
}