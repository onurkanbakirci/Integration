using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Response;

public class GetCardResponseModel : IResponseModel
{
    public int Id { get; set; }
    public int PosId { get; set; }
    public string CardToken { get; set; }
    public int MerchantId { get; set; }
    public int CustomerNumber { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public long CustomerPhone { get; set; }
    public int Bin { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}