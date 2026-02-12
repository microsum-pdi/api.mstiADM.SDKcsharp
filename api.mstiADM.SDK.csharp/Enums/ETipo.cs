using System.Runtime.Serialization;

namespace api.mstiADM.SDK.csharp.Enums
{
    public enum ETipo
    {
        [EnumMember(Value = "ENTRADA")]
        ENTRADA = 0,

        [EnumMember(Value = "SAÍDA")]
        SAÍDA = 1
    }
}
