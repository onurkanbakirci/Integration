using Integration.Marketplaces.Trendyol.Models.Provider;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Constants;
public static class Providers
{
    public static List<Provider> GetProviders()
    {
        return new List<Provider>
        {
            new Provider(41, "DHLMP", "DHL Marketplace", "951-241-77-13"),
            new Provider(38, "SENDEOMP", "Sendeo Marketplace", "2910804196"),
            new Provider(36, "NETMP", "NetKargo Lojistik Marketplace", "6930094440"),
            new Provider(34, "MARSMP", "Mars Lojistik Marketplace", "6120538808"),
            new Provider(39, "BIRGUNDEMP", "Bir Günde Kargo Marketplace", "1770545653"),
            new Provider(35, "OCTOMP", "Octovan Lojistik Marketplace", "6330506845"),
            new Provider(30, "BORMP", "Borusan Lojistik Marketplace", "1800038254"),
            new Provider(12, "UPSMP", "UPS Kargo Marketplace", "9170014856"),
            new Provider(13, "AGTMP", "AGT Marketplace", "6090414309"),
            new Provider(14, "CAIMP", "Cainiao Marketplace", "0"),
            new Provider(10, "MNGMP", "MNG Kargo Marketplace", "6080712084"),
            new Provider(19, "PTTMP", "PTT Kargo Marketplace", "7320068060"),
            new Provider(9, "SURATMP", "Sürat Kargo Marketplace", "7870233582"),
            new Provider(17, "TEXMP", "Trendyol Express Marketplace", "8590921777"),
            new Provider(6, "HOROZMP", "Horoz Kargo Marketplace", "4630097122"),
            new Provider(20, "CEVAMP", "CEVA Marketplace", "8450298557"),
            new Provider(4, "YKMP", "Yurtiçi Kargo Marketplace", "3130557669"),
            new Provider(7, "ARASMP", "Aras Kargo Marketplace", "720039666")
        };
    }

    public static Provider GetProviderById(int id) => GetProviders().First(x => x.Id == id);
    public static Provider GetProviderByCode(string code) => GetProviders().First(x => x.Code == code);
    public static Provider GetProviderByName(string name) => GetProviders().First(x => x.Name == name);
}