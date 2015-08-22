Module Modulo_de_variaveis_gerais




    'Variáveis de configurações gerais de arquivos


    Public V_VAL_CONFIG_PAGINA_INICIAL As String = Nothing

    Public V_VAL_CONFIG_PAGINA_INICIAL_EM_BRANCO_OU_HOME As String = Nothing

    Public V_VAL_CONFIG_ALERTAR_ABRIR_ABAS_DEMAIS As String = Nothing

    Public V_VAL_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR As String = Nothing

    Public V_VAL_CONFIG_POP_UP_ACAO As String = Nothing

    Public V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS As String = Nothing

    Public V_VAL_CONFIG_ARMAZENAR_HISTORICO As String = Nothing

    Public V_VAL_CONFIG_PASTA_DE_DOWNLOADS As String = Nothing

    Public V_VAL_CONFIG_PERGUNTAR_ONDE_SALVAR_DOWNLOADS As String = Nothing

    Public V_VAL_CONFIG_TELA_DE_BOAS_VINDAS As String = Nothing

    Public V_VAL_CONFIG_USAR_RECURSO_DE_VOZ As String = Nothing

    Public V_VAL_CONFIG_VOZ_SELECIONADA As String = Nothing

    Public V_VAL_CONFIG_PROTEGER_CONTRA_CODIGOS_MALICIOSOS As String = Nothing

    Public V_VAL_CONFIG_TIPO_DE_TEMA As String = Nothing

    Public V_VAL_CONFIG_TRANSPARENCIA As String = Nothing

    Public V_VAL_CONFIG_COMPUTADOR_LENTO_SOLUCAO As String = Nothing

    Public V_VAL_CONFIG_MODO_GEEK_ATIVADO As String = Nothing

    Public V_VAL_CONFIG_NOME_DE_USUARIO As String = Nothing

    Public V_VAL_CONFIG_AVISE_ERRO_ABRIR_SITE As String = Nothing

    Public V_VAL_CONFIG_INFORME_VOZ_ABRIR_SITE As String = Nothing

    Public V_VAL_CONFIG_ABRIR_LINK_EM_SEGUNDO_PLANO As String = Nothing

    Public V_VAL_CONFIG_RESTAURAR_SESSAO As String = Nothing

    Public V_VAL_CONFIG_RECURSO_TESTE_DE_PAGINA_ONLINE As String = Nothing

    Public V_VAL_CONFIG_RECURSO_DE_SONS_DE_SISTEMA As String = Nothing

    Public V_VAL_CONFIG_USAR_VOZ_EM_CAIXAS_DE_DIALOGO As String = Nothing

    Public V_VAL_CONFIG_USAR_RECURSO_AUTO_COMPLETAR_BARRA_DE_END As String = Nothing

    Public V_VAL_ENDERECO_URL_RECEBIDO_VIA_COMANDO_EXTERNO As String = Command() 'Informa o endereço url vindo de um comando externo.















    'Variaveis que não dependem de arquivos

    Public V_VAL_VOZES_NO_SISTEMA As String = Nothing 'Vozes no sistema

    Public V_VAL_OPCAO_DE_PESQUISA_NA_WEB As Integer = 0 'Informa a opção de pesquisa na web

    Public V_PAGINA_EM_BRANCO_ABRIR As String = "about:blank" 'Página em branco

    Public V_QUANTIDADE_DE_ABAS_ABERTAS_ALERTAR_SOBRE_LENTIDAO As Integer = 15 'Quantidade de abas que podem causar lentidao no computador

    Public V_PASTA_DA_INSTALACAO_DO_PROGRAMA As String = CurDir() 'Pasta onde fica o programa

    Public V_PASTA_DE_FAVORITOS As String = V_PASTA_DE_CONFIGURACAO & "\" & v_nome_generico_de_pasta_de_favoritos 'Pasta de favorítos'Pasta 





























    'Atualizador de variáveis e alguns objetos que dependem de variáveis gerais

    Private Sub proc_atualize_objetos_que_dependem_de_variaveis_gerais() 'Atualiza objetos que dependem de variáveis gerais
        On Error Resume Next


        'Selecionando o tipo de ação para o problema -------------------------------------------------------------------

        Select Case V_VAL_CONFIG_COMPUTADOR_LENTO_SOLUCAO




            Case 1
                FRM_NAVEGACAO.TMR_SOLUCIONADOR_DE_PROBLEMAS.Enabled = True 'Desativa timer solucionador de problema
                V_PODE_CONTINUAR_EXECUTANDO_PROCEDIMENTOS_NORMAIS = True 'Informa que o processamento está normal




            Case 2
                FRM_NAVEGACAO.TMR_SOLUCIONADOR_DE_PROBLEMAS.Enabled = False 'Desativa timer solucionador de problema
                V_PODE_CONTINUAR_EXECUTANDO_PROCEDIMENTOS_NORMAIS = True 'Informa que o processamento está normal




            Case 3
                FRM_NAVEGACAO.TMR_SOLUCIONADOR_DE_PROBLEMAS.Enabled = True 'Ativa timer solucionador de problema
                V_PODE_CONTINUAR_EXECUTANDO_PROCEDIMENTOS_NORMAIS = True 'Informa que o processamento está normal




        End Select

        '---------------------------------------------------------------------------------------------------------------











































    End Sub

    Private Sub proc_atualizar_valor_de_nivel_de_transparencia() 'Atualiza o valor do nivel da transparencia
        On Error Resume Next


        'Obtendo a transparencia ---------------------------------------------------------------------------------------

        V_VAL_CONFIG_TRANSPARENCIA = func_ler_valor(V_ARQ_CONFIG_TRANSPARENCIA) 'Retorna o valor do arquivo lido

        '---------------------------------------------------------------------------------------------------------------




        'Não permite transparencia com valor muito baixo --------------------------------------------------------------------------------------

        If (V_VAL_CONFIG_TRANSPARENCIA < 0.4) Or (V_VAL_CONFIG_TRANSPARENCIA = Nothing) Or (V_VAL_CONFIG_TRANSPARENCIA = "") Then


            V_VAL_CONFIG_TRANSPARENCIA = 1 'Valor padrao


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis
        On Error Resume Next


        'Lendo valor de variáveis --------------------------------------------------------------------------------------------------------------------------------------------------------

        V_VAL_CONFIG_PAGINA_INICIAL = func_ler_valor(V_ARQ_CONFIG_PAGINA_INICIAL) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_PAGINA_INICIAL_EM_BRANCO_OU_HOME = func_ler_valor(V_ARQ_CONFIG_PAGINA_INICIAL_EM_BRANCO_OU_HOME) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_ALERTAR_ABRIR_ABAS_DEMAIS = func_ler_valor(V_ARQ_CONFIG_ALERTAR_ABRIR_ABAS_DEMAIS) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR = func_ler_valor(V_ARQ_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_POP_UP_ACAO = func_ler_valor(V_ARQ_CONFIG_POP_UP_ACAO) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_ARMAZENAR_HISTORICO = func_ler_valor(V_ARQ_CONFIG_ARMAZENAR_HISTORICO) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_PASTA_DE_DOWNLOADS = func_ler_valor(V_ARQ_CONFIG_PASTA_DE_DOWNLOADS) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_PERGUNTAR_ONDE_SALVAR_DOWNLOADS = func_ler_valor(V_ARQ_CONFIG_PERGUNTAR_ONDE_SALVAR_DOWNLOADS) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_TELA_DE_BOAS_VINDAS = func_ler_valor(V_ARQ_CONFIG_TELA_DE_BOAS_VINDAS) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_USAR_RECURSO_DE_VOZ = func_ler_valor(V_ARQ_CONFIG_USAR_RECURSO_DE_VOZ) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_VOZ_SELECIONADA = func_ler_valor(V_ARQ_CONFIG_VOZ_SELECIONADA) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_PROTEGER_CONTRA_CODIGOS_MALICIOSOS = func_ler_valor(V_ARQ_CONFIG_PROTEGER_CONTRA_CODIGOS_MALICIOSOS) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_TIPO_DE_TEMA = func_ler_valor(V_ARQ_CONFIG_TIPO_DE_TEMA) 'Retorna o valor do arquivo lido

        proc_atualizar_valor_de_nivel_de_transparencia() 'Atualiza o valor do nivel da transparencia

        V_VAL_CONFIG_COMPUTADOR_LENTO_SOLUCAO = func_ler_valor(V_ARQ_CONFIG_COMPUTADOR_LENTO_SOLUCAO) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_MODO_GEEK_ATIVADO = func_ler_valor(V_ARQ_CONFIG_MODO_GEEK_ATIVADO) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_NOME_DE_USUARIO = func_ler_valor(V_ARQ_CONFIG_NOME_DE_USUARIO) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_AVISE_ERRO_ABRIR_SITE = func_ler_valor(V_ARQ_CONFIG_AVISE_ERRO_ABRIR_SITE) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_INFORME_VOZ_ABRIR_SITE = func_ler_valor(V_ARQ_CONFIG_INFORME_VOZ_ABRIR_SITE) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_ABRIR_LINK_EM_SEGUNDO_PLANO = func_ler_valor(V_ARQ_CONFIG_ABRIR_LINK_EM_SEGUNDO_PLANO) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_RESTAURAR_SESSAO = func_ler_valor(V_ARQ_CONFIG_RESTAURAR_SESSAO) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS = func_ler_valor(V_ARQ_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_RECURSO_TESTE_DE_PAGINA_ONLINE = func_ler_valor(V_ARQ_CONFIG_RECURSO_TESTE_DE_PAGINA_ONLINE) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_RECURSO_DE_SONS_DE_SISTEMA = func_ler_valor(V_ARQ_CONFIG_RECURSO_DE_SONS_DE_SISTEMA) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_USAR_VOZ_EM_CAIXAS_DE_DIALOGO = func_ler_valor(V_ARQ_CONFIG_USAR_VOZ_EM_CAIXAS_DE_DIALOGO) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_USAR_RECURSO_AUTO_COMPLETAR_BARRA_DE_END = func_ler_valor(V_ARQ_CONFIG_USAR_RECURSO_AUTO_COMPLETAR_BARRA_DE_END) 'Retorna o valor do arquivo lido










        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Atualizando objetos agora -------------------------------------------------------------------------------------------------------------------------------------------------------

        proc_atualize_objetos_que_dependem_de_variaveis_gerais() 'Atualiza objetos que dependem de variáveis gerais

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub














End Module
