Module Modulo_de_enderecos_de_arquivos


    'Variáveis ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    Public V_EXTENCAO_DE_ARQUIVOS As String = ".dll" 'Informa a extenção do arquivo

    Public V_PASTA_DE_CONFIGURACAO As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\" & v_nome_generico_de_pasta_de_configuracoes_gerais 'Informa a pasta de configurações gerais

    Public V_ARQ_CONFIG_PAGINA_INICIAL As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_0" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_PAGINA_INICIAL_EM_BRANCO_OU_HOME As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_0_1" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_ALERTAR_ABRIR_ABAS_DEMAIS As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_1" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_2" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_3" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_POP_UP_ACAO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_4" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_ARMAZENAR_HISTORICO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_5" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_PASTA_DE_DOWNLOADS As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_6" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_PERGUNTAR_ONDE_SALVAR_DOWNLOADS As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_7" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_TELA_DE_BOAS_VINDAS As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_8" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_USAR_RECURSO_DE_VOZ As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_9" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_VOZ_SELECIONADA As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_10" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_PROTEGER_CONTRA_CODIGOS_MALICIOSOS As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_11" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_TIPO_DE_TEMA As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_12" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_TRANSPARENCIA As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_13" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_COMPUTADOR_LENTO_SOLUCAO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_14" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_MODO_GEEK_ATIVADO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_15" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_NOME_DE_USUARIO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_16" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_ESQUEMA_DE_ABA As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_17" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_BARRA_DE_NAVEGACAO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_18" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_BARRA_DE_STATUS As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_19" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_AVISE_ERRO_ABRIR_SITE As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_20" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_INFORME_VOZ_ABRIR_SITE As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_21" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_ABRIR_LINK_EM_SEGUNDO_PLANO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_24" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_RESTAURAR_SESSAO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_25" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_LIMPAR_DADOS_NAVEGACAO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_26" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_TITULO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_27" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_URL As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_28" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_DATA As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_29" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_NOMES_IMAGENS_SALVAS As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_30" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_LIMPAR_DADOS_NAVEGACAO_HISTORICO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_31" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_HISTORICO_DE_IMAGENS_FAVICONS_KEYS As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_32" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_RECURSO_TESTE_DE_PAGINA_ONLINE As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_33" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_RECURSO_DE_SONS_DE_SISTEMA As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_34" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_ENDERECO_IMAGEM_PAINEL_DE_CONTROLE As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_35" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_SESSAO_URLS_SALVAS As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_36" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_SESSAO_ENCERROU_CORRETAMENTE As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_37" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_SESSAO_URLS_SALVAS_POP_UPS As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_38" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_SESSAO_ENCERROU_CORRETAMENTE_POP_UP As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_39" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_USAR_VOZ_EM_CAIXAS_DE_DIALOGO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_40" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_DESABILITA_EFEITOS_AVANCADOS_DE_NAVEGACAO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_41" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_CONFIG_USAR_RECURSO_AUTO_COMPLETAR_BARRA_DE_END As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_42" & V_EXTENCAO_DE_ARQUIVOS 'Arquivo de configuração

    Public V_ARQ_PAGINA_DE_RECURSO_AUTO_COMPLETAR_HISTORICO As String = V_PASTA_DE_CONFIGURACAO & "\" & "arq_43" & v_extencao_1 'Arquivo de configuração





















    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


End Module
