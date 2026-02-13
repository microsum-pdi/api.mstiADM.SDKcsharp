namespace api.mstiADM.SDK.csharp.Entidade
{
    public class HUB : DadosAmbiente
    {
        public int LimiteCanais { get; set; }

        public void AtualizaProcessoDeImplantacao()
        {
            this.ImplantacaoExecutada = true;
        }
    }
}