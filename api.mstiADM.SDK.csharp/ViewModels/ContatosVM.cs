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
    public class ContatosVM
    {
        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public string Site { get; set; }

        public string Contato { get; set; }

        public ContatosVMPack ToContatosVMPack()
        {
            return new ContatosVMPack
            {
                Telefone = Telefone,
                Celular = Celular,
                Email = Email,
                Site = Site,
                Contato = Contato
            };
        }

        public Contatos ToContatos()
        {
            return new Contatos
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
