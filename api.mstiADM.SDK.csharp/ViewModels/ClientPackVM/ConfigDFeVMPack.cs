using MessagePack;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM
{
    [MessagePackObject]
    public class ConfigDFeVMPack
    {
        /// <summary> 
        /// <para>Série atual</para> 
        /// </summary> 
        [Key(0)]
        public string SerieAtual { get; set; }

        /// <summary> 
        /// <para>Próximo número a ser enviado</para> 
        /// </summary> 
        [Key(1)]
        public int ProximoLote { get; set; }

        /// <summary> 
        /// <para>Próximo lote a ser enviado</para> 
        /// </summary> 
        [Key(2)]
        public int ProximoNumero { get; set; }

        public ConfigDFeVM ToConfigDFeVM()
        {
            return new ConfigDFeVM()
            {
                SerieAtual = this.SerieAtual,
                ProximoLote = this.ProximoLote,
                ProximoNumero = this.ProximoNumero
            };
        }
    }
}
