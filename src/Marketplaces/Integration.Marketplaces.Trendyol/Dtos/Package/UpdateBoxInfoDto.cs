using Integration.Core;

public class UpdateBoxInfoDto : IDto
{
    public int BoxQuantity { get; set; }
    public double Deci { get; set; }
    public UpdateBoxInfoDto(int boxQuantity, double deci)
    {
        BoxQuantity = boxQuantity;
        Deci = deci;
    }
}