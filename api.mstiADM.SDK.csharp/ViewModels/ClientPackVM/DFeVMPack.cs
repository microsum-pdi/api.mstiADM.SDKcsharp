using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class DFeVMPack : DadosAmbienteVMPack
    {
        public DFeVM ToDFeVM()
        {
            return new DFeVM()
            {
                Ativo = Ativo,
                ImplantacaoExecutada = ImplantacaoExecutada,
                configBD = configBD?.ToConfigBdVM()
            };
        }
    }
}
