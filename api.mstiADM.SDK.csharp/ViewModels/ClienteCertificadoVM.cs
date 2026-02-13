using api.mstiADM.SDK.csharp.Extensions;
using api.mstiADM.SDK.csharp.Services;
using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    public class ClienteCertificadoVM
    {
        /// <summary>
        /// Representação base64 do certificado digital
        /// </summary>
        public string CertificadoBase64 { get; set; }

        /// <summary>
        /// Nome do certificado digital
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Senha do certificado digital
        /// </summary>
        public string Senha { get; set; }

        /// <summary>
        /// Data de validade do certificado digital 
        /// </summary>
        public string Validade { get; set; }

        /// <summary>
        /// Método para acionado ao incluir/atualizar o certificado digital da empresa
        /// </summary>
        /// <param name="certificadoDigital"></param>
        /// <param name="senhaCertificado"></param>
        public async Task InstanciaCertificado(IFormFile certificadoDigital, string senhaCertificado)
        {
            X509Certificate2 certificado = null;
            try
            {
                CertificadoBase64 = await FileServices.getBase64Async(certificadoDigital);
                certificado = CertificadoDigitalServices.getX509Certificate2(CertificadoBase64, senhaCertificado);

                if (certificado == null)
                {
                    throw new Exception(Resources.Resource.ErroAoGerarCertificdoDigital);
                }

                Nome = certificado.Subject;
                Senha = senhaCertificado;
                Validade = certificado.GetExpirationDateString();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: InstanciaCertificado" + ex.ADMGetAllInnerExceptionsMessage());
            }
            finally
            {
                certificado?.Dispose();
            }
        }

        /// <summary>
        /// Construtor para ser utilizado ao recuperar o certificado digital do banco de dados
        /// </summary>
        /// <param name="CertificadoBase64"></param>
        /// <param name="Nome"></param>
        /// <param name="Senha"></param>
        /// <param name="Validade"></param>
        [JsonConstructor]
        public ClienteCertificadoVM(string CertificadoBase64, string Nome, string Senha, string Validade)
        {
            this.CertificadoBase64 = CertificadoBase64;
            this.Nome = Nome;
            this.Senha = Senha;
            this.Validade = Validade;
        }

        public ClienteCertificadoVM()
        {
        }

        public ClienteCertificadoVMPack ToClienteCertificadoVMPack()
        {
            return new ClienteCertificadoVMPack
            {
                CertificadoBase64 = this.CertificadoBase64,
                Nome = this.Nome,
                Senha = this.Senha,
                Validade = this.Validade
            };
        }
    }
}
