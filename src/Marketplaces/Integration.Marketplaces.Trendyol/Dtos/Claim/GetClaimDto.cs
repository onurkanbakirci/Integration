using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Dtos.Claim;
public class GetClaimDto : IDto
{
    public List<Claim> Content { get; set; }
}

public class Claim : IDto
{
    public string Id { get; set; }
    public string OrderNumber { get; set; }
    public long OrderDate { get; set; }
    public string CustomerFirstName { get; set; }
    public string CustomerLastName { get; set; }
    public long ClaimDate { get; set; }
    public string CargoTrackingNumber { get; set; }
    public string CargoTrackingLink { get; set; }
    public string CargoSenderNumber { get; set; }
    public string CargoProviderName { get; set; }
    public int OrderShipmentPackageId { get; set; }
    public ReplacementOutboundPackageInfo ReplacementOutboundPackageInfo { get; set; }
    public RejectedPackageInfo RejectedPackageInfo { get; set; }
    public List<ClaimItem> Items { get; set; }
}

public class ReplacementOutboundPackageInfo : IDto
{
    public string CargoTrackingNumber { get; set; }
    public string CargoProviderName { get; set; }
    public string CargoSenderNumber { get; set; }
    public string CargoTrackingLink { get; set; }
    public int Packageid { get; set; }
    public List<string> Items { get; set; }
}

public class RejectedPackageInfo : IDto
{
    public string CargoTrackingNumber { get; set; }
    public string CargoProviderName { get; set; }
    public string CargoTrackingLink { get; set; }
    public int Packageid { get; set; }
    public List<string> Items { get; set; }
}

public class ClaimItem : IDto
{
    public ClaimOrderLine OrderLine { get; set; }
    public List<ClaimItemItem> ClaimItems { get; set; }
}

public class ClaimOrderLine : IDto
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Barcode { get; set; }
    public string MerchantSku { get; set; }
    public string ProductColor { get; set; }
    public string ProductSize { get; set; }
    public double Price { get; set; }
    public int VatBaseAmount { get; set; }
    public int SalesCampaignId { get; set; }
    public string ProductCategory { get; set; }
}

public class ClaimItemItem : IDto
{
    public string Id { get; set; }
    public long OrderLineItemId { get; set; }
    public ClaimItemReason CustomerClaimItemReason { get; set; }
    public ClaimItemReason TrendyolClaimItemReason { get; set; }
    public ClaimItemStatus ClaimItemStatus { get; set; }
    public string Note { get; set; }
    public string CustomerNote { get; set; }
    public bool Resolved { get; set; }
}

public class ClaimItemReason : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ExternalReasonId { get; set; }
    public string Code { get; set; }
}

public class ClaimItemStatus : IDto
{
    public string Name { get; set; }
}