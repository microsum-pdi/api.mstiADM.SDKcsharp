using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_RegimeTributario_VMPack : TABPDBaseVMPack
    {
        public TABPD_RegimeTributario_VM To_TABPD_RegimeTributario_VM()
        {
            TABPD_RegimeTributario_VM regimeTributarioVM = new TABPD_RegimeTributario_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return regimeTributarioVM;
        }
    }
}
