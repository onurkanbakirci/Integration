using Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration.Models.Request;
using Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration.Models.Response;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration;
public interface ITrendyolClaimIntegration
{
    /// <summary>
    /// Trendyol sisteminde iadesi oluşan siparişleri bu metod yardımıyla çekebilirsiniz.
    /// </summary>
    /// <param name="filterQuery"></param>
    /// <returns></returns>
    public Task<GetClaimsResponseModel?> GetClaimsAsync(string filterQuery);

    /// <summary>
    /// Deponuza iade kodu alınmadan gelen sipariş paketlerin iade talep 
    /// paketlerini oluşturmak için kullanabilirsiniz. Bu servis ile paket 
    /// oluşturduktan sonra iade paketlerini çekme servisi ile iade paketlerini 
    /// tekrardan çekebilirsiniz.
    /// </summary>
    /// <param name="createClaimRequestModel"></param>
    /// <returns></returns>
    public Task<bool> CreateClaimAsync(CreateClaimRequestModel createClaimRequestModel);

    /// <summary>
    /// Trendyol Paneli üzerinden iade siparişleri onaylama işlemini,
    /// artık Trendyol API servisini kullanarakta yapabilirsiniz. Ekran 
    /// görüntüsünü aşağıda görebilirsiniz.
    /// </summary>
    /// <param name="approveClaimLineItemsRequestModel"></param>
    /// <param name="claimId"></param>
    /// <returns></returns>
    public Task<bool> ApproveClaimLineItemsAsync(ApproveClaimLineItemsRequestModel approveClaimLineItemsRequestModel, string claimId);
}