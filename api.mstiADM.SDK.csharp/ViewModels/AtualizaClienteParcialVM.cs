using NJsonSchema.Annotations;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    [JsonSchemaExtensionData("example",
	@"{
	  ""CodigoRevenda"": ""1"",
	  ""NomeRazaoSocial"": ""Microsum Tecnologia da Informação Ltda"",
	  ""Pessoa"": ""JURÍDICA"",
	  ""ApelidoFantasia"": ""Microsum"",
	  ""Contribuinte"": ""NÃO"",
	  ""DI"": """",
	  ""Contatos"": {
		  ""Telefone"": ""(62) 3239-8000"",
		  ""Celular"": """",
		  ""Email"": ""comercial@microsum.com.br"",
		  ""Site"": """",
		  ""Contato"": """"
	  },
	  ""Endereco"": {
		  ""Logradouro"": ""Rua 90"",
		  ""Numero"": ""418"",
		  ""Complemento"": """",
		  ""Bairro"": ""Setor Sul"",
		  ""CidadeCodigo"": ""5208707"",
		  ""CidadeDescricao"": ""Goiânia"",
		  ""UFDescricao"": ""Goiás"",
		  ""UFCodigo"": ""52"",
		  ""UFSigla"": ""GO"",
		  ""CEP"": ""74093-020"",
		  ""PaisCodigo"": ""55"",
		  ""PaisDescricao"": ""Brasil""
	  },
	  ""CPFCNPJ"": ""05.462.662/0001-05"",
	  ""IE"": ""10.358.086-7"",
	  ""IM"": ""1926829""
	}")]
    public class AtualizaClienteParcialVM
    {
        public string CodigoRevenda { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string Pessoa { get; set; }
        public string ApelidoFantasia { get; set; }
        public string Contribuinte { get; set; }
        public string DI { get; set; }
        public ContatosVM Contatos { get; set; }
        public EnderecoVM Endereco { get; set; }
        public string CPFCNPJ { get; set; }
        public string IE { get; set; }
        public string IM { get; set; }
    }
}
