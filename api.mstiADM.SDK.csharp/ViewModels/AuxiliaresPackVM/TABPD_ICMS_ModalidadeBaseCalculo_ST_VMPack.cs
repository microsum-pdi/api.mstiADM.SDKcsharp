using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_ICMS_ModalidadeBaseCalculo_ST_VMPack : TABPDBaseVMPack
    {
        public TABPD_ICMS_ModalidadeBaseCalculo_ST_VM ToTABPD_ICMS_ModalidadesCalculo_ST_VM()
        {
            TABPD_ICMS_ModalidadeBaseCalculo_ST_VM icms_calculoST = new TABPD_ICMS_ModalidadeBaseCalculo_ST_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return icms_calculoST;
        }
    }
}
