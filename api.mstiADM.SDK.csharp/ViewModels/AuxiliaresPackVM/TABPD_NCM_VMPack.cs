using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_NCM_VMPack : TABPDBaseVMPack
    {
        public TABPD_NCM_VM To_TABPD_NCM_VM()
        {
            TABPD_NCM_VM ncmVM = new TABPD_NCM_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return ncmVM;
        }
    }
}
