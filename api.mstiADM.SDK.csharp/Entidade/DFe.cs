using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.Entidade
{
    [ClassInterface(ClassInterfaceType.None)]
    public class DFe : DadosAmbiente
    {
        public void AtualizaProcessoDeImplantacao()
        {
            this.ImplantacaoExecutada = true;
        }

    }
}