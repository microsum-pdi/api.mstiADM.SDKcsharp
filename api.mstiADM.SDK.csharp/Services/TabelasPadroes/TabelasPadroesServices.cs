using api.mstiADM.SDK.csharp.Enums;
using api.mstiADM.SDK.csharp.Extensions;
using api.mstiADM.SDK.csharp.Interfaces.Adm;
using api.mstiADM.SDK.csharp.ViewModels;
using api.mstiADM.SDK.csharp.ViewModels.Config;
using api.mstiADM.SDK.csharp.ViewModels.ResultVM;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Services.TabelasPadroes
{
    public class TabelasPadroesServices : GenericServices, ITabelasPadroesServices
    {
        public TabelasPadroesServices(ConfigAmbienteSDK configAmbienteSDK) : base(configAmbienteSDK)
        {
        }



        /// <summary>
        /// Verifica se o código está cadastrado na respectiva tabela padrão
        /// </summary>
        public async Task<bool> VerificaExistenciaRegistro(ENomeTabela tabela, string codigo)
        {
            string url = configAmbienteSDK.URL + $"/api/admui/TabelasPadroes/verificaexistencia/{tabela}/{codigo}";

            try
            {
                HttpResponseMessage response = await ExecutaGet(url);

                string responseBody = response.Content.ReadAsStringAsync().Result;

                var resposta = JsonConvert.DeserializeObject<bool>(responseBody);                

                return resposta;
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao obter verificar existência de registro na tabela padrão." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }

        /// <summary>
        /// Permite obter dados sobre os registro na API
        /// </summary>
        /// <remarks>
        /// Deve ser utilizado para identificar se um grupo de tabelas, precisa ser atualizado
        /// <para></para>
        /// A atualização pode ser realizada por meio do endpoint 'api/tabelaspadroes/atualizacao/{tabela}/{SYSVER}'
        /// </remarks>
        public async Task<ADMResultVM<TABPDCheckAndUpdateResponseVM>> GetAtualizacoes(List<TABPDCheckAndUpdateRequestVM> request)
        {
            string url = configAmbienteSDK.URL + $"/api/admui/tabelaspadroes/atualizacao";

            ADMResultVM<TABPDCheckAndUpdateResponseVM> result = new ADMResultVM<TABPDCheckAndUpdateResponseVM>();

            try
            {
                HttpResponseMessage response = await ExecutaPost(request, url);

                string responseBody = response.Content.ReadAsStringAsync().Result;

                var resposta = JsonConvert.DeserializeObject<ADMResultVM<TABPDCheckAndUpdateResponseVM>>(responseBody);

                if (resposta == null)
                {
                    result
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível verificar a necessidade de atualização das tabelas padrões.");
                }
                else
                {
                    result = resposta;
                }

                return result;
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao verificar a necessidade de atualização das tabelas padrões." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }

        /// <summary>
        /// Permite obter todos os registros de uma determinada tabela.
        /// </summary>
        /// <param name="tabela">Enum que define a tabela a ser consultada</param>
        /// <param name="sysver">Versão do sistema para sincronização incremental</param>
        /// <param name="limit">Quantidade máxima de registros a retornar</param>
        /// <param name="skip">Quantidade de registros a pular (paginação)</param>
        /// <remarks>
        /// O retorno é um objeto <b>T</b>, onde <b>T</b> depende do parâmetro <b>tabela</b>:
        /// 
        ///  | Tabela (ENomeTabela)              | Tipo de Retorno (T)                              |
        ///  | --------------------------------- | -----------------------------------------------  |
        ///  | TABPDANPs                         | ResultVM[TABPD_ANP_VM]                           |
        ///  | TABPDCESTs                        | ResultVM[TABPD_CEST_VM]                          |
        ///  | TABPDCFOPs                        | ResultVM[TABPD_CFOP_VM]                          |
        ///  | TABPDCidades                      | ResultVM[TABPD_Cidade_VM]                        |
        ///  | TABPDCOFINSCSTs                   | ResultVM[TABPD_COFINS_CST_VM]                    |
        ///  | TABPDFinalidadesEmissoes          | ResultVM[TABPD_FinalidadeEmissao_VM]             |
        ///  | TABPDICMSCSOSNs                   | ResultVM[TABPD_ICMS_CSOSN_VM]                    |
        ///  | TABPDICMSCSTs                     | ResultVM[TABPD_ICMS_CST_VM]                      |
        ///  | TABPDICMSModalidadesBaseCalculo   | ResultVM[TABPD_ICMS_ModalidadeBaseCalculo_VM]    |
        ///  | TABPDICMSModalidadesBaseCalculoST | ResultVM[TABPD_ICMS_ModalidadeBaseCalculo_ST_VM] |
        ///  | TABPDICMSMotivosDesoneracao       | ResultVM[TABPD_ICMS_MotivoDesoneracao_VM]        |
        ///  | TABPDIndicadoresPresencas         | ResultVM[TABPD_IndicadorPresenca_VM]             |
        ///  | TABPDIPICSTs                      | ResultVM[TABPD_IPI_CST_VM]                       |
        ///  | TABPDIPIEnquadramentosLegais      | ResultVM[TABPD_IPI_EnquadramentoLegal_VM]        |
        ///  | TABPDMeiosDePagamento             | ResultVM[TABPD_MeioDePagamento_VM]               |
        ///  | TABPDModalidadesFretes            | ResultVM[TABPD_ModalidadeFrete_VM]               |
        ///  | TABPDNCMs                         | ResultVM[TABPD_NCM_VM]                           |
        ///  | TABPDOrigensItens                 | ResultVM[TABPD_OrigemItem_VM]                    |
        ///  | TABPDPaises                       | ResultVM[TABPD_Pais_VM]                          |
        ///  | TABPDPISCSTs                      | ResultVM[TABPD_PIS_CST_VM]                       |
        ///  | TABPDRegimesTributarios           | ResultVM[TABPD_RegimeTributario_VM]              |
        ///  | TABPDTiposItens                   | ResultVM[TABPD_TipoItem_VM]                      |
        ///  | TABPDUFs                          | ResultVM[TABPD_UF_VM]                            |
        ///  | Outros (Genéricos)                | TABPDBaseVM                                      |
        /// </remarks>
        /// <returns>Retorna os dados da tabela solicitada</returns>
        public async Task<ADMResultVM<T>> GetAtualizacoes<T>(ENomeTabela tabela, int sysver = 0, int limit = 0, int skip = 0)
        {
            string url = configAmbienteSDK.URL + $"/api/admui/tabelaspadroes/atualizacao/{tabela}/{sysver}?limit={limit}&skip={skip}";

            try
            {
                HttpResponseMessage response = await ExecutaGet(url);

                string responseBody = response.Content.ReadAsStringAsync().Result;

                var resposta = JsonConvert.DeserializeObject<ADMResultVM<T>>(responseBody);

                if (resposta != null)
                {                    
                    return resposta;
                }

                return default;
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao consultar informações das tabelas padrões." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }
    }
}