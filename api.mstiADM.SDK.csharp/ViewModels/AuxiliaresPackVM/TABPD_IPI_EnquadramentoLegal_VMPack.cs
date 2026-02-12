using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_IPI_EnquadramentoLegal_VMPack : TABPDBaseVMPack
    {
        public TABPD_IPI_EnquadramentoLegal_VM To_TABPD_IPI_EnquadramentosLegais_VM()
        {
            TABPD_IPI_EnquadramentoLegal_VM viewmodel = new TABPD_IPI_EnquadramentoLegal_VM()
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
