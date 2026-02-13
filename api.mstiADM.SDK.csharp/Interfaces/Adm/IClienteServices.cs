using api.mstiADM.SDK.csharp.ViewModels;
using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using api.mstiADM.SDK.csharp.ViewModels.ResultVM;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Interfaces.Adm
{
    public interface IClienteServices
    {
        Task<ADMResultVMPack<ClienteVMPack>> GetClienteFastByToken(string token);
        Task<ADMResultVM<UsuarioVM>> GetUsuariosDoCliente(string token);
        Task<ADMResultVMPack<ClienteCertificadoVMPack>> AtualizaCertificadoDigital(string tokenDoCliente, string senha, byte[] certificadoDigital, string nomeArquivo);
        Task<ADMResultVMPack<ClienteCertificadoVMPack>> GetCertificadoDigital(string tokenDoCliente);
        Task<ADMResultVM<string>> AtualizaLogotipo(string tokenDoCliente, string strB64Logotipo);
        Task<ADMResultVM<ClienteVM>> AtualizarClienteParcial(string tokenDoCliente, AtualizaClienteParcialVM cliente);
    }
}
