using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_OrigemItem_VMPack : TABPDBaseVMPack
    {
        public TABPD_OrigemItem_VM To_TABPD_OrigemItem_VM()
        {
            TABPD_OrigemItem_VM origemItemVM = new TABPD_OrigemItem_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return origemItemVM;
        }
    }
}