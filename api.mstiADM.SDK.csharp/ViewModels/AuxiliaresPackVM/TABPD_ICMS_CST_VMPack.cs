using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_ICMS_CST_VMPack : TABPDBaseVMPack
    {
        public TABPD_ICMS_CST_VM To_TABPD_CST_VM()
        {
            TABPD_ICMS_CST_VM icms_cstVM = new TABPD_ICMS_CST_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return icms_cstVM;
        }
    }
}
