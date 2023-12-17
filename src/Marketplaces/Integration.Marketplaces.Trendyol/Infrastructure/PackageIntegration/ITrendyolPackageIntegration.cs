using Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Request;
using Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Response;

namespace Integration.Marketplaces.Trendyol.Infrastructure.OrderIntegration;

public interface ITrendyolPackageIntegration
{
    /// <summary>
    /// Trendyol sistemine ilettiğiniz ürünler ile planlanın butik sonrası
    /// müşteriler tarafından verilen ve ödeme kontrolünde olan her siparişin 
    /// bilgisini bu method yardımıyla alabilirsiniz. Sistem tarafından ödeme 
    /// kontrolünden sonra otomatik paketlenerek sipariş paketleri oluşturulur.
    /// </summary>
    /// <param name="filterQuery"></param>
    /// <returns></returns>
    Task<GetShipmentPackagesResponseModel?> GetShipmentPackagesAsync(string filterQuery);

    /// <summary>
    /// Bu method herhangi bir paket için çağırıldığında, artık 
    /// Trendyol’un anlaşması üzerinden olan paket değil, tedarikçinin 
    /// kendi anlaşması üzerinden yaptığı gönderinin durumu sorgulanmaya 
    /// başlar ve Yola Çıktı, Teslim Edildi, Teslim Edilemedi bilgileri 
    /// entegrasyon üzerinden alınır ve takip edilir.
    /// </summary>
    /// <param name="shipmentPackageId"></param>
    /// <param name="updateTrackingNumberRequestModel"></param>
    /// <returns></returns>
    Task<bool> UpdateTrackingNumberAsync(long shipmentPackageId, UpdateTrackingNumberRequestModel updateTrackingNumberRequestModel);

    /// <summary>
    /// Oluşturularan sipariş paketinin faturasının kesilmesi işleminin Trendyol’a 
    /// bildirilebilmesi için kullanılır. Fatura kesme işleminin bildirilmesi, 
    /// Trendyol Müşteri Hizmetlerine ulaşan, müşteri kaynaklı iptallerin önlenmesi 
    /// için bir referanstır.
    /// </summary>
    /// <param name="shipmentPackageId"></param>
    /// <param name="updatePackageRequestModel"></param>
    /// <returns></returns>
    Task<bool> UpdatePackageAsync(long shipmentPackageId, UpdatePackageRequestModel updatePackageRequestModel);

    /// <summary>
    /// Tedarikçi tarafından kendi sisteminde yaratılmış e-Arşiv ya da 
    /// e-Fatura bilgisinin LİNK detayını Trendyol sistemine transfer etmek 
    /// için bu method kullanılacaktır.
    /// </summary>
    /// <param name="addInvoiceLinkRequestModel"></param>
    /// <returns></returns>
    Task<bool> SendInvoiceLinkAsync(AddInvoiceLinkRequestModel addInvoiceLinkRequestModel);

    /// <summary>
    /// Daha önce hatalı beslenen faturalar bu servis üzerinden silinip, fatura 
    /// linki gönderme servisi ile tekrar beslenebilmektedir.
    /// </summary>
    /// <param name="deleteInvoiceLinkRequestModel"></param>
    /// <returns></returns>
    Task<bool> DeleteInvoiceLinkAsync(DeleteInvoiceLinkRequestModel deleteInvoiceLinkRequestModel);

    /// <summary>
    /// Bu servis ile Trendyol üzerinde oluşmuş siparişlerinizi birden fazla 
    /// paket haline getirebilirsiniz. Bu servisi kulandıktan sonra sipariş 
    /// numarasına bağlı yeni paketler "UnPacked" statüsünde, asenkron olarak 
    /// oluşacaktır. Bu nedenle Sipariş Paketlerini Çekme servisinden tekrar 
    /// güncel paketleri çekmelisiniz.
    /// </summary>
    /// <param name="shipmentPackageId"></param>
    /// <param name="splitMultiPackageByQuantityRequestModel"></param>
    /// <returns></returns>
    Task<bool> SplitMultiPackageByQuantityAsync(long shipmentPackageId, SplitMultiPackageByQuantityRequestModel splitMultiPackageByQuantityRequestModel);

    /// <summary>
    /// Bu servis ile Trendyol üzerinde oluşmuş siparişlerinizi birden fazla 
    /// paket haline getirebilirsiniz. Bu servisi kulandıktan sonra sipariş 
    /// numarasına bağlı yeni paketler "UnPacked" statüsünde, asenkron olarak 
    /// oluşacaktır. Bu nedenle Sipariş Paketlerini Çekme servisinden tekrar 
    /// güncel paketleri çekmelisiniz.
    /// </summary>
    /// <param name="shipmentPackageId"></param>
    /// <param name="splitMultiShipmentPackageRequestModel"></param>
    /// <returns></returns>
    Task<bool> SplitMultiShipmentPackageAsync(long shipmentPackageId, SplitMultiShipmentPackageRequestModel splitMultiShipmentPackageRequestModel);

    /// <summary>
    /// Bu servis ile Trendyol üzerinde oluşmuş siparişlerinizi birden fazla 
    /// paket haline getirebilirsiniz. Bu servisi kulandıktan sonra sipariş 
    /// numarasına bağlı yeni paketler "UnPacked" statüsünde, asenkron olarak 
    /// oluşacaktır. Bu nedenle Sipariş Paketlerini Çekme servisinden tekrar 
    /// güncel paketleri çekmelisiniz.
    /// </summary>
    /// <param name="shipmentPackageId"></param>
    /// <param name="splitShipmentPackageRequestModel"></param>
    /// <returns></returns>
    Task<bool> SplitShipmentPackageAsync(long shipmentPackageId, SplitShipmentPackageRequestModel splitShipmentPackageRequestModel);

    /// <summary>
    /// Bu servis ile Trendyol üzerinde oluşmuş siparişlerinizi birden fazla 
    /// paket haline getirebilirsiniz. Bu servisi kulandıktan sonra sipariş 
    /// numarasına bağlı yeni paketler "UnPacked" statüsünde, asenkron olarak 
    /// oluşacaktır. Bu nedenle Sipariş Paketlerini Çekme servisinden tekrar 
    /// güncel paketleri çekmelisiniz.
    /// </summary>
    /// <param name="shipmentPackageId"></param>
    /// <param name="splitMultiPackageByQuantityRequestModel"></param>
    /// <returns></returns>
    Task<bool> SplitShipmentPackageByQuantityAsync(long shipmentPackageId, SplitMultiPackageByQuantityRequestModel splitMultiPackageByQuantityRequestModel);
    
    /// <summary>
    /// Bu servis ile Horoz ve CEVA Lojistik firmalarına ait sipariş paketleriniz 
    /// için desi ve koli bilgisi besleyebilirsiniz.
    /// </summary>
    /// <param name="shipmentPackageId"></param>
    /// <param name="updateBoxInfoRequestModel"></param>
    /// <returns></returns>
    Task<bool> UpdateBoxInfoAsync(long shipmentPackageId, UpdateBoxInfoRequestModel updateBoxInfoRequestModel);
}