using Integration.Core;
namespace Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Request;
public class AddInvoiceLinkRequestModel : IRequestModel
{
   public string InvoiceLink { get; set; }
    public int ShipmentPackageId { get; set; }
    public int InvoiceDateTime { get; set; }
    public string InvoiceNumber { get; set; }
    public AddInvoiceLinkRequestModel(string invoiceLink, int shipmentPackageId, int invoiceDateTime, string invoiceNumber)
    {
        InvoiceLink = invoiceLink;
        ShipmentPackageId = shipmentPackageId;
        InvoiceDateTime = invoiceDateTime;
        InvoiceNumber = invoiceNumber;
    }
}