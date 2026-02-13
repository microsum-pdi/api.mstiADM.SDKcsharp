using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class ContatosVMPack
    {
        [Key(0)]
        public string Telefone { get; set; }

        [Key(1)]
        public string Celular { get; set; }

        [Key(2)]
        public string Email { get; set; }

        [Key(3)]
        public string Site { get; set; }

        [Key(4)]
        public string Contato { get; set; }

        public ContatosVM ToContatosVM()
        {
            return new ContatosVM
            {
                Telefone = Telefone,
                Celular = Celular,
                Email = Email,
                Site = Site,
                Contato = Contato
            };
        }
    }
}
