using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Helpers;
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Response;
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration;
using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration;
using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Response;

public class SipayPaymentIntegration : SipayIntegrationBase, ISipayPaymentIntegration
{
    private readonly ISipayAuthIntegration _authIntegration;
    private string GetCheckInstallmentsUrl() => $"{GetBaseUrl()}api/getpos";
    private string GetNonSecurePaymentUrl() => $"{GetBaseUrl()}api/paySmart2D";
    private string GetSecurePaymentInitialUrl() => $"{GetBaseUrl()}api/paySmart3D";
    private string GetSecurePaymentChargeUrl() => $"{GetBaseUrl()}api/complete";
    private string GetRefundUrl() => $"{GetBaseUrl()}api/refund";
    private string GetCancelUrl() => $"{GetBaseUrl()}api/refund";
    public SipayPaymentIntegration(string merchantKey, string appKey, string appSecret, int merchantId, bool isInProduction = true) : base(merchantKey, appKey, appSecret, merchantId, isInProduction)
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
    /// <param name="checkInstallmentRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SipayBaseResponseModel<List<CheckInstallmentResponseModel>>> CheckInstallmentsAsync(CheckInstallmentRequestModel checkInstallmentRequestModel)
    {
        checkInstallmentRequestModel.MerchantKey = _merchantKey;
        return await InvokeRequestAsync<CheckInstallmentRequestModel, SipayBaseResponseModel<List<CheckInstallmentResponseModel>>>((client, requestBody) => client.PostAsync(GetCheckInstallmentsUrl(), requestBody), checkInstallmentRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="nonSecurePaymentRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SipayBaseResponseModel<NonSecurePaymentResponseModel>> NonSecurePaymentAsync(NonSecurePaymentRequestModel nonSecurePaymentRequestModel)
    {
        nonSecurePaymentRequestModel.MerchantKey = _merchantKey;
        return await InvokeRequestAsync<NonSecurePaymentRequestModel, SipayBaseResponseModel<NonSecurePaymentResponseModel>>((client, requestBody) => client.PostAsync(GetNonSecurePaymentUrl(), requestBody), nonSecurePaymentRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="securePaymentInitialRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public string SecurePaymentInitial(SecurePaymentInitialRequestModel securePaymentInitialRequestModel)
    {
        securePaymentInitialRequestModel.MerchantKey = _merchantKey;

        //Generate hashkey
        var hashKey = HashHelper.GenerateHashKey(securePaymentInitialRequestModel.Total.ToString(), securePaymentInitialRequestModel.InstallmentsNumber.ToString(), securePaymentInitialRequestModel.CurrencyCode, securePaymentInitialRequestModel.MerchantKey, securePaymentInitialRequestModel.InvoiceId, _appSecret);

        //Add hash key to dto
        securePaymentInitialRequestModel.HashKey = hashKey;

        //Generate template
        var template = HTMLHelper.GenerateTemplate("3ds-payment-form", "Resources/HTML", securePaymentInitialRequestModel);
        return template;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="securePaymentChargeRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SipayBaseResponseModel<SecurePaymentChargeResponseModel>> SecurePaymentChargeAsync(SecurePaymentChargeRequestModel securePaymentChargeRequestModel)
    {
        securePaymentChargeRequestModel.MerchantKey = _merchantKey;

        return await InvokeRequestAsync<SecurePaymentChargeRequestModel, SipayBaseResponseModel<SecurePaymentChargeResponseModel>>((client, requestBody) => client.PostAsync(GetSecurePaymentChargeUrl(), requestBody), securePaymentChargeRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="cancellationRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SipayBaseResponseModel<CancellationResponseModel>> CancelAsync(CancellationRequestModel cancellationRequestModel)
    {
        cancellationRequestModel.MerchantKey = _merchantKey;
        cancellationRequestModel.AppSecret = _appSecret;
        cancellationRequestModel.AppId = _appKey;

        return await InvokeRequestAsync<CancellationRequestModel, SipayBaseResponseModel<CancellationResponseModel>>((client, requestBody) => client.PostAsync(GetCancelUrl(), requestBody), cancellationRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="refundRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SipayBaseResponseModel<RefundResponseModel>> RefundAsync(RefundRequestModel refundRequestModel)
    {
        refundRequestModel.MerchantKey = _merchantKey;
        refundRequestModel.AppSecret = _appSecret;
        refundRequestModel.AppId = _appKey;

        return await InvokeRequestAsync<RefundRequestModel, SipayBaseResponseModel<RefundResponseModel>>((client, requestBody) => client.PostAsync(GetRefundUrl(), requestBody), refundRequestModel);
    }
}