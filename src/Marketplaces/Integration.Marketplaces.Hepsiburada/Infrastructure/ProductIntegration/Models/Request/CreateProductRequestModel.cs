using Integration.Hub;
namespace Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration.Models.Request;
public class CreateProductRequestModel : IRequestModel
{
    public CreateProductRequestModel(int categoryId, string merchant, List<CreateProductAttributeRequestModel> attributes)
    {
        CategoryId = categoryId;
        Merchant = merchant;
        Attributes = attributes;
    }

    public int CategoryId { get; set; }
    public string Merchant { get; set; }
    public List<CreateProductAttributeRequestModel> Attributes { get; set; }
}

public class CreateProductAttributeRequestModel : IRequestModel
{
    public CreateProductAttributeRequestModel(string merchantSku, string varyantGroupID, string barcode, string urunAdi, string urunAciklamasi, string marka, int garantiSuresi, string kg, string taxVatRate, string price, string stock, string image1, string image2, string image3, string image4, string image5, string video1, string renkVariantProperty, string ebatlarVariantProperty)
    {
        MerchantSku = merchantSku;
        VaryantGroupID = varyantGroupID;
        Barcode = barcode;
        UrunAdi = urunAdi;
        UrunAciklamasi = urunAciklamasi;
        Marka = marka;
        GarantiSuresi = garantiSuresi;
        Kg = kg;
        TaxVatRate = taxVatRate;
        Price = price;
        Stock = stock;
        Image1 = image1;
        Image2 = image2;
        Image3 = image3;
        Image4 = image4;
        Image5 = image5;
        Video1 = video1;
        RenkVariantProperty = renkVariantProperty;
        EbatlarVariantProperty = ebatlarVariantProperty;
    }

    public string MerchantSku { get; set; }
    public string VaryantGroupID { get; set; }
    public string Barcode { get; set; }
    public string UrunAdi { get; set; }
    public string UrunAciklamasi { get; set; }
    public string Marka { get; set; }
    public int GarantiSuresi { get; set; }
    public string Kg { get; set; }
    public string TaxVatRate { get; set; }
    public string Price { get; set; }
    public string Stock { get; set; }
    public string Image1 { get; set; }
    public string Image2 { get; set; }
    public string Image3 { get; set; }
    public string Image4 { get; set; }
    public string Image5 { get; set; }
    public string Video1 { get; set; }
    public string RenkVariantProperty { get; set; }
    public string EbatlarVariantProperty { get; set; }
}