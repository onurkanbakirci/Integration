---
sidebar_position: 1
---

# Hepsiburada Integration

Integrate your services with hepsiburada

## How to use

```bash
dotnet add package Integration.Marketplaces.Hepsiburada
```


Configure your credentials which are given by hepsiburada

```csharp
using Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration;

var hepsiburadaProductIntegration = new HepsiburadaProductIntegration(
        username: "username",
        password: "password",
        isInProduction: false);
```

:::tip

You have to get your **username** and **password** from hepsiburada.

:::

### Get all categories

```csharp
var categories = await hepsiburadaProductIntegration.GetCategoriesAsync();
```

### Get category attributes

Get category attributes of category

```csharp
var categoryAttributes = await hepsiburadaProductIntegration.GetCategoryAttributesAsync(categoryId: 80844002);
```

### Get category attribute values

Get values of category attribute

```csharp
var categoryAttributeValues = await hepsiburadaProductIntegration.GetCategoryAttributeValuesAsync(categoryId: 80844002, attributeId: "gram");
```
