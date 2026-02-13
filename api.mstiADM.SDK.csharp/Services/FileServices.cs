using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace api.mstiADM.SDK.csharp.Services
{
    /// <summary>
    /// Operações relacionadas à arquivos, como: 
    /// Codificação, conversões para array, base64, etc
    /// </summary>
    public static class FileServices
    {
        /// <summary>
        /// Retorna um array de bytes de um objeto IFormFile
        /// </summary>
        /// <returns></returns>
        public async static Task<byte[]> getByteArray(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }

        /// <summary>
        /// Retorna a string base64 de um objeto IFormFile
        /// </summary>
        /// <returns></returns>
        public static async Task<string> getBase64Async(IFormFile file)
        {
            try
            {
                return Convert.ToBase64String(await getByteArray(file));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
