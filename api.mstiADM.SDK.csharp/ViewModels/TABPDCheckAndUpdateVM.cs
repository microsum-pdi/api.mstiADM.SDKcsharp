using api.mstiADM.SDK.csharp.Enums;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    public class TABPDCheckAndUpdateRequestVM
    {
        public ENomeTabela Tabela { get; set; }

        /// <summary>
        /// A quantidade de registros armazenados no sistema que chamou o endpoint.
        /// </summary>
        public int Quantidade { get; set; }

        /// <summary>
        /// A versão dos registros armazenados no sistema que chamou o endpoint. Deve ser utilizada para sincronização incremental, ou seja, para obter apenas os registros que foram atualizados após a versão informada.
        /// </summary>
        public int Versao { get; set; }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    public class TABPDCheckAndUpdateResponseVM
    {
        public ENomeTabela Tabela { get; set; }

        /// <summary>
        /// Quantidade de registros armazenados na ADM.
        /// </summary>
        public int ADMQuantidade { get; set; }

        /// <summary>
        /// Versão dos registros armazenados na ADM
        /// </summary>
        public int ADMVersao { get; set; }

        /// <summary>
        /// Quantidade de registros armazenados no sistema que chamou o endpoint.
        /// </summary>
        public int RemotoQuantidade { get; set; }

        /// <summary>
        /// Versão dos registros armazenados no sistema que chamou o endpoint.        
        /// </summary>
        public int RemotoVersao { get; set; }

        /// <summary>
        /// Se igual a 'true', significa que a respectiva tabela, precisa ser atualizada
        /// </summary>
        public bool IsDiferente { get; set; }
    }
}
