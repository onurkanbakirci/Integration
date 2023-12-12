using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Models.Supplier;
public class SupplierAddress : IModel
{
    public int Id { get; set; }

    public string AddressType { get; set; }

    public string Country { get; set; }

    public string City { get; set; }

    public int CityCode { get; set; }

    public string District { get; set; }

    public int DistrictId { get; set; }

    public string PostCode { get; set; }

    public string Address { get; set; }

    public bool ReturningAddress { get; set; }

    public string FullAddress { get; set; }

    public bool ShipmentAddress { get; set; }

    public bool InvoiceAddress { get; set; }

    public bool Default { get; set; }
}