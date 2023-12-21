using Integration.Hub;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Response;
public class FilterProductsResponseModel : PaginationModel, IResponseModel
{
    public List<FilterProductResponseModel> Content { get; set; }
}

public class FilterProductResponseModel : IResponseModel
{
    public string Id { get; set; }
    public bool Approved { get; set; }
    public bool Archived { get; set; }
    public int ProductCode { get; set; }
    public string BatchRequestId { get; set; }
    public int SupplierId { get; set; }
    public long CreateDateTime { get; set; }
    public long LastUpdateDate { get; set; }
    public string Gender { get; set; }
    public string Brand { get; set; }
    public string Barcode { get; set; }
    public string Title { get; set; }
    public string CategoryName { get; set; }
    public string ProductMainId { get; set; }
    public string Description { get; set; }
    public string StockUnitType { get; set; }
    public int Quantity { get; set; }
    public double ListPrice { get; set; }
    public double SalePrice { get; set; }
    public int VatRate { get; set; }
    public double DimensionalWeight { get; set; }
    public string StockCode { get; set; }
    public FilterProductDeliveryOptionResponseModel DeliveryOption { get; set; }
    public List<FilterProductImageResponseModel> Images { get; set; }
    public List<FilterProductAttributeResponseModel> Attributes { get; set; }
    public string PlatformListingId { get; set; }
    public string StockId { get; set; }
    public bool HasActiveCampaign { get; set; }
    public bool Locked { get; set; }
    public int ProductContentId { get; set; }
    public int PimCategoryId { get; set; }
    public int BrandId { get; set; }
    public int Version { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
    public bool LockedByUnSuppliedReason { get; set; }
    public bool Onsale { get; set; }
}

public class FilterProductDeliveryOptionResponseModel : IResponseModel
{
    public int DeliveryDuration { get; set; }
    public string FastDeliveryType { get; set; }// TODO: Check
}

public class FilterProductImageResponseModel : IResponseModel
{
    public string Url { get; set; }
}

public class FilterProductAttributeResponseModel : IResponseModel
{
    public int AttributeId { get; set; }
    public string AttributeName { get; set; }
    public int? AttributeValueId { get; set; }
    public string? AttributeValue { get; set; }
}