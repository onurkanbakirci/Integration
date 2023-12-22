using Integration.Hub;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Response;
public class SecurePaymentChargeResponseModel: IResponseModel
{
    public bool IsTds { get; set; }
    public int MDStatus { get; set; }
    public int Id { get; set; }
    public string XactId { get; set; }
    public string XactDate { get; set; }
    public int TransactionType { get; set; }
    public int PosType { get; set; }
    public string AgentId { get; set; }
    public string UserId { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Installment { get; set; }
    public decimal Ratio { get; set; }
    public string CardNoMasked { get; set; }
    public string CardHolder { get; set; }
    public decimal Amount { get; set; }
    public decimal NetAmount { get; set; }
    public decimal Comission { get; set; }
    public decimal ComissionTax { get; set; }
    public string Currency { get; set; }
    public string BankId { get; set; }
    public string BankName { get; set; }
    public string BankAuthorizationCode { get; set; }
    public string BankReferenceCode { get; set; }
    public string BankOrderId { get; set; }
    public bool IsSucceed { get; set; }
    public string PaynetErrorId { get; set; }
    public string PaynetErrorMessage { get; set; }
    public string BankErrorId { get; set; }
    public string BankErrorMessage { get; set; }
    public string BankErrorShortDesc { get; set; }
    public string BankErrorLongDesc { get; set; }
    public string ReferenceNo { get; set; }
    public string XactTransactionId { get; set; }
    public string CampaignUrl { get; set; }
    public decimal EndUserComission { get; set; }
    public decimal EndUserRatio { get; set; }
    public string RatioCode { get; set; }
    public string RatioCodeMethod { get; set; }
    public bool IsSaveCardSucceed { get; set; }
    public string SaveCardResultMessage { get; set; }
    public string CardOwnerId { get; set; }
    public string UserUniqueId { get; set; }
    public string CardHash { get; set; }
    public string CardBankId { get; set; }
    public string CardLogoUrl { get; set; }
    public string CompanyCostRatio { get; set; }
    public string Company_Commission { get; set; }
    public string CompanyCommissionWithTax { get; set; }
    public string CompanyNetAmount { get; set; }
    public string PlusInstallment { get; set; }
    public string CardType { get; set; }
    public string CardBrandName { get; set; }
    public string ObjectName { get; set; }
    public int Code { get; set; }
    public string Message { get; set; }
}

