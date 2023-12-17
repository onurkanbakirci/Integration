using Integration.Core;
using Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration;
using Integration.Marketplaces.Trendyol.Infrastructure;

public class HepsiburadaProductIntegration : HepsiburadaIntegrationBase, IHepsiburadaProductIntegration, IMarketplaceIntegration
{
    public HepsiburadaProductIntegration(string username, string password, bool isInProduction = true) : base(username, password, isInProduction)
    {
    }
}