using api.mstiADM.SDK.csharp.Enums;
using MessagePack;
using System.Collections.Generic;
using System.Linq;

namespace api.mstiADM.SDK.csharp.ViewModels.ResultVM
{
    [MessagePackObject]
    public class ADMResultVMPack<T>
    {
        #region Propriedades

        /// <summary>
        /// Código HTTP da resposta para a requisição
        /// </summary>
        [Key(0)]
        public ADMEHttpStatusCode HttpStatusCode { get; set; }

        /// <summary> 
        /// Lista de mensagens de erros, alertas ou informações
        /// </summary>
        [Key(1)]
        public List<string> Messages { get; set; }

        /// <summary> 
        /// Quantidade total de registros sendo retornados nesta requisição
        /// 
        /// <para>Utilizado para controles de paginação</para> 
        /// </summary> 
        [Key(2)]
        public int Count { get; set; }

        /// <summary> 
        /// Quantidade total de registros existentes no repositório, que atendem aos critérios de pesquisa
        /// 
        /// <para>Utilizado para controles de paginação</para> 
        /// </summary> 
        [Key(3)]
        public int Total { get; set; }

        /// <summary> 
        /// Lista de informações solicitadas
        /// 
        /// <para>Mesmo quando for solicitado apenas um recurso, será devolvido em uma lista</para> 
        /// </summary> 
        [Key(4)]
        public ADMMstiList<T> Data { get; set; }

        #endregion


        #region Construtores

        public ADMResultVMPack()
        {
            HttpStatusCode = ADMEHttpStatusCode.OK;
            Data = new ADMMstiList<T>();
            Messages = new List<string>();
        }

        #endregion


        #region Métodos acessórios

        /// <summary>
        /// Retorna o primeiro item da lista "Data", convertido para o tipo passado no parâmetro "T"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetFirstData()
        {
            if (HttpStatusCode == ADMEHttpStatusCode.OK && Data[0] != null)
                return Data.FirstOrDefault();
            else
                return default(T);
        }

        public bool IsSuccessStatusCode()
        {
            return HttpStatusCode == ADMEHttpStatusCode.OK;
        }

        #endregion

        #region BUILDERS

        public ADMResultVMPack<T> WithStatusCode(ADMEHttpStatusCode statusCode)
        {
            HttpStatusCode = statusCode;
            return this;
        }

        public ADMResultVMPack<T> WithMessage(string message)
        {
            if (!string.IsNullOrEmpty(message)) Messages.Add(message);
            return this;
        }

        public ADMResultVMPack<T> WithMessages(List<string> messages)
        {
            Messages.AddRange(messages);
            return this;
        }

        public ADMResultVMPack<T> WithData(T Dado)
        {
            Data.Add(Dado);
            AtualizaTotais();
            return this;
        }

        public ADMResultVMPack<T> WithDatas(ADMMstiList<T> Dados)
        {
            Data.AddRange(Dados);
            Data.Capacidade = Dados.Capacidade;
            AtualizaTotais();

            return this;
        }

        private void AtualizaTotais()
        {
            Total = Data.Capacidade;
            Count = Data.Count;
        }

        #endregion        
    }
}
