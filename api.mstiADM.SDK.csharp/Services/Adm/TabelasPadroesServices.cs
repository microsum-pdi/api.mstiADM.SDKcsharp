using api.mstiADM.SDK.csharp.Enums;
using api.mstiADM.SDK.csharp.Interfaces.Adm;
using api.mstiADM.SDK.csharp.ViewModels;
using api.mstiADM.SDK.csharp.ViewModels.ResultVM;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Services.Adm
{
    public class TabelasPadroesServices : BaseService, ITabelasPadroesServices
    {
        public TabelasPadroesServices(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<bool> VerificaExistenciaRegistro(ENomeTabela tabela, string codigo)
        {
            return await GetAsync<bool>($"api/TabelasPadroes/verificaexistencia/{tabela}/{codigo}");
        }

        public async Task<ADMResultVM<TABPDCheckAndUpdateResponseVM>> GetAtualizacoes(List<TABPDCheckAndUpdateRequestVM> request)
        {
            return await PostAsync<ADMResultVM<TABPDCheckAndUpdateResponseVM>>("api/tabelaspadroes/atualizacao", request);
        }

        public async Task<T> GetAtualizacoes<T>(ENomeTabela tabela, int sysver = 0, int limit = 0, int skip = 0)
        {
            return await GetAsync<T>($"api/tabelaspadroes/atualizacao/{tabela}/{sysver}?limit={limit}&skip={skip}");
        }
    }
}