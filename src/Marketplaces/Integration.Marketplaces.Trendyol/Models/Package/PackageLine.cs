using Integration.Core;

public class PackageLine : IModel
{
    public int Quantity { get; set; }
    public int SalesCampaignId { get; set; }
    public string ProductSize { get; set; }
    public string MerchantSku { get; set; }
    public string ProductName { get; set; }
    public int ProductCode { get; set; }
    public string ProductOrigin { get; set; }
    public int MerchantId { get; set; }
    public double Amount { get; set; }
    public double Discount { get; set; }
    public double TyDiscount { get; set; }
    public List<PackageDiscountDetail> DiscountDetails { get; set; }
    public List<PackageFastDeliveryOption> FastDeliveryOptions { get; set; }
    public string CurrencyCode { get; set; }
    public string ProductColor { get; set; }
    public int Id { get; set; }
    public string Sku { get; set; }
    public int VatBaseAmount { get; set; }
    public string Barcode { get; set; }
    public string OrderLineItemStatusName { get; set; }
    public double Price { get; set; }
}