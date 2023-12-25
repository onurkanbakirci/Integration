# Integration Project

<p>
  <a href="https://opensource.org/licenses/MIT">
    <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-blue.svg">
  </a>
  <img src="https://yt3.googleusercontent.com/tOTacHyEgTXLN6JWT8ftiZ-xtHnX0R_XFRRS-AB_A9FXVrTC5-QhAWNF0pfWi2yi_APG3Q4N1Q=s900-c-k-c0x00ffffff-no-rj" width="48">
  <img src="https://media.licdn.com/dms/image/C4D0BAQE1iTu5X4_WDw/company-logo_200_200/0/1679918244582?e=1710979200&v=beta&t=CccfF3oAMI5QYf_LWKzcvfAocW7x_1aIzXGpgFbueZo" width="48">
  <img src="https://pbs.twimg.com/profile_images/1723743306796953601/ETtAZnlV_400x400.jpg" width="48">
  <img src="https://www.paynet.com.tr/themes/custom/paynet/images/og.jpg" width="90">
</p>

**Synchronize Your Code Universe**

Enhance your integration workflows by leveraging the Integration Library, which encompasses a wide array of industrial API integrations.

## Build Status

&nbsp; | `status` | `version`
--- | --- | --- 
**Integration.Hub** | ![build](https://github.com/onurkanbakirci/Integration/actions/workflows/integration-hub.yml/badge.svg) |  1.0.1
**Integration.Marketplaces.Trendyol** | ![build](https://github.com/onurkanbakirci/Integration/actions/workflows/trendyol-integration.yml/badge.svg) |  1.0.1
**Integration.Marketplaces.Hepsiburada** | ![build](https://github.com/onurkanbakirci/Integration/actions/workflows/hepsiburada-integration.yml/badge.svg) |  1.0.1
**Integration.PaymentGateways.Paynet** | ![build](https://github.com/onurkanbakirci/Integration/actions/workflows/paynet-integration.yml/badge.svg) |  1.0.0
**Integration.PaymentGateways.Sipay** | ![build](https://github.com/onurkanbakirci/Integration/actions/workflows/sipay-integration.yml/badge.svg) |  1.0.0

## Table of contents

- [Integration Project](#integration-project)
  - [Build Status](#build-status)
  - [Table of contents](#table-of-contents)
  - [Introduction](#introduction)
  - [How to use](#how-to-use)
    - [Trendyol](#trendyol)
    - [Hepsiburada](#hepsiburada)
    - [Paynet](#paynet)
    - [Sipay](#sipay)


## Introduction

Enhance your integration workflows by leveraging the Integration Library, which encompasses a wide array of industrial API integrations. This library is designed to streamline and facilitate the integration process, providing seamless connectivity to various APIs commonly used in industrial settings. Whether you're working with manufacturing, automation, or any other industry, the Integration Library is a valuable resource to foster efficient and effective integration of diverse systems and services.


## How to use

### Trendyol

```
dotnet add package Integration.Marketplaces.Trendyol --version 1.0.1
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
dotnet add package Integration.Marketplaces.Hepsiburada --version 1.0.1
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

### Paynet

```
dotnet add package Integration.PaymentGateways.Paynet --version 1.0.0
```

```c#
using Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;

var paynetPaymentIntegration = new PaynetPaymentIntegration(
    secretKey: "secretKey",
    isInProduction: false);

// Get installments
var installments = await paynetPaymentIntegration.CheckInstallmentAsync(new CheckInstallmentRequestModel(bin: "bin", amount: 100));

// Non secure payment
var nonSecurePaymentResponse = await paynetPaymentIntegration.NonSecurePaymentAsync(new NonSecurePaymentRequestModel(
    amount: "100",
    referenceNo: "referenceNo",
    domain: "domain",
    cardHolder: "cardHolder",
    pan: "pan",
    month: "month",
    year: "year",
    cvc: "cvc",
    instalment: 1));

// Secure payment
// 1. Get secure payment initial
var securePaymentInitialResponse = await paynetPaymentIntegration.SecurePaymentInitialAsync(new SecurePaymentInitialRequestModel(
    amount: "100",
    orderRefNo: "orderRefNo",
    domain: "domain",
    cardHolder: "cardHolder",
    pan: "pan",
    month: 1,
    year: 2021,
    cVC: "cVC",
    returnUrl: "returnUrl",
    instalment: 1));

// 2. Show 3ds html content to user
Console.WriteLine(securePaymentInitialResponse.HtmlContent);

// 3. After successfull 3d confirmation, secure payment charge
var securePaymentChargeRequest = await paynetPaymentIntegration.SecurePaymentChargeAsync(new SecurePaymentChargeRequestModel(
    sessionId: securePaymentInitialResponse.SessionId,
    tokenId: securePaymentInitialResponse.TokenId));

// Cancel payment
var cancelResponse = await paynetPaymentIntegration.CancelAsync(new CancellationRequestModel(
    xactId: "xactId",
    succeedUrl: "succeedUrl"
));

// Refund payment
var refundResponse = await paynetPaymentIntegration.RefundAsync(new RefundRequestModel(
    xactId: "xactId",
    amount: "100",
    succeedUrl: "succeedUrl"
));
```

### Sipay

```
dotnet add package Integration.PaymentGateways.Sipay --version 1.0.0
```

```c#
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Response;

var sipayPaymentIntegration = new SipayPaymentIntegration(
    merchantKey: "merchantKey",
    appKey: "appKey",
    appSecret: "appSecret",
    merchantId: 0,
    isInProduction: false
);

// Get installments
var installments = await sipayPaymentIntegration.CheckInstallmentsAsync(new CheckInstallmentRequestModel(
    creaditCard: "123456",
    amount: 100,
    currenyCode: "TRY"
));

// Non secure payment
var nonSecurePaymentResponse = await sipayPaymentIntegration.NonSecurePaymentAsync(new NonSecurePaymentRequestModel(
    ccHolderName: "John Doe",
    ccNo: "123456",
    expiryMonth: 12,
    expiryYear: 2022,
    cvv: 123,
    currencyCode: "TRY",
    installmentsNumber: 1,
    invoiceId: 1,
    invoiceDescription: "Invoice description",
    name: "John",
    surname: "Doe",
    total: 100,
    items: "items",
    cancelUrl: "https://cancelUrl.com",
    returnUrl: "https://returnUrl.com",
    hashKey: "hashKey",
    ip: "",
    orderType: 0
));

// Secure payment
// 1. Get secure payment hmtl content and show to user
var securePaymentInitialHtml = sipayPaymentIntegration.SecurePaymentInitial(new SecurePaymentInitialRequestModel(
    ccHolderName: "John Doe",
    ccNo: "123456",
    expiryMonth: 12,
    expiryYear: 2022,
    cvv: 123,
    currencyCode: "TRY",
    installmentsNumber: 1,
    invoiceId: "1",
    invoiceDescription: "Invoice description",
    name: "John",
    surname: "Doe",
    total: 100,
    items: "items",
    cancelUrl: "https://cancelUrl.com",
    returnUrl: "https://returnUrl.com",
    hashKey: "hashKey",
    orderType: 0,
    recurringPaymentNumber: 0,
    recurringPaymentCycle: "",
    recurringPaymentInterval: "",
    recurringWebHookKey: "",
    maturityPeriod: 0,
    paymentFrequency: 0
));

// 2. Show 3ds html content to user
Console.WriteLine(securePaymentInitialHtml);

// 3. After successfull 3d confirmation, secure payment charge
var securePaymentChargeRequest = await sipayPaymentIntegration.SecurePaymentChargeAsync(new SecurePaymentChargeRequestModel(
    invoiceId: "1",
    orderId: "1",
    status: "1",
    hashKey: ""));


// Cancel payment
var cancelResponse = await sipayPaymentIntegration.CancelAsync(new CancellationRequestModel(
    invoiceId: "",
    hashKey: "",
    refundTransactionId: "",
    refundWebhookKey: ""
));

// Refund payment
var refundResponse = await sipayPaymentIntegration.RefundAsync(new RefundRequestModel(
    invoiceId: "",
    amount: 100,
    hashKey: "",
    refundTransactionId: "",
    refundWebhookKey: ""
));
```