namespace api.mstiADM.SDK.csharp.Resources
{
    public static class Resource
    {
        #region Mensagens genéricas dos serviços da api.msti.Shared e framework.mstiCSharp

        public const string UrlCheckoutNaoConfigurada = "Necessário configurar a url do checkout ('EnderecoAmiPayCheckout') no arquivo 'appsettings.json'";

        public const string SomenteAdministradorPodeExecutarEssaAcao = "Somente o usuário ADMIN pode executar essa ação";

        public const string AlteracaoNaoPermitidaParaEsseUsuario = "O usuário não pertence a essa Revenda, modificação não permitida";

        public const string AcaoNaoPermitidaParaEsseUsuario = "Ação não permitida à esse usuário";

        public const string SomenteNivelTipoClientePodeSerAdicionado = "Somente NivelTipo=CLIENTE pode ser adicionado por esse usuário";

        #endregion

        #region Mensagens do sistema de controle da api.msti

        public const string ApiMstiAdmInacessivel = @"Não foi possível obter resposta da 'api.msti.ADM', verifique se a API está em execução no endereço: ";

        #endregion

        #region  MENSAGENS ENTIDADE Cliente

        //Inclusão/Atualização
        public const string ClienteCodigoInvalido = "Codigo do cliente inválido";
        public const string ClienteTokenInvalido = "Token inválido";        
        public const string ClienteTokenRevogado = "Token revogado";
        public const string ClienteAdicionarSucesso = "Cliente adicionado com sucesso";
        public const string ClienteLogotipoInvalido = "Logotipo inválido";
        public const string ClienteCodigoJaUtilizado = "Codigo do cliente já está cadastrado";
        public const string ClienteEmailJaUtilizado = "Email já utilizado";
        public const string ClienteNaoLocalizado = "Não existe um cliente cadastrado, com o código especificado";
        public const string ClienteCodigoNaoPreenchido = "Para a operação de atualização, é obrigatório informar o código do cliente";
        public const string ClienteAdicionarFalha = "Erro ao adicionar o cliente";
        public const string ClienteLocalizarFalha = "Cliente não localizado";
        public const string RevendaSemClientes = "Nao foram encontrados clientes para a revenda especificada";
        public const string ClienteNomeNaoPreenchido = "O nome do cliente deve ser preenchido";
        public const string SenhaCertificadoNaoPreenchida = "A senha do certificado deve ser preenchida";
        public const string FalhaMigrationHub = "Houve um erro na criação do banco de dados do cliente no HUB";
        public const string FalhaMigrationEfd = "Houve um erro na criação do banco de dados do cliente no EFD";
        public const string CodigoRevendaNaoPreenchido = "O Codigo da revenda deve ser preenchido";
        public const string CodigoRevendaInvalido = "O Codigo da revenda deve ser numerico";

        //Atualização
        public const string ClienteAtualizarSucesso = "Cliente atualizado com sucesso";
        public const string ClienteAtualizarFalha = "Erro ao atualizar o cliente";
        public const string ClienteNaoPossuiModuloDFEHabilitado = "Cliente não possui módulo DFE habilitado.";
        public const string ClienteNaoPossuiModuloTAXHabilitado = "Cliente não possui módulo TAX habilitado.";
        public const string ClienteNaoPossuiModuloHUBHabilitado = "Cliente não possui módulo HUB habilitado.";
        public const string ClienteNaoPossuiModuloEFDHabilitado = "Cliente não possui módulo EFD habilitado.";
        public const string ClienteNaoPossuiModuloPAYHabilitado = "Cliente não possui módulo PAY habilitado.";
       
        //Implantacao
        public const string ClienteImplantadoComSucesso = "Cliente implantado com sucesso";
        public const string ClienteImplantadoFalha = "Erro ao implantar cliente";

        //Exclusão
        public const string ClienteExcluirSucesso = "Cliente excluido com sucesso";
        public const string ClienteExcluirFalha = "Erro ao excluir o cliente";
        public const string ClienteExcluirFalhaUsuarioAssociado = "Erro ao excluir o cliente revenda, existe um usuário associado a esse cliente";

        #endregion

        #region  MENSAGENS ENTIDADE Usuario

        //Inclusão/Atualização
        public const string UsuarioCodigoInvalido = "Codigo do usuário inválido";
        public const string UsuarioAdicionarSucesso = "Usuario adicionado com sucesso";
        public const string UsuarioCodigoJaUtilizado = "Codigo do usuário já está cadastrado";
        public const string UsuarioEmailJaUtilizado = "Email já está em uso";
        public const string UsuarioNaoLocalizado = "Não existe um usuário cadastrado, com o código especificado";
        public const string UsuarioCodigoNaoPreenchido = "Para a operação de atualização, é obrigatório informar o código do usuário";
        public const string UsuarioAdicionarFalha = "Erro ao adicionar o usuário";
        public const string UsuarioLocalizarFalha = "Usuario não localizado";
        public const string RevendaSemUsuarios = "Nao foram encontrados usuários para a revenda especificada";
        public const string UsuarioNomeNaoPreenchido = "O nome do usuário deve ser preenchido";
        public const string UsuarioEmailNaoPreenchido = "O email do usuário deve ser preenchido";
        public const string UsuarioSenhaNaoPreenchido = "A senha do usuário deve ser preenchida";
        public const string UsuarioAcessoNaoPreenchido = "Os acessos do usuário deve ser preenchidos";
        public const string UsuarioRevendaIdInvalidoParaNivelTipo = "O campo NivelIDCollection deve ter o Id de uma revenda válida para o nivelTipo REVENDA";
        public const string UsuarioClienteIdInvalidoParaNivelTipo = "O campo NivelIDCollection deve ter o Id de um cliente válido para o nivelTipo CLIENTE";
        public const string UsuarioNivelTipoNaoInformado = "O campo ENivelTipo do usuário deve ser preenchido";
        public const string SomenteUsuarioRevendaOuADMPodemAdicionarUsuariosDesseNivel = "Usuário do NivelTipo=CLIENTE não tem permissão para adicionar esse NivelTipo";
        public const string EsseUsuarioPodeSomenteAlterarSeuUsuario = "Não é permitido alterar o usuário diferente do usuário logado";

        //Registro ADMINISTRADOR
        public const string UsuarioAdministradoroNaoPodeTerNivelTipoAlterado = "O campo NivelTipo do usuário ADMINISTRADOR não pode ser alterado";
        public const string UsuarioAdministradoroNaoPodeTerAcessoAlterado = "O campo Acessos do usuário ADMINISTRADOR não pode ser alterado";
        public const string UsuarioAdministradoroNaoPodeTerIDCollectionPreenchido = "O campo IDCollection do usuário ADMINISTRADOR não pode ser preenchido";


        //Atualização
        public const string UsuarioAtualizarSucesso = "Usuario atualizado com sucesso";
        public const string UsuarioAtualizarFalha = "Erro ao atualizar o usuário";
        public const string UsuarioSenhaAtualizacaoSucesso = "Senha atualizada com sucesso";


        //Exclusão
        public const string UsuarioExcluirSucesso = "Usuario excluido com sucesso";
        public const string UsuarioExcluirFalha = "Erro ao excluir o usuário";
        public const string UsuarioAdminNivelExcluirFalha = "não é permitido excluir o usuário ADMINISTRADOR";

        #endregion

        #region  MENSAGENS ENTIDADE Parametro

        //Inclusão/Atualização
        public const string ParametroCodigoInvalido = "Codigo do Parametro inválido";
        public const string ParametroAdicionarSucesso = "Parametro adicionado com sucesso";
        public const string ParametroCodigoJaUtilizado = "Codigo do Parametro já está cadastrado";
        public const string ParametroNaoLocalizado = "Não existe um Parametro cadastrado, com o código especificado";
        public const string ParametroCodigoNaoPreenchido = "Para a operação de atualização, é obrigatório informar o código do Parametro";
        public const string ParametroAdicionarFalha = "Erro ao adicionar o Parametro";
        public const string ParametroLocalizarFalha = "Parametro não localizado";


        //Atualização
        public const string ParametroAtualizarSucesso = "Parametro atualizado com sucesso";
        public const string ParametroAtualizarFalha = "Erro ao atualizar o Parametro";

        //Exclusão
        public const string ParametroExcluirSucesso = "Parametro excluido com sucesso";
        public const string ParametroExcluirFalha = "Erro ao excluir o Parametro";


        #endregion

        #region MENSAGENS ENTIDADES Tabelas Auxiliares

        public const string TABPDCodigoInvalido = "Código inválido";
        public const string TABPDLocalizarFalha = "Não existe registro cadastrado com o código especificado";
        public const string TABPDExcluirSucesso = "Registro excluido com sucesso";


        public const string MeioDePagamentoCodigoInvalido = "Codigo Meio de Pagamento inválido";
        public const string MeioDePagamentoLocalizarFalha = "Não existe Meio de Pagamento cadastrado com o código especificado";
        public const string MeioDePagamentoExcluirSucesso = "Meio de Pagamento excluido com sucesso";
        public const string MeioDePagamentoExcluirFalha = "Erro ao excluir o Meio de Pagamento";
        public const string MeioDePagamentoAdicionarSucesso = "Meio de Pagamento adicionado com sucesso";
        public const string MeioDePagamentoAdicionarFalha = "Erro ao adicionar o Meio de Pagamento";
        public const string MeioDePagamentoAdicionarFalhaSysVer = "Erro ao adicionar o Meio de Pagamento. É necessário cadastrar os Meio de Pagamento padrões no banco de dados.";
        public const string MeioDePagamentoAtualizarSucesso = "Meio de Pagamento atualizado com sucesso";
        public const string MeioDePagamentoAtualizarFalha = "Erro ao atualizar o Meio de Pagamento";
        public const string MeioDePagamentoCodigoJaUtilizado = "Codigo Meio de Pagamento já está cadastrado";


        public const string IPI_EnquadramentoLegalCodigoInvalido = "Codigo IPI_EnquadramentoLegal inválido";
        public const string IPI_EnquadramentoLegalLocalizarFalha = "Não existe IPI_EnquadramentoLegal cadastrado com o código especificado";
        public const string IPI_EnquadramentoLegalExcluirSucesso = "IPI_EnquadramentoLegal excluido com sucesso";
        public const string IPI_EnquadramentoLegalExcluirFalha = "Erro ao excluir o IPI_EnquadramentoLegal";
        public const string IPI_EnquadramentoLegalAdicionarSucesso = "IPI_EnquadramentoLegal adicionado com sucesso";
        public const string IPI_EnquadramentoLegalAdicionarFalha = "Erro ao adicionar o IPI_EnquadramentoLegal";
        public const string IPI_EnquadramentoLegalAdicionarFalhaSysVer = "Erro ao adicionar o IPI_EnquadramentoLegal. É necessário cadastrar os IPI_EnquadramentoLegals padrões no banco de dados.";
        public const string IPI_EnquadramentoLegalAtualizarSucesso = "IPI_EnquadramentoLegal atualizado com sucesso";
        public const string IPI_EnquadramentoLegalAtualizarFalha = "Erro ao atualizar o IPI_EnquadramentoLegal";
        public const string IPI_EnquadramentoLegalCodigoJaUtilizado = "Codigo IPI_EnquadramentoLegal já está cadastrado";

        public const string ICMS_ModalidadeBaseCalculoSTCodigoInvalido = "Codigo ICMS_ModalidadeBaseCalculoST inválido";
        public const string ICMS_ModalidadeBaseCalculoSTLocalizarFalha = "Não existe ICMS_ModalidadeBaseCalculoST cadastrado com o código especificado";
        public const string ICMS_ModalidadeBaseCalculoSTExcluirSucesso = "ICMS_ModalidadeBaseCalculoST excluido com sucesso";
        public const string ICMS_ModalidadeBaseCalculoSTExcluirFalha = "Erro ao excluir o ICMS_ModalidadeBaseCalculoST";
        public const string ICMS_ModalidadeBaseCalculoSTAdicionarSucesso = "ICMS_ModalidadeBaseCalculoST adicionado com sucesso";
        public const string ICMS_ModalidadeBaseCalculoSTAdicionarFalha = "Erro ao adicionar o ICMS_ModalidadeBaseCalculoST";
        public const string ICMS_ModalidadeBaseCalculoSTAdicionarFalhaSysVer = "Erro ao adicionar o ICMS_ModalidadeBaseCalculoST. É necessário cadastrar os ICMS_ModalidadeBaseCalculoSTs padrões no banco de dados.";
        public const string ICMS_ModalidadeBaseCalculoSTAtualizarSucesso = "ICMS_ModalidadeBaseCalculoST atualizado com sucesso";
        public const string ICMS_ModalidadeBaseCalculoSTAtualizarFalha = "Erro ao atualizar o ICMS_ModalidadeBaseCalculoST";
        public const string ICMS_ModalidadeBaseCalculoSTCodigoJaUtilizado = "Codigo ICMS_ModalidadeBaseCalculoST já está cadastrado";

        public const string ICMS_ModalidadeBaseCalculoCodigoInvalido = "Codigo ICMS_ModalidadeBaseCalculo inválido";
        public const string ICMS_ModalidadeBaseCalculoLocalizarFalha = "Não existe ICMS_ModalidadeBaseCalculo cadastrado com o código especificado";
        public const string ICMS_ModalidadeBaseCalculoExcluirSucesso = "ICMS_ModalidadeBaseCalculo excluido com sucesso";
        public const string ICMS_ModalidadeBaseCalculoExcluirFalha = "Erro ao excluir o ICMS_ModalidadeBaseCalculo";
        public const string ICMS_ModalidadeBaseCalculoAdicionarSucesso = "ICMS_ModalidadeBaseCalculo adicionado com sucesso";
        public const string ICMS_ModalidadeBaseCalculoAdicionarFalha = "Erro ao adicionar o ICMS_ModalidadeBaseCalculo";
        public const string ICMS_ModalidadeBaseCalculoAdicionarFalhaSysVer = "Erro ao adicionar o ICMS_ModalidadeBaseCalculo. É necessário cadastrar os ICMS_ModalidadeBaseCalculos padrões no banco de dados.";
        public const string ICMS_ModalidadeBaseCalculoAtualizarSucesso = "ICMS_ModalidadeBaseCalculo atualizado com sucesso";
        public const string ICMS_ModalidadeBaseCalculoAtualizarFalha = "Erro ao atualizar o ICMS_ModalidadeBaseCalculo";
        public const string ICMS_ModalidadeBaseCalculoCodigoJaUtilizado = "Codigo ICMS_ModalidadeBaseCalculo já está cadastrado";

        public const string ICMS_MotivosDesoneracaoCodigoInvalido = "Codigo ICMS_MotivosDesoneracao inválido";
        public const string ICMS_MotivosDesoneracaoLocalizarFalha = "Não existe ICMS_MotivosDesoneracao cadastrado com o código especificado";
        public const string ICMS_MotivosDesoneracaoExcluirSucesso = "ICMS_MotivosDesoneracao excluido com sucesso";
        public const string ICMS_MotivosDesoneracaoExcluirFalha = "Erro ao excluir o ICMS_MotivosDesoneracao";
        public const string ICMS_MotivosDesoneracaoAdicionarSucesso = "ICMS_MotivosDesoneracao adicionado com sucesso";
        public const string ICMS_MotivosDesoneracaoAdicionarFalha = "Erro ao adicionar o ICMS_MotivosDesoneracao";
        public const string ICMS_MotivosDesoneracaoAdicionarFalhaSysVer = "Erro ao adicionar o ICMS_MotivosDesoneracao. É necessário cadastrar os ICMS_MotivosDesoneracaos padrões no banco de dados.";
        public const string ICMS_MotivosDesoneracaoAtualizarSucesso = "ICMS_MotivosDesoneracao atualizado com sucesso";
        public const string ICMS_MotivosDesoneracaoAtualizarFalha = "Erro ao atualizar o ICMS_MotivosDesoneracao";
        public const string ICMS_MotivosDesoneracaoCodigoJaUtilizado = "Codigo ICMS_MotivosDesoneracao já está cadastrado";

        public const string COFINS_CSTCodigoInvalido = "Codigo COFINS_CST inválido";
        public const string COFINS_CSTLocalizarFalha = "Não existe COFINS_CST cadastrado com o código especificado";
        public const string COFINS_CSTExcluirSucesso = "COFINS_CST excluido com sucesso";
        public const string COFINS_CSTExcluirFalha = "Erro ao excluir o COFINS_CST";
        public const string COFINS_CSTAdicionarSucesso = "COFINS_CST adicionado com sucesso";
        public const string COFINS_CSTAdicionarFalha = "Erro ao adicionar o COFINS_CST";
        public const string COFINS_CSTAdicionarFalhaSysVer = "Erro ao adicionar o COFINS_CST. É necessário cadastrar os COFINS_CSTs padrões no banco de dados.";
        public const string COFINS_CSTAtualizarSucesso = "COFINS_CST atualizado com sucesso";
        public const string COFINS_CSTAtualizarFalha = "Erro ao atualizar o COFINS_CST";
        public const string COFINS_CSTCodigoJaUtilizado = "Codigo COFINS_CST já está cadastrado";

        public const string PIS_CSTCodigoInvalido = "Codigo PIS_CST inválido";
        public const string PIS_CSTLocalizarFalha = "Não existe PIS_CST cadastrado com o código especificado";
        public const string PIS_CSTExcluirSucesso = "PIS_CST excluido com sucesso";
        public const string PIS_CSTExcluirFalha = "Erro ao excluir o PIS_CST";
        public const string PIS_CSTAdicionarSucesso = "PIS_CST adicionado com sucesso";
        public const string PIS_CSTAdicionarFalha = "Erro ao adicionar o PIS_CST";
        public const string PIS_CSTAdicionarFalhaSysVer = "Erro ao adicionar o PIS_CST. É necessário cadastrar os PIS_CSTs padrões no banco de dados.";
        public const string PIS_CSTAtualizarSucesso = "PIS_CST atualizado com sucesso";
        public const string PIS_CSTAtualizarFalha = "Erro ao atualizar o PIS_CST";
        public const string PIS_CSTCodigoJaUtilizado = "Codigo PIS_CST já está cadastrado";

        public const string IPI_CSTCodigoInvalido = "Codigo IPI_CST inválido";
        public const string IPI_CSTLocalizarFalha = "Não existe IPI_CST cadastrado com o código especificado";
        public const string IPI_CSTExcluirSucesso = "IPI_CST excluido com sucesso";
        public const string IPI_CSTExcluirFalha = "Erro ao excluir o IPI_CST";
        public const string IPI_CSTAdicionarSucesso = "IPI_CST adicionado com sucesso";
        public const string IPI_CSTAdicionarFalha = "Erro ao adicionar o IPI_CST";
        public const string IPI_CSTAdicionarFalhaSysVer = "Erro ao adicionar o IPI_CST. É necessário cadastrar os IPI_CSTs padrões no banco de dados.";
        public const string IPI_CSTAtualizarSucesso = "IPI_CST atualizado com sucesso";
        public const string IPI_CSTAtualizarFalha = "Erro ao atualizar o IPI_CST";
        public const string IPI_CSTCodigoJaUtilizado = "Codigo IPI_CST já está cadastrado";

        public const string ICMS_CSOSNCodigoInvalido = "Codigo ICMS_CSOSN inválido";
        public const string ICMS_CSOSNLocalizarFalha = "Não existe ICMS_CSOSN cadastrado com o código especificado";
        public const string ICMS_CSOSNExcluirSucesso = "ICMS_CSOSN excluido com sucesso";
        public const string ICMS_CSOSNExcluirFalha = "Erro ao excluir o ICMS_CSOSN";
        public const string ICMS_CSOSNAdicionarSucesso = "ICMS_CSOSN adicionado com sucesso";
        public const string ICMS_CSOSNAdicionarFalha = "Erro ao adicionar o ICMS_CSOSN";
        public const string ICMS_CSOSNAdicionarFalhaSysVer = "Erro ao adicionar o ICMS_CSOSN. É necessário cadastrar os ICMS_CSOSNs padrões no banco de dados.";
        public const string ICMS_CSOSNAtualizarSucesso = "ICMS_CSOSN atualizado com sucesso";
        public const string ICMS_CSOSNAtualizarFalha = "Erro ao atualizar o ICMS_CSOSN";
        public const string ICMS_CSOSNCodigoJaUtilizado = "Codigo ICMS_CSOSN já está cadastrado";

        public const string ICMS_CSTCodigoInvalido = "Codigo ICMS_CST inválido";
        public const string ICMS_CSTLocalizarFalha = "Não existe ICMS_CST cadastrado com o código especificado";
        public const string ICMS_CSTExcluirSucesso = "ICMS_CST excluido com sucesso";
        public const string ICMS_CSTExcluirFalha = "Erro ao excluir o ICMS_CST";
        public const string ICMS_CSTAdicionarSucesso = "ICMS_CST adicionado com sucesso";
        public const string ICMS_CSTAdicionarFalha = "Erro ao adicionar o ICMS_CST";
        public const string ICMS_CSTAdicionarFalhaSysVer = "Erro ao adicionar o ICMS_CST. É necessário cadastrar os ICMS_CSTs padrões no banco de dados.";
        public const string ICMS_CSTAtualizarSucesso = "ICMS_CST atualizado com sucesso";
        public const string ICMS_CSTAtualizarFalha = "Erro ao atualizar o ICMS_CST";
        public const string ICMS_CSTCodigoJaUtilizado = "Codigo ICMS_CST já está cadastrado";

        public const string CFOPCodigoInvalido = "Codigo CFOP inválido";
        public const string CFOPLocalizarFalha = "Não existe CFOP cadastrado com o código especificado";
        public const string CFOPExcluirSucesso = "CFOP excluido com sucesso";
        public const string CFOPExcluirFalha = "Erro ao excluir o CFOP";
        public const string CFOPAdicionarSucesso = "CFOP adicionado com sucesso";
        public const string CFOPAdicionarFalha = "Erro ao adicionar o CFOP";
        public const string CFOPAdicionarFalhaSysVer = "Erro ao adicionar o CFOP. É necessário cadastrar os CFOPs padrões no banco de dados.";
        public const string CFOPAtualizarSucesso = "CFOP atualizado com sucesso";
        public const string CFOPAtualizarFalha = "Erro ao atualizar o CFOP";
        public const string CFOPCodigoJaUtilizado = "Codigo CFOP já está cadastrado";

        public const string ANPCodigoInvalido = "Codigo ANP inválido";
        public const string ANPLocalizarFalha = "Não existe ANP cadastrado com o código especificado";
        public const string ANPExcluirSucesso = "ANP excluido com sucesso";
        public const string ANPExcluirFalha = "Erro ao excluir o ANP";
        public const string ANPAdicionarSucesso = "ANP adicionado com sucesso";
        public const string ANPAdicionarFalha = "Erro ao adicionar o ANP";
        public const string ANPAdicionarFalhaSysVer = "Erro ao adicionar o ANP. É necessário cadastrar os ANPs padrões no banco de dados.";
        public const string ANPAtualizarSucesso = "ANP atualizado com sucesso";
        public const string ANPAtualizarFalha = "Erro ao atualizar o ANP";
        public const string ANPCodigoJaUtilizado = "Codigo ANP já está cadastrado";

        public const string ModalidadeFreteCodigoInvalido = "Codigo da Modalidade Frete inválido";
        public const string ModalidadeFreteLocalizarFalha = "Não existe uma Modalidade Frete cadastrado com o código especificado";
        public const string ModalidadeFreteExcluirSucesso = "Modalidade Frete excluida com sucesso";
        public const string ModalidadeFreteExcluirFalha = "Erro ao excluir a Modalidade Frete";
        public const string ModalidadeFreteAdicionarSucesso = "Modalidade Frete adicionada com sucesso";
        public const string ModalidadeFreteAdicionarFalha = "Erro ao adicionar a Modalidade Frete";
        public const string ModalidadeFreteAdicionarFalhaSysVer = "Erro ao adicionar a Modalidade Frete. É necessário cadastrar as modalidades frete padrões no banco de dados.";
        public const string ModalidadeFreteAtualizarSucesso = "Modalidade Frete atualizada com sucesso";
        public const string ModalidadeFreteAtualizarFalha = "Erro ao atualizar a Modalidade Frete";
        public const string ModalidadeFreteCodigoJaUtilizado = "Codigo da Modalidade Frete já está cadastrada";

        public const string IndicadorPresencaCodigoInvalido = "Codigo do Indicador Presenca inválido";
        public const string IndicadorPresencaLocalizarFalha = "Não existe um Indicador Presenca cadastrado com o código especificado";
        public const string IndicadorPresencaExcluirSucesso = "Indicador Presenca excluido com sucesso";
        public const string IndicadorPresencaExcluirFalha = "Erro ao excluir o Indicador Presenca";
        public const string IndicadorPresencaAdicionarSucesso = "Indicador Presenca adicionado com sucesso";
        public const string IndicadorPresencaAdicionarFalha = "Erro ao adicionar o Indicador Presenca";
        public const string IndicadorPresencaAdicionarFalhaSysVer = "Erro ao adicionar o Indicador Presenca. É necessário cadastrar os indicadores presença padrões no banco de dados.";
        public const string IndicadorPresencaAtualizarSucesso = "Indicador Presenca atualizado com sucesso";
        public const string IndicadorPresencaAtualizarFalha = "Erro ao atualizar o Indicador Presenca";
        public const string IndicadorPresencaCodigoJaUtilizado = "Codigo do Indicador Presenca já está cadastrado";

        public const string FinalidadeEmissaoCodigoInvalido = "Codigo da Finalidade Emissao inválido";
        public const string FinalidadeEmissaoLocalizarFalha = "Não existe uma Finalidade Emissao cadastrada com o código especificado";
        public const string FinalidadeEmissaoExcluirSucesso = "Finalidade Emissao excluida com sucesso";
        public const string FinalidadeEmissaoExcluirFalha = "Erro ao excluir a Finalidade Emissao";
        public const string FinalidadeEmissaoAdicionarSucesso = "Finalidade Emissao adicionada com sucesso";
        public const string FinalidadeEmissaoAdicionarFalha = "Erro ao adicionar a Finalidade Emissao";
        public const string FinalidadeEmissaoAdicionarFalhaSysVer = "Erro ao adicionar a Finalidade Emissao. É necessário cadastrar as finalidades emissoes padrões no banco de dados.";
        public const string FinalidadeEmissaoAtualizarSucesso = "Finalidade Emissao atualizada com sucesso";
        public const string FinalidadeEmissaoAtualizarFalha = "Erro ao atualizar a Finalidade Emissao";
        public const string FinalidadeEmissaoCodigoJaUtilizado = "Codigo da Finalidade Emissao já está cadastrada";

        public const string CESTCodigoInvalido = "Codigo do cest inválido";
        public const string CESTLocalizarFalha = "Não existe um cest cadastrado com o código especificado";
        public const string CESTExcluirSucesso = "CEST excluido com sucesso";
        public const string CESTExcluirFalha = "Erro ao excluir o cest";
        public const string CESTAdicionarSucesso = "CEST adicionada com sucesso";
        public const string CESTAdicionarFalha = "Erro ao adicionar a cest";
        public const string CESTAdicionarFalhaSysVer = "Erro ao adicionar o CEST. É necessário cadastrar os CESTs padrão no banco de dados.";
        public const string CESTAtualizarSucesso = "CEST atualizado com sucesso";
        public const string CESTAtualizarFalha = "Erro ao atualizar o CEST";
        public const string CESTCodigoJaUtilizado = "Codigo do CEST já está cadastrado";

        public const string NCMCodigoInvalido = "Codigo do ncm inválido";
        public const string NCMLocalizarFalha = "Não existe um ncm cadastrado com o código especificado";
        public const string NCMExcluirSucesso = "NCM excluido com sucesso";
        public const string NCMExcluirFalha = "Erro ao excluir o ncm";
        public const string NCMAdicionarSucesso = "NCM adicionada com sucesso";
        public const string NCMAdicionarFalha = "Erro ao adicionar a ncm";
        public const string NCMAdicionarFalhaSysVer = "Erro ao adicionar o NCM. É necessário cadastrar os NCMs padrão no banco de dados.";
        public const string NCMAtualizarSucesso = "NCM atualizado com sucesso";
        public const string NCMAtualizarFalha = "Erro ao atualizar o NCM";
        public const string NCMCodigoJaUtilizado = "Codigo do NCM já está cadastrado";

        public const string OrigemItemCodigoInvalido = "Codigo origemItem inválido";
        public const string OrigemItemLocalizarFalha = "Não existe um origemItem cadastrado com o código especificado";
        public const string OrigemItemExcluirSucesso = "OrigemItem excluido com sucesso";
        public const string OrigemItemExcluirFalha = "Erro ao excluir o origemItem";
        public const string OrigemItemAdicionarSucesso = "OrigemItem adicionado com sucesso";
        public const string OrigemItemAdicionarFalha = "Erro ao adicionar origemItem";
        public const string OrigemItemAdicionarFalhaSysVer = "Erro ao adicionar o OrigemItem. É necessário cadastrar os OrigemItems padrão no banco de dados.";
        public const string OrigemItemAtualizarSucesso = "OrigemItem atualizado com sucesso";
        public const string OrigemItemAtualizarFalha = "Erro ao atualizar o OrigemItem";
        public const string OrigemItemCodigoJaUtilizado = "Codigo do OrigemItem já está cadastrado";

        public const string TipoItemCodigoInvalido = "Codigo tipoItem inválido";
        public const string TipoItemLocalizarFalha = "Não existe um tipoItem cadastrado com o código especificado";
        public const string TipoItemExcluirSucesso = "TipoItem excluido com sucesso";
        public const string TipoItemExcluirFalha = "Erro ao excluir o tipoItem";
        public const string TipoItemAdicionarSucesso = "TipoItem adicionado com sucesso";
        public const string TipoItemAdicionarFalha = "Erro ao adicionar tipoItem";
        public const string TipoItemAdicionarFalhaSysVer = "Erro ao adicionar o TipoItem. É necessário cadastrar os TipoItems padrão no banco de dados.";
        public const string TipoItemAtualizarSucesso = "TipoItem atualizado com sucesso";
        public const string TipoItemAtualizarFalha = "Erro ao atualizar o TipoItem";
        public const string TipoItemCodigoJaUtilizado = "Codigo do TipoItem já está cadastrado";

        public const string RegimeTributarioCodigoInvalido = "Codigo regimeTributario inválido";
        public const string RegimeTributarioLocalizarFalha = "Não existe um regimeTributario cadastrado com o código especificado";
        public const string RegimeTributarioExcluirSucesso = "RegimeTributario excluido com sucesso";
        public const string RegimeTributarioExcluirFalha = "Erro ao excluir o regimeTributario";
        public const string RegimeTributarioAdicionarSucesso = "RegimeTributario adicionado com sucesso";
        public const string RegimeTributarioAdicionarFalha = "Erro ao adicionar regimeTributario";
        public const string RegimeTributarioAdicionarFalhaSysVer = "Erro ao adicionar o RegimeTributario. É necessário cadastrar os RegimeTributarios padrão no banco de dados.";
        public const string RegimeTributarioAtualizarSucesso = "RegimeTributario atualizado com sucesso";
        public const string RegimeTributarioAtualizarFalha = "Erro ao atualizar o RegimeTributario";
        public const string RegimeTributarioCodigoJaUtilizado = "Codigo do RegimeTributario já está cadastrado";

        public const string CidadeCodigoInvalido = "Codigo da cidade inválido";
        public const string CidadeLocalizarFalha = "Não existe uma cidade cadastrada, com o código especificado";
        public const string CidadeExcluirSucesso = "Cidade excluida com sucesso";
        public const string CidadeExcluirFalha = "Erro ao excluir a cidade";
        public const string CidadeAdicionarSucesso = "Cidade adicionada com sucesso";
        public const string CidadeAdicionarFalha = "Erro ao adicionar a cidade";
        public const string CidadeAdicionarFalhaSysVer = "Erro ao adicionar a cidade, é necessário cadastrar as cidades padrão no banco de dados.";
        public const string CidadeAtualizarSucesso = "Cidade atualizada com sucesso";
        public const string CidadeAtualizarFalha = "Erro ao atualizar a cidade";
        public const string CidadeCodigoJaUtilizado = "Codigo da cidade já está cadastrado";

        public const string UFCodigoInvalido = "Codigo da uf inválido";
        public const string UFLocalizarFalha = "Não existe uma uf cadastrada, com o código especificado";
        public const string UFExcluirSucesso = "UF excluida com sucesso";
        public const string UFExcluirFalha = "Erro ao excluir a uf";
        public const string UFAdicionarSucesso = "UF adicionado com sucesso";
        public const string UFAdicionarFalha = "Erro ao adicionar a uf";
        public const string UFAdicionarFalhaSysVer = "Erro ao adicionar uf, é necessário cadastrar as ufs padrão no banco de dados.";
        public const string UFAtualizarSucesso = "UF atualizado com sucesso";
        public const string UFAtualizarFalha = "Erro ao atualizar a uf";
        public const string UFCodigoJaUtilizado = "Codigo da UF já está cadastrado";

        public const string PaisCodigoInvalido = "Codigo do país inválido";
        public const string PaisLocalizarFalha = "Não existe um país cadastrado, com o código especificado";

        public const string PaisExcluirSucesso = "País excluido com sucesso";
        public const string PaisExcluirFalha = "Erro ao excluir o país";
        public const string PaisAdicionarSucesso = "País adicionado com sucesso";
        public const string PaisAdicionarFalha = "Erro ao adicionar o país";
        public const string PaisAdicionarFalhaSysVer = "Erro ao adicionar país, é necessário cadastrar os paises padrão no banco de dados.";
        public const string PaisAtualizarSucesso = "País atualizado com sucesso";
        public const string PaisAtualizarFalha = "Erro ao atualizar o país";
        public const string PaisCodigoJaUtilizado = "Codigo do país já está cadastrado";

        public const string ISSQN_IndicadorOperacao_CodigoInvalido = "Codigo ISSQN_IndicadorOperacao inválido";
        public const string ISSQN_IndicadorOperacao_DescricaoInvalida = "Descrição ISSQN_IndicadorOperacao inválida";
        public const string ISSQN_IndicadorOperacao_TipoInvalido = "Tipo ISSQN_IndicadorOperacao inválido";
        public const string ISSQN_IndicadorOperacao_LocalInvalido = "Local ISSQN_IndicadorOperacao inválido";

        public const string ISSQN_IndicadorOperacao_LocalizarFalha = "Não existe ISSQNIndicadorOperacao cadastrado com o código especificado";
        public const string ISSQN_IndicadorOperacao_ExcluirSucesso = "ISSQNIndicadorOperacao excluido com sucesso";
        public const string ISSQN_IndicadorOperacao_ExcluirFalha = "Erro ao excluir o ISSQNIndicadorOperacao";
        public const string ISSQN_IndicadorOperacao_AdicionarSucesso = "ISSQNIndicadorOperacao adicionado com sucesso";
        public const string ISSQN_IndicadorOperacao_AdicionarFalha = "Erro ao adicionar o ISSQNIndicadorOperacao";
        public const string ISSQN_IndicadorOperacao_AdicionarFalhaSysVer = "Erro ao adicionar o ISSQNIndicadorOperacao. É necessário cadastrar os ISSQNIndicadorOperacao padrões no banco de dados.";
        public const string ISSQN_IndicadorOperacao_AtualizarSucesso = "ISSQNIndicadorOperacao atualizado com sucesso";
        public const string ISSQN_IndicadorOperacao_AtualizarFalha = "Erro ao atualizar o ISSQNIndicadorOperacao";
        public const string ISSQN_IndicadorOperacao_CodigoJaUtilizado = "Codigo ISSQNIndicadorOperacao já está cadastrado";
        public const string CodigoNaoPodeSerAlterado = "Código não pode ser alterado";

        #endregion

        #region  MENSAGENS ENTIDADE Log

        //Inclusão/Atualização
        public const string LogCodigoInvalido = "Codigo do Log inválido";
        public const string LogAdicionarSucesso = "Log adicionado com sucesso";
        public const string LogNaoLocalizado = "Não existe um Log cadastrado, com o código especificado";
        public const string LogCodigoNaoPreenchido = "Para a operação de atualização, é obrigatório informar o código do Log";
        public const string LogAdicionarFalha = "Erro ao adicionar o Log";
        public const string LogLocalizarFalha = "Log não localizado";


        //Exclusão
        public const string LogExcluirSucesso = "Log excluido com sucesso";
        public const string LogExcluirFalha = "Erro ao excluir o Log";


        #endregion

        #region  MENSAGENS ENTIDADE Token
        //Inclusão
        public const string ClienteTokenAdicionarSucesso = "Token adicionado com sucesso";
        public const string ClienteTokenAdicionarFalha = "Erro ao adicionar o token";
        public const string ClienteTokenAdicionarFalhaConfiguracao = "Necessário configurar o parâmetro 'Config:SenhaGerarTokens' no arquivo 'appsettings.json'";
        //Pesquisa
        public const string ClienteTokenLocalizarFalha = "Token não localizado";
        //Revogação
        public const string ClienteTokenRevogarSucesso = "Tokens ativos revogados com sucesso";
        public const string ClienteTokenRevogarFalha = "Erro ao revogar os tokens ativos";
        public const string ClienteTokenRevogarFalhaSemTokensAtivos = "Cliente não apresenta tokens ativos para serem revogados";
        #endregion

        #region  MENSAGENS ENTIDADE Certificado
        public const string ErroAoGerarCertificdoDigital = "Não foi possível gerar um certificado digital com os dados recebidos";
        public const string ClienteCertificadoAdicionarFalha = "Erro ao armazenar o certificado digital";
        public const string ClienteCertificadoAdicionarSucesso = "Certificado digital adicionado com sucesso";

        #endregion

        #region  MENSAGENS logotipo        
        public const string ClienteLogotipoAtualizarFalha = "Erro ao atualizar o logotipo";
        public const string ClienteLogotipoAtualizarSucesso = "Logotipo atualizado com sucesso";

        #endregion

        #region Mensagens da api.msti.ADM
        public const string FalhaAoRecuperarSenha = "Falha ao recuperar senha";
        public const string FalhaConfiguracao_api_msti_SenhaAdm_NaoConfigurada = "Necessário configurar o parâmetro 'Config:SenhaAdm' no arquivo 'appsettings.json'";
        public const string ErroAoConectarBD = "Erro ao conectar ao banco de dados: ";
        public const string IdInvalido = @"Deve ser informado um Id de 24 caracteres no padrão hexadecimal (^[a-fA-F0-9]+$)";
        public const string TokenNaoPreenchido = "Informe um token válido";
        public const string CpfCnpjNaoPreenchido = "Informe um CPF ou CNPJ válido";
        #endregion

        #region Mecanismo de Login

        public const string LoginFalha = "Usuário ou senha inválidos";
        public const string LoginSucesso = "Sucesso ao realizar login";

        public const string LoginRecuperacaoSenhaLinkEnviadoParaEmail = "Um link de redefinição de senha foi enviado para o email informado.";
        public const string LoginRecuperacaoSenhaEmailInvalido = "Email deve ser informado";

        #endregion

        #region  MENSAGENS Filtros das APIs
        public const string TokenAdmInvalido = "Token administrativo inválido.";
        public const string TokenOperacionalInvalido = "Token inválido, entre em contato com a sua revenda.";
        public const string TokenRevogado = "O token informado já foi revogado.";
        public const string TokenNaoEncontrado = "O token informado não foi localizado.";
        public const string FalhaNaValidacaoDoAmbiente = "Falha na validação do ambiente";

        public const string EmailOperacionalInvalido = "E-mail inválido. É obrigatório enviar um email válido no query param '?email=email_aqui'";
        public const string TokenWebhookInvalido = "Não foi encontrado o token na requisição WebHook. Não é possível localizar o cliente.";
        public const string CpfCnpjNaoEncontrado = "Não foi possível encontrar um cliente, baseado no CPF ou CNPJ informado.";
        #endregion

        #region Value objects
        public const string CNPJInvalido = "CNPJ Inválido.";
        public const string CPFInvalido = "CPF Inválido.";
        public const string IEInvalida = "Inscrição Estatual Inválida.";
        public const string CPFCNPJInvalido = "CPFCNPJ Inválido.";
        public const string EmailInvalido = "E-mail Inválido.";

        #endregion

        #region OpenTracing

        public const string ErroAoGerarVariaveisOpenTracing = "Não foi possível obter as configurações para as variáveis do OpenTracing ('JAEGER_AGENT_HOST' e 'JAEGER_AGENT_PORT') . Verifique o arquivo 'appsettings.json'";

        

        public static string CodigoTamanhoMaximoPermitido(int tamanhoMaximo)
        {
            if(tamanhoMaximo == 1)
                return $"Código deve ter no máximo {tamanhoMaximo} caracter";
            else
                return $"Código deve ter no máximo {tamanhoMaximo} caracteres";
        }
      
        #endregion
    }
}