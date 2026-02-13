using System.Runtime.Serialization;

namespace api.mstiADM.SDK.csharp.Enums
{
    public enum ENivelTipo
    {
        /// <summary>
        /// usado para validação
        /// </summary>
        [EnumMember(Value = "NENHUM")]
        NENHUM = 0,


        /// <summary>
        /// SuperUsuários da Microsum
        /// </summary>
        [EnumMember(Value = "ADM")]
        ADM = 1,


        /// <summary>
        /// Usuários gestores da Revenda e Suporte Microsum
        /// </summary>
        [EnumMember(Value = "REVENDA")]
        REVENDA = 2,


        /// <summary>
        /// Usuários gestores do Cliente
        /// </summary>
        [EnumMember(Value = "CLIENTE")]
        CLIENTE = 3
    }
}
