using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.Entidade
{
    [ClassInterface(ClassInterfaceType.None)]
    public class ClienteToken : EntidadeBase
    {
        [BsonElement("HashToken")]
        public string HashToken { get; set; }

        [BsonElement("AesToken")]
        public string AesToken { get; set; }

        [BsonElement("Geracao")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Geracao { get; private set; }

        [BsonElement("Revogacao")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Revogacao { get; private set; }

        public ClienteToken(string HashToken, string AesToken, DateTime Geracao, DateTime Revogacao)
        {
            this.HashToken = HashToken;
            this.AesToken = AesToken;
            this.Geracao = Geracao;
            this.Revogacao = Revogacao;
        }

        public bool Revogar()
        {
            DateTime DataAtual = DateTime.UtcNow;
            Revogacao = DataAtual;
            return true;
        }
    }
}
