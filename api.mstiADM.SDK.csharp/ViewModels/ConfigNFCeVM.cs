using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    /// <summary> 
    /// Configuração do ambiente do cliente, para envio da NFC-e 
    /// </summary> 
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    [BsonIgnoreExtraElements]
    [System.Serializable()]
    public class ConfigNFCeVM : ConfigDFeVM
    {
        public ConfigNFCeVMPack ToConfigNFCeVMPack()
        {
            return new ConfigNFCeVMPack()
            {
                SerieAtual = this.SerieAtual,
                ProximoLote = this.ProximoLote,
                ProximoNumero = this.ProximoNumero
            };
        }
    }
}