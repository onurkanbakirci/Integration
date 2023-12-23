using Integration.Hub;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;
public class CheckInstallmentRequestModel : IRequestModel
{
    public int? PosType { get; set; }
    public string? RatioCode { get; set; }
    public string? Bin { get; set; }
    public decimal? Amount { get; set; }
    public string? AgentId { get; set; }
    public string? CardType { get; set; }
    public bool? AddcomissionToAmount { get; set; }
    public bool? MergeOption { get; set; }

    public CheckInstallmentRequestModel(int? posType = null, string? ratioCode = null, string? bin = null, decimal? amount = null, string? agentId = null, string? cardType = null, bool? addcomissionToAmount = null, bool? mergeOption = null)
    {
        PosType = posType;
        RatioCode = ratioCode;
        Bin = bin;
        Amount = amount;
        AgentId = agentId;
        CardType = cardType;
        AddcomissionToAmount = addcomissionToAmount;
        MergeOption = mergeOption;
    }
}