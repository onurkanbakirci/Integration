using Integration.Hub;
using Integration.PaymentGateways.Sipay.Infrastructure.AuthIntegration.Models.Response;
using Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Response;
using Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Request;

namespace Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration;

public interface ISipayCardIntegration : ICardIntegration
{
    /// <summary>
    /// Saklı kart ile ödeme servisi, sipariş vermek için kullanılır. Üye işyeri web 
    /// sitesi ödeme formunu doldurup gönderdikten sonra kullanıcı doğrudan banka sayfasına
    /// yönlendirilecektir. Ödeme, banka ağ geçidinde bir SMS koduyla doğrulanacaktır.
    /// Ödeme başarılı olduktan sonra, kullanıcı üye iş yerinin başarılı URL'sine yeniden 
    /// yönlendirilecektir, aksi takdirde, üye iş yeri tarafından belirlenen URL'yi iptal 
    /// etmek için yeniden yönlendirilecektir. Bu getpos API 'sinde diğer ödeme api adı 
    /// verilenler gibi getPos Api'yi çağırmaya gerek yoktur.
    /// </summary>
    /// <param name="nonSecurePaymentWithCardTokenRequestModel"></param>
    /// <returns><see cref="NonSecurePaymentWithCardTokenResponseModel"/></returns>
    Task<SipayBaseResponseModel<NonSecurePaymentWithCardTokenResponseModel>> NonSecurePaymentWithCardTokenAsync(NonSecurePaymentWithCardTokenRequestModel nonSecurePaymentWithCardTokenRequestModel);

    /// <summary>
    /// Kart Kayıt servisi, kart bilgilerini Sipay Sisteminde saklamak ve bir tokenı geri 
    /// göndermek için kullanılır. payByCardToken API 'de kullanılacak yanıt.
    /// </summary>
    /// <param name="saveCardRequestModel"></param>
    /// <returns><see cref="SaveCardResponseModel"/></returns>
    Task<SipayBaseResponseModel<SaveCardResponseModel>> SaveCardAsync(SaveCardRequestModel saveCardRequestModel);

    /// <summary>
    /// Müşteri için kaydedilmiş kartları çağırabileceğiniz servistir.
    /// </summary>
    /// <param name="getCardRequestModel"></param>
    /// <returns></returns>
    Task<SipayBaseResponseModel<List<GetCardResponseModel>>> GetCardAsync(GetCardRequestModel getCardRequestModel);

    /// <summary>
    /// Müşterinin kartında yapılacak değişiklik için kullanılan servistir.
    /// </summary>
    /// <param name="updateCardRequestModel"></param>
    /// <returns></returns>
    Task<SipayBaseResponseModel<UpdateCardResponseModel>> UpdateCardAsync(UpdateCardRequestModel updateCardRequestModel);

    /// <summary>
    /// Müşteriye ait daha önce kaydedilmiş bir kartı silmeye yarayan servistir.
    /// </summary>
    /// <param name="deleteCardRequestModel"></param>
    /// <returns></returns>
    Task<SipayBaseResponseModel<bool>> DeleteCardAsync(DeleteCardRequestModel deleteCardRequestModel);
}