using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Models.Response;
public class SaveCardResponseModel : IResponseModel
{
    public string CardToken { get; set; }
}