using api.mstiADM.SDK.csharp.Extensions;
using System;
using System.Security.Cryptography.X509Certificates;

namespace api.mstiADM.SDK.csharp.Services
{
    public static class CertificadoDigitalServices
    {
        public static X509Certificate2 getX509Certificate2(string CertificadoBase64, string Senha)
        {
            try
            {
                byte[] decodedByteArray = Convert.FromBase64String(CertificadoBase64);
                var certificate = new X509Certificate2(decodedByteArray, Senha);
                return certificate;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar certificado digital: \n" +
                                    $"api.mstiADM.SDK.csharp.Services.CertificadoDigitalServices.getX509Certificate2()\n" +
                                    "StackTrace: " + ex?.StackTrace + "\n" +
                                    "Message: " + ex.ADMGetAllInnerExceptionsMessage());
            }
        }
    }
}
