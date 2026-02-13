using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public abstract class DadosAmbienteVMPack
    {
        [Key(0)]
        public bool Ativo { get; set; }

        [Key(1)]
        public bool ImplantacaoExecutada { get; set; }


        [Key(2)]
        public ConfigBdVMPack configBD { get; set; }
    }
}
