using Integration.Core;
using Integration.Marketplaces.Trendyol.Infrastructure.OrderIntegration.Constants;

namespace Integration.Marketplaces.Trendyol.Infrastructure.OrderIntegration.Helpers;
public class ShipmentFilterBuilder : IFilterBuilder
{
    private string _filterQuery;
    public ShipmentFilterBuilder()
    {
        _filterQuery = string.Empty;
    }

    public ShipmentFilterBuilder AddStartDate(long startDate)
    {
        _filterQuery += $"startDate={startDate}&";
        return this;
    }
    public ShipmentFilterBuilder AddEndDate(long endDate)
    {
        _filterQuery += $"endDate={endDate}&";
        return this;
    }

    public ShipmentFilterBuilder AddPage(int page)
    {
        _filterQuery += $"page={page}&";
        return this;
    }

    public ShipmentFilterBuilder AddSize(int size)
    {
        if (size > 200)
            throw new Exception("Page must be less than 2500");
        _filterQuery += $"size={size}&";
        return this;
    }
    public ShipmentFilterBuilder AddSupplierId(long supplierId)
    {
        _filterQuery += $"supplierId={supplierId}&";
        return this;
    }

    public ShipmentFilterBuilder AddOrderNumber(string orderNumber)
    {
        _filterQuery += $"orderNumber={orderNumber}&";
        return this;
    }

    public ShipmentFilterBuilder AddStatus(PackageStatus status)
    {
        _filterQuery += $"status={status}&";
        return this;
    }

    public ShipmentFilterBuilder AddOrderByField(OrderField orderByField)
    {
        _filterQuery += $"orderByField={orderByField}&";
        return this;
    }

    public ShipmentFilterBuilder AddOrderByDirection(OrderByDirection orderByDirection)
    {
        _filterQuery += $"orderByDirection={orderByDirection}&";
        return this;
    }

    public ShipmentFilterBuilder AddShipmentPackageIds(List<long> shipmentPackageIds)
    {
        _filterQuery += $"shipmentPackageIds={string.Join(",", shipmentPackageIds)}&";
        return this;
    }

    public string Build()
    {
        return _filterQuery.Remove(_filterQuery.Length - 1);
    }
}