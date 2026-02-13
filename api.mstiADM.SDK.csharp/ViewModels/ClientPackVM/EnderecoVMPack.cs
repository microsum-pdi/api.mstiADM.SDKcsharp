using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class EnderecoVMPack
    {
        [Key(0)]
        public string Logradouro { get; set; }

        [Key(1)]
        public string Numero { get; set; }

        [Key(2)]
        public string Complemento { get; set; }

        [Key(3)]
        public string Bairro { get; set; }

        [Key(4)]
        public string CidadeCodigo { get; set; }

        [Key(5)]
        public string CidadeDescricao { get; set; }

        [Key(6)]
        public string UFDescricao { get; set; }

        [Key(7)]
        public string UFCodigo { get; set; }

        [Key(8)]
        public string CEP { get; set; }

        [Key(9)]
        public string PaisCodigo { get; set; }

        [Key(10)]
        public string PaisDescricao { get; set; }

        [Key(11)]
        public string UFSigla { get; set; }



        public EnderecoVM ToEnderecoVM()
        {
            return new EnderecoVM
            {
                Logradouro = this.Logradouro,
                Numero = this.Numero,
                Complemento = this.Complemento,
                Bairro = this.Bairro,
                CidadeCodigo = this.CidadeCodigo,
                CidadeDescricao = this.CidadeDescricao,
                UFDescricao = this.UFDescricao,
                CEP = this.CEP,
                PaisCodigo = this.PaisCodigo,
                PaisDescricao = this.PaisDescricao,
                UFSigla = this.UFSigla,
                UFCodigo = UFCodigo
            };
        }
    }
}
