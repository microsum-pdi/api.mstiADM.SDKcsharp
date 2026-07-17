using api.mstiADM.SDK.csharp.Extensions;
using api.mstiADM.SDK.csharp.ViewModels.Config;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Services
{
    public class GenericServices : BaseRetryRequestService
    {
        public GenericServices(ConfigAmbienteSDK configAmbienteSDK): base(configAmbienteSDK){ }

        protected async Task<HttpResponseMessage> ExecutaPut<T>(T dados, string url)
        {
            return await SendRequestWithRetry(HttpMethod.Put, url, dados);
        }

        /// <summary>
        /// Realiza um Post de um MultipartFormDataContent
        /// </summary>
        /// <param name="url">url onde se encontra o endpoint</param>
        /// <param name="form">dados a serem enviados</param>
        public async Task<HttpResponseMessage> ExecutaPostMultiPartFormAsync(string url, MultipartFormDataContent form)
        {
            configAmbienteSDK.VerificaConfiguracaoAmbiente();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.AddXApiKey(configAmbienteSDK.Token);

            return await httpClient.PostAsync(url, form);
        }

        /// <summary>
        /// Realiza um Put de um MultipartFormDataContent
        /// </summary>
        /// <param name="url">url onde se encontra o endpoint</param>
        /// <param name="form">dados a serem enviados</param>
        public async Task<HttpResponseMessage> ExecutaPutMultiPartFormAsync(string url, MultipartFormDataContent form)
        {
            configAmbienteSDK.VerificaConfiguracaoAmbiente();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.AddXApiKey(configAmbienteSDK.Token);

            return await httpClient.PutAsync(url, form);
        }

        protected async Task<HttpResponseMessage> ExecutaPost<T>(T dados, string url)
        {
            return await SendRequestWithRetry(HttpMethod.Post, url, dados);
        }

        protected async Task<HttpResponseMessage> ExecutaGet(string url)
        {
            return await SendRequestWithRetry(HttpMethod.Get, url);
        }

        protected async Task<HttpResponseMessage> ExecutaDelete(string url)
        {
            return await SendRequestWithRetry(HttpMethod.Delete, url);
        }
    }
}
