using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.Entidade
{
    [ClassInterface(ClassInterfaceType.None)]
    public class ConfigNFCe : ConfigDFe
    {
        public string CSC { get; set; }

        public string CSCId { get; set; }
    }
}
