using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    /// <summary>
    /// Configuração da API Tax
    /// </summary>
    [BsonIgnoreExtraElements]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    public class TaxVM : DadosAmbienteVM
    {
        public TaxVM()
        {
            configBD = new ConfigBdVM();
        }

        public TaxVMPack ToTaxVMPack()
        {
            return new TaxVMPack()
            {
                Ativo = Ativo,
                ImplantacaoExecutada = ImplantacaoExecutada,
                configBD = configBD.ToConfigBdVMPack()
            };
        }
    }
}
