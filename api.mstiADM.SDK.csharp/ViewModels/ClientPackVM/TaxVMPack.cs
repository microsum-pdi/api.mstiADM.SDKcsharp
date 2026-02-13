using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class TaxVMPack : DadosAmbienteVMPack
    {
        public TaxVM ToTaxVM()
        {
            return new TaxVM()
            {
                Ativo = Ativo,
                ImplantacaoExecutada = ImplantacaoExecutada,
                configBD = configBD?.ToConfigBdVM()
            };
        }
    }
}
