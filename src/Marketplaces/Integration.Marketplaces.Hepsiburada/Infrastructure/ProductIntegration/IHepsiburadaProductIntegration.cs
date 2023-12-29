using Integration.Hub;
using Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Request;
using Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;

namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration;
public interface IHepsiburadaProductIntegration
{
    /// <summary>
    /// Bu metod ile Hepsiburada kategorileri bilgilerini alabilirsiniz.
    /// </summary>
    /// <returns><see cref="GetCategoriesResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<List<GetCategoriesResponseModel>>> GetCategoriesAsync();

    /// <summary>
    /// Bu metod ile Hepsiburada’ daki uç kategorilerin özellik bilgilerini alabilirsiniz. 
    /// Kategori özellikleri, sadece ‘leaf’ ve ‘available’ değerleri ‘true’ olan kategorilerde mevcuttur.
    /// </summary>
    /// <returns><see cref="GetCategoryAttributesResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<List<GetCategoryAttributesResponseModel>>> GetCategoryAttributesAsync(int categoryId);

    /// <summary>
    /// Bu metod ile ‘type’ alanı değeri ‘enum’ olan özellikler için kullanılabilecek değerleri alabilirsiniz.
    /// </summary>
    /// <param name="categoryId">Category id</param>
    /// <param name="attributeId">Attribute id</param>
    /// <returns><see cref="GetCategoryAttributeValuesResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<List<GetCategoryAttributeValuesResponseModel>>> GetCategoryAttributeValuesAsync(int categoryId, string attributeId);

    /// <summary>
    /// Eşleşen statü red endpointi ile eşleşen statüdeki ürünlerinize api üzerinden red işlemi yapılabilmektedir.
    /// </summary>
    /// <param name="rejectPrematchRequestModel">Category id</param>
    /// <returns><see cref="RejectPrematchResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<RejectPrematchResponseModel>> GetCategoryAttributeValuesAsync(RejectPrematchRequestModel rejectPrematchRequestModel);

    /// <summary>
    /// Bu metod ile; ürün bilgilerini, ürün giriş sürecine dahil olması için Hepsiburada’ ya gönderebilirsiniz.
    /// </summary>
    /// <param name="createProductRequestModels">Category id</param>
    /// <returns><see cref="RejectPrematchResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<CreateProductResponseModel>> CreateProductsAsync(BulkModel<CreateProductRequestModel> createProductRequestModels);

    /// <summary>
    /// Bu method ile HB katalogunda kayıtlı olan ve global barkod içeren ürünleri mapping 
    /// sürecine gerek kalmadan hızlı bir şekilde mağazanıza yükleyebilirsiniz. 
    /// HB katalogunda kayıtlı olmayan ürünler bu method kullanıldığında yüklenmeyecektir. 
    /// HB katalogunda kayıtlı olmayan ilk defa açılacak ürünler için “Ürün Bilgisi Gönderme” 
    /// methodu kullanılmalıdır. Süreç aşağıda aşamalarıyla birlikte anlatılmıştır.
    /// </summary>
    /// <param name="fastListingRequestModels"></param>
    /// <returns><see cref="FastListingResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<List<FastListingResponseModel>>> FastListingAsync(BulkModel<FastListingRequestModel> fastListingRequestModels);

    /// <summary>
    /// Bu method ile bir Merchant'a ait ürünlerin statü bilgilerine ulaşabilirsiniz. 
    /// İstek limiti her bir IP başına “500 istek/1 saniye”
    /// </summary>
    /// <param name="checkProductStatusRequestModels"></param>
    /// <returns><see cref="CheckProductStatusResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<CheckProductStatusResponseModel>> CheckProductStatusAsync(BulkModel<CheckProductStatusRequestModel> checkProductStatusRequestModels);

    /// <summary>
    /// Eşleşen statü onay endpointi ile eşleşen statüdeki ürünlerinize api üzerinden onay işlemi yapılabilmektedir.
    /// </summary>
    /// <param name="approvePrematchRequestModels"></param>
    /// <returns><see cref="ApprovePrematchResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<ApprovePrematchResponseModel>> ApprovePrematchAsync(BulkModel<ApprovePrematchRequestModel> approvePrematchRequestModels);

    /// <summary>
    /// Bu metod ile, daha önce almış olduğunuz ‘trackingId’ bilgilerini alabilirsiniz.Pagination yapısı ve sıralama özelliği geliştirilmiştir.
    /// </summary>
    /// <returns><see cref="GetTrackingIdHistoriesResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<List<GetTrackingIdHistoriesResponseModel>>> GetTrackingIdHistoryAsync();


    /// <summary>
    /// Bu metod ile; ‘trackingId’ bilgisine sahip olduğunuz ürünlerin durumlarını alabilirsiniz.
    /// </summary>
    /// <param name="trackingId"></param>
    /// <returns><see cref="CheckProductStatusByTrackingIdResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<CheckProductStatusByTrackingIdResponseModel>> GetProductStatusByTrackingIdAsync(string trackingId);

    /// <summary>
    /// Bu method ile bir Merchanta ait ürünlerin statü bazlı ürün bilgilerine ulaşabilirsiniz.
    /// </summary>
    /// <param name="merchantId"></param>
    /// <param name="productStatus"></param>
    /// <returns><see cref="GetProductByStatusResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<List<GetProductByStatusResponseModel>>> GetProductsByStatusAsync(string merchantId, string productStatus);

    /// <summary>
    /// Silme isteğinin sonucunu kontrol için trackingid değerini sorgulamanız gerekir.
    /// </summary>
    /// <param name="trackingId"></param>
    /// <returns><see cref="GetProductByStatusResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<CheckDeleteProductProcessResponseModel>> CheckDeleteProductProcessAsync(string trackingId);

    /// <summary>
    /// Bu metod ile mağazaların tüm ürünlerinin (ürün özellik değerleriyle birlikte) api üzerinden 
    /// listeleyebilirsiniz. Bu servisle artık mağazaların entegratör değişikliği yaptığı durumlarda 
    /// eski çalıştığı entegratörden ürün bilgilerini talep etmesine gerek kalmayacak, Hepsiburada API 
    /// servisi üzerinden bütün ürün bilgilerini listeleyebilecektir.
    /// </summary>
    /// <param name="merchantId"></param>
    /// <returns><see cref="GetMerchantProductResponseModel"/></returns>
    public Task<HepsiburadaBaseResponseModel<List<GetMerchantProductResponseModel>>> GetMerchantProductsAsync(string merchantId);

}