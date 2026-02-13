using api.mstiADM.SDK.csharp.Enums;
using api.mstiADM.SDK.csharp.ViewModels;
using api.mstiADM.SDK.csharp.ViewModels.ResultVM;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Interfaces.Adm
{
    public interface ITabelasPadroesServices
    {
        Task<bool> VerificaExistenciaRegistro(ENomeTabela tabela, string codigo);

        Task<ADMResultVM<TABPDCheckAndUpdateResponseVM>> GetAtualizacoes(List<TABPDCheckAndUpdateRequestVM> request);

        Task<T> GetAtualizacoes<T>(ENomeTabela tabela, int sysver = 0, int limit = 0, int skip = 0);
    }
}