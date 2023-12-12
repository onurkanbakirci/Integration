using Integration.Core;

namespace Integration.Marketplaces.Trendyol.Dtos.Invoice;
public class DeleteInvoiceLinkDto : IDto
{
    public int ServiceSourceId { get; set; }
    public int ChannelId { get; set; }
    public int CustomerId { get; set; }
    public DeleteInvoiceLinkDto(int serviceSourceId, int channelId, int customerId)
    {
        ServiceSourceId = serviceSourceId;
        ChannelId = channelId;
        CustomerId = customerId;
    }
}