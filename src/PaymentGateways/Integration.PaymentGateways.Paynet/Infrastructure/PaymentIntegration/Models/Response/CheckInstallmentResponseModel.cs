using Integration.Hub;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Response;

public class CheckInstallmentResponseModel : IResponseModel
{
    public bool TdsRequired { get; set; }

    public string ObjectName { get; set; }

    public int Code { get; set; }

    public string Message { get; set; }

    public List<CheckInstallmentBankResponseModel> Data { get; set; }
}

public class CheckInstallmentBankResponseModel : IResponseModel
{
    public string Id { get; set; }
    public string Logo { get; set; }
    public string Name { get; set; }
    public string CardType { get; set; }
    public bool TdsRequired { get; set; }
    public List<CheckInstallmentRatioResponseModel> Ratio { get; set; }
}

public class CheckInstallmentRatioResponseModel : IResponseModel
{
    public float RatioNumber { get; set; }
    public string InstalmentKey { get; set; }
    public int Instalment { get; set; }
    public decimal InstalmentAmount { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TotalNetAmount { get; set; }
    public decimal Commission { get; set; }
    public decimal CommissionTax { get; set; }
    public string Desc { get; set; }
    public bool IsHasCampaign { get; set; }
    public int PlusInstallment { get; set; }
    public int PostPone { get; set; }
    public string CampaignNote { get; set; }
}