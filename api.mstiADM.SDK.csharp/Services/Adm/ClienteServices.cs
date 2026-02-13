using api.mstiADM.SDK.csharp.Interfaces.Adm;
using api.mstiADM.SDK.csharp.ViewModels;
using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using api.mstiADM.SDK.csharp.ViewModels.ResultVM;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Services.Adm
{
    public class ClienteServices : BaseService, IClienteServices
    {
        public ClienteServices(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<ADMResultVMPack<ClienteVMPack>> GetClienteFastByToken(string token)
        {
            return await GetAsyncPack<ADMResultVMPack<ClienteVMPack>>($"api/clientefast/{Uri.EscapeDataString(token)}");
        }

        public async Task<ADMResultVM<UsuarioVM>> GetUsuariosDoCliente(string token)
        {
            return await GetAsync<ADMResultVM<UsuarioVM>>($"api/clientefast/{Uri.EscapeDataString(token)}/usuarios");
        }

        public async Task<ADMResultVMPack<ClienteCertificadoVMPack>> AtualizaCertificadoDigital(string tokenDoCliente, string senha, byte[] certificadoDigital, string nomeArquivo)
        {
            var content = new MultipartFormDataContent
            {
                { new StringContent(senha), "Senha" },
                { new ByteArrayContent(certificadoDigital), "CertificadoDigital", nomeArquivo }
            };

            return await PutAsyncPack<ADMResultVMPack<ClienteCertificadoVMPack>>($"api/clientefast/{tokenDoCliente}/atualiza_certificado_digital", content);
        }

        public async Task<ADMResultVMPack<ClienteCertificadoVMPack>> GetCertificadoDigital(string tokenDoCliente)
        {
            return await GetAsyncPack<ADMResultVMPack<ClienteCertificadoVMPack>>($"api/clientefast/{tokenDoCliente}/get_certificado_digital");
        }

        public async Task<ADMResultVM<string>> AtualizaLogotipo(string tokenDoCliente, string strB64Logotipo)
        {
            return await PutAsync<ADMResultVM<string>>($"api/clientefast/{tokenDoCliente}/atualiza_logotipo", strB64Logotipo);
        }

        public async Task<ADMResultVM<ClienteVM>> AtualizarClienteParcial(string tokenDoCliente, AtualizaClienteParcialVM cliente)
        {
            return await PutAsync<ADMResultVM<ClienteVM>>($"api/clientefast/{tokenDoCliente}/atualizarcliente", cliente);
        }
    }
}