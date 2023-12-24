---
sidebar_position: 2
---

# Trendyol Integration

Integrate your services with trendyol

## How to use

```bash
dotnet add package Integration.Marketplaces.Trendyol
```


Configure your credentials which are given by trendyol

```csharp
using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration;

var trendyolProductIntegration = new TrendyolProductIntegration(
        supplierId: "supplierId",
        apiKey: "apiKey",
        apiSecret: "apiSecret",
        isInProduction: false,
        entegratorFirm: "entegratorFirm");
```

:::tip

You have to get your **supplierId**, **apiKey** and **apiSecret** from trendyol.

:::

### Get all categories

```csharp
var categories = await trendyolProductIntegration.GetCategoryTreeAsync();
```

### Get all brands

```csharp
var brands = await trendyolProductIntegration.GetBrandsAsync();
```

### Filter products

Get values of category attribute

```csharp
var productFilter = new ProductFilterBuilder()
    .AddApprovalStatus(true)
    .AddBarcode("barcode")
    .AddStartDate(0)
    .AddEndDate(0)
    .AddPage(1)
    .AddSize(10)
    .AddSupplierId(0)
    .Build();

var products = await trendyolProductIntegration.FilterProductsAsync(productFilter);
```
