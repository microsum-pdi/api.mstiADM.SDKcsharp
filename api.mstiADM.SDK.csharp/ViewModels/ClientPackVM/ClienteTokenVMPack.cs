using MessagePack;
using System;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class ClienteTokenVMPack
    {
        [Key(0)]
        public string HashToken { get; set; }


        [Key(1)]
        public string AesToken { get; set; }


        [Key(2)]
        public DateTime Geracao { get; set; }


        [Key(3)]
        public DateTime Revogacao { get; set; }
    }
}



