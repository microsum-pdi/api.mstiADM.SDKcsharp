using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using MongoDB.Bson.Serialization.Attributes;
using NSwag.Annotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [BsonIgnoreExtraElements]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    public class ConfigBdVM
    {
        public string host { get; set; }

        public string porta { get; set; }

        public string nome { get; set; }

        [IgnoreDataMember]
        [JsonIgnore]
        [OpenApiIgnore]
        public string usuario { get; set; }

        [IgnoreDataMember]
        [JsonIgnore]
        [OpenApiIgnore]
        public string senha { get; set; }

        public int versao { get; set; }

        public bool ImplantacaoExecutada { get; set; }

        public ConfigBdVMPack ToConfigBdVMPack()
        {
            ConfigBdVMPack config = new ConfigBdVMPack()
            {
                host = this.host,
                porta = this.porta,
                nome = this.nome,
                usuario = this.usuario,
                senha = this.senha,
                versao = this.versao
            };

            return config;
        } 
    }
}