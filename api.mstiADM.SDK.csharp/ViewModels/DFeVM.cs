using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using MongoDB.Bson.Serialization.Attributes;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    /// <summary>
    /// Configuração da API DF-e
    /// </summary>    
    [BsonIgnoreExtraElements]
    public class DFeVM : DadosAmbienteVM
    {
        public DFeVM()
        {
            configBD = new ConfigBdVM();
        }

        public DFeVMPack ToDFeVMPack()
        {
            return new DFeVMPack()
            {
                Ativo = Ativo,
                ImplantacaoExecutada = ImplantacaoExecutada,
                configBD = configBD.ToConfigBdVMPack(),
            };
        }
    }
}