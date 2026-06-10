using api.mstiADM.SDK.csharp.Entidade;
using api.mstiADM.SDK.csharp.ViewModels.ClientPackVM;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [AutoGuid]
    [BsonIgnoreExtraElements]
    public class EnderecoVM
    {
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string CidadeCodigo { get; set; }

        public string CidadeDescricao { get; set; }

        public string UFDescricao { get; set; }

        public string UFCodigo { get; set; }

        public string CEP { get; set; }

        public string PaisCodigo { get; set; }

        public string PaisDescricao { get; set; }

        public string PaisSigla { get; set; }

        public string UFSigla { get; set; }

        public EnderecoVMPack ToEnderecoVMPack()
        {
            return new EnderecoVMPack
            {
                Logradouro = Logradouro,
                Numero = Numero,
                Complemento = Complemento,
                Bairro = Bairro,
                CidadeCodigo = CidadeCodigo,
                CidadeDescricao = CidadeDescricao,
                UFDescricao = UFDescricao,
                UFCodigo = UFCodigo,
                CEP = CEP,
                PaisCodigo = PaisCodigo,
                PaisDescricao = PaisDescricao,
                PaisSigla = PaisSigla,
                UFSigla = UFSigla
            };
        }

        public Endereco ToEndereco()
        {
            return new Endereco()
            {
                Logradouro = Logradouro,
                Numero = Numero,
                Complemento = Complemento,
                Bairro = Bairro,
                CidadeCodigo = CidadeCodigo,
                CidadeDescricao = CidadeDescricao,
                CEP = CEP,
                UFCodigo = UFCodigo,
                UFDescricao = UFDescricao,
                UFSigla = UFSigla,
                PaisCodigo = PaisCodigo,
                PaisDescricao = PaisDescricao,
                PaisSigla = PaisSigla
            };
        }
    }
}