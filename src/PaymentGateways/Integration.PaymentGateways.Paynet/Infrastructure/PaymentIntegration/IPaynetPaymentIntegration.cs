using Integration.Hub;
using Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;
using Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Response;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration;
public interface IPaynetPaymentIntegration : IPaymentIntegration
{
    public Task<NonSecurePaymentResponseModel> NonSecurePaymentAsync(NonSecurePaymentRequestModel nonSecurePaymentRequest);
    public Task<SecurePaymentInitialResponseModel> SecurePaymentChargeAsync(SecurePaymentInitialRequestModel securePaymentInitialRequest);
    public Task<SecurePaymentChargeResponseModel> SecurePaymentChargeAsync(SecurePaymentChargeRequestModel securePaymentChargeRequest);
    public Task<RefundResponseModel> RefundAsync(RefundRequestModel refundRequest);
    public Task<CancellationResponseModel> CancelAsync(CancellationRequestModel cancellationRequest);
    public Task<CheckInstallmentResponseModel> CheckInstallmentAsync(CheckInstallmentRequestModel checkInstallmentRequest);
}