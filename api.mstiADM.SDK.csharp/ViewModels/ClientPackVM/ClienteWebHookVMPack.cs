using api.mstiADM.SDK.csharp.Enums;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class ClienteWebHookVMPack
    {
        /// <summary>
        /// Nome da API (HUB, PAY...)
        /// </summary>
        [Key(1)]
        public ENomeAPI API { get; set; }

        /// <summary>
        /// Nome do sistema acionado ou acionador (TRAY, SAGE, IFOOD...)
        /// </summary>
        [Key(2)]
        public string SISTEMA { get; set; }

        /// <summary>
        /// Nome do serviço do webhook (PEDIDO, BOLETO, PIX...). Exemplo: Webhook de Pedidos, boleto, etc
        /// </summary>
        [Key(3)]
        public string SERVICO { get; set; }

        /// <summary>
        /// Define se a API envia ou recebe notificações
        /// </summary>
        [Key(4)]
        public AcaoTipo ACAO { get; set; }

        /// <summary>
        /// URL que será acionada externamente ou que a API chamará
        /// </summary>
        [Key(5)]
        public string URL { get; set; }

        /// <summary>
        /// Token usado para autenticação da chamada
        /// </summary>
        [Key(6)]
        public string Token { get; set; }

        /// <summary>
        /// Identificador utilizado pela API (ex: IDCanal na HUB)
        /// </summary>
        [Key(7)]
        public string Identificador { get; set; }
    }
}
