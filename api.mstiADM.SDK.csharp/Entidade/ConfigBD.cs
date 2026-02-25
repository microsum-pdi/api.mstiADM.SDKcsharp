using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.Entidade
{
    [ClassInterface(ClassInterfaceType.None)]
    public class ConfigBD
    {
        public string host { get; set; }

        public string porta { get; set; }

        public string nome { get; set; }

        public int versao { get; set; }
    }
}