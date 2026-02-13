using MessagePack;


namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class ClienteCertificadoVMPack
    {
        /// <summary>
        /// Representação base64 do certificado digital
        /// </summary>
        [Key(0)]
        public string CertificadoBase64 { get; set; }

        /// <summary>
        /// Nome do certificado digital
        /// </summary>
        [Key(1)]
        public string Nome { get; set; }

        /// <summary>
        /// Senha do certificado digital
        /// </summary>
        [Key(2)]
        public string Senha { get; set; }

        /// <summary>
        /// Data de validade do certificado digital 
        /// </summary>
        [Key(3)]
        public string Validade { get; set; }


        public ClienteCertificadoVM ToClienteCertificadoVM()
        {
            return new ClienteCertificadoVM
            {
                CertificadoBase64 = this.CertificadoBase64,
                Nome = this.Nome,
                Senha = this.Senha,
                Validade = this.Validade
            };
        }
    }
}
