using api.mstiADM.SDK.csharp.Enums;
using MongoDB.Bson.Serialization.Attributes;
using NJsonSchema.Annotations;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [BsonIgnoreExtraElements]
    [JsonSchemaExtensionData("example",
    @"{
        ""API"": ""HUB"",
        ""SISTEMA"": ""TRAY"",
        ""SERVICO"": ""PEDIDOS"",
        ""ACAO"": ""RECEBE"",
        ""URL"": ""https://hub.com.br"",
        ""Token"": ""12312"",
        ""Identificador"": ""IDCanal""
    }")]
    public class ClienteWebHookVM
    {
        /// <summary>
        /// Nome da API (HUB, PAY...)
        /// </summary>
        public ENomeAPI API { get; set; }

        /// <summary>
        /// Nome do sistema acionado ou acionador (TRAY, SAGE, IFOOD...)
        /// </summary>
        public string SISTEMA { get; set; }

        /// <summary>
        /// Nome do serviço do webhook (PEDIDO, BOLETO, PIX...). Exemplo: Webhook de Pedidos, boleto, etc
        /// </summary>
        public string SERVICO { get; set; }

        /// <summary>
        /// Define se a API envia ou recebe notificações
        /// </summary>
        public AcaoTipo ACAO { get; set; }

        /// <summary>
        /// URL que será acionada externamente ou que a API chamará
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// Token usado para autenticação da chamada
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Identificador utilizado pela API (ex: IDCanal na HUB)
        /// </summary>
        public string Identificador { get; set; }
    }
}
