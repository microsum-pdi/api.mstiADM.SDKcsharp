using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_UF_VMPack : TABPDBaseVMPack
    {

        [Key(5)]
        public string Sigla { get; set; }


        public TABPD_UF_VM ToTABPDUFVM()
        {
            TABPD_UF_VM ufVM = new TABPD_UF_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Sigla = Sigla,
                Situacao = Situacao,
                SYSVER = SYSVER

            };

            return ufVM;
        }
    }
}
