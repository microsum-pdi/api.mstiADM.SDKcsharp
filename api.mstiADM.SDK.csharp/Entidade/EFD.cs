using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.Entidade
{
    [ClassInterface(ClassInterfaceType.None)]
    public class EFD : DadosAmbiente
    {
        public void AtualizaProcessoDeImplantacao()
        {
            ImplantacaoExecutada = true;
        }
    }
}
