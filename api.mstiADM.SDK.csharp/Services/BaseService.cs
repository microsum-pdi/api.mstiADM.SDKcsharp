using MessagePack;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Services
{
    public abstract class BaseService
    {
        protected readonly HttpClient _httpClient;

        protected BaseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        #region JSON Methods

        protected async Task<T> GetAsync<T>(string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return await SendRequestAsync<T>(request, false);
        }

        protected async Task<T> PostAsync<T>(string endpoint, object content)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Content = CreateJsonContent(content);
            return await SendRequestAsync<T>(request, false);
        }

        protected async Task<T> PutAsync<T>(string endpoint, object content)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, endpoint);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Content = CreateJsonContent(content);
            return await SendRequestAsync<T>(request, false);
        }

        private HttpContent CreateJsonContent(object content)
        {
            if (content == null) return null;
            var json = JsonConvert.SerializeObject(content);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        #endregion

        #region MessagePack Methods

        protected async Task<T> GetAsyncPack<T>(string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-msgpack"));
            return await SendRequestAsync<T>(request, true);
        }

        protected async Task<T> PutAsyncPack<T>(string endpoint, HttpContent content)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, endpoint);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-msgpack"));
            request.Content = content;
            return await SendRequestAsync<T>(request, true);
        }

        #endregion

        private async Task<T> SendRequestAsync<T>(HttpRequestMessage request, bool isMessagePack)
        {
            using (var response = await _httpClient.SendAsync(request))
            {
                if (!response.IsSuccessStatusCode)
                {
                    // Tratamento básico de erro, pode ser expandido conforme necessidade
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Erro na requisição: {response.StatusCode}. Detalhes: {errorContent}");
                }

                if (isMessagePack)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    return MessagePackSerializer.Deserialize<T>(stream);
                }
                else
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(json);
                }
            }
        }
    }
}