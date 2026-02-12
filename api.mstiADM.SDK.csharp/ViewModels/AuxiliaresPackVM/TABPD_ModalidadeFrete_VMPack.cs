using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_ModalidadeFrete_VMPack : TABPDBaseVMPack
    {
        public TABPD_ModalidadeFrete_VM To_TABPD_Modalidade_Frete_VM()
        {
            TABPD_ModalidadeFrete_VM modalidadeVM = new TABPD_ModalidadeFrete_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return modalidadeVM;
        }
    }
}
