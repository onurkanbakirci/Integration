using Integration.Hub;
using Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;
using Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Response;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration;
public interface IPaynetPaymentIntegration : IPaymentIntegration
{
    /// <summary>
    /// 3D doğrulama olmadan ödeme servisimizi kullanarak  tek çekim, 
    /// taksitli ve saklı kart ile ödeme işlemlerini gerçekleştirebilirsiniz. 
    /// Kredi kartından direkt ödeme tutarı çekilir,  3D doğrulama yapılmaz.
    /// </summary>
    /// <param name="nonSecurePaymentRequest"></param>
    /// <returns><see cref="NonSecurePaymentResponseModel"/></returns>
    public Task<NonSecurePaymentResponseModel> NonSecurePaymentAsync(NonSecurePaymentRequestModel nonSecurePaymentRequest);

    /// <summary>
    /// Ödeme işleminden farklı olarak return_url parametresi gönderilir. 
    /// Servisten dönen post_url ya da html_content parametrelerini kullanarak 
    /// bankaların 3D doğrulama sayfasını açabilirsiniz.
    /// </summary>
    /// <param name="securePaymentInitialRequest"></param>
    /// <returns><see cref="SecurePaymentInitialResponseModel"/></returns>
    public Task<SecurePaymentInitialResponseModel> SecurePaymentInitialAsync(SecurePaymentInitialRequestModel securePaymentInitialRequest);

    /// <summary>
    /// 3D doğrulama sonucunda kredi kartından ilgili tutarın çekim yapıldığı servis. 
    /// "3D ödeme başlatma" servisinde kullandığınız return_url'e post edilen session_id 
    /// ve token_id değerlerini bu service post edip ödeme akışını tamamlayabilirsiniz.
    /// </summary>
    /// <param name="securePaymentChargeRequest"></param>
    /// <returns><see cref="SecurePaymentChargeResponseModel"/></returns>
    public Task<SecurePaymentChargeResponseModel> SecurePaymentChargeAsync(SecurePaymentChargeRequestModel securePaymentChargeRequest);

    /// <summary>
    /// Başarılı kredi kartı işlemlerinin iptali, iadesi veya kısmi iadesi için kullanılır. 
    /// Burada önemli olan nokta işlemin yapıldığı tarihtir. Aynı gün yapılan işlemler tüm 
    /// tutar iptal edilir. Geçmiş tarihli işlemler tümü iade olabilir ya da kısmı iade yapabilirsiniz. 
    /// Aynı gün yapılan işlemlerde kısmi iade yapılamaz.
    /// </summary>
    /// <param name="refundRequest"></param>
    /// <returns><see cref="RefundResponseModel"/></returns>
    public Task<RefundResponseModel> RefundAsync(RefundRequestModel refundRequest);

    /// <summary>
    /// Başarılı kredi kartı işlemlerinin iptali, iadesi veya kısmi iadesi için kullanılır. 
    /// Burada önemli olan nokta işlemin yapıldığı tarihtir. Aynı gün yapılan işlemler tüm 
    /// tutar iptal edilir. Geçmiş tarihli işlemler tümü iade olabilir ya da kısmı iade yapabilirsiniz. 
    /// Aynı gün yapılan işlemlerde kısmi iade yapılamaz.
    /// </summary>
    /// <param name="cancellationRequest"></param>
    /// <returns><see cref="CancellationResponseModel"/></returns>
    public Task<CancellationResponseModel> CancelAsync(CancellationRequestModel cancellationRequest);

    /// <summary>
    /// 3D doğrulama olmadan ödeme servisimizi kullanarak  tek çekim, 
    /// taksitli ve saklı kart ile ödeme işlemlerini gerçekleştirebilirsiniz. 
    /// Kredi kartından direkt ödeme tutarı çekilir,  3D doğrulama yapılmaz.
    /// </summary>
    /// <param name="nonSecurePaymentRequest"></param>
    /// <returns><see cref="CheckInstallmentResponseModel"/></returns>
    public Task<CheckInstallmentResponseModel> CheckInstallmentAsync(CheckInstallmentRequestModel checkInstallmentRequest);
}