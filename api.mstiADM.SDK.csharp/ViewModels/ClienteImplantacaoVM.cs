using api.mstiADM.SDK.csharp.Entidade;
using api.mstiADM.SDK.csharp.Enums;
using api.mstiADM.SDK.csharp.Extensions;
using MongoDB.Bson.Serialization.Attributes;
using NJsonSchema.Annotations;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [BsonIgnoreExtraElements]
    [JsonSchemaExtensionData("example",
@"{
  ""CodigoRevenda"": ""1"",
  ""Nome"": ""Microsum Tecnologia da Informação Ltda"",
  ""CPFCNPJ"": ""05.462.662/0001-05"",
  ""Celular"": ""(62) 91234-5678"",
  ""Email"": ""comercial@microsum.com.br"",
  ""Senha"": ""senha_usada_para_acessar_newpro"",
  ""DFE"": {
    ""Ativo"": true,
    ""configBD"": {
      ""host"": ""192.168.1.202"",
      ""porta"": ""27017""
    }
  },
  ""PAY"": {
    ""Ativo"": false,
    ""configBD"": {
      ""host"": ""192.168.1.202"",
      ""porta"": ""27017""
    }
  },
  ""TAX"": {
    ""Ativo"": true,
    ""configBD"": {
      ""host"": ""192.168.1.202"",
      ""porta"": ""27017""
    }
  },
  ""HUB"": {
    ""Ativo"": false,
    ""configBD"": {
      ""host"": ""SERVER\\SQL2019PDI"",
      ""porta"": ""1433""
    },
    ""LimiteCanais"": 2
  },
  ""EFD"": {
    ""Ativo"": false,
    ""configBD"": {
      ""host"": ""SERVER\\SQL2019PDI"",
      ""porta"": ""1433""
    }
  }
}")]
    public class ClienteImplantacaoVM
    {
        public string CodigoRevenda { get; set; }

        public string Nome { get; set; }

        [JsonSchemaExtensionData("example", "01.078.133/0001-43")]
        public string CPFCNPJ { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public DFeVM DFE { get; set; }

        public PayVM PAY { get; set; }

        public TaxVM TAX { get; set; }

        public HubVM HUB { get; set; }

        public EfdVM EFD { get; set; }

        public ClienteImplantacaoVM()
        {
            DFE = new DFeVM();
            PAY = new PayVM();
            TAX = new TaxVM();
            HUB = new HubVM();
            EFD = new EfdVM();
        }

        public ClienteVM ToClienteVM()
        {

            string cpfcnpj = CPFCNPJ;

            string cpfCnpjNumeros = cpfcnpj.SomenteNumeros();

            EPessoa ePessoa;
            if (cpfCnpjNumeros.Length > 11)
            {
                ePessoa = EPessoa.JURÍDICA;
            }
            else
            {
                ePessoa = EPessoa.FÍSICA;
            }

            return new ClienteVM()
            {
                CodigoRevenda = CodigoRevenda,
                Pessoa = ePessoa,
                NomeRazaoSocial = Nome,
                ApelidoFantasia = Nome,
                CPFCNPJ = CPFCNPJ,
                Contribuinte = EContribuinte.NÃO,
                Contatos = new ContatosVM
                {
                    Telefone = Telefone,
                    Celular = Celular,
                    Email = Email
                },
                DFE = DFE,
                PAY = PAY,
                TAX = TAX,
                HUB = HUB,
                EFD = EFD
            };
        }
    }
}