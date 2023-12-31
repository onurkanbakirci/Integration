using Integration.Hub;

namespace Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Response;
public class CheckInstallmentResponseModel : IResponseModel
{
    public int PosId { get; set; }
    public int CampaignId { get; set; }
    public int AllocationId { get; set; }
    public int InstallmentsNumber { get; set; }
    public string CardType { get; set; }
    public string CardScheme { get; set; }
    public string CardProgram { get; set; }
    public double PayableAmount { get; set; }
    public string HashKey { get; set; }
    public string AmountToBePaid { get; set; }
    public string CurrencyCode { get; set; }
    public int CurrencyId { get; set; }
    //public string Title { get; set; }//Sipay has problem. This prop can be both string and int
}