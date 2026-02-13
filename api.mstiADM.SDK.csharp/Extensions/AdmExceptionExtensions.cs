using System;

namespace api.mstiADM.SDK.csharp.Extensions
{
    public static class AdmExceptionExtensions
    {
        /// <summary>
        /// Obtém todas as messagens de erro das InnerException encadeadas
        /// </summary>
        /// <returns>retorna a ultima mensagem</returns>
        public static string ADMGetAllInnerExceptionsMessage(this Exception ex)
        {
            if (ex == null) { return ""; }
            if (ex?.InnerException == null)
            {
                return ex?.Message;
            }
            else
            {
                return ex?.Message + "\n" + ADMGetAllInnerExceptionsMessage(ex?.InnerException);
            }
        }
    }
}
