using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace api.mstiADM.SDK.csharp.Enums
{
    [ComVisible(true)]
    /// <summary> 
    /// Código de Status HTTP 
    /// 
    /// <para>200 - Requisição processada com sucesso</para> 
    /// <para>400 - Uma ou mais falhas de regra de negócio</para> 
    /// <para>401 - É necessário autenticação para acessar o recurso</para> 
    /// <para>403 - Sem permissão para acessar o recurso</para> 
    /// <para>404 - Recurso requisitado, não foi encontrado</para> 
    /// <para>405 - O servidor não entendeu a requisição pois está com uma sintaxe inválida</para> 
    /// <para>500 - Erro interno no servidor</para> 
    /// </summary> 
    public enum ADMEHttpStatusCode
    {
        /// <summary>
        /// Quando a requisição for processada com sucesso
        /// </summary>
        [EnumMember(Value = "200")]
        OK = 200,

        /// <summary>
        /// Quando houver um erro interno no servidor
        /// </summary>
        [EnumMember(Value = "500")]
        BadGateway = 500,

        /// <summary>
        /// Serviço indisponível
        /// </summary>
        [EnumMember(Value = "503")]
        ServiceUnavailable = 503,

        /// <summary>
        /// Quando ocorrerem uma ou mais falhas de regra de negócio
        /// </summary>
        [EnumMember(Value = "400")]
        BadRequest = 400,

        /// <summary>
        /// É necessário autenticação para acessar o recurso
        /// </summary>
        [EnumMember(Value = "401")]
        NotAutorized = 401,

        /// <summary>
        /// Sem permissão para acessar o recurso
        /// </summary>
        [EnumMember(Value = "403")]
        Forbidden = 403,

        /// <summary>
        /// Recurso não encontrado
        /// </summary>
        [EnumMember(Value = "404")]
        NotFound = 404,

        /// <summary>
        ///  O servidor não entendeu a requisição pois está com uma sintaxe inválida
        /// </summary>
        [EnumMember(Value = "405")]
        MethodNotAllowed = 405
    }
}