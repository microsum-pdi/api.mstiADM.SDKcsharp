using api.mstiADM.SDK.csharp.Enums;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    public class TABPDCheckAndUpdateRequestVM
    {
        public ENomeTabela Tabela { get; set; }

        public long Quantidade { get; set; }

        public long Versao { get; set; }
    }

    public class TABPDCheckAndUpdateResponseVM
    {
        public ENomeTabela Tabela { get; set; }

        /// <summary>
        /// Quantidade de registros armazenados na ADM.
        /// </summary>
        public long ADMQuantidade { get; set; }

        /// <summary>
        /// Versão dos registros armazenados na ADM
        /// </summary>
        public long ADMVersao { get; set; }

        /// <summary>
        /// Quantidade de registros armazenados no sistema que chamou o endpoint.
        /// </summary>
        public long RemotoQuantidade { get; set; }

        /// <summary>
        /// Versão dos registros armazenados no sistema que chamou o endpoint.        
        /// </summary>
        public long RemotoVersao { get; set; }

        public bool IsDiferente { get; set; }
    }
}
