namespace api.mstiADM.SDK.csharp.Entidade
{
    /// <summary>
    /// Essa classe foi feita para configurações do ambiente de cada API
    /// </summary>
    public abstract class DadosAmbiente
    {
        /// <summary>
        /// Define se a api está habilitada ou não
        /// </summary>
        public bool Ativo { get; protected set; }

        /// <summary>
        /// Define se a API executou o processo de implantação, ou seja, está preparada para atender um cliente
        /// </summary>
        public bool ImplantacaoExecutada { get; protected set; }


        /// <summary>
        /// Configurações relacionadas ao banco do cliente
        /// </summary>
        public ConfigBD configBD { get; protected set; }
    }
}
