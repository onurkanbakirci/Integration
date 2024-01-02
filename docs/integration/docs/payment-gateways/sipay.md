---
sidebar_position: 2
---

# Sipay Integration

Integrate your services with sipay

```bash
dotnet add package Integration.PaymentGateways.Sipay
```

Configure your credentials which are given by sipay

```csharp
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;

var sipayPaymentIntegration = new SipayPaymentIntegration(
    merchantKey: "merchantKey",
    appKey: "appKey",
    appSecret: "appSecret",
    merchantId: 0,
    isInProduction: false
);
```

:::tip

You have to get your **merchantKey**, **appKey**, **appSecret**, **merchantId** from sipay.

:::

### Authentication/Authorization
Authentication/Authorization is mandatory to further requests
```csharp
await sipayPaymentIntegration.SetTokenAsync();
```

### Get installments

```csharp
var installments = await sipayPaymentIntegration.CheckInstallmentsAsync(new CheckInstallmentRequestModel(
    creaditCard: "123456",
    amount: 100,
    currenyCode: "TRY"
));
```

### Non secure payment

```csharp
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
```

### Secure payment
Secure payment consist of 3 phases:

  1. **Get secure payment initial**
```csharp
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
```

  2. **Show 3ds html content to user**
```csharp
Console.WriteLine(securePaymentInitialHtml);
```

  3. **After successfull 3d confirmation, secure payment charge**
```csharp
var securePaymentChargeRequest = await sipayPaymentIntegration.SecurePaymentChargeAsync(new SecurePaymentChargeRequestModel(
    invoiceId: "1",
    orderId: "1",
    status: "1",
    hashKey: ""));
```

### Cancel payment
```csharp
var cancelResponse = await sipayPaymentIntegration.CancelAsync(new CancellationRequestModel(
    invoiceId: "",
    hashKey: "",
    refundTransactionId: "",
    refundWebhookKey: ""
));
```

### Refund payment
```csharp
var refundResponse = await sipayPaymentIntegration.RefundAsync(new RefundRequestModel(
    invoiceId: "",
    amount: 100,
    hashKey: "",
    refundTransactionId: "",
    refundWebhookKey: ""
));
```