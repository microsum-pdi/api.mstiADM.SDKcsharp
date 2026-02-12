using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;
using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.AuxiliaresPackVM
{
    [MessagePackObject]
    public class TABPD_Cidade_VMPack : TABPDBaseVMPack
    {
        public TABPD_Cidade_VM ToTABPDCidadeVM()
        {
            TABPD_Cidade_VM cidadeVM = new TABPD_Cidade_VM()
            {
                Id = Id,
                Codigo = Codigo,
                Descricao = Descricao,
                Situacao = Situacao,
                SYSVER = SYSVER
            };

            return cidadeVM;
        }
    }
}