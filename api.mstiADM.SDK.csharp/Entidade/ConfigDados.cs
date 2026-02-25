using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.Entidade
{
    [ClassInterface(ClassInterfaceType.None)]
    public class ConfigDados
    {
        public string SenhaAdm { get; set; }

        public string SaltGerarTokens { get; set; }

        public string CriptografiaAESKey { get; set; }

        public EmailConfig EmailConfig { get; set; }
    }
}
