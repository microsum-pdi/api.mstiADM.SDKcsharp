using api.mstiADM.SDK.csharp.Enums;
using api.mstiADM.SDK.csharp.Resources;
using api.mstiADM.SDK.csharp.ValueObjects;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.Entidade
{
    [ClassInterface(ClassInterfaceType.None)]
    public class Cliente : Notificavel
    {

        #region PROPRIEDADES
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }

        [BsonElement("CodigoRevenda")]
        public long CodigoRevenda { get; private set; }

        [BsonElement("Codigo")]
        public long Codigo { get; private set; }

        [BsonElement("NomeRazaoSocial")]
        public string NomeRazaoSocial { get; private set; }

        [BsonElement("ApelidoFantasia")]
        public string ApelidoFantasia { get; private set; }

        [BsonElement("Contribuinte")]
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public EContribuinte Contribuinte { get; private set; } = EContribuinte.NÃO;

        [BsonElement("DI")]
        public string DI { get; private set; }

        [BsonElement("Celular")]
        public string Celular { get; private set; }

        [BsonElement("Site")]
        public string Site { get; private set; }

        [BsonElement("Contato")]
        public string Contato { get; private set; }

        [BsonElement("Logradouro")]
        public string Logradouro { get; private set; }

        [BsonElement("Numero")]
        public string Numero { get; private set; }

        [BsonElement("Complemento")]
        public string Complemento { get; private set; }

        [BsonElement("Bairro")]
        public string Bairro { get; private set; }

        [BsonElement("CidadeCodigo")]
        public string CidadeCodigo { get; private set; }

        [BsonElement("CidadeDescricao")]
        public string CidadeDescricao { get; private set; }

        [BsonElement("UFDescricao")]
        public string UFDescricao { get; private set; }

        [BsonElement("CEP")]
        public string CEP { get; private set; }

        [BsonElement("PaisCodigo")]
        public string PaisCodigo { get; private set; }

        [BsonElement("PaisDescricao")]
        public string PaisDescricao { get; private set; }

        [BsonElement("PaisSigla")]
        public string PaisSigla { get; private set; }

        [BsonElement("UFCodigo")]
        public string UFCodigo { get; private set; }

        [BsonElement("UFSigla")]
        public string UFSigla { get; private set; }

        [BsonElement("Telefone")]
        public string Telefone { get; private set; }

        [BsonElement("CPFCNPJ")]
        public string CPFCNPJ { get; private set; }

        [BsonElement("IE")]
        public string IE { get; private set; }

        [BsonElement("IM")]
        public string IM { get; private set; }

        [BsonElement("Email")]
        public string Email { get; private set; }

        [BsonElement("Pessoa")]
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public EPessoa Pessoa { get; private set; }

        [BsonElement("Tokens")]
        public ICollection<ClienteToken> Tokens { get; private set; }

        [BsonElement("WebHooks")]
        public ICollection<ClienteWebHook> WebHooks { get; private set; }

        [BsonElement("Certificado")]
        public ClienteCertificado Certificado { get; private set; }

        [BsonElement("LogotipoB64")]
        public string LogotipoB64 { get; set; }

        [BsonElement("DFE")]
        public DFe DFe { get; private set; }

        [BsonElement("PAY")]
        public PAY PAY { get; private set; }

        [BsonElement("HUB")]
        public HUB HUB { get; private set; }

        [BsonElement("EFD")]
        public EFD EFD { get; private set; }

        [BsonElement("TAX")]
        public TAX TAX { get; private set; }

        [BsonElement("Situacao")]
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public EEntidadeSituacao Situacao { get; private set; }

        #endregion

        public Cliente()
        {
        }

        public Cliente(string Id, string Codigo, long CodigoRevenda, string NomeRazaoSocial, string ApelidoFantasia, EContribuinte Contribuinte,
                       string DI, EPessoa Pessoa, string CPFCNPJ, string IE, string IM, Endereco endereco, Contatos contatos,
                       string LogotipoB64, ICollection<ClienteToken> Tokens, ICollection<ClienteWebHook> WebHooks,
                       ClienteCertificado Certificado, DFe DFe, PAY PAY, HUB HUB, EFD EFD, TAX TAX, EEntidadeSituacao situacao)
        {
            this.Id = Id;
            this.Codigo = long.Parse(Codigo);
            this.CodigoRevenda = CodigoRevenda;
            this.NomeRazaoSocial = NomeRazaoSocial;
            this.ApelidoFantasia = ApelidoFantasia;
            this.Contribuinte = Contribuinte;
            this.Pessoa = Pessoa;
            this.DI = DI;
            this.CPFCNPJ = CPFCNPJ;
            this.IE = IE;
            this.IM = IM;

            //campos da antiga classe Endereco, foi feito assim devido aos requisitos
            this.Logradouro = endereco?.Logradouro;
            this.Numero = endereco?.Numero;
            this.Complemento = endereco?.Complemento;
            this.Bairro = endereco?.Bairro;
            this.CidadeCodigo = endereco?.CidadeCodigo;
            this.CidadeDescricao = endereco?.CidadeDescricao;
            this.UFDescricao = endereco?.UFDescricao;
            this.UFCodigo = endereco?.UFCodigo;
            this.UFSigla = endereco?.UFSigla;
            this.CEP = endereco?.CEP;
            this.PaisCodigo = endereco?.PaisCodigo;
            this.PaisDescricao = endereco?.PaisDescricao;
            this.PaisSigla = endereco?.PaisSigla;

            //campos da classe Contatos
            this.Telefone = contatos.Telefone;
            this.Celular = contatos.Celular;
            this.Email = contatos.Email;
            this.Contato = contatos.Contato;
            this.Site = contatos.Site;

            this.LogotipoB64 = LogotipoB64;
            this.Tokens = Tokens;
            this.WebHooks = WebHooks;
            this.Certificado = Certificado;
            this.DFe = DFe ?? new DFe();
            this.PAY = PAY ?? new PAY();
            this.HUB = HUB ?? new HUB();
            this.EFD = EFD ?? new EFD();
            this.TAX = TAX ?? new TAX();
            Situacao = situacao;

            if (this.Certificado != null)
            {
                // Objetos filhos que devem ser validados pelo padrão Notification
                AddNotifications(this.Certificado);
            }


            if (string.IsNullOrEmpty(NomeRazaoSocial))
            {
                AddNotification("NomeRazaoSocial", Resource.ClienteNomeNaoPreenchido);
            }

            ValidaCpfCnpj();
          
        }

        private void ValidaCpfCnpj()
        {
            if(string.IsNullOrEmpty(CPFCNPJ) && string.IsNullOrWhiteSpace(CPFCNPJ))
            {
                AddNotification("CPFCNPJ", Resource.CPFCNPJInvalido);
            }
            else
            {
                if(VoCNPJ.IsCNPJ(CPFCNPJ))
                {
                    if(!VoCNPJ.Check(CPFCNPJ)) AddNotification("CPFCNPJ", "CNPJ inválido!");
                }
                else
                {
                    var cpf  = new VoCPF(CPFCNPJ);
                    if(!cpf.IsValid) AddNotification("CPFCNPJ", "CPF inválido!");
                }
            }
        }


        //TODO: Remover após atualização
        public void AtualizaId(string Id)
        {
            this.Id = Id;
        }

        public void CriarListaTokens()
        {
            Tokens = new List<ClienteToken>();
        }

        public void AtualizaCertificado(ClienteCertificado Certificado)
        {
            if (Certificado != null)
            {
                this.Certificado = Certificado;
            }
        }

        public void AtualizaLogotipo(string b64Logotipo)
        {
            const string INICIOB64 = "data:image/jpeg;base64,";
            const string INICIOB64PNG = "data:image/png;base64,";
            if (!string.IsNullOrEmpty(b64Logotipo))
            {
                if (!b64Logotipo.StartsWith(INICIOB64) && !b64Logotipo.StartsWith(INICIOB64PNG))
                {
                    b64Logotipo = INICIOB64 + b64Logotipo;
                }
            }
            LogotipoB64 = b64Logotipo;
        }

        public void AtualizaSenhaCertificado(string Senha)
        {
            if (Certificado != null)
            {
                this.Certificado.AtualizaSenhaCertificado(Senha);
            }
        }

        public void AtualizaConfigDFE(DFe dFe)
        {
            if (dFe != null)
            {
                this.DFe = dFe;
            }
        }

        public void AtualizaConfigTAX(TAX tax)
        {
            if (tax != null)
            {
                this.TAX = tax;
            }
        }

        public void AtualizaConfigPAY(PAY pay)
        {
            if (pay != null)
            {
                this.PAY = pay;
            }
        }

        public void AtualizaConfigHUB(HUB hub)
        {
            if (hub != null)
            {
                this.HUB = hub;
            }
        }

        public void AtualizaConfigEFD(EFD efd)
        {
            if (efd != null)
            {
                this.EFD = efd;
            }
        }

        /// <summary>
        /// Esse método foi criado para ApiADM ser notificada que a api executou o processo de implantacao corretamente
        /// </summary>
        /// <param name="nomeApi">nome da api que executou o processo</param>
        public void AtualizaImplantacaoAPIs(ENomeAPI nomeApi)
        {
            if (nomeApi == ENomeAPI.TAX)
            {
                TAX.AtualizaProcessoDeImplantacao();
            }
            else if (nomeApi == ENomeAPI.DFE)
            {
                DFe.AtualizaProcessoDeImplantacao();
            }
            else if (nomeApi == ENomeAPI.HUB)
            {
                HUB.AtualizaProcessoDeImplantacao();
            }
            else if (nomeApi == ENomeAPI.EFD)
            {
                EFD.AtualizaProcessoDeImplantacao();
            }
            else if (nomeApi == ENomeAPI.PAY)
            {
                PAY.AtualizaProcessoDeImplantacao();
            }
        }

        /// <summary>
        /// Atualiza a informação da versão do banco de dados do cliente, na respectiva API
        /// </summary>
        /// <param name="nomeApi">nome da api que executou o processo</param>
        /// <param name="versao"></param>
        public void AtualizaVersaoBancoDeDadosAPI(ENomeAPI nomeApi, int versao)
        {
            if (nomeApi == ENomeAPI.TAX)
            {
                TAX.configBD.versao = versao;
            }
            else if (nomeApi == ENomeAPI.DFE)
            {
                DFe.configBD.versao = versao;
            }
            else if (nomeApi == ENomeAPI.HUB)
            {
                HUB.configBD.versao = versao;
            }
            else if (nomeApi == ENomeAPI.EFD)
            {
                EFD.configBD.versao = versao;
            }
            else if (nomeApi == ENomeAPI.PAY)
            {
                PAY.configBD.versao = versao;
            }
        }


        /// <summary>
        /// Atualiza o endereço de um cliente
        /// </summary>
        /// <param name="endereco"></param>
        public void AtualizaEndereco(Endereco endereco)
        {
            //campos da antiga classe Endereco, foi feito assim devido aos requisitos
            this.Logradouro = endereco?.Logradouro;
            this.Numero = endereco?.Numero;
            this.Complemento = endereco?.Complemento;
            this.Bairro = endereco?.Bairro;
            this.CidadeCodigo = endereco?.CidadeCodigo;
            this.CidadeDescricao = endereco?.CidadeDescricao;
            this.UFDescricao = endereco?.UFDescricao;
            this.UFCodigo = endereco?.UFCodigo;
            this.UFSigla = endereco?.UFSigla;
            this.CEP = endereco?.CEP;
            this.PaisCodigo = endereco?.PaisCodigo;
            this.PaisDescricao = endereco?.PaisDescricao;
        }
        public void AtualizaPaisCodigo(string PaisCodigo)
        {
            this.PaisCodigo = PaisCodigo;
        }
    }
}