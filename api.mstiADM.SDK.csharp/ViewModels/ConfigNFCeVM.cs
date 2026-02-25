using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using NJsonSchema.Annotations;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    /// <summary> 
    /// Configuração do ambiente do cliente, para envio da NFC-e 
    /// </summary> 
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    [BsonIgnoreExtraElements]
    [System.Serializable()]
    public class ConfigNFCeVM : ConfigDFeVM
    {
        /// <summary> 
        /// <para>Código de Segurança do Contribuinte</para> 
        /// <para>Geração de CSC em cada estado:</para> 
        /// <para></para> 
        /// <para> Goiás: http://www.nfce.go.gov.br/post/ver/214410/geracao-do-codigo-de-seguranca-do-contribuinte---csc </para> 
        /// <para> Bahia: https://nfe.sefaz.ba.gov.br/servicos/nfce/ASLibrary.X509/CertLogin?ReturnUrl=%2fservicos%2fnfce%2fModulos%2fAutenticado%2fNFCEC_contribuinte_consulta_csc.aspx </para> 
        /// <para> DF: http://dec.fazenda.df.gov.br/TransacaoCredenciamento.aspx# </para> 
        /// </summary> 
        [JsonProperty(Order = 4)]
        [JsonSchemaExtensionData("example", "beb43119cb3b2f21")]
        public string CSC { get; set; }

        /// <summary> 
        /// <para>Identificador do CSC – Código de Segurança do Contribuinte no Banco de Dados da SEFAZ</para> 
        /// </summary> 
        [JsonProperty(Order = 5)]
        [JsonSchemaExtensionData("example", "1")]
        public string CSCId { get; set; }

        public ConfigNFCeVMPack ToConfigNFCeVMPack()
        {
            return new ConfigNFCeVMPack()
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