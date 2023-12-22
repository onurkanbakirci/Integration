﻿using Integration.Hub;

namespace Integration.PaymentGateways.Paynet.Infrastructure.PaymentIntegration.Models.Response;
public class CancellationResponseModel : IResponseModel
{
    public string ObjectName { get; set; }
    public int Code { get; set; }
    public string Message { get; set; }
}