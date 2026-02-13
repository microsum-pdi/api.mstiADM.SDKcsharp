using MongoDB.Bson.Serialization.Attributes;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [BsonIgnoreExtraElements]
    public abstract class DadosAmbienteVM
    {
        public bool Ativo { get; set; }

        public bool ImplantacaoExecutada { get; set; }

        public ConfigBdVM configBD { get; set; } = new ConfigBdVM();

        public void AtualizaProcessoDeImplantacao()
        {
            this.ImplantacaoExecutada = true;
        }
    }
}
