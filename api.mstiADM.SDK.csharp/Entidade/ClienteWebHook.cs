using api.mstiADM.SDK.csharp.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace api.mstiADM.SDK.csharp.Entidade
{
    public class ClienteWebHook
    {
        /// <summary>
        /// Nome da API (HUB, PAY...)
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public ENomeAPI API { get; set; }

        /// <summary>
        /// Nome do sistema acionado ou acionador (TRAY, SAGE, IFOOD...)
        /// </summary>
        public string SISTEMA { get; set; }

        /// <summary>
        /// Nome do serviço do webhook (PEDIDO, BOLETO, PIX...)
        /// </summary>
        public string SERVICO { get; set; }

        /// <summary>
        /// Define se a API envia ou recebe notificações
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
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
