using Integration.Hub;
namespace Integration.PaymentGateways.Sipay.Infrastructure.CardIntegration.Request;
public class NonSecurePaymentWithCardTokenRequestModel : IRequestModel
{
    public NonSecurePaymentWithCardTokenRequestModel(string cardToken, int customerNumber, string customerEmail, string customerPhone, string customerName, string currencyCode, int installmentsNumber, string invoiceId, string invoiceDescription, double total, string merchantKey, string items, string cancelUrl, string returnUrl, string hashKey, int orderType)
    {
        CardToken = cardToken;
        CustomerNumber = customerNumber;
        CustomerEmail = customerEmail;
        CustomerPhone = customerPhone;
        CustomerName = customerName;
        CurrencyCode = currencyCode;
        InstallmentsNumber = installmentsNumber;
        InvoiceId = invoiceId;
        InvoiceDescription = invoiceDescription;
        Total = total;
        MerchantKey = merchantKey;
        Items = items;
        CancelUrl = cancelUrl;
        ReturnUrl = returnUrl;
        HashKey = hashKey;
        OrderType = orderType;
    }

    public string CardToken { get; set; }
    public int CustomerNumber { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; }
    public string CustomerName { get; set; }
    public string CurrencyCode { get; set; }
    public int InstallmentsNumber { get; set; }
    public string InvoiceId { get; set; }
    public string InvoiceDescription { get; set; }
    public double Total { get; set; }
    public string MerchantKey { get; set; }
    public string Items { get; set; }
    public string CancelUrl { get; set; }
    public string ReturnUrl { get; set; }
    public string HashKey { get; set; }
    public string BillAddress1 { get; set; }
    public string BillAddress2 { get; set; }
    public string BillCity { get; set; }
    public string BillPostcode { get; set; }
    public string BillState { get; set; }
    public string BillCountry { get; set; }
    public string BillEmail { get; set; }
    public string BillPhone { get; set; }
    public string CardProgram { get; set; }
    public string Ip { get; set; }
    public string TransactionType { get; set; }
    public string SaleWebHookKey { get; set; }
    public int OrderType { get; set; }
    public int RecurringPaymentNumber { get; set; }
    public string RecurringPaymentCycle { get; set; }
    public string RecurringPaymentInterval { get; set; }
    public string RecurringWebHookKey { get; set; }
}