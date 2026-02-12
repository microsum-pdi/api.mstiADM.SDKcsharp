using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_ICMS_MotivoDesoneracao_VMPack : TABPDBaseVMPack
    {
        public TABPD_ICMS_MotivoDesoneracao_VM To_TABPD_ICMS_MotivosDesoneracao_VM()
        {
            TABPD_ICMS_MotivoDesoneracao_VM viewmodel = new TABPD_ICMS_MotivoDesoneracao_VM()
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