using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_IndicadorPresenca_VMPack : TABPDBaseVMPack
    {
        public TABPD_IndicadorPresenca_VM ToTABPD_IndicadorPresencaVM()
        {
            TABPD_IndicadorPresenca_VM presencaVM = new TABPD_IndicadorPresenca_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return presencaVM;
        }
    }
}
