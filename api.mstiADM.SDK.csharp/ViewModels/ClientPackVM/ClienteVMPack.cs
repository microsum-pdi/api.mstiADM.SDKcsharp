using api.mstiADM.SDK.csharp.Enums;
using api.mstiADM.SDK.csharp.Extensions;
using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM._Base;
using MessagePack;
using System.Collections.Generic;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    /// <summary>
    /// Ao realizar Alteração nessa classe, realizar alteração nas classes do ERP pois foi decidido na época que foi construido
    /// não colocar a api.msti.Shared no ERP diretamente, ou seja, houve replicação de código no ERP. 
    /// Alterar a classe msti.newpro.Core\Services\ADMServices\ClientPackVM
    /// Publicar Todas as apis ao alterar essa classe: PAY, TAX, HUB e DFE
    /// </summary>
    [MessagePackObject]
    public class ClienteVMPack
    {
        /// <summary>
        /// Código sequencial do cliente
        /// </summary>
        [Key(0)]
        public string Codigo { get; set; }

        [Key(1)]
        public string CodigoRevenda { get; set; }

        [Key(2)]
        public EPessoa Pessoa { get; set; }

        [Key(3)]
        public string NomeRazaoSocial { get; set; }

        [Key(4)]
        public string ApelidoFantasia { get; set; }

        [Key(5)]
        public EContribuinte Contribuinte { get; set; }

        [Key(6)]
        public string DI { get; set; }

        [Key(7)]
        public EnderecoVMPack Endereco { get; set; }

        [Key(8)]
        public ContatosVMPack Contatos { get; set; }

        [Key(9)]
        public string CPFCNPJ { get; set; }

        [Key(10)]
        public string IE { get; set; }

        [Key(11)]
        public string IM { get; set; }

        [Key(12)]
        public ICollection<ClienteTokenVMPack> Tokens { get; set; }

        [Key(13)]
        public ICollection<ClienteWebHookVMPack> WebHooks { get; set; }

        [Key(14)]
        public ClienteCertificadoVMPack Certificado { get; set; }

        [Key(15)]
        public string LogotipoB64 { get; set; }

        [Key(16)]
        public DFeVMPack DFE { get; set; }

        [Key(17)]
        public PayVMPack PAY { get; set; }

        [Key(18)]
        public TaxVMPack TAX { get; set; }

        [Key(19)]
        public HubVMPack HUB { get; set; }

        [Key(20)]
        public EfdVMPack EFD { get; set; }

        [Key(21)]
        public EEntidadeSituacao Situacao { get; set; }

        [Key(22)]
        public string Id { get; set; }

        public string GetCpfOrCnpj()
        {
            return !string.IsNullOrEmpty(CPFCNPJ) ? CPFCNPJ.SomenteNumeros() : "";
        }

        public bool IsCodigoRevendaValido()
        {
            if (string.IsNullOrEmpty(CodigoRevenda) || string.IsNullOrWhiteSpace(CodigoRevenda))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public ClienteVM ToClientVM()
        {
            ClienteVM clienteVM = new ClienteVM()
            {
                Id = Id,
                Codigo = Codigo,
                CodigoRevenda = CodigoRevenda,
                NomeRazaoSocial = NomeRazaoSocial,
                Endereco = Endereco?.ToEnderecoVM(),
                Contatos = Contatos?.ToContatosVM(),
                CPFCNPJ = CPFCNPJ,
                IE = IE,
                IM = IM,
                Pessoa = Pessoa,
                ApelidoFantasia = ApelidoFantasia,
                Contribuinte = Contribuinte,
                DI = DI,
                LogotipoB64 = LogotipoB64,
                Tokens = Tokens?.ToListTokenVM(),
                WebHooks = WebHooks?.ToListWebHookVM(),
                Certificado = Certificado?.ToClienteCertificadoVM(),
                DFE = DFE?.ToDFeVM(),
                PAY = PAY?.ToPayVM(),
                TAX = TAX?.ToTaxVM(),
                HUB = HUB?.ToHubVM(),
                EFD = EFD?.ToEfdVM(),
                Situacao = Situacao
            };

            return clienteVM;
        }
    }
}