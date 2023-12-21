using Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;

namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration;
public interface IHepsiburadaProductIntegration
{
    /// <summary>
    /// Bu metod ile Hepsiburada kategorileri bilgilerini alabilirsiniz.
    /// </summary>
    /// <returns><see cref="GetCategoriesResponseModel"/></returns>
    public Task<GetCategoriesResponseModel> GetCategoriesAsync();

    /// <summary>
    /// Bu metod ile Hepsiburada’ daki uç kategorilerin özellik bilgilerini alabilirsiniz. 
    /// Kategori özellikleri, sadece ‘leaf’ ve ‘available’ değerleri ‘true’ olan kategorilerde mevcuttur.
    /// </summary>
    /// <returns><see cref="GetCategoryAttributesResponseModel"/></returns>
    public Task<GetCategoryAttributesResponseModel> GetCategoryAttributesAsync(int categoryId);

    /// <summary>
    /// Bu metod ile ‘type’ alanı değeri ‘enum’ olan özellikler için kullanılabilecek değerleri alabilirsiniz.
    /// </summary>
    /// <param name="categoryId">Category id</param>
    /// <param name="attributeId">Attribute id</param>
    /// <returns><see cref="GetCategoryAttributeValuesResponseModel"/></returns>
    public Task<GetCategoryAttributeValuesResponseModel> GetCategoryAttributeValuesAsync(int categoryId, string attributeId);
}