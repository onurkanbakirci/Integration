using System.Text;
using System.Text.Json;

namespace Integration.Hub;

public class IntegrationBase
{
    protected static readonly HttpClient _httpClient;
    static IntegrationBase()
    {
        _httpClient = new HttpClient();
    }

    public async Task<TResponse> InvokeRequestAsync<TResponse>(Func<HttpClient, Task<HttpResponseMessage>> httpRequest) where TResponse : IResponseModel
    {
        var response = await httpRequest.Invoke(_httpClient);
        var responseAsString = await response.Content.ReadAsStringAsync();
        var isSuccess = response.IsSuccessStatusCode;
        if (!isSuccess)
            throw new Exception(responseAsString);

        return JsonSerializer.Deserialize<TResponse>(responseAsString)!;
    }

    public async Task<bool> InvokeRequestAsync(Func<HttpClient, Task<HttpResponseMessage>> httpRequest)
    {
        var response = await httpRequest.Invoke(_httpClient);
        var responseAsString = await response.Content.ReadAsStringAsync();
        var isSuccess = response.IsSuccessStatusCode;
        if (!isSuccess)
            throw new Exception(responseAsString);

        return isSuccess;
    }

    public async Task<TResponse> InvokeRequestAsync<TResponse>(Func<HttpClient, StringContent?, Task<HttpResponseMessage>> httpRequest, IRequestModel requestModel) where TResponse : IResponseModel
    {
        var jsonData = JsonSerializer.Serialize(requestModel);
        var requestBody = new StringContent(jsonData, Encoding.UTF8, "application/json");

        var response = await httpRequest.Invoke(_httpClient, requestBody);
        var responseAsString = await response.Content.ReadAsStringAsync();
        var isSuccess = response.IsSuccessStatusCode;
        if (!isSuccess)
            throw new Exception(responseAsString);
        return JsonSerializer.Deserialize<TResponse>(responseAsString)!;
    }

    public async Task<bool> InvokeRequestAsync(Func<HttpClient, StringContent?, Task<HttpResponseMessage>> httpRequest, IRequestModel requestModel)
    {
        var jsonData = JsonSerializer.Serialize(requestModel);
        var requestBody = new StringContent(jsonData, Encoding.UTF8, "application/json");

        var response = await httpRequest.Invoke(_httpClient, requestBody);
        var responseAsString = await response.Content.ReadAsStringAsync();
        var isSuccess = response.IsSuccessStatusCode;
        if (!isSuccess)
            throw new Exception(responseAsString);
        return isSuccess;
    }
}