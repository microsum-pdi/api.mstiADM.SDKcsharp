using MongoDB.Bson.Serialization.Attributes;

namespace api.mstiADM.SDK.csharp.Entidade
{
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
