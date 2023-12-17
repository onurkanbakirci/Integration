using Integration.Marketplaces.Trendyol.Models.Provider;

namespace Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Constants;
public static class Providers
{
    public static List<GetProviderResponseModel> GetProviders()
    {
        return new List<GetProviderResponseModel>
        {
            new GetProviderResponseModel(41, "DHLMP", "DHL Marketplace", "951-241-77-13"),
            new GetProviderResponseModel(38, "SENDEOMP", "Sendeo Marketplace", "2910804196"),
            new GetProviderResponseModel(36, "NETMP", "NetKargo Lojistik Marketplace", "6930094440"),
            new GetProviderResponseModel(34, "MARSMP", "Mars Lojistik Marketplace", "6120538808"),
            new GetProviderResponseModel(39, "BIRGUNDEMP", "Bir Günde Kargo Marketplace", "1770545653"),
            new GetProviderResponseModel(35, "OCTOMP", "Octovan Lojistik Marketplace", "6330506845"),
            new GetProviderResponseModel(30, "BORMP", "Borusan Lojistik Marketplace", "1800038254"),
            new GetProviderResponseModel(12, "UPSMP", "UPS Kargo Marketplace", "9170014856"),
            new GetProviderResponseModel(13, "AGTMP", "AGT Marketplace", "6090414309"),
            new GetProviderResponseModel(14, "CAIMP", "Cainiao Marketplace", "0"),
            new GetProviderResponseModel(10, "MNGMP", "MNG Kargo Marketplace", "6080712084"),
            new GetProviderResponseModel(19, "PTTMP", "PTT Kargo Marketplace", "7320068060"),
            new GetProviderResponseModel(9, "SURATMP", "Sürat Kargo Marketplace", "7870233582"),
            new GetProviderResponseModel(17, "TEXMP", "Trendyol Express Marketplace", "8590921777"),
            new GetProviderResponseModel(6, "HOROZMP", "Horoz Kargo Marketplace", "4630097122"),
            new GetProviderResponseModel(20, "CEVAMP", "CEVA Marketplace", "8450298557"),
            new GetProviderResponseModel(4, "YKMP", "Yurtiçi Kargo Marketplace", "3130557669"),
            new GetProviderResponseModel(7, "ARASMP", "Aras Kargo Marketplace", "720039666")
        };
    }

    public static GetProviderResponseModel GetProviderById(int id) => GetProviders().First(x => x.Id == id);
    public static GetProviderResponseModel GetProviderByCode(string code) => GetProviders().First(x => x.Code == code);
    public static GetProviderResponseModel GetProviderByName(string name) => GetProviders().First(x => x.Name == name);
}