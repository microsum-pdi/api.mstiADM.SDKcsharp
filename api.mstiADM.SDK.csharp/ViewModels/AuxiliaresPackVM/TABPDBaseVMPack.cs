using api.mstiADM.SDK.csharp.Enums;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPDBaseVMPack
    {
        [Key(0)]
        public string Id { get; set; }

        [Key(1)]
        public string Codigo { get; set; }

        [Key(2)]
        public string Descricao { get; set; }

        [Key(3)]
        public ESituacao Situacao { get; set; }

        [Key(4)]
        public int SYSVER { get; set; }
    }
}