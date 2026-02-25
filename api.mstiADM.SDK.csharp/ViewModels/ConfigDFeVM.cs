using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using NJsonSchema.Annotations;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    /// <summary>
    /// Configuração do ambiente do cliente, para envio de todos os modelos de DF-e
    /// </summary>
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    [BsonIgnoreExtraElements]
    [System.Serializable()]
    public class ConfigDFeVM
    {
        /// <summary> 
        /// <para>Série atual</para> 
        /// </summary> 
        [JsonProperty(Order = 1)]
        [JsonSchemaExtensionData("example", "001")]
        public string SerieAtual { get; set; }

        /// <summary> 
        /// <para>Próximo número a ser enviado</para> 
        /// </summary> 
        [JsonProperty(Order = 2)]
        [JsonSchemaExtensionData("example", "100")]
        public int ProximoLote { get; set; }

        /// <summary> 
        /// <para>Próximo lote a ser enviado</para> 
        /// </summary> 
        [JsonProperty(Order = 3)]
        [JsonSchemaExtensionData("example", "100")]
        public int ProximoNumero { get; set; }

        public ConfigDFeVMPack ToConfigDFeVMPack()
        {
            return new ConfigDFeVMPack()
            {
                SerieAtual = this.SerieAtual,
                ProximoLote = this.ProximoLote,
                ProximoNumero = this.ProximoNumero
            };
        }
    }
}