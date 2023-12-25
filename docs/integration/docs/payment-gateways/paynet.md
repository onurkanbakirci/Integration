---
sidebar_position: 1
---

# Paynet Integration

Integrate your services with paynet

```bash
dotnet add package Integration.PaymentGateways.Paynet
```

Configure your credentials which are given by paynet

```csharp
using Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;

var paynetPaymentIntegration = new PaynetPaymentIntegration(
    secretKey: "secretKey",
    isInProduction: false);
```

:::tip

You have to get your **secretKey** from paynet.

:::

### Get installments

```csharp
var installments = await paynetPaymentIntegration.CheckInstallmentAsync(new CheckInstallmentRequestModel(bin: "bin", amount: 100));
```

### Non secure payment

```csharp
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
```

### Secure payment
Secure payment consist of 3 phases:

  1. **Get secure payment initial**
```csharp
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
```

  2. **Show 3ds html content to user**
```csharp
Console.WriteLine(securePaymentInitialResponse.HtmlContent);
```

  3. **After successfull 3d confirmation, secure payment charge**
```csharp
var securePaymentChargeRequest = await paynetPaymentIntegration.SecurePaymentChargeAsync(new SecurePaymentChargeRequestModel(
    sessionId: securePaymentInitialResponse.SessionId,
    tokenId: securePaymentInitialResponse.TokenId));
```

### Cancel payment
```csharp
var cancelResponse = await paynetPaymentIntegration.CancelAsync(new CancellationRequestModel(
    xactId: "xactId",
    succeedUrl: "succeedUrl"
));
```

### Refund payment
```csharp
var refundResponse = await paynetPaymentIntegration.RefundAsync(new RefundRequestModel(
    xactId: "xactId",
    amount: "100",
    succeedUrl: "succeedUrl"
));
```