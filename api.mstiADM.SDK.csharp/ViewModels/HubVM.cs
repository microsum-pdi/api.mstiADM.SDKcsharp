using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    /// <summary>
    /// Configuração da API HUB
    /// </summary>
    [BsonIgnoreExtraElements]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    public class HubVM : DadosAmbienteVM
    {
        public HubVM()
        {
            this.configBD = new ConfigBdVM();
        }

        public HubVMPack ToHubVMPack()
        {
            return new HubVMPack()
            {
                Ativo = this.Ativo,
                ImplantacaoExecutada = ImplantacaoExecutada,
                configBD = configBD.ToConfigBdVMPack()
            };
        }
    }
}