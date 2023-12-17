using Integration.Core;
using Integration.Marketplaces.Trendyol.Infrastructure.OrderIntegration.Constants;
namespace Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Request;
public class UpdatePackageRequestModel : IRequestModel
{
    public List<UpdatePackageLineRequestModel> Lines { get; set; }
    public PackageStatus Status { get; set; }
    public UpdatePackageParamsRequestModel? Params { get; set; }

    public UpdatePackageRequestModel(List<UpdatePackageLineRequestModel> lines, PackageStatus status, string? invoiceNumber)
    {
        Lines = lines;
        Status = status;

        if (!string.IsNullOrEmpty(invoiceNumber))
            Params = new UpdatePackageParamsRequestModel(invoiceNumber);
    }
}

public class UpdatePackageLineRequestModel : IRequestModel
{
    public long LineId { get; set; }
    public int Quantity { get; set; }
    public UpdatePackageLineRequestModel(long lineId, int quantity)
    {
        LineId = lineId;
        Quantity = quantity;
    }
}

public class UpdatePackageParamsRequestModel : IResponseModel
{
    public string InvoiceNumber { get; set; }

    public UpdatePackageParamsRequestModel(string invoiceNumber)
    {
        InvoiceNumber = invoiceNumber;
    }
}