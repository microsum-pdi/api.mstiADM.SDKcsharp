using api.mstiADM.SDK.csharp.Enums;
using api.mstiADM.SDK.csharp.Extensions;
using api.mstiADM.SDK.csharp.Interfaces.Adm;
using api.mstiADM.SDK.csharp.ViewModels;
using api.mstiADM.SDK.csharp.ViewModels.Config;
using api.mstiADM.SDK.csharp.ViewModels.ResultVM;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Services.Clientes
{
    public class ClienteServices : GenericServices, IClienteServices
    {
        public ClienteServices(ConfigAmbienteSDK configAmbienteSDK) : base(configAmbienteSDK)
        {
        }

        /// <summary>
        /// Localiza um cliente através do token passado
        /// </summary>
        /// <param name="token">Token do cliente da API</param>
        public async Task<ADMResultVM<ClienteVM>> ObterCliente(string token)
        {
            string url = configAmbienteSDK.URL + $"/api/admui/clientefast/{Uri.EscapeDataString(token)}";

            ADMResultVM<ClienteVM> result = new ADMResultVM<ClienteVM>();

            try
            {
                HttpResponseMessage response = await ExecutaGet(url);

                string responseBody = response.Content.ReadAsStringAsync().Result;

                var resposta = JsonConvert.DeserializeObject<ADMResultVM<ClienteVM>>(responseBody);

                if (resposta == null)
                {
                    result
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível obter o cliente através do token.");
                }
                else
                {
                    result = resposta;
                }

                return result;
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao obter o cliente através do token." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }

        /// <summary>
        /// Lista os usuários relacionados ao cliente
        /// </summary>
        /// <param name="token">Token do cliente da API</param>
        public async Task<ADMResultVM<UsuarioVM>> ObterUsuariosDoCliente(string token)
        {
            string url = configAmbienteSDK.URL + $"/api/admui/clientefast/{Uri.EscapeDataString(token)}/usuarios";

            ADMResultVM<UsuarioVM> result = new ADMResultVM<UsuarioVM>();

            try
            {
                HttpResponseMessage response = await ExecutaGet(url);

                string responseBody = response.Content.ReadAsStringAsync().Result;

                var resposta = JsonConvert.DeserializeObject<ADMResultVM<UsuarioVM>>(responseBody);

                if (resposta == null)
                {
                    result
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível obter os usuarios do cliente através do token.");
                }
                else
                {
                    result = resposta;
                }

                return result;
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao obter os usuários do cliente através do token." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }

        /// <summary>
        /// Permite atualização do certificado digital do cliente
        /// </summary>
        /// <param name="token">Token do cliente</param>
        /// <param name="senha">senha do certificado digital</param>
        /// <param name="certificadoDigital">certificado digital</param>
        public async Task<ADMResultVM<ClienteCertificadoVM>> AtualizaCertificadoDigital(string token, string senha, byte[] certificadoDigital)
        {
            var content = new MultipartFormDataContent
            {
                { new StringContent(senha), "senha" },
                { new ByteArrayContent(certificadoDigital), "certificadoDigital", "certificadoDigital" }
            };

            string url = configAmbienteSDK.URL + $"/api/admui/clientefast/{token}/atualiza_certificado_digital";

            ADMResultVM<ClienteCertificadoVM> result = new ADMResultVM<ClienteCertificadoVM>();

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Put, url)
                {
                    Content = content
                };
                request.Headers.Add("x-api-key", configAmbienteSDK.Token);
                HttpResponseMessage response = await configAmbienteSDK.HttpClient.SendAsync(request);

                string responseBody = response.Content.ReadAsStringAsync().Result;

                var resposta = JsonConvert.DeserializeObject<ADMResultVM<ClienteCertificadoVM>>(responseBody);

                if (resposta == null)
                {
                    result
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível atualizar o certificado digital do cliente.");
                }
                else
                {
                    result = resposta;
                }

                return result;
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao atualizar o certificado digital do cliente." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }

        /// <summary>
        /// Recupera informações sobre o do certificado digital do cliente
        /// </summary>
        /// <param name="token">Token do cliente</param>
        public async Task<ADMResultVM<ClienteCertificadoVM>> ObterCertificadoDigital(string token)
        {
            string url = configAmbienteSDK.URL + $"/api/admui/clientefast/{token}/get_certificado_digital";

            ADMResultVM<ClienteCertificadoVM> result = new ADMResultVM<ClienteCertificadoVM>();

            try
            {
                HttpResponseMessage response = await ExecutaGet(url);

                string responseBody = response.Content.ReadAsStringAsync().Result;

                var resposta = JsonConvert.DeserializeObject<ADMResultVM<ClienteCertificadoVM>>(responseBody);

                if (resposta == null)
                {
                    result
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível obter o certificado digital do cliente.");
                }
                else
                {
                    result = resposta;
                }

                return result;
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao obter o certificado digital do cliente." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }

        /// <summary>
        /// Permite atualização do logotipo do cliente 
        /// </summary>
        /// <param name="token">Token do cliente</param>
        /// <param name="strB64Logotipo">B64 do logotipo</param>
        public async Task<ADMResultVM<string>> AtualizaLogotipo(string token, string strB64Logotipo)
        {
            string url = configAmbienteSDK.URL + $"/api/admui/clientefast/{token}/atualiza_logotipo";

            ADMResultVM<string> result = new ADMResultVM<string>();

            try
            {
                HttpResponseMessage response = await ExecutaPut(strB64Logotipo, url);

                string responseBody = response.Content.ReadAsStringAsync().Result;

                var resposta = JsonConvert.DeserializeObject<ADMResultVM<string>>(responseBody);

                if (resposta == null)
                {
                    result
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível atualizar o logotipo do cliente.");
                }
                else
                {
                    result = resposta;
                }

                return result;
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao atualizar o logotipo do cliente." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }

        /// <summary>
        /// Atualiza dados parciais do cliente
        /// <param name="token">Token do cliente</param>
        /// <param name="Cliente">Informações do cliente a ser atualizado</param>
        /// </summary>
        public async Task<ADMResultVM<ClienteVM>> AtualizarClienteParcial(string token, AtualizaClienteParcialVM cliente)
        {
            string url = configAmbienteSDK.URL + $"/api/admui/clientefast/{token}/atualizarcliente";

            ADMResultVM<ClienteVM> result = new ADMResultVM<ClienteVM>();

            try
            {
                HttpResponseMessage response = await ExecutaPut(cliente, url);

                string responseBody = response.Content.ReadAsStringAsync().Result;

                var resposta = JsonConvert.DeserializeObject<ADMResultVM<ClienteVM>>(responseBody);

                if (resposta == null)
                {
                    result
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível atualizar os dados do cliente.");
                }
                else
                {
                    result = resposta;
                }

                return result;
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao atualizar os dados do cliente." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }
    }
}