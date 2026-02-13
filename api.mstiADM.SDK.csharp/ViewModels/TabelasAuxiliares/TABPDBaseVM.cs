using api.mstiADM.SDK.csharp.Enums;

namespace api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares
{
    public class TABPDBaseVM
    {
        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public ETABPDSituacao Situacao { get; set; }
        public int SYSVER { get; set; }

        public void AplicaTransformacoes()
        {
            Codigo = Codigo?.Replace(".", "");
        }
    }
}