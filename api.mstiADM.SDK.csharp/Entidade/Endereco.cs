using MongoDB.Bson.Serialization.Attributes;

namespace api.mstiADM.SDK.csharp.Entidade
{
    public class Endereco : EntidadeBase
    {
        [BsonElement("Logradouro")]
        public string Logradouro { get; set; }

        [BsonElement("Numero")]
        public string Numero { get; set; }

        [BsonElement("Complemento")]
        public string Complemento { get; set; }

        [BsonElement("Bairro")]
        public string Bairro { get; set; }

        [BsonElement("CidadeCodigo")]
        public string CidadeCodigo { get; set; }

        [BsonElement("CidadeDescricao")]
        public string CidadeDescricao { get; set; }

        [BsonElement("UFDescricao")]
        public string UFDescricao { get; set; }

        [BsonElement("CEP")]
        public string CEP { get; set; }

        [BsonElement("PaisCodigo")]
        public string PaisCodigo { get; set; }

        [BsonElement("PaisDescricao")]
        public string PaisDescricao { get; set; }

        [BsonElement("UFCodigo")]
        public string UFCodigo { get; set; }

        [BsonElement("UFSigla")]
        public string UFSigla { get; set; }
    }
}