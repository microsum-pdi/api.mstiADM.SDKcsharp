using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [BsonIgnoreExtraElements]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
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
