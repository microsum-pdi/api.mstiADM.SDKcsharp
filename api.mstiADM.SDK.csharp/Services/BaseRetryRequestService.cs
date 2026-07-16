using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using api.mstiADM.SDK.csharp.Resources;
using api.mstiADM.SDK.csharp.ViewModels.Config;
using Newtonsoft.Json;

namespace api.mstiADM.SDK.csharp.Services
{
    public class BaseRetryRequestService
    {
        protected readonly HttpClient httpClient;
        protected readonly ConfigAmbienteSDK configAmbienteSDK;

        public BaseRetryRequestService(ConfigAmbienteSDK _configAmbienteSDK)
        {
            MstiAssert.Check(_configAmbienteSDK, ConfigAmbienteSDK.DEFAULT_MESSAGE_CONFIG_REQUIRED);

            configAmbienteSDK = _configAmbienteSDK;

            if (configAmbienteSDK.HttpClient == null)
                httpClient = new HttpClient();
            else
                httpClient = configAmbienteSDK.HttpClient;
        }

        protected async Task<HttpResponseMessage> SendRequestWithRetry(HttpMethod method, string url, object data = null)
        {
            int max_retries = configAmbienteSDK.MaxRetries;
            int retries = 0;

            while (retries < max_retries)
            {
                var response = await SendRequest(method, url, data);
                var statusCode = response.StatusCode.ToString();

                if (statusCode == "TooManyRequests")
                {
                    int retryAfter = GetRetryAfterFromHeaders(response);
                    if (retryAfter > 0)
                        await Task.Delay(TimeSpan.FromSeconds(retryAfter));
                    else
                        return response;
                }
                else
                {
                    return response;
                }

                retries++;
            }

            return new HttpResponseMessage();
        }

        private async Task<HttpResponseMessage> SendRequest(HttpMethod method, string url, object data = null)
        {
            configAmbienteSDK.VerificaConfiguracaoAmbiente();

            var request = new HttpRequestMessage(method, url);
            request.Headers.TryAddWithoutValidation("x-api-key", configAmbienteSDK.Token);

            if (data != null)
            {
                request.Content = new StringContent(JsonConvert.SerializeObject(data));
                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            }

            return await httpClient.SendAsync(request);
        }

        private int GetRetryAfterFromHeaders(HttpResponseMessage response)
        {
            if (response.Headers.TryGetValues("Retry-After", out IEnumerable<string> values))
            {
                if (double.TryParse(values.FirstOrDefault(), out double retryAfter))
                {
                    return (int)Math.Ceiling(retryAfter);
                }
            }

            return -1;
        }
    }
}