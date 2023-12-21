using Integration.Hub;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Models.Response;

public class GetSuppliersAddressesResponseModel : IResponseModel
{
    public List<SupplierAddressResponse> SupplierAddresses { get; set; }
    public DefaultShipmentAddressResponse DefaultShipmentAddress { get; set; }
    public DefaultInvoiceAddressResponse DefaultInvoiceAddress { get; set; }
    public DefaultReturningAddressResponse DefaultReturningAddress { get; set; }
}

public class SupplierAddressResponse
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

public class DefaultShipmentAddressResponse
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Company { get; set; }
    public string Address1 { get; set; }
    public string? Address2 { get; set; }
    public string City { get; set; }
    public int CityCode { get; set; }
    public string District { get; set; }
    public int DistrictId { get; set; }
    public string PostalCode { get; set; }
    public string CountryCode { get; set; }
    public int NeighborhoodId { get; set; }
    public string Neighborhood { get; set; }
    public string? Phone { get; set; }
    public string FullName { get; set; }
    public string FullAddress { get; set; }
}

public class DefaultInvoiceAddressResponse
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Company { get; set; }
    public string Address1 { get; set; }
    public string? Address2 { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public int DistrictId { get; set; }
    public string? PostalCode { get; set; }
    public string CountryCode { get; set; }
    public int NeighborhoodId { get; set; }
    public string Neighborhood { get; set; }
    public string? Phone { get; set; }
    public string FullName { get; set; }
    public string FullAddress { get; set; }
    public string TaxOffice { get; set; }
    public string TaxNumber { get; set; }
}

public class DefaultReturningAddressResponse
{
    public bool Present { get; set; }
}