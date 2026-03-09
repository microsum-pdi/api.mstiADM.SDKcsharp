using api.mstiADM.SDK.csharp.ViewModels;
using api.mstiADM.SDK.csharp.ViewModels.ResultVM;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Interfaces.Adm
{
    public interface IClienteServices
    {
        Task<ADMResultVM<ClienteVM>> ObterCliente(string token);

        Task<ADMResultVM<UsuarioVM>> ObterUsuariosDoCliente(string token);        

        Task<ADMResultVM<ClienteCertificadoVM>> AtualizaCertificadoDigital(string tokenDoCliente, string senha, byte[] certificadoDigital);

        Task<ADMResultVM<ClienteCertificadoVM>> AtualizaCertificadoDigital(string token, string senha, IFormFile certificadoDigital);
        
        Task<ADMResultVM<ClienteCertificadoVM>> ObterCertificadoDigital(string tokenDoCliente);
        
        Task<ADMResultVM<string>> AtualizaLogotipo(string tokenDoCliente, string strB64Logotipo);
        
        Task<ADMResultVM<ClienteVM>> AtualizarClienteParcial(string tokenDoCliente, AtualizaClienteParcialVM cliente);
    }
}
