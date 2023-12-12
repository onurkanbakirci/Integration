namespace Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration.Helpers;
public class ClaimFilterBuilder
{
    private string _filterQuery;
    public ClaimFilterBuilder()
    {
        _filterQuery = string.Empty;
    }

    public ClaimFilterBuilder AddClaimIds(List<int> claimIds)
    {
        _filterQuery += $"claimIds={string.Join(",", claimIds)}&";
        return this;
    }

    public ClaimFilterBuilder AddClaimItemStatus(string status)
    {
        _filterQuery += $"claimItemStatus={status}&";
        return this;
    }

    public ClaimFilterBuilder AddStartDate(long startDate)
    {
        _filterQuery += $"startDate={startDate}&";
        return this;
    }

    public ClaimFilterBuilder AddEndDate(long endDate)
    {
        _filterQuery += $"endDate={endDate}&";
        return this;
    }

    public ClaimFilterBuilder AddOrderNumber(string orderNumber)
    {
        _filterQuery += $"orderNumber={orderNumber}&";
        return this;
    }

    public ClaimFilterBuilder AddSize(int size)
    {
        _filterQuery += $"size={size}&";
        return this;
    }

    public ClaimFilterBuilder AddPage(int page)
    {
        _filterQuery += $"page={page}&";
        return this;
    }

    public string Build()
    {
        return _filterQuery.Remove(_filterQuery.Length - 1);
    }
}