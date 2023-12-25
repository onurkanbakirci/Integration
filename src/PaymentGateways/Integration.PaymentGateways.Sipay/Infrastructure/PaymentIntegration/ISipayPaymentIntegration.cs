using Integration.Hub;
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Response;

namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration;

public interface ISipayPaymentIntegration : IPaymentIntegration
{

    /// <summary>
    /// Kullanıcı kart numarasının ilk 6 hanesini, tarım kartları için 
    /// kart numarasının tamamını girdiğinde, API çağrılmalıdır. getPos API, 
    /// ödeme sayfasındaki verilen kart numarasına göre taksit listesini, 
    /// tarım kartları için vade aralığını ve ödeme sıklığını sağlamaktan sorumludur.
    /// <param name="checkInstallmentRequestModel"></param>
    /// <returns><see cref="CheckInstallmentResponseModel"/></returns>
    Task<CheckInstallmentResponseModel> CheckInstallmentsAsync(CheckInstallmentRequestModel checkInstallmentRequestModel);

    /// <summary>
    /// Sipay admini, üye işyeri web sitesinden yapılan ödemenin Non-Secure mi 
    /// yoksa 3D mi yapılması gerektiğine karar verecektir. Aşağıdaki istek, 
    /// üye iş yeri web sitesinden SiPay ödeme entegrasyon sistemine gönderilmelidir. 
    /// CURL post isteği, aşağıdaki parametrelerle SiPay'de alınmalıdır.
    /// </summary>
    /// <param name="nonSecurePaymentRequestModel"></param>
    /// <returns><see cref="NonSecurePaymentResponseModel"/></returns>
    Task<NonSecurePaymentResponseModel> NonSecurePaymentAsync(NonSecurePaymentRequestModel nonSecurePaymentRequestModel);

    /// <summary>
    /// Initial request to pay secure. This method returns html template. 
    /// You must render this template to your view.
    /// </summary>
    /// <param name="securePaymentInitialRequestModel"></param>
    /// <returns><see cref="string"/></returns>
    string SecurePaymentInitial(SecurePaymentInitialRequestModel securePaymentInitialRequestModel);


    /// <summary>
    /// Charge request to pay secure
    /// </summary>
    /// <param name="securePaymentChargeRequestModel"></param>
    /// <returns><see cref="SecurePaymentInitialRequestModel"/></returns>
    Task<SecurePaymentChargeResponseModel> SecurePaymentChargeAsync(SecurePaymentChargeRequestModel securePaymentChargeRequestModel);

    /// <summary>
    /// Cancel payment request
    /// </summary>
    /// <param name="cancellationRequestModel"></param>
    /// <returns><see cref="CancellationResponseModel"/></returns>
    Task<CancellationResponseModel> CancelAsync(CancellationRequestModel cancellationRequestModel);

    /// <summary>
    /// Refund payment request
    /// </summary>
    /// <param name="refundRequestModel"></param>
    /// <returns><see cref="RefundResponseModel"/></returns>
    Task<RefundResponseModel> RefundAsync(RefundRequestModel refundRequestModel);
}