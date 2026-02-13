using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [BsonIgnoreExtraElements]
    public class ClienteAcessoInfo
    {
        /// <summary>
        /// Marcador do tipo da requisição: CLIENTE ou ADMIN. Utilizado na apiHUB para identificar se a requisição é administrativa.
        /// </summary>
        public string Tipo { get; set; }


        /// <summary>
        /// Cadastro da empresa
        /// </summary>
        public ClienteVM cliente { get; set; }

        /// <summary>
        /// Configurações para acesso ao banco de dados da empresa
        /// </summary>
        public ConfigBdVM configBd { get; set; }

        /// <summary>
        /// Utilizado para repassar mensagens de validação, entre a API.ADM e as APIs que a utilizam
        /// </summary>
        public List<string> Mensagens { get; set; }
    }
}
