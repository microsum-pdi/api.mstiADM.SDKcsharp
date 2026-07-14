using api.mstiADM.SDK.csharp.Extensions;
using api.mstiADM.SDK.csharp.ViewModels.Config;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Services
{
    public class GenericServices
    {
        public readonly HttpClient _httpClient;
        protected ConfigAmbienteSDK configAmbienteSDK;

        public GenericServices(ConfigAmbienteSDK configAmbienteSDK)
        {
            this.configAmbienteSDK = configAmbienteSDK;

            if (configAmbienteSDK.HttpClient == null)
                _httpClient = new HttpClient();
            else
                _httpClient = configAmbienteSDK.HttpClient;
        }

        protected async Task<HttpResponseMessage> ExecutaPut<T>(T dados, string url)
        {
            VerificaConfiguracaoAmbiente();
            var request = new HttpRequestMessage(new HttpMethod("PUT"), url);
            request.Headers.TryAddWithoutValidation("x-api-key", configAmbienteSDK.Token);
            request.Content = new StringContent(JsonConvert.SerializeObject(dados));
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            HttpResponseMessage response = await _httpClient.SendAsync(request);
            return response;
        }

        /// <summary>
        /// Realiza um Post de um MultipartFormDataContent
        /// </summary>
        /// <param name="url">url onde se encontra o endpoint</param>
        /// <param name="form">dados a serem enviados</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> ExecutaPostMultiPartFormAsync(string url, MultipartFormDataContent form)
        {
            VerificaConfiguracaoAmbiente();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.AddXApiKey(configAmbienteSDK.Token);

            HttpResponseMessage response = await _httpClient.PostAsync(url, form);

            return response;
        }

        protected async Task<HttpResponseMessage> ExecutaPost<T>(T dados, string url)
        {
            VerificaConfiguracaoAmbiente();
            var request = new HttpRequestMessage(new HttpMethod("POST"), url);
            request.Headers.TryAddWithoutValidation("x-api-key", configAmbienteSDK.Token);
            request.Content = new StringContent(JsonConvert.SerializeObject(dados));
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            HttpResponseMessage response = await _httpClient.SendAsync(request);
            return response;
        }

        protected async Task<HttpResponseMessage> ExecutaGet(string url)
        {
            VerificaConfiguracaoAmbiente();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.AddXApiKey(configAmbienteSDK.Token);

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            return response;
        }

        protected async Task<HttpResponseMessage> ExecutaDelete(string url)
        {
            VerificaConfiguracaoAmbiente();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.AddXApiKey(configAmbienteSDK.Token);

            HttpResponseMessage response = await _httpClient.DeleteAsync(url);
            return response;
        }

        private void VerificaConfiguracaoAmbiente()
        {
            if (configAmbienteSDK == null ||
               string.IsNullOrEmpty(configAmbienteSDK?.Token) ||
               string.IsNullOrEmpty(configAmbienteSDK?.URL))
            {
                throw new Exception("Necessário executar a configuração do ambiente (ConfigAmbienteSDKServices.ConfigurarAmbiente(new ConfigAmbienteSDK())), antes de comunicar com a API ami.ADM.");
            }
        }
    }
}
