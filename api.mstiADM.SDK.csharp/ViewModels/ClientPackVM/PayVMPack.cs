using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class PayVMPack : DadosAmbienteVMPack
    {
        public PayVM ToPayVM()
        {
            return new PayVM()
            {
                Ativo = Ativo,
                ImplantacaoExecutada = ImplantacaoExecutada,
                configBD = configBD?.ToConfigBdVM()
            };
        }
    }
}
