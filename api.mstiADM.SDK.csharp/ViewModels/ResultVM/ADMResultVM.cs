using api.mstiADM.SDK.csharp.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace api.mstiADM.SDK.csharp.ViewModels.ResultVM
{
    public class ADMResultVM<T> : List<T>
    {
        #region Propriedades
        /// <summary>
        /// Código HTTP da resposta para a requisição
        /// </summary>
        [JsonProperty(Order = 0)]
        public ADMEHttpStatusCode HttpStatusCode { get; private set; }

        /// <summary> 
        /// Lista de mensagens de erros, alertas ou informações
        /// </summary>
        [JsonProperty(Order = 1)]
        public List<string> Messages { get; private set; }

        /// <summary> 
        /// Quantidade total de registros sendo retornados nesta requisição
        /// 
        /// <para>Utilizado para controles de paginação</para> 
        /// </summary> 
        [JsonProperty(Order = 2)]
        public int Count { get; private set; }

        /// <summary> 
        /// Quantidade total de registros existentes no repositório, que atendem aos critérios de pesquisa
        /// 
        /// <para>Utilizado para controles de paginação</para> 
        /// </summary> 
        [JsonProperty(Order = 3)]
        public int Total { get; private set; }

        /// <summary> 
        /// Lista de informações solicitadas
        /// 
        /// <para>Mesmo quando for solicitado apenas um recurso, será devolvido em uma lista</para> 
        /// </summary> 
        [JsonProperty(Order = 4)]
        public ADMMstiList<T> Data { get; private set; }

        #endregion

        public ADMResultVM()
        {
            HttpStatusCode = ADMEHttpStatusCode.OK;
            Data = new ADMMstiList<T>();
            Messages = new List<string>();
        }

        #region Métodos acessórios
        /// <summary>
        /// Retorna o primeiro item da lista "Data", convertido para o tipo passado no parâmetro "T"
        /// </summary>
        /// <returns></returns>
        public T GetFirstData()
        {
            T Dado = Data.FirstOrDefault();

            if (Dado != null)
            {
                return Dado;
            }
            else
            {
                return default;
            }
        }
        /// <summary>
        /// Retorno verdadeiro quando o StatusCode é igual a OK, caso contrário retornará false.
        /// </summary>
        /// <returns></returns>
        public bool IsSuccessStatusCode()
        {
            return HttpStatusCode == ADMEHttpStatusCode.OK;
        }
        #endregion


        #region BUILDERS
        public ADMResultVM<T> WithStatusCode(ADMEHttpStatusCode statusCode)
        {
            HttpStatusCode = statusCode;
            return this;
        }

        public ADMResultVM<T> WithMessage(string message)
        {
            Messages.Add(message);
            return this;
        }

        public ADMResultVM<T> WithMessages(List<string> messages)
        {
            Messages.AddRange(messages);
            return this;
        }

        /// <summary>
        /// Possibilita ajustar a variável de controle de paginação. Útil quando o retorno é apenas um objeto. 
        /// Pois, por padrão, a propriedade capacity é iniciada com o valor 4
        /// </summary>
        /// <returns></returns>
        public ADMResultVM<T> WithTotal(int capacity)
        {
            Total = capacity;
            return this;
        }

        public ADMResultVM<T> WithData(T Dado)
        {
            Data.Add(Dado);

            AtualizaTotais();

            return this;
        }

        public ADMResultVM<T> WithDatas(ADMMstiList<T> Dados)
        {
            Data.AddRange(Dados);

            //Ao acionar o método AddRange(), o valor da propriedade "Capacidade" é perdido
            Data.Capacidade = Dados.Capacidade;

            AtualizaTotais();

            return this;
        }

        private void AtualizaTotais()
        {
            Count = Data.Count;
            Total = Data.Capacidade;
        }
        #endregion
    }
}