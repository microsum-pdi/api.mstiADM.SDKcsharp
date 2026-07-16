using System;
using System.Net.Http;

namespace api.mstiADM.SDK.csharp.ViewModels.Config
{
    public class ConfigAmbienteSDK
    {
        public static readonly string DEFAULT_MESSAGE_CONFIG_REQUIRED = "Necessário executar a configuração do ambiente (ConfigAmbienteSDKServices.ConfigurarAmbiente(new ConfigAmbienteSDK())), antes de comunicar com a AMIntegra.";
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
        /// Número máximo de retentativas de requisição, ao receber HttpStatusCode 429.
        /// </summary>
        public int MaxRetries { get; set; } = 3;

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

        public void VerificaConfiguracaoAmbiente()
        {
            if (string.IsNullOrEmpty(Token) || string.IsNullOrEmpty(URL))
                throw new Exception(DEFAULT_MESSAGE_CONFIG_REQUIRED);
        }
    }
}