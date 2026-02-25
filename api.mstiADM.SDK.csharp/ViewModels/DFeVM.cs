using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    /// <summary>
    /// Configuração da API DF-e
    /// </summary>    
    [BsonIgnoreExtraElements]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
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