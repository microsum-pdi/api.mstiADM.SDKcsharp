using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class ConfigBdVMPack
    {
        [Key(0)]
        public string host { get; set; }

        [Key(1)]
        public string porta { get; set; }

        [Key(2)]
        public string nome { get; set; }

        [Key(3)]
        public string usuario { get; set; }

        [Key(4)]
        public string senha { get; set; }

        [Key(5)]
        public int versao { get; set; }

        public ConfigBdVM ToConfigBdVM()
        {
            ConfigBdVM config = new ConfigBdVM()
            {
                host = this.host,
                porta = this.porta,
                nome = this.nome,
                usuario = this.usuario,
                senha = this.senha,
                versao = this.versao
            };

            return config;
        }
    }
}
