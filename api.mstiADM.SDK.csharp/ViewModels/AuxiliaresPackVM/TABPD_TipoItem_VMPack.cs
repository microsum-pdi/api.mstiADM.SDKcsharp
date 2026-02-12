using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_TipoItem_VMPack : TABPDBaseVMPack
    {
        public TABPD_TipoItem_VM To_TABPD_TipoItem_VM()
        {
            TABPD_TipoItem_VM tipoItemVM = new TABPD_TipoItem_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return tipoItemVM;
        }
    }
}
