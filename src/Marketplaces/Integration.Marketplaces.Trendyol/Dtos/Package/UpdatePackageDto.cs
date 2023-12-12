using Integration.Core;
using Integration.Marketplaces.Trendyol.Infrastructure.OrderIntegration.Constants;
namespace Integration.Marketplaces.Trendyol.Dtos.Package;
public class UpdatePackageDto : IDto
{
    public List<UpdatePackageLineDto> Lines { get; set; }
    public PackageStatus Status { get; set; }
    public UpdatePackageParamsDto? Params { get; set; }

    public UpdatePackageDto(List<UpdatePackageLineDto> lines, PackageStatus status, string? invoiceNumber)
    {
        Lines = lines;
        Status = status;

        if (!string.IsNullOrEmpty(invoiceNumber))
            Params = new UpdatePackageParamsDto(invoiceNumber);
    }
}

public class UpdatePackageLineDto : IDto
{
    public long LineId { get; set; }
    public int Quantity { get; set; }
    public UpdatePackageLineDto(long lineId, int quantity)
    {
        LineId = lineId;
        Quantity = quantity;
    }
}

public class UpdatePackageParamsDto : IDto
{
    public string InvoiceNumber { get; set; }

    public UpdatePackageParamsDto(string invoiceNumber)
    {
        InvoiceNumber = invoiceNumber;
    }
}