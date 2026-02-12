using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_CEST_VMPack : TABPDBaseVMPack
    {
        [Key(5)]
        public string NCMs { get; set; }

        [Key(6)]
        public string Segmento { get; set; }

        public TABPD_CEST_VM To_TABPD_CEST_VM()
        {
            TABPD_CEST_VM cidadeVM = new TABPD_CEST_VM()
            {
                Id = Id,
                Codigo = Codigo,
                NCMs = NCMs,
                Segmento = Segmento,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return cidadeVM;
        }
    }
}