using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_ICMS_ModalidadeBaseCalculo_VMPack : TABPDBaseVMPack
    {
        public TABPD_ICMS_ModalidadeBaseCalculo_VM To_TABPD_ICMS_ModalidadesBaseCalculo_VM()
        {
            TABPD_ICMS_ModalidadeBaseCalculo_VM icms_BaseCalculo = new TABPD_ICMS_ModalidadeBaseCalculo_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return icms_BaseCalculo;
        }
    }
}
