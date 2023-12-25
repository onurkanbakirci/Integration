using Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration;
using Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;
using Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Response;

public class PaynetPaymentIntegration : PaynetIntegrationBase, IPaynetPaymentIntegration
{
    private string GetNonSecurePaymentUrl() => $"{GetBaseUrl()}v2/transaction/payment/";
    private string GetSecurePaymentInitialUrl() => $"{GetBaseUrl()}v2/transaction/tds_initial/";
    private string GetSecurePaymentChargeUrl() => $"{GetBaseUrl()}v2/transaction/tds_charge/";
    private string GetCheckInstallmentUrl() => $"{GetBaseUrl()}v1/ratio/Get/";
    private string GetRefundUrl() => $"{GetBaseUrl()}v1/transaction/reversed_request/";
    private string GetCancelUrl() => $"{GetBaseUrl()}v1/transaction/reversed_request/";

    public PaynetPaymentIntegration(string secretKey, bool isInProduction = false) : base(secretKey, isInProduction)
    {
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="nonSecurePaymentRequest"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<NonSecurePaymentResponseModel> NonSecurePaymentAsync(NonSecurePaymentRequestModel nonSecurePaymentRequest)
    {
        return await InvokeRequestAsync<NonSecurePaymentResponseModel>((client, requestBody) => client.PostAsync(GetNonSecurePaymentUrl(), requestBody), nonSecurePaymentRequest);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="securePaymentInitialRequest"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SecurePaymentInitialResponseModel> SecurePaymentInitialAsync(SecurePaymentInitialRequestModel securePaymentInitialRequest)
    {
        return await InvokeRequestAsync<SecurePaymentInitialResponseModel>((client, requestBody) => client.PostAsync(GetSecurePaymentInitialUrl(), requestBody), securePaymentInitialRequest);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="securePaymentChargeRequest"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<SecurePaymentChargeResponseModel> SecurePaymentChargeAsync(SecurePaymentChargeRequestModel securePaymentChargeRequest)
    {
        return await InvokeRequestAsync<SecurePaymentChargeResponseModel>((client, requestBody) => client.PostAsync(GetSecurePaymentChargeUrl(), requestBody), securePaymentChargeRequest);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="refundRequest"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<RefundResponseModel> RefundAsync(RefundRequestModel refundRequest)
    {
        return await InvokeRequestAsync<RefundResponseModel>((client, requestBody) => client.PostAsync(GetRefundUrl(), requestBody), refundRequest);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="cancellationRequest"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<CancellationResponseModel> CancelAsync(CancellationRequestModel cancellationRequest)
    {
        return await InvokeRequestAsync<CancellationResponseModel>((client, requestBody) => client.PostAsync(GetCancelUrl(), requestBody), cancellationRequest);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="checkInstallmentRequest"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<CheckInstallmentResponseModel> CheckInstallmentAsync(CheckInstallmentRequestModel checkInstallmentRequest)
    {
        return await InvokeRequestAsync<CheckInstallmentResponseModel>((client, requestBody) => client.PostAsync(GetCheckInstallmentUrl(), requestBody), checkInstallmentRequest);
    }
}