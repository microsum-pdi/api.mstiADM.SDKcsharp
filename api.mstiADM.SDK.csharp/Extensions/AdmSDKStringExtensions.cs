using System.Text.RegularExpressions;

namespace api.mstiADM.SDK.csharp.Extensions
{
    public static class AdmSDKStringExtensions
    {
        /// <summary>
        /// Retorna somente a parte numérica da string
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string SomenteNumeros(this string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return null;
            }
            return string.Join("", Regex.Split(valor, @"[^\d]"));
        }
    }
}
