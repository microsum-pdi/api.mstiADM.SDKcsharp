using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.Entidade
{
    [ClassInterface(ClassInterfaceType.None)]
    public class Contatos : EntidadeBase
    {
        [BsonElement("Telefone")]
        public string Telefone { get; set; }

        [BsonElement("Celular")]
        public string Celular { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Contato")]
        public string Contato { get; set; }

        [BsonElement("Site")]
        public string Site { get; set; }
    }
}
