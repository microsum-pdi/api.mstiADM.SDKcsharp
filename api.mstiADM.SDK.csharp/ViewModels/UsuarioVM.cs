using api.mstiADM.SDK.csharp.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Converters;
using NJsonSchema.Annotations;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    [JsonSchemaExtensionData("example",
    @"{
         ""codigo"": ""1"",
         ""nome"": ""Microsum Tecnologia da Informação"",
         ""email"": ""msti@microsum.com.br"",
         ""senha"": ""keycod&"",
         ""nivelTipo"": ""REVENDA"",
         ""nivelIDCollection"": ""5f3ec01276d85c301c9af975"",
         ""Situacao"": ""ATIVO"",
         ""Acessos"":{
            ""AcessoApiDFE"": true,
            ""AcessoApiTAX"": true,
            ""AcessoApiHUB"": true,
            ""AcessoApiPAY"": true
        }
    }")]
    public class UsuarioVM
    {
        #region PROPRIEDADES

        public string Id { get; set; }

        public string Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string EmailAnterior { get; set; }

        public string Senha { get; set; }

        public ENivelTipo NivelTipo { get; set; } = ENivelTipo.CLIENTE;

        /// <summary>
        /// (ID da Revenda ou do Cliente, dependendo no Nível, quando for ADM ficará vazio)
        /// </summary>
        public string NivelIDCollection { get; set; }

        public AcessosApiVM Acessos { get; set; }

        /// <summary>
        /// Somente utilizado quando é um usuário de um Cliente
        /// </summary>
        public AcessosApiVM ModulosCliente { get; set; }

        public string NomeEntidadeRelacionamento { get; set; }

        public string CodigoRelacionamento { get; set; }

        public string ApelidoFantasiaRelacionamento { get; set; }

        public EEntidadeSituacao Situacao { get; set; }

        #endregion
    }
}
