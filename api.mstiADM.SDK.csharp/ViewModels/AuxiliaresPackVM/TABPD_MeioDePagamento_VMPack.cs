using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    public class TABPD_MeioDePagamento_VMPack: TABPDBaseVMPack
    {
        public TABPD_MeioDePagamento_VM To_TABPD_MeioDePagamento_VM()
        {
            TABPD_MeioDePagamento_VM meioDePagamentoVM = new TABPD_MeioDePagamento_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };
            return meioDePagamentoVM;
        }
    }
}
