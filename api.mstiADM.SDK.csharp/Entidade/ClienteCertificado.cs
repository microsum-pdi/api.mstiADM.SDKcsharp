namespace api.mstiADM.SDK.csharp.Entidade
{
    public class ClienteCertificado : EntidadeBase
    {
        /// <summary>
        /// Representação base64 do certificado digital
        /// </summary>
        public string CertificadoBase64 { get; private set; }

        /// <summary>
        /// Nome do certificado digital
        /// </summary>
        public string Nome { get; private set; }

        /// <summary>
        /// Senha do certificado digital
        /// </summary>
        public string Senha { get; private set; }

        /// <summary>
        /// Data de validade do certificado digital 
        /// </summary>
        public string Validade { get; private set; }


        public ClienteCertificado(string CertificadoBase64, string Nome, string Senha, string Validade)
        {
            this.CertificadoBase64 = CertificadoBase64;
            this.Nome = Nome;
            this.Senha = Senha;
            this.Validade = Validade;
        }


        public void AtualizaSenhaCertificado(string Senha)
        {
            this.Senha = Senha;
        }
    }
}
