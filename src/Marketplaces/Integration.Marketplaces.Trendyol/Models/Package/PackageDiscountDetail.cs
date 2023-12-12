using Integration.Core;

public class PackageDiscountDetail : IModel
{
    public double LineItemPrice { get; set; }
    public double LineItemDiscount { get; set; }
    public double LineItemTyDiscount { get; set; }
}