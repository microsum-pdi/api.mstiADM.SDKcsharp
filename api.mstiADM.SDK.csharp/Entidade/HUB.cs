using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.Entidade
{
    [ClassInterface(ClassInterfaceType.None)]
    public class HUB : DadosAmbiente
    {
        public int LimiteCanais { get; set; }

        public void AtualizaProcessoDeImplantacao()
        {
            this.ImplantacaoExecutada = true;
        }
    }
}