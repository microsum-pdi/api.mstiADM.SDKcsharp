using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    /// <summary>
    /// Configuração da API EFD
    /// </summary>
    public class EfdVM : DadosAmbienteVM
    {
        public EfdVM()
        {
            configBD = new ConfigBdVM();
        }

        public EfdVMPack ToEfdVMPack()
        {
            return new EfdVMPack()
            {
                Ativo = this.Ativo,
                ImplantacaoExecutada = ImplantacaoExecutada,
                configBD = configBD.ToConfigBdVMPack()
            };
        }
    }
}