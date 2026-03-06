using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM

{
    [MessagePackObject]
    public class HubVMPack : DadosAmbienteVMPack
    {
        public HubVM ToHubVM()
        {
            return new HubVM()
            {
                Ativo = this.Ativo,
                ImplantacaoExecutada = ImplantacaoExecutada,
                configBD = this?.configBD.ToConfigBdVM()
            };
        }
    }
}
