using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Response;
public class UpdateCardResponseModel : IResponseModel
{
    public string CardToken { get; set; }
}