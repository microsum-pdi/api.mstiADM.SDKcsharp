namespace api.mstiADM.SDK.csharp.Entidade
{
    public class EmailConfig
    {
        /// <summary>
        /// Nome de apresentação do email
        /// </summary>
        public string NomeApresentacao { get; set; }

        /// <summary>
        /// Será enviado um email apartir deste email
        /// </summary>
        public string EmailFrom { get; set; }

        /// <summary>
        /// Endereço do servidor de email
        /// </summary>
        public string SmtpServer { get; set; }

        /// <summary>
        /// Porta
        /// </summary>
        public int Porta { get; set; }

        /// <summary>
        /// Usuário
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// Senha
        /// </summary>
        public string Senha { get; set; }
    }
}