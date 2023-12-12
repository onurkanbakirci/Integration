using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Models.Provider;
public class Provider : IModel
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string TaxNumber { get; set; }
    public Provider(int id, string code, string name, string taxNumber)
    {
        Id = id;
        Code = code;
        Name = name;
        TaxNumber = taxNumber;
    }
}