# Integration Project 

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**Synchronize Your Code Universe**

Enhance your integration workflows by leveraging the Integration Library, which encompasses a wide array of industrial API integrations.

## Build Status

&nbsp; | `status` | `version`
--- | --- | --- 
**Integration.Core** | ![build](https://github.com/onurkanbakirci/Integration/actions/workflows/integration-core.yml/badge.svg) |  1.0.0
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

var trendyolProductIntegration = new TrendyolProductIntegration("supplierId", "apiKey", "apiSecret", false, "entegratorFirm");

//Get All Categories
var categories = trendyolProductIntegration.GetCategoryTreeAsync();

//Get All Brands
var brands = trendyolProductIntegration.GetBrandsAsync();

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

var products = trendyolProductIntegration.FilterProductsAsync(productFilter);
```

### Hepsiburada

```
dotnet add package Integration.Marketplaces.Hepsiburada --version 1.0.0
```
