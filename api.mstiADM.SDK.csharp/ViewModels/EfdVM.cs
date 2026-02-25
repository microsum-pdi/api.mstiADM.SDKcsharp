using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    /// <summary>
    /// Configuração da API EFD
    /// </summary>
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
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