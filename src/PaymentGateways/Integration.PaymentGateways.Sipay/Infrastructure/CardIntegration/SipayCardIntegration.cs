using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration;
using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Response;
using Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Response;
using Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration;

namespace Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration;

public class SipayCardIntegration : SipayIntegrationBase, ISipayCardIntegration
{
    private readonly ISipayAuthIntegration _authIntegration;
    private string GetDeleteCardUrl() => $"{GetBaseUrl()}api/deleteCard";
    private string GetCardUrl() => $"{GetBaseUrl()}api/getCardTokens";
    private string GetSaveCardUrl() => $"{GetBaseUrl()}api/saveCard";
    private string GetUpdateCardUrl() => $"{GetBaseUrl()}api/editCard";
    private string GetNonSecurePaymentWithCardTokenUrl() => $"{GetBaseUrl()}api/payByCardToken";
    public SipayCardIntegration(string merchantKey, string appKey, string appSecret, int merchantId, bool isInProduction = true) : base(merchantKey, appKey, appSecret, merchantId, isInProduction)
    {
        _authIntegration = new SipayAuthIntegration(merchantKey, appKey, appSecret, merchantId, isInProduction);
    }

    public async Task<bool> SetTokenAsync()
    {
        var authResponse = await _authIntegration.GetAuthTokenAsync(new GetAuthTokenRequestModel(_appKey, _appSecret));
        SetHeader(new KeyValuePair<string, string>("Authorization", $"Bearer {authResponse.Data.Token}"));
        return true;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="deleteCardRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SipayBaseResponseModel<bool>> DeleteCardAsync(DeleteCardRequestModel deleteCardRequestModel)
    {
        deleteCardRequestModel.MerchantKey = _merchantKey;
        return await InvokeRequestAsync<DeleteCardRequestModel, SipayBaseResponseModel<bool>>((client, requestBody) => client.PostAsync(GetDeleteCardUrl(), requestBody), deleteCardRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="getCardRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SipayBaseResponseModel<List<GetCardResponseModel>>> GetCardAsync(GetCardRequestModel getCardRequestModel)
    {
        return await InvokeRequestAsync<GetCardRequestModel, SipayBaseResponseModel<List<GetCardResponseModel>>>((client, requestBody) => client.PostAsync(GetCardUrl(), requestBody), getCardRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="nonSecurePaymentWithCardTokenRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SipayBaseResponseModel<NonSecurePaymentWithCardTokenResponseModel>> NonSecurePaymentWithCardTokenAsync(NonSecurePaymentWithCardTokenRequestModel nonSecurePaymentWithCardTokenRequestModel)
    {
        return await InvokeRequestAsync<NonSecurePaymentWithCardTokenRequestModel, SipayBaseResponseModel<NonSecurePaymentWithCardTokenResponseModel>>((client, requestBody) => client.PostAsync(GetNonSecurePaymentWithCardTokenUrl(), requestBody), nonSecurePaymentWithCardTokenRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="saveCardRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SipayBaseResponseModel<SaveCardResponseModel>> SaveCardAsync(SaveCardRequestModel saveCardRequestModel)
    {
        return await InvokeRequestAsync<SaveCardRequestModel, SipayBaseResponseModel<SaveCardResponseModel>>((client, requestBody) => client.PostAsync(GetSaveCardUrl(), requestBody), saveCardRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="updateCardRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SipayBaseResponseModel<UpdateCardResponseModel>> UpdateCardAsync(UpdateCardRequestModel updateCardRequestModel)
    {
        return await InvokeRequestAsync<UpdateCardRequestModel, SipayBaseResponseModel<UpdateCardResponseModel>>((client, requestBody) => client.PostAsync(GetUpdateCardUrl(), requestBody), updateCardRequestModel);
    }
}