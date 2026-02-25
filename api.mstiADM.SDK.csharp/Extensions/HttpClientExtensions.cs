using System.Net.Http;

namespace api.mstiADM.SDK.csharp.Extensions
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// Adiciona um token do cliente na propriedade "x-api-key" do header
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="token">Token a ser adicionado</param>
        /// <returns></returns>
        public static HttpClient AddXApiKey(this HttpClient cliente, string token)
        {
            cliente.DefaultRequestHeaders.Add("x-api-key", token);
            return cliente;
        }
    }
}
