using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.Entidade
{
    [ClassInterface(ClassInterfaceType.None)]
    public class TAX : DadosAmbiente
    {
        public void AtualizaProcessoDeImplantacao()
        {
            this.ImplantacaoExecutada = true;
        }
    }

}
