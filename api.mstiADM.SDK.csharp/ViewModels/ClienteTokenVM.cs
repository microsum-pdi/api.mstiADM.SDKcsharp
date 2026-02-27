using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [ComVisible(false)]
    [BsonIgnoreExtraElements]
    public class ClienteTokenVM
    {
        public string Token { get; set; }

        [JsonIgnore]
        public string HashToken { get; set; }

        [JsonIgnore]
        public string AesToken { get; set; }
        
        [ComVisible(false)]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Geracao { get; set; }

        [ComVisible(false)]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Revogacao { get; set; }

        public bool Revogar()
        {
            DateTime DataAtual = DateTime.Now.ToLocalTime();
            Revogacao = DataAtual;
            return true;
        }

    }
}
