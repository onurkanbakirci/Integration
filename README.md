# Integration Project

<p>
  <a href="https://opensource.org/licenses/MIT">
    <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-blue.svg">
  </a>
  <img src="https://yt3.googleusercontent.com/tOTacHyEgTXLN6JWT8ftiZ-xtHnX0R_XFRRS-AB_A9FXVrTC5-QhAWNF0pfWi2yi_APG3Q4N1Q=s900-c-k-c0x00ffffff-no-rj" width="48">
  <img src="https://media.licdn.com/dms/image/C4D0BAQE1iTu5X4_WDw/company-logo_200_200/0/1679918244582?e=1710979200&v=beta&t=CccfF3oAMI5QYf_LWKzcvfAocW7x_1aIzXGpgFbueZo" width="48">
</p>

**Synchronize Your Code Universe**

Enhance your integration workflows by leveraging the Integration Library, which encompasses a wide array of industrial API integrations.

## Build Status

&nbsp; | `status` | `version`
--- | --- | --- 
**Integration.Hub** | ![build](https://github.com/onurkanbakirci/Integration/actions/workflows/integration-hub.yml/badge.svg) |  1.0.0
**Integration.Marketplaces.Trendyol** | ![build](https://github.com/onurkanbakirci/Integration/actions/workflows/trendyol-integration.yml/badge.svg) |  1.0.0
**Integration.Marketplaces.Hepsiburada** | ![build](https://github.com/onurkanbakirci/Integration/actions/workflows/hepsiburada-integration.yml/badge.svg) |  1.0.0

## Table of contents

- [Integration Project](#integration-project)
  - [Build Status](#build-status)
  - [Table of contents](#table-of-contents)
  - [Introduction](#introduction)
  - [How to use](#how-to-use)
    - [Trendyol](#trendyol)
    - [Hepsiburada](#hepsiburada)


## Introduction

Enhance your integration workflows by leveraging the Integration Library, which encompasses a wide array of industrial API integrations. This library is designed to streamline and facilitate the integration process, providing seamless connectivity to various APIs commonly used in industrial settings. Whether you're working with manufacturing, automation, or any other industry, the Integration Library is a valuable resource to foster efficient and effective integration of diverse systems and services.


## How to use

### Trendyol

```
dotnet add package Integration.Marketplaces.Trendyol --version 1.0.0
```

```c#
using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration;
using Integration.Marketplaces.Trendyol.Infrastructure.ProductIntegration.Helpers;

var trendyolProductIntegration = new TrendyolProductIntegration(
        supplierId: "supplierId",
        apiKey: "apiKey",
        apiSecret: "apiSecret",
        isInProduction: false,
        entegratorFirm: "entegratorFirm");

//Get All Categories
var categories = await trendyolProductIntegration.GetCategoryTreeAsync();

//Get All Brands
var brands = await trendyolProductIntegration.GetBrandsAsync();

//Filter products
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

### Hepsiburada

```
dotnet add package Integration.Marketplaces.Hepsiburada --version 1.0.0
```

```c#
using Integration.Marketplaces.Hepsiburada.Infrastructure.ProductIntegration;

var hepsiburadaProductIntegration = new HepsiburadaProductIntegration(
        username: "username",
        password: "password",
        isInProduction: false);

//Get All Categories
var categories = await hepsiburadaProductIntegration.GetCategoriesAsync();

//Get Category Attributes
var categoryAttributes = await hepsiburadaProductIntegration.GetCategoryAttributesAsync(categoryId: 80844002);

// Get Category Attribute Values
var categoryAttributeValues = await hepsiburadaProductIntegration.GetCategoryAttributeValuesAsync(categoryId: 80844002, attributeId: "gram");
```
