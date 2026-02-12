using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_FinalidadeEmissao_VMPack : TABPDBaseVMPack
    {

        public TABPD_FinalidadeEmissao_VM To_TABPD_Finalidade_Emissao_VM()
        {
            TABPD_FinalidadeEmissao_VM finalidadeVM = new TABPD_FinalidadeEmissao_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return finalidadeVM;
        }
    }
}
