namespace Integration.Marketplaces.Trendyol.Infrastructure.ClaimIntegration.Constants;
public static class ClaimReasons
{
    public static List<ClaimReason> GetClaimReasons()
    {
        return new List<ClaimReason>
        {
            new ClaimReason(51, "Sebep Yok", "Trendyol"),
            new ClaimReason(101, "Depo Kayıp", "Trendyol"),
            new ClaimReason(151, "Çapraz Hatalı", "Trendyol"),
            new ClaimReason(201, "Müşteri İade Kayıp", "Trendyol"),
            new ClaimReason(251, "Modelini beğenmedim", "Müşteri"),
            new ClaimReason(301, "Kusurlu ürün gönderildi", "Müşteri"),
            new ClaimReason(351, "Yanlış ürün gönderildi", "Müşteri"),
            new ClaimReason(401, "Vazgeçtim", "Müşteri"),
            new ClaimReason(451, "Diğer", "Müşteri"),
            new ClaimReason(501, "Bedeni küçük geldi", "Müşteri"),
            new ClaimReason(551, "Bedeni büyük geldi", "Müşteri"),
            new ClaimReason(651, "Ürün belirtilen özelliklere sahip değil", "Müşteri"),
            new ClaimReason(701, "Yanlış sipariş verdim", "Müşteri"),
            new ClaimReason(751, "Diğer - Fraud Kaynaklı", "Trendyol"),
            new ClaimReason(1651, "Kalitesini beğenmedim", "Müşteri"),
            new ClaimReason(1701, "Kargo Teslimatı Gecikmesi", "Trendyol"),
            new ClaimReason(2000, "Cezalı Onay", "Trendyol"),
            new ClaimReason(2001, "Cezasız Onay", "Trendyol"),
            new ClaimReason(2002, "Teknik Servis Desteği Gerekiyor", "Trendyol"),
            new ClaimReason(2003, "Kullanılmış Ürün Sebepli Red", "Trendyol"),
            new ClaimReason(2004, "Hijyenik Sebepli Red", "Trendyol"),
            new ClaimReason(2005, "Analiz sonucu üretimden kaynaklı sorun yok", "Trendyol"),
            new ClaimReason(2006, "Analiz Değişim", "Trendyol"),
            new ClaimReason(2007, "Analiz Tamirat", "Trendyol"),
            new ClaimReason(2008, "Üründe adet/aksesuar eksiği", "Trendyol"),
            new ClaimReason(2009, "Firmaya ait olmayan ürün", "Trendyol"),
            new ClaimReason(2010, "Tekrar Sevk", "Trendyol"),
            new ClaimReason(2011, "Satıcı Tarafından Aksiyona Çekilen", "Trendyol"),
            new ClaimReason(2012, "İade Süresi Geçmiş", "Trendyol"),
            new ClaimReason(2013, "Ürün Müşteride", "Trendyol"),
            new ClaimReason(2014, "Analize Gönder", "Trendyol"),
            new ClaimReason(2015, "Teslim edilemeyen gönderi", "Trendyol"),
            new ClaimReason(2030, "Daha iyi bir fiyat mevcut", "Müşteri"),

        };
    }

    public static ClaimReason GetClaimReasonById(int id) => GetClaimReasons().First(x => x.Id == id);
}
public class ClaimReason
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Issuer { get; set; }
    public ClaimReason(int id, string description, string issuer)
    {
        Id = id;
        Description = description;
        Issuer = issuer;
    }
}