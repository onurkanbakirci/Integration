using Integration.Hub;
using Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Response;
using Integration.Marketplaces.Trendyol.Infrastructure;

namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration;

public class HepsiburadaProductIntegration : HepsiburadaIntegrationBase, IHepsiburadaProductIntegration, IMarketplaceIntegration
{
    private string GetCategoriesUrl() => $"{GetBaseUrl}product/api/categories/get-all-categories";
    private string GetCategoryAttributesUrl(int categoryId) => $"{GetBaseUrl}product/api/categories/{categoryId}/attributes";
    private string GetCategoryAttributeValueUrl(int categoryId, string attributeId) => $"{GetBaseUrl}product/api/categories/{categoryId}/attribute/{attributeId}/v";

    public HepsiburadaProductIntegration(string username, string password, bool isInProduction = true) : base(username, password, isInProduction)
    {
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns><inheritdoc/></returns>
    public async Task<GetCategoriesResponseModel> GetCategoriesAsync()
    {
        return await InvokeRequestAsync<GetCategoriesResponseModel>((client) => client.GetAsync(GetCategoriesUrl()));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="categoryId"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<GetCategoryAttributesResponseModel> GetCategoryAttributesAsync(int categoryId)
    {
        return await InvokeRequestAsync<GetCategoryAttributesResponseModel>((client) => client.GetAsync(GetCategoryAttributesUrl(categoryId)));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="categoryId"><inheritdoc/></param>
    /// <param name="attributeId"><inheritdoc/></param>
    /// <returns><inheritdoc/></returns>
    public async Task<GetCategoryAttributeValuesResponseModel> GetCategoryAttributeValuesAsync(int categoryId, string attributeId)
    {
        return await InvokeRequestAsync<GetCategoryAttributeValuesResponseModel>((client) => client.GetAsync(GetCategoryAttributeValueUrl(categoryId, attributeId)));
    }
}