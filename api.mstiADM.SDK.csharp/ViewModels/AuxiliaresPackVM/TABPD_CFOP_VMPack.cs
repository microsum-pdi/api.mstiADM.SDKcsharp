using api.mstiADM.SDK.csharp.Enums;
using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_CFOP_VMPack : TABPDBaseVMPack
    {
        [Key(5)]
        public ETipo Tipo { get; set; }

        public TABPD_CFOP_VM To_TABPD_CFOP_VM()
        {
            TABPD_CFOP_VM cfopVM = new TABPD_CFOP_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Tipo = Tipo,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return cfopVM;
        }
    }
}