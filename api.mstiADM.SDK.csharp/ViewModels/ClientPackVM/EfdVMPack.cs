using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class EfdVMPack : DadosAmbienteVMPack
    {

        public EfdVM ToEfdVM()
        {
            return new EfdVM()
            {
                Ativo = this.Ativo,
                ImplantacaoExecutada = ImplantacaoExecutada,
                configBD = this?.configBD.ToConfigBdVM()
            };
        }
    }
}
