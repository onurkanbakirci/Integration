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