using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_COFINS_CST_VMPack : TABPDBaseVMPack
    {
        public TABPD_COFINS_CST_VM To_TABPD_COFINS_CST_VM()
        {
            TABPD_COFINS_CST_VM viewmodel = new TABPD_COFINS_CST_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };
            return viewmodel;
        }
    }
}