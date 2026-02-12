using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_Quantidade_De_Registros_VMPack
    {
        [Key(0)]
        public long QuantidadeDeRegistros { get; set; }
    }
}