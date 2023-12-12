using Integration.Core;
namespace Integration.Marketplaces.Trendyol.Dtos.Invoice;
public class AddInvoiceLinkDto : IDto
{
    public string InvoiceLink { get; set; }
    public int ShipmentPackageId { get; set; }
    public int InvoiceDateTime { get; set; }
    public string InvoiceNumber { get; set; }
    public AddInvoiceLinkDto(string invoiceLink, int shipmentPackageId, int invoiceDateTime, string invoiceNumber)
    {
        InvoiceLink = invoiceLink;
        ShipmentPackageId = shipmentPackageId;
        InvoiceDateTime = invoiceDateTime;
        InvoiceNumber = invoiceNumber;
    }
}