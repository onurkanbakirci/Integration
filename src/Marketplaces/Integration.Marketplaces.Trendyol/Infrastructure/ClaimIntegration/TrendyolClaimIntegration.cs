using Integration.Hub;
using Integration.Marketplaces.Trendyol.Infrastructure;
using Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration;
using Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration.Models.Request;
using Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration.Models.Response;

public class TrendyolClaimIntegration : TrendyolIntegrationBase, ITrendyolClaimIntegration, IMarketplaceIntegration
{
    private string GetClaimsUrl() => $"{GetBaseUrl()}suppliers/{_supplierId}/claims";
    private string GetCreateClaimUrl() => $"{GetBaseUrl()}suppliers/{_supplierId}/claims/create";
    private string GetApproveClaimLineItemUrl(string claimId) => $"{GetBaseUrl()}claims/{claimId}/items/approve";
    public TrendyolClaimIntegration(string supplierId, string apiKey, string apiSecret, bool isInProduction, string entegratorFirm) : base(supplierId, apiKey, apiSecret, isInProduction, entegratorFirm)
    {
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="filterQuery"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<GetClaimsResponseModel?> GetClaimsAsync(string filterQuery)
    {
        return await InvokeRequestAsync<GetClaimsResponseModel>((client) => client.GetAsync(GetClaimsUrl() + filterQuery));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="createClaimRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> CreateClaimAsync(CreateClaimRequestModel createClaimRequestModel)
    {
        return await InvokeRequestAsync((client, requestBody) => client.PostAsync(GetCreateClaimUrl(), requestBody), createClaimRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="approveClaimLineItemsRequestModel"><inheritdoc/></param>
    /// <param name="claimId"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<bool> ApproveClaimLineItemsAsync(ApproveClaimLineItemsRequestModel approveClaimLineItemsRequestModel, string claimId)
    {
        return await InvokeRequestAsync((client, requestBody) => client.PutAsync(GetApproveClaimLineItemUrl(claimId), requestBody), approveClaimLineItemsRequestModel);
    }
}