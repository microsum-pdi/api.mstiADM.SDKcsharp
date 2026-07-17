using api.mstiADM.SDK.csharp.Enums;
using api.mstiADM.SDK.csharp.Extensions;
using api.mstiADM.SDK.csharp.Interfaces.Adm;
using api.mstiADM.SDK.csharp.ViewModels;
using api.mstiADM.SDK.csharp.ViewModels.Config;
using api.mstiADM.SDK.csharp.ViewModels.ResultVM;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Services.Clientes
{
    public class ClienteServices : GenericServices, IClienteServices
    {
        JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
        {
            DateFormatString = "dd/MM/yyyy HH:mm:ss"
        };

        public ClienteServices(ConfigAmbienteSDK configAmbienteSDK) : base(configAmbienteSDK) { }

        /// <summary>
        /// Localiza um cliente através do token passado
        /// </summary>
        /// <param name="token">Token do cliente da API</param>
        public async Task<ADMResultVM<ClienteVM>> ObterCliente(string token)
        {
            var url = configAmbienteSDK.URL + $"/admui/api/clientefast/{Uri.EscapeDataString(token)}";

            try
            {
                var response = await ExecutaGet(url);
                var json = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(json))
                    return new ADMResultVM<ClienteVM>()
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível obter o cliente através do token.");

                return JsonConvert.DeserializeObject<ADMResultVM<ClienteVM>>(json, jsonSerializerSettings);
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
            var url = configAmbienteSDK.URL + $"/admui/api/clientefast/{Uri.EscapeDataString(token)}/usuarios";

            try
            {
                var response = await ExecutaGet(url);
                var json = await response.Content.ReadAsStringAsync();
                var resposta = JsonConvert.DeserializeObject<ADMResultVM<UsuarioVM>>(json, jsonSerializerSettings);

                if (string.IsNullOrEmpty(json))
                    return new ADMResultVM<UsuarioVM>()
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível obter o cliente através do token.");

                return JsonConvert.DeserializeObject<ADMResultVM<UsuarioVM>>(json, jsonSerializerSettings);
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
        /// <param name="senha">Senha do certificado digital</param>
        /// <param name="certificadoDigital">Array de bytes do certificado digital</param>
        public async Task<ADMResultVM<ClienteCertificadoVM>> AtualizaCertificadoDigital(string token, string senha, byte[] certificadoDigital)
        {
            var content = new MultipartFormDataContent
            {
                { new StringContent(senha), "senha" },
                { new ByteArrayContent(certificadoDigital), "certificadoDigital", "certificadoDigital" }
            };

            var url = configAmbienteSDK.URL + $"/admui/api/clientefast/{token}/atualiza_certificado_digital";

            try
            {
                var response = await ExecutaPutMultiPartFormAsync(url, content);
                var json = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(json))
                    return new ADMResultVM<ClienteCertificadoVM>()
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível atualizar o certificado digital do cliente.");

                return JsonConvert.DeserializeObject<ADMResultVM<ClienteCertificadoVM>>(json, jsonSerializerSettings);
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao atualizar o certificado digital do cliente." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }

        private async Task<byte[]> ConverterParaBytes(IFormFile certificadoDigital)
        {
            if (certificadoDigital == null || certificadoDigital.Length == 0) return null;

            using (var memoryStream = new MemoryStream())
            {
                // Copia o conteúdo do arquivo para o stream de memória
                await certificadoDigital.CopyToAsync(memoryStream);

                // Retorna o array de bytes
                return memoryStream.ToArray();
            }
        }

        /// <summary>
        /// Permite atualização do certificado digital do cliente
        /// </summary>
        /// <param name="token">Token do cliente</param>
        /// <param name="senha">senha do certificado digital</param>
        /// <param name="certificadoDigital">IFormFile do certificado digital</param>
        public async Task<ADMResultVM<ClienteCertificadoVM>> AtualizaCertificadoDigital(string token, string senha, IFormFile certificadoDigital)
        {
            return await AtualizaCertificadoDigital(token, senha, await ConverterParaBytes(certificadoDigital));
        }

        /// <summary>
        /// Recupera informações sobre o do certificado digital do cliente
        /// </summary>
        /// <param name="token">Token do cliente</param>
        public async Task<ADMResultVM<ClienteCertificadoVM>> ObterCertificadoDigital(string token)
        {
            var url = $"{configAmbienteSDK.URL}/admui/api/clientefast/{token}/get_certificado_digital";

            try
            {
                var response = await ExecutaGet(url);
                var json = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(json))
                    return new ADMResultVM<ClienteCertificadoVM>()
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível obter o certificado digital do cliente.");

                return JsonConvert.DeserializeObject<ADMResultVM<ClienteCertificadoVM>>(json, jsonSerializerSettings);
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
            var url = configAmbienteSDK.URL + $"/admui/api/clientefast/{token}/atualiza_logotipo";

            try
            {
                var response = await ExecutaPut(strB64Logotipo, url);
                var json = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(json))
                    return new ADMResultVM<string>()
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível atualizar o logotipo do cliente.");

                return JsonConvert.DeserializeObject<ADMResultVM<string>>(json, jsonSerializerSettings);
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
            var url = configAmbienteSDK.URL + $"/admui/api/clientefast/{token}/atualizarcliente";

            try
            {
                var response = await ExecutaPut(cliente, url);
                var json = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(json))
                    return new ADMResultVM<ClienteVM>()
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível atualizar os dados do cliente.");

                return JsonConvert.DeserializeObject<ADMResultVM<ClienteVM>>(json, jsonSerializerSettings);
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao atualizar os dados do cliente." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }
    
        /// <summary>
        /// Permite obter uma chave de acesso temporária na AMIntegra.
        /// </summary>
        /// <param name="data">Dados do cliente</param>
        public async Task<ADMResultVM<string>> GeraChaveAcessoTemporario(ClienteAutoLoginVM data)
        {
            var token = data.Token;
            var baseURL = configAmbienteSDK.URL.TrimEnd('/');
            var URL = $"{baseURL}/admui/api/clientefast/autologin";

            if(string.IsNullOrEmpty(token))
                return new ADMResultVM<string>()
                    .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                    .WithMessage("Token do usuário deve ser informado!");

            try
            {
                var response = await ExecutaPost(data, URL);
                var json = await response.Content.ReadAsStringAsync();
                
                if (string.IsNullOrEmpty(json))
                {
                    return new ADMResultVM<string>()
                        .WithStatusCode(ADMEHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível gerar chave de acesso temporária.");
                }

                var resultVM = JsonConvert.DeserializeObject<ADMResultVM<string>>(json, jsonSerializerSettings);
                if(!resultVM.IsSuccessStatusCode()) return resultVM;

                var chaveAcesso = resultVM.GetFirstData();
                var linkAcesso = $"{GetURLFrontend()}/autologin?acesso={chaveAcesso}";

                return new ADMResultVM<string>().WithData(linkAcesso);
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao atualizar os dados do cliente." + " - " + ex.ADMGetAllInnerExceptionsMessage() + "\n";
                DetalheErro += "Url: " + URL + "\n";

                throw new Exception(DetalheErro);
            }
        }

        private string GetURLFrontend()
        {
            if(string.IsNullOrEmpty(configAmbienteSDK.URLFrontend))
                throw new Exception("Necessário informar a URL do frontend da AMIIntegra nas configurações do SDK.");

            return configAmbienteSDK.URLFrontend.TrimEnd('/');
        }
    }
}