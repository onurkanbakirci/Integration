using Integration.Core;
using Integration.Marketplaces.Trendyol.Dtos.Claim;
using Integration.Marketplaces.Trendyol.Infrastructure;
using Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration;

public class TrendyolClaimIntegration : TrendyolIntegrationBase, ITrendyolClaimIntegration, IMarketplaceIntegration
{
    public string GetClaimsUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/claims";
    public string GetCreateClaimUrl() => $"{GetBaseUrl}suppliers/{_supplierId}/claims/create";
    public string GetApproveClaimLineItemUrl(string claimId) => $"{GetBaseUrl}claims/{claimId}/items/approve";
    public TrendyolClaimIntegration(string supplierId, string apiKey, string apiSecret, bool isInProduction, string entegratorFirm) : base(supplierId, apiKey, apiSecret, isInProduction, entegratorFirm)
    {
    }
    public async Task<GetClaimDto?> GetClaimsAsync(string filterQuery)
    {
        return await InvokeRequestAsync<GetClaimDto>((client) => client.GetAsync(GetClaimsUrl() + filterQuery));
    }

    public async Task<bool> CreateClaimAsync(AddClaimDto addClaimDto)
    {
        return await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetCreateClaimUrl(), requestBody), addClaimDto);
    }

    public async Task<bool> ApproveClaimLineItemsAsync(ApproveClaimLineItemsDto getApproveClaimLineItemsDto, string claimId)
    {
        return await InvokeRequestAsync((client, requestBody) => client.PutAsync(GetApproveClaimLineItemUrl(claimId), requestBody), getApproveClaimLineItemsDto);
    }
}