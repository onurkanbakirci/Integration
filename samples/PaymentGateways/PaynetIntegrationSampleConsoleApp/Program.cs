using Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Request;

var paynetPaymentIntegration = new PaynetPaymentIntegration(
    secretKey: "secretKey",
    isInProduction: false);

// Get installments
var installments = await paynetPaymentIntegration.CheckInstallmentAsync(new CheckInstallmentRequestModel(bin: "bin", amount: 100));