using System.Net.Http;

namespace api.mstiADM.SDK.csharp.ViewModels.Config
{
    public class ConfigAmbienteSDK
    {
        public ConfigAmbienteSDK()
        {
        }

        public ConfigAmbienteSDK(string token, string url)
        {
            Token = token;
            URL = url;
        }

        public string Token { get; set; }

        public string URL { get; set; }

        /// <summary>
        /// Http client do consumidor
        /// </summary>
        public HttpClient HttpClient { get; set; }
    }
}