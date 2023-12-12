using Integration.Core;
using Integration.Marketplaces.Trendyol.Models.Address;
using Integration.Marketplaces.Trendyol.Models.Supplier;
namespace Integration.Marketplaces.Trendyol.Dtos.Supplier;
public class GetSupplierDto : IDto
{
    public List<SupplierAddress> SupplierAddresses { get; set; }
    public ShipmentAddress DefaultShipmentAddress { get; set; }
    public InvoiceAddress DefaultInvoiceAddress { get; set; }
    public bool DefaultReturningAddress { get; set; } //TODO check if this is correct
}