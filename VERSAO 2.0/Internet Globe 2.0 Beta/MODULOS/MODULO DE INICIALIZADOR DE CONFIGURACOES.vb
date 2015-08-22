Imports Gecko

Module MODULO_DE_INICIALIZADOR_DE_CONFIGURACOES


    'VARIAVEIS

    Public V_NIVEL_DE_TRANSPARENCIA_ATUAL As Single = 1 'INFORMA O NIVEL DE TRANSPARENCIA ATUAL

    Public V_JA_EXISTE_UMA_INSTANCIA_DO_NAVEGADOR_ABERTO As String = Command() 'INFORMA SE JÁ HÁ UMA INSTANCIA DO NAVEGADOR EM ABERTO























    'PROCEDIMENTOS

    Public Sub PROC_CARREGAR_OS_ICONES_DA_BARRA_DE_NAVEGACAO() 'CARREGA OS ICONES DA BARRA DE NAVEGAÇÃO
        On Error Resume Next


        'CARREGANDO AS IMAGENS ---------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripButton4.Image = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.IML_ICONES.Images.Item(0) 'IMAGEM
        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripButton3.Image = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.IML_ICONES.Images.Item(1) 'IMAGEM
        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripButton5.Image = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.IML_ICONES.Images.Item(2) 'IMAGEM

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CARREGAR_CONFIGURACOES_DE_PRIMEIRO_USO() 'CARREGA AS CONFIGURAÇÕES DE PRIMEIRO USO
        On Error Resume Next


        'ARQUIVOS DE PRIMEIRO USO --------------------------------------------------------------------------------------

        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ARQUIVO_END_1) = False) Then

            PROC_SALVAR_ARQUIVO("http://www.google.com.br/", V_ARQUIVO_END_1) 'SALVANDO CONFIGURAÇÃO

        End If


        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ARQUIVO_END_8) = False) Then

            PROC_SALVAR_ARQUIVO(True, V_ARQUIVO_END_8) 'SALVANDO CONFIGURAÇÃO
            PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_7) 'SALVANDO CONFIGURAÇÃO
            PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_9) 'SALVANDO CONFIGURAÇÃO

        End If


        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ARQUIVO_END_34) = False) Then

            PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_34) 'SALVANDO CONFIGURAÇÃO

        End If


        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ARQUIVO_END_23) = False) Then

            PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_23) 'SALVANDO CONFIGURAÇÃO

        End If

        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ARQUIVO_END_24) = False) Then

            PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_24) 'SALVANDO CONFIGURAÇÃO

        End If


        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ARQUIVO_END_26) = False) Then

            PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_26) 'SALVANDO CONFIGURAÇÃO

        End If


        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ARQUIVO_END_35) = False) Then

            PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_35) 'SALVANDO CONFIGURAÇÃO

        End If


        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ARQUIVO_END_32) = False) Then

            PROC_SALVAR_ARQUIVO("Usuário", V_ARQUIVO_END_32) 'SALVANDO CONFIGURAÇÃO

        End If


        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ARQUIVO_END_6) = False) Then

            PROC_SALVAR_ARQUIVO(V_PASTA_DE_MEUS_DOWNLOADS_BAIXADOS_PADRAO_END, V_ARQUIVO_END_6) 'SALVANDO CONFIGURAÇÃO

        End If


        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ARQUIVO_END_37) = False) Then

            PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_37) 'SALVANDO CONFIGURAÇÃO

        End If
















































        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_RECURSO_DE_CARREGAR_SITE_MAIS_RAPIDO() 'RECURSO DE CARREGAR O SITE MAIS RAPIDO
        On Error Resume Next

        Dim V_RESP_DE_CONFIGURACAO As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_37) 'LENDO CONFIGURAÇÃO

        Dim V_MEMORIA_RAM_EM_KB_DISPONIVEL As Long = (FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_DISPONIVEL() / 1024) 'MEMORIA RAM EM KILOBYTES DISPONIVEIS

        Dim V_QUANTOS_KB_EM_CACHE_DE_RAM_USAR As Integer = ((22 * V_MEMORIA_RAM_EM_KB_DISPONIVEL) / 100) 'MEMORIA EM CACHE KB A USAR






        'HACK PARA CARREGAMENTO MAIS RAPIDO ---------------------------------------------------------------------------------------------------------

        If (V_RESP_DE_CONFIGURACAO = True) Then




            'RELACIONADO A CONEXÃO ------------------------------------------------------------------------------------------------------------------

            Gecko.GeckoPreferences.User("content.notify.interval") = 500000
            Gecko.GeckoPreferences.User("content.notify.ontimer") = True
            Gecko.GeckoPreferences.User("content.switch.threshold") = 250000
            Gecko.GeckoPreferences.User("network.http.keep-alive") = True
            Gecko.GeckoPreferences.User("network.http.pipelining") = True
            Gecko.GeckoPreferences.User("network.http.proxy.pipelining") = True
            Gecko.GeckoPreferences.User("network.http.pipelining.maxrequests") = 8

            '----------------------------------------------------------------------------------------------------------------------------------------




            'RELACIONADO A MEMORIA CACHE ------------------------------------------------------------------------------------------------------------

            If (V_QUANTOS_KB_EM_CACHE_DE_RAM_USAR >= 5120) Then


                Gecko.GeckoPreferences.User("browser.cache.disk.enable") = False 'DESABILITA CACHE EM DISCO
                Gecko.GeckoPreferences.User("browser.cache.memory.enable") = True 'ATIVA O CACHE DE MEMORIA
                Gecko.GeckoPreferences.User("browser.cache.memory.max_entry_size") = V_QUANTOS_KB_EM_CACHE_DE_RAM_USAR 'KB A USAR


            End If

            '----------------------------------------------------------------------------------------------------------------------------------------




        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CARREGA_PREFERENCIAS_DO_MOTOR_GECKOFX() 'CARREGA AS PREFERENCIAS DO MOTOR GECKOFX
        On Error Resume Next


        'EXIBE OU NAO A PAGINA DE ERROS DO MOTOR -------------------------------------------------

        Gecko.GeckoPreferences.User("browser.xul.error_pages.enabled") = True

        '-----------------------------------------------------------------------------------------




        'CONFIGURAÇÃO DA VERSÃO DO NAVEGADOR ----------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_24) = False) Then

            Gecko.GeckoPreferences.User("general.useragent.compatMode.firefox") = True

        End If

        '----------------------------------------------------------------------------------------------------------------------




        'USO DE JAVASCRIPT ------------------------------------------------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_25) = True) Then

            Gecko.GeckoPreferences.User("javascript.enabled") = True 'JAVASCRIPT

        Else

            Gecko.GeckoPreferences.User("javascript.enabled") = False 'JAVASCRIPT

        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------




        'EM CASO DE NÃO HOUVER CONFIGURAÇÃO ---------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_6) = Nothing) Then

            PROC_SALVAR_ARQUIVO(True, V_PASTA_DE_MEUS_DOWNLOADS_BAIXADOS_PADRAO_END) 'SALVANDO NOVA CONFIGURAÇÃO

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CARREGAR_PREFERENCIAS_DO_NAVEGADOR() 'CARREGAR AS PREFERENCIAS DO NAVEGADOR
        On Error Resume Next


        'BARRA DE FERRAMENTAS, BARRA DE NAVEGAÇÃO --------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_10) = False) Then 'LÊ CONFIG DE ARQUIVO


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TOL_BARRA_DE_NAVEGACAO.Visible = False 'FALSO

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ExibirToolStripMenuItem1.Enabled = True 'SIM

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.NãoExibirToolStripMenuItem.Enabled = False 'NÃO

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_BARRA_DE_ENDERECOS.Visible = False 'FALSO


        Else


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TOL_BARRA_DE_NAVEGACAO.Visible = True 'VERDADEIRO

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ExibirToolStripMenuItem1.Enabled = False 'SIM

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.NãoExibirToolStripMenuItem.Enabled = True 'NÃO

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_BARRA_DE_ENDERECOS.Visible = True 'VERDADEIRO


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------




        'BARRA DE FERRAMENTAS, BARRA DE STATUS -----------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_11) = False) Then 'LÊ CONFIG DE ARQUIVO


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ST_BARRA_DE_STATUS.Visible = False 'FALSO

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ExibirToolStripMenuItem2.Enabled = True 'SIM

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.NãoExibirToolStripMenuItem1.Enabled = False 'NÃO


        Else


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ST_BARRA_DE_STATUS.Visible = True 'VERDADEIRO

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ExibirToolStripMenuItem2.Enabled = False 'SIM

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.NãoExibirToolStripMenuItem1.Enabled = True 'NÃO


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE RECURSO ESTA ATIVADO ----------------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_27) = False) Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel1.Visible = False 'NAO EXIBE O TESTE DE LINK

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripSeparator1.Visible = False 'OCULTA O SEPARADOR


        Else


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel1.Visible = True 'EXIBE O TESTE DE LINK

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripSeparator1.Visible = True 'EXIBE O SEPARADOR


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CARREGA_COR_E_ESTILO_DE_ABA(ByRef V_RESTAURAR_COR As Boolean) 'CARREGA A COR E O ESTILO DA ABA
        On Error Resume Next

        Dim V_NOME_DE_COR(2) As String 'INFORMA O NOME DAS CORES

        Dim OBJ_COR As Color 'COR A APLICAR

        Dim OBJ_COR_DE_FONTE As Color 'COR A APLICAR






        'OBTENDO OS NOMES DAS CORES ------------------------------------------------------------------------------------

        V_NOME_DE_COR(1) = FUNC_LER_ARQUIVO(V_ARQUIVO_END_12) 'LÊ CONFIG DE ARQUIVO

        V_NOME_DE_COR(2) = FUNC_LER_ARQUIVO(V_ARQUIVO_END_13) 'LÊ CONFIG DE ARQUIVO

        '---------------------------------------------------------------------------------------------------------------




        'CODIGO QUE RESTAURA A COR -------------------------------------------------------------------------------------

        If (V_RESTAURAR_COR = True) Then


            V_NOME_DE_COR(1) = "Control" 'RESTAURA A COR

            V_NOME_DE_COR(2) = "Black" 'RESTAURA A COR


        End If

        '---------------------------------------------------------------------------------------------------------------

       


        'NÃO PERMITE CARREGAR VALORES NULOS ----------------------------------------------------------------------------

        If (V_NOME_DE_COR(1) = "True") And (V_NOME_DE_COR(2) = "True") Then

            Exit Sub 'SAINDO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'COR DA ABA ----------------------------------------------------------------------------------------------------

        OBJ_COR = Color.FromArgb(V_NOME_DE_COR(1)) 'CRIANDO A COR

        '---------------------------------------------------------------------------------------------------------------




        'COR DA FONTE --------------------------------------------------------------------------------------------------

        OBJ_COR_DE_FONTE = Color.FromArgb(V_NOME_DE_COR(2)) 'CRIANDO A COR

        '---------------------------------------------------------------------------------------------------------------




        'APLICANDO -----------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.BackHighColor = OBJ_COR 'COR
        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.BackLowColor = OBJ_COR 'COR
        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabBackLowColor = OBJ_COR 'COR
        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabBackHighColor = OBJ_COR 'COR
        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabBackLowColorDisabled = OBJ_COR 'COR
        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.Refresh() 'ATUALIZANDO
        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.ForeColor = OBJ_COR_DE_FONTE 'COR DA FONTE

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_ADICIONADOR_DE_EVENTOS_AO_INICIALIZAR() 'ADICIONA OS EVENTOS AO INICIALIZAR
        On Error Resume Next


        'ADICIONA EVENTO DE TROCAR DE ABA ------------------------------------------------------------------------------

        AddHandler FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedTabChanged, AddressOf TAB_ABAS_SELECIONAR_OUTRA_ABA 'ADICIONA EVENTO

        '---------------------------------------------------------------------------------------------------------------


















    End Sub

    Public Sub PROC_CARREGAR_VARIAVEIS_DE_HISTORICO() 'CARREGA AS VARIÁVEIS DE HISTORICO
        On Error Resume Next

        Dim V_ARQUIVO_DE_INDICE_DE_HISTORICO As String = V_PASTA_DE_HISTORICO_DE_SITES_VISITADOS & "\indice" & V_EXTENCAO_DE_ARQUIVO_4 'INFORMA O ARQUIVO DE INDICE GERAL

        Dim ARRAY_ITENS As Array = Split(FUNC_LER_ARQUIVO(V_ARQUIVO_DE_INDICE_DE_HISTORICO), V_SEPARADOR_DE_STRINGS_2) 'ARRAY DE VALORES






        'ADICIONA ITENS DA LISTA ------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_LISTA_DE_HISTORICO_URL_JA_EXISTE = FUNC_LER_ARQUIVO(V_ARQUIVO_DE_INDICE_DE_HISTORICO) 'LÊ CONFIG DE ARQUIVO COM VALOR NÃO NULO COMO RESPOSTA

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'OBTEM VALOR DE ITENS DE HISTORICO --------------------------------------------------------------------------------------------------------------------------------------------------

        V_CONTADOR_DE_ITENS_DE_HISTORICO = (ARRAY_ITENS.Length / 3) 'OBTENDO...



        If (V_CONTADOR_DE_ITENS_DE_HISTORICO = 0) Then




            V_CONTADOR_DE_ITENS_DE_HISTORICO = 1 'DEFINE COMO UM

            V_LISTA_DE_HISTORICO_URL_JA_EXISTE = "" 'LIMPA LISTA DE LIXO CASO HOUVER

            PROC_SALVAR_ARQUIVO(" ", V_ARQUIVO_DE_INDICE_DE_HISTORICO) 'SALVA O ARQUIVO




        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CARREGA_INTELIGENCIA_INICIALIZAR() 'CARREGA O TESTE DE INTELIGENCIA AO INICIALIZAR
        On Error Resume Next


        PROC_TESTE_DE_INTELIGENCIA_ATIVAR(FUNC_LER_ARQUIVO(V_ARQUIVO_END_26)) 'INICIA OS TESTES DE INTELIGENCIA


    End Sub

    Public Sub PROC_INICIAR_REMOVER_OS_COOKIES() 'AO INICIAR REMOVER OS COOKIES
        On Error Resume Next

        Dim V_RESPOSTA As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_36) 'LENDO CONFIGURAÇÃO






        'VERIFICA SE HÁ UMA INSTANCIA DO NAVEGADOR EM ABERTO ----------------------------------------------------------------------------------

        If (V_JA_EXISTE_UMA_INSTANCIA_DO_NAVEGADOR_ABERTO.Length > 0) Then

            Exit Sub 'SAINDO DO PROCEDIMENTO

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE A RESPOSTA É VALIDA -------------------------------------------------------------------------------

        If (V_RESPOSTA = Nothing) Or (V_RESPOSTA <> True) Then


            PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_36) 'SALVANDO CONFIGURAÇÃO

            Exit Sub 'SAINDO


        End If

        '---------------------------------------------------------------------------------------------------------------




        'REMOVENDO OS COOKIES ------------------------------------------------------------------------------------------

        Kill(Xpcom.ProfileDirectory & "\" & "*.sqlite*") 'REMOVENDO ARQUIVOS DE COOKIE

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_36) 'INFORMA PARA NAO LIMPAR MAIS

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EXIBIR_BARRA_DE_ABAS_AO_INICIALIZAR() 'AO INICIALIZAR EXIBIR A BARRA DE ABAS
        On Error Resume Next


        'EXIBE A BARRA DE ABAS -------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_PRINCIPAL.Dock = DockStyle.Fill 'PAINEL PRINCIPAL PREENCHIMENTO COMPLETO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.Visible = True 'EXIBE A BARRA DE ABAS

        '-----------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_INICIALIZAR_ANTI_TRAVAMENTO() 'INICIALIZA O APLICATIVO ANTI-TRAVAMENTO
        On Error Resume Next

        PROC_VERIFICADOR_DE_TRAVAMENTO_DE_APLICATIVO() 'APLICATIVO ANTI-TRAVAMENTO

    End Sub

    Public Sub PROC_REMOVER_TODAS_AS_CONFIGURACOES_DO_NAVEGADOR_AO_INICIALIZAR() 'AO INICIALIZAR VERIFICA SE DEVE REMOVER TODAS AS CONFIGURAÇÕES DO NAVEGADOR, SOLICITADAS PELO USUÁRIO.
        On Error Resume Next

        Dim V_CONFIGURACAO As Boolean = FUNC_LER_ARQUIVO(V_ARQUIVO_END_38) 'LÊ CONFIG DE ARQUIVO






        'VERIFICA SE REMOVE OU NAO ------------------------------------------------------------------------------------------------------------

        If (V_CONFIGURACAO = True) Then

            PROC_REMOVE_PASTA_COMPLETA_COM_SUB_PASTAS(V_PASTA_DE_CONFIGURACOES_END, False) 'REMOVE TODA A PASTA INCLUINDO ARQUIVOS

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'INFORMA QUE NAO PODE EXECUTAR A MESMA AÇÃO DA PRÓXIMA VEZ ----------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_38) 'SALVANDO CONFIGURAÇÃO

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub





























    'INICIALIZADOR

    Public Sub PROC_CARREGAR_E_INICIALIZAR_AS_CONFIGURACOES() 'CARREGA E INICIALIZA AS CONFIGURAÇÕES
        On Error Resume Next

        '#NOTA:::::::::::::::::::::::::::::: NAO ALTERAR A ORDEM DE INICIALIZAÇÃO :::::::::::::::::::::::::::::::::::::#






        'CRIA AS PASTAS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_CRIAR_PASTAS() 'CRIAR PASTAS DE SISTEMA DO NAVEGADOR

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'REMOVE OU NAO TODAS AS CONFIGURAÇÕES -----------------------------------------------------------------------------------------------------------------------------------------------

        PROC_REMOVER_TODAS_AS_CONFIGURACOES_DO_NAVEGADOR_AO_INICIALIZAR() 'AO INICIALIZAR VERIFICA SE DEVE REMOVER TODAS AS CONFIGURAÇÕES DO NAVEGADOR, SOLICITADAS PELO USUÁRIO.

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



        'CARREGA AS CONFIGURAÇÕES DE PRIMEIRO USO -------------------------------------------------------------------------------------------------------------------------------------------

        PROC_CARREGAR_CONFIGURACOES_DE_PRIMEIRO_USO() 'CARREGA AS CONFIGURAÇÕES DE PRIMEIRO USO

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'NAVEGAÇÃO ANONIMA ------------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_NAVEGACAO_ANONIMA_UTILIZAR() 'NAVEGAÇÃO ANONIMA UTILIZAR

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'LIMPA O HISTORICO NO MODO SILENCIOSO -----------------------------------------------------------------------------------------------------------------------------------------------

        PROC_LIMPAR_HISTORICO_EM_MODO_SILENCIOSO() 'LIMPA O HISTÓRICO NO MODO SILENCIOSO

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'REMOVER COOKIES AO INICIAR ---------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_INICIAR_REMOVER_OS_COOKIES() 'AO INICIAR REMOVER OS COOKIES

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'PREFERENCIAS DO MOTOR GECKOFX ------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_CARREGA_PREFERENCIAS_DO_MOTOR_GECKOFX() 'CARREGA AS PREFERENCIAS DO MOTOR GECKOFX

        PROC_RECURSO_DE_CARREGAR_SITE_MAIS_RAPIDO() 'RECURSO DE CARREGAR O SITE MAIS RAPIDO

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ADICIONA EVENTOS -------------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_ADICIONADOR_DE_EVENTOS_AO_INICIALIZAR() 'ADICIONA OS EVENTOS AO INICIALIZAR

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'CARREGA AS PREFERENCIAS DO NAVEGADOR -----------------------------------------------------------------------------------------------------------------------------------------------

        PROC_CARREGA_COR_E_ESTILO_DE_ABA(False) 'CARREGA A COR E O ESTILO DA ABA

        PROC_CARREGAR_PREFERENCIAS_DO_NAVEGADOR() 'CARREGAR AS PREFERENCIAS DO NAVEGADOR

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'CARREGA AS VARIÁVEIS DE HISTORICO --------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_CARREGAR_VARIAVEIS_DE_HISTORICO() 'CARREGA AS VARIÁVEIS DE HISTORICO

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'CARREGA OS ICONES DA BARRA DE NAVEGAÇÃO --------------------------------------------------------------------------------------------------------------------------------------------

        PROC_CARREGAR_OS_ICONES_DA_BARRA_DE_NAVEGACAO() 'CARREGA OS ICONES DA BARRA DE NAVEGAÇÃO

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'CARREGA O TEMA AGORA ---------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_APLICADOR_DE_TEMAS_NO_NAVEGADOR() 'APLICADOR DE TEMAS NO NAVEGADOR

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'INICIALIZA OS TESTES DE INTELIGENCIA -----------------------------------------------------------------------------------------------------------------------------------------------

        PROC_CARREGA_INTELIGENCIA_INICIALIZAR() 'CARREGA O TESTE DE INTELIGENCIA AO INICIALIZAR

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'EXIBIR A BARRA DE ABAS -------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_EXIBIR_BARRA_DE_ABAS_AO_INICIALIZAR() 'AO INICIALIZAR EXIBIR A BARRA DE ABAS

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'CRIA A PRIMEIRA ABA ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_ANALISA_RESTAURAR_SESSAO_ANTERIOR() 'RESTAURA A SESSÃO ANTERIOR

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'INICIALIZA O APLICATIVO ANTI-TRAVAMENTO --------------------------------------------------------------------------------------------------------------------------------------------

        PROC_INICIALIZAR_ANTI_TRAVAMENTO() 'INICIALIZA O APLICATIVO ANTI-TRAVAMENTO

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------






























    End Sub











































End Module
