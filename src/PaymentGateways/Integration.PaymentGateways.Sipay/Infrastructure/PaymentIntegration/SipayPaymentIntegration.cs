using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Helpers;
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Response;
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration;
using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Request;

public class SipayPaymentIntegration : SipayIntegrationBase, ISipayPaymentIntegration
{
    private string GetCheckInstallmentsUrl() => $"{GetBaseUrl()}api/getpos";
    private string GetNonSecurePaymentUrl() => $"{GetBaseUrl()}api/paySmart2D";
    private string GetSecurePaymentInitialUrl() => $"{GetBaseUrl()}api/paySmart3D";
    private string GetSecurePaymentChargeUrl() => $"{GetBaseUrl()}api/complete";
    private string GetRefundUrl() => $"{GetBaseUrl()}api/refund";
    private string GetCancelUrl() => $"{GetBaseUrl()}api/refund";

    public SipayPaymentIntegration(string merchantKey, string appKey, string appSecret, int merchantId, bool isInProduction = true) : base(merchantKey, appKey, appSecret, merchantId, isInProduction)
    {
        var sipayAuthIntegration = new SipayAuthIntegration(merchantKey, appKey, appSecret, merchantId, isInProduction);
        var token = sipayAuthIntegration.GetAuthTokenAsync(new GetAuthTokenRequestModel(appKey, appSecret));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="checkInstallmentRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<CheckInstallmentResponseModel> CheckInstallmentsAsync(CheckInstallmentRequestModel checkInstallmentRequestModel)
    {
        checkInstallmentRequestModel.MerchantKey = _merchantKey;
        return await InvokeRequestAsync<CheckInstallmentResponseModel>((client, requestBody) => client.PostAsync(GetCheckInstallmentsUrl(), requestBody), checkInstallmentRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="nonSecurePaymentRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<NonSecurePaymentResponseModel> NonSecurePaymentAsync(NonSecurePaymentRequestModel nonSecurePaymentRequestModel)
    {
        nonSecurePaymentRequestModel.MerchantKey = _merchantKey;
        return await InvokeRequestAsync<NonSecurePaymentResponseModel>((client, requestBody) => client.PostAsync(GetNonSecurePaymentUrl(), requestBody), nonSecurePaymentRequestModel);
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
    public async Task<SecurePaymentChargeResponseModel> SecurePaymentChargeAsync(SecurePaymentChargeRequestModel securePaymentChargeRequestModel)
    {
        securePaymentChargeRequestModel.MerchantKey = _merchantKey;

        return await InvokeRequestAsync<SecurePaymentChargeResponseModel>((client, requestBody) => client.PostAsync(GetSecurePaymentChargeUrl(), requestBody), securePaymentChargeRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="cancellationRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<CancellationResponseModel> CancelAsync(CancellationRequestModel cancellationRequestModel)
    {
        cancellationRequestModel.MerchantKey = _merchantKey;
        cancellationRequestModel.AppSecret = _appSecret;
        cancellationRequestModel.AppId = _appKey;

        return await InvokeRequestAsync<CancellationResponseModel>((client, requestBody) => client.PostAsync(GetCancelUrl(), requestBody), cancellationRequestModel);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="refundRequestModel"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<RefundResponseModel> RefundAsync(RefundRequestModel refundRequestModel)
    {
        refundRequestModel.MerchantKey = _merchantKey;
        refundRequestModel.AppSecret = _appSecret;
        refundRequestModel.AppId = _appKey;

        return await InvokeRequestAsync<RefundResponseModel>((client, requestBody) => client.PostAsync(GetRefundUrl(), requestBody), refundRequestModel);
    }
}