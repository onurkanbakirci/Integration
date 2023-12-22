using Integration.Hub;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;
public class SecurePaymentInitialRequestModel : IRequestModel
{
    public string Amount { get; set; }

    public string OrderRefNo { get; set; }

    public string AgentReferenceNo { get; set; }

    public string Domain { get; set; }

    public string CardHolder { get; set; }

    public string Pan { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public string CVC { get; set; }

    public string CardHash { get; set; }

    public string CardHolderPhone { get; set; }

    public string CardHolderMail { get; set; }

    public string Description { get; set; }

    public int? Instalment { get; set; }

    public string AgentId { get; set; }

    public string CompanyAmount { get; set; }

    public bool AddCommission { get; set; }

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

    public string ReturnUrl { get; set; }

    public bool ApprovedCard { get; set; }

}