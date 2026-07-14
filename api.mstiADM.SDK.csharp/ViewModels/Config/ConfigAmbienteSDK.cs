using System.Net.Http;

namespace api.mstiADM.SDK.csharp.ViewModels.Config
{
    public class ConfigAmbienteSDK
    {
        /// <summary>
        /// Token de acesso do cliente da API.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        ///  URL onde a API.ADM está sendo executada.
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        ///  URL onde a frontend da AMIntegra está sendo executada.
        /// </summary>
        public string URLFrontend { get; set; }

        /// <summary>
        /// Http client do consumidor
        /// </summary>
        public HttpClient HttpClient { get; set; }

        public ConfigAmbienteSDK() { }

        public ConfigAmbienteSDK(string token, string url, string urlFrontend = null)
        {
            Token = token;
            URL = url;
            URLFrontend = urlFrontend;
        }
    }
}