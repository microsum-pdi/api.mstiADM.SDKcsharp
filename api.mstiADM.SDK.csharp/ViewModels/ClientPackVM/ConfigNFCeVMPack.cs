using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class ConfigNFCeVMPack : ConfigDFeVMPack
    {
        /// <summary> 
        /// <para>Código de Segurança do Contribuinte</para> 
        /// <para>Geração de CSC em cada estado:</para> 
        /// <para></para> 
        /// <para> Goiás: http://www.nfce.go.gov.br/post/ver/214410/geracao-do-codigo-de-seguranca-do-contribuinte---csc </para> 
        /// <para> Bahia: https://nfe.sefaz.ba.gov.br/servicos/nfce/ASLibrary.X509/CertLogin?ReturnUrl=%2fservicos%2fnfce%2fModulos%2fAutenticado%2fNFCEC_contribuinte_consulta_csc.aspx </para> 
        /// <para> DF: http://dec.fazenda.df.gov.br/TransacaoCredenciamento.aspx# </para> 
        /// </summary> 
        [Key(3)]
        public string CSC { get; set; }


        /// <summary> 
        /// <para>Identificador do CSC – Código de Segurança do Contribuinte no Banco de Dados da SEFAZ</para> 
        /// </summary> 
        [Key(4)]
        public string CSCId { get; set; }


        public ConfigNFCeVM ToConfigNFCeVM()
        {
            return new ConfigNFCeVM()
            {
                CSC = this.CSC,
                CSCId = this.CSCId,
                SerieAtual = this.SerieAtual,
                ProximoLote = this.ProximoLote,
                ProximoNumero = this.ProximoNumero
            };
        }

    }
}