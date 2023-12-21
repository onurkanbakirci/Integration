using Integration.Hub;
namespace Integration.Marketplaces.Trendyol.Infrastructure.PackageIntegration.Models.Request;
public class DeleteInvoiceLinkRequestModel : IRequestModel
{
    public int ServiceSourceId { get; set; }
    public int ChannelId { get; set; }
    public int CustomerId { get; set; }
    public DeleteInvoiceLinkRequestModel(int serviceSourceId, int channelId, int customerId)
    {
        ServiceSourceId = serviceSourceId;
        ChannelId = channelId;
        CustomerId = customerId;
    }
}