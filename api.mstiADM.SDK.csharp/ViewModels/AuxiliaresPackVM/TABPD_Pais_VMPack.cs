using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_Pais_VMPack : TABPDBaseVMPack
    {
        public string Sigla { get; set; }
        
        public TABPD_Pais_VM ToTABPDPaisesVM()
        {
            TABPD_Pais_VM paisVM = new TABPD_Pais_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return paisVM;
        }
    }
}