using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM

{
    [MessagePackObject]
    public class HubVMPack : DadosAmbienteVMPack
    {
        [Key(3)]
        public int LimiteCanais { get; set; }


        public HubVM ToHubVM()
        {
            return new HubVM()
            {
                Ativo = this.Ativo,
                ImplantacaoExecutada = ImplantacaoExecutada,
                LimiteCanais = this.LimiteCanais,
                configBD = this?.configBD.ToConfigBdVM()
            };
        }
    }
}
