using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class ConfigNFCeVMPack : ConfigDFeVMPack
    {
        public ConfigNFCeVM ToConfigNFCeVM()
        {
            return new ConfigNFCeVM()
            {
                SerieAtual = this.SerieAtual,
                ProximoLote = this.ProximoLote,
                ProximoNumero = this.ProximoNumero
            };
        }

    }
}