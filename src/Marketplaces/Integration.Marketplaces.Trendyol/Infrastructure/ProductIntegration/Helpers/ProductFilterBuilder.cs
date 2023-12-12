namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Helpers;
public class ProductFilterBuilder
{
    private string _filterQuery;
    public ProductFilterBuilder()
    {
        _filterQuery = string.Empty;
    }

    public ProductFilterBuilder AddApprovalStatus(bool status)
    {
        _filterQuery += $"approvalStatus={status}&";
        return this;
    }

    public ProductFilterBuilder AddBarcode(string barcode)
    {
        _filterQuery += $"barcode={barcode}&";
        return this;
    }

    public ProductFilterBuilder AddStartDate(long startDate)
    {
        _filterQuery += $"startDate={startDate}&";
        return this;
    }

    public ProductFilterBuilder AddEndDate(long endDate)
    {
        _filterQuery += $"endDate={endDate}&";
        return this;
    }

    public ProductFilterBuilder AddPage(int page)
    {
        if (page > 2500)
            throw new Exception("Page must be less than 2500");
        _filterQuery += $"page={page}&";
        return this;
    }

    public ProductFilterBuilder AddSize(string dateQueryType)
    {
        _filterQuery += $"dateQueryType={dateQueryType}&";
        return this;
    }


    public ProductFilterBuilder AddSize(int size)
    {
        _filterQuery += $"size={size}&";
        return this;
    }

    public ProductFilterBuilder AddSupplierId(long supplierId)
    {
        _filterQuery += $"supplierId={supplierId}&";
        return this;
    }

    public ProductFilterBuilder AddStockCode(string stockCode)
    {
        _filterQuery += $"stockCode={stockCode}&";
        return this;
    }

    public ProductFilterBuilder AddArchived(bool archived)
    {
        _filterQuery += $"archived={archived}&";
        return this;
    }

    public ProductFilterBuilder AddProductMainId(string productMainId)
    {
        _filterQuery += $"productMainId={productMainId}&";
        return this;
    }

    public ProductFilterBuilder AddOnSale(bool onSale)
    {
        _filterQuery += $"onSale={onSale}&";
        return this;
    }

    public ProductFilterBuilder AddRejected(bool rejected)
    {
        _filterQuery += $"rejected={rejected}&";
        return this;
    }

    public ProductFilterBuilder AddBlacklisted(bool blacklisted)
    {
        _filterQuery += $"blacklisted={blacklisted}&";
        return this;
    }

    public ProductFilterBuilder AddBrandIds(List<int> brandIds)
    {
        _filterQuery += $"brandIds={string.Join(",", brandIds)}&";
        return this;
    }

    public string Build()
    {
        return _filterQuery.Remove(_filterQuery.Length - 1);
    }
}