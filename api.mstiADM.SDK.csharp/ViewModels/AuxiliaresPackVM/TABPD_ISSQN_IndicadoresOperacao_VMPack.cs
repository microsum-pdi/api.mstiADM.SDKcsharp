using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_ISSQN_IndicadoresOperacao_VMPack : TABPDBaseVMPack
    {
        [Key(5)]
        public string Tipo { get; set; }

        [Key(6)]
        public string Local { get; set; }

        public TABPD_ISSQN_IndicadoresOperacao_VM To_TABPD_ISSQN_IndicadoresOperacao_VM()
        {
            TABPD_ISSQN_IndicadoresOperacao_VM entidade = new TABPD_ISSQN_IndicadoresOperacao_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER,
                Tipo = Tipo,
                Local = Local
            };
            return entidade;
        }
    }
}
