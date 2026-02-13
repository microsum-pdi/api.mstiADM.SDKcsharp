namespace api.mstiADM.SDK.csharp.Entidade
{
    public class ConfigDados
    {
        public string SenhaAdm { get; set; }

        public string SaltGerarTokens { get; set; }

        public string CriptografiaAESKey { get; set; }

        public EmailConfig EmailConfig { get; set; }
    }
}
