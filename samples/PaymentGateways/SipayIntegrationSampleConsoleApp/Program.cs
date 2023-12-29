using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Request;
using Integration.PaymentGateways.Sipay.Infrastructure.PaymentIntegration.Models.Response;

var sipayPaymentIntegration = new SipayPaymentIntegration(
    merchantKey: "$2y$10$HmRgYosneqcwHj.UH7upGuyCZqpQ1ITgSMj9Vvxn.t6f.Vdf2SQFO",
    appKey: "6d4a7e9374a76c15260fcc75e315b0b9",
    appSecret: "b46a67571aa1e7ef5641dc3fa6f1712a",
    merchantId: 18309,
    isInProduction: false
);

await sipayPaymentIntegration.SetTokenAsync();

// Get installments
var installments = await sipayPaymentIntegration.CheckInstallmentsAsync(new CheckInstallmentRequestModel(
    creditCard: "450803",
    amount: 100,
    currencyCode: "TRY"
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