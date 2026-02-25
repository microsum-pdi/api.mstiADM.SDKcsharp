using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    /// <summary>
    /// Configuração da API 
    /// 
    /// </summary>
    [BsonIgnoreExtraElements]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    public class PayVM : DadosAmbienteVM
    {
        public PayVM()
        {
            configBD = new ConfigBdVM();
        }

        public PayVMPack ToPayVMPack()
        {
            return new PayVMPack()
            {
                Ativo = Ativo,
                ImplantacaoExecutada = ImplantacaoExecutada,
                configBD = configBD.ToConfigBdVMPack()
            };
        }
    }
}