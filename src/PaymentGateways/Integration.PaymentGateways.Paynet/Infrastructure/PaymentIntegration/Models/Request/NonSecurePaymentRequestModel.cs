using Integration.Hub;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;
public class NonSecurePaymentRequestModel : IRequestModel
{
    public NonSecurePaymentRequestModel(string amount, string referenceNo, string domain, string cardHolder, string pan, string month, string year, string cvc, int? instalment = null)
    {
        Amount = amount;
        ReferenceNo = referenceNo;
        Domain = domain;
        CardHolder = cardHolder;
        Pan = pan;
        Month = month;
        Year = year;
        CVC = cvc;
        Instalment = instalment;
    }

    /// <summary>
    /// Kredi kartından çekilecek tutar. Ondalık ayıraç olarak virgül (,)  kullanılmaktadır.(Zorunlu)
    /// </summary>
    public string Amount { get; set; }

    /// <summary>
    /// Ödeme işleminin ilişkili olduğu referans numarası. Tekil (unique) bir veri olmalı. ( örn: sipariş numarası) (Zorunlu)
    /// </summary>
    public string ReferenceNo { get; set; }

    /// <summary>
    /// İşlemin yapıldığı uygulamanın domain bilgisi. ( örn: www.acme.com ) (Zorunlu)
    /// </summary>
    public string Domain { get; set; }

    /// <summary>
    /// Kart sahibi bilgisi Saklı kart ile işlem yapılmıyorsa zorunlu.
    /// </summary>
    public string CardHolder { get; set; }

    /// <summary>
    /// Kart numarası Saklı kart ile işlem yapılmıyorsa zorunlu.
    /// </summary>
    public string Pan { get; set; }

    /// <summary>
    /// Son kullanma tarihi Ay bilgisi. ( örn: 8,12 )  Saklı kart ile işlem yapılmıyorsa zorunlu.
    /// </summary>
    public string Month { get; set; }

    /// <summary>
    /// Son kullanma tarihi Yıl bilgisi. ( örn: 2020, 2030  ) Saklı kart ile işlem yapılmıyorsa zorunlu.
    /// </summary>
    public string Year { get; set; }

    /// <summary>
    /// Kart güvenlik kodu. 
    //Saklı kart ile işlem yapılmıyorsa zorunlu.
    /// </summary>
    public string CVC { get; set; }

    /// <summary>
    /// Ana firma bayi referans kodu (Zorunlu değil)
    /// </summary>
    public string AgentReferenceNo { get; set; }

    public string CardHash { get; set; }

    public string CardHolderName { get; set; }

    public string CardHolderMail { get; set; }

    public string Description { get; set; }

    public int? Instalment { get; set; }

    public string AgentId { get; set; }

    public string CompanyAmount { get; set; }

    public bool AddCommission { get; set; }

    public int TransactionType { get; set; }

    public string RatioCode { get; set; }

    public bool SaveCard { get; set; }

    public string CardDesc { get; set; }

    public string UserUniqueId { get; set; }

    public string CardOwnerId { get; set; }

    public string UserGsmNo { get; set; }

    public string SubscriptionId { get; set; }

    public string InvoiceNo { get; set; }

    public string RatioCodeMethod { get; set; }

    public bool MergeOption { get; set; }

    public int PosType { get; set; }

    public string UserId { get; set; }

    public bool DontApplyCampaign { get; set; }

    public bool IsEscrow { get; set; }

    public string AgentCustomerName { get; set; }

    public string Iban { get; set; }

    public bool ApprovedCard { get; set; }
}