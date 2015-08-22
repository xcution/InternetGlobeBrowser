Imports SpeechLib
Imports Skybound.Gecko


Module Modulo_de_aplicar_configuracoes


    'Procedimentos

    Public Sub proc_carregar_configuracoes_padrao_em_caso_de_falta() 'Em caso de nao houver configurações, então carregar configuração padrao.
        On Error Resume Next

        Dim v_pasta_existe As Boolean 'Informa se a pasta de configuração existe ou não

        Dim v_arquivo_de_configuracao_inicial As Boolean 'Informa se o arquivo de configuração inicial existe ou não






        'Verificando existencia de pasta ------------------------------------------------------------------------------------------------------

        v_pasta_existe = My.Computer.FileSystem.DirectoryExists(V_PASTA_DE_CONFIGURACAO) 'Verificando existencia de pasta

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Verifica se o arquivo de configuração inicial existe ou não ---------------------------------------------------------------------------------------------------------

        v_arquivo_de_configuracao_inicial = func_retorne_se_arquivo_existe_no_computador(V_ARQ_CONFIG_PAGINA_INICIAL) 'Retorna se o arquivo existe ou não no computador

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Verificando resposta --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (v_pasta_existe = False) Or (v_arquivo_de_configuracao_inicial = False) Then




            'Aplica as configurações padrão ------------------------------------------------------------------------------------------------------------------------------------------------------

            proc_chamar_painel_de_controle_app_config_padrao() 'Chamar o painel de controle e aplica as configurações padrão

            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'Chamar o aplicativo associador de extenção ------------------------------------------------------------------------------------------------------------------------------------------

            proc_chamar_aplicativo_associador_de_extencao() 'Associador de extenção

            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------












        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub proc_aplicar_tema_Modulo_de_aplicar_configuracoes() 'Aplica o tema no programa
        On Error Resume Next


        'Obtendo a configuração do tema -----------------------------------------------------------------------------

        V_VAL_CONFIG_TIPO_DE_TEMA = func_ler_valor(V_ARQ_CONFIG_TIPO_DE_TEMA) 'Retorna o valor do arquivo lido

        '------------------------------------------------------------------------------------------------------------


        'Selecionando o tipo de tema --------------------------------------------------------------------------------------------------------------------------------

        Select Case V_VAL_CONFIG_TIPO_DE_TEMA


            Case v_acao_tema_1 'Tema 1

                FRM_NAVEGACAO.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black 'Preto


            Case v_acao_tema_2 'Tema 2

                FRM_NAVEGACAO.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue 'Azul


            Case v_acao_tema_3 'Tema 3

                FRM_NAVEGACAO.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver 'Prateado


        End Select

        '------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_aplicar_tipo_de_aba_Modulo_de_aplicar_configuracoes() 'Aplica o tipo de aba
        On Error Resume Next

        Dim v_tipo_de_aba_definir As Integer = Nothing 'Informa o tipo de aba a ser definida






        'Obtendo o tipo da aba ------------------------------------------------------------------------------------------------------------

        v_tipo_de_aba_definir = func_ler_valor(V_ARQ_CONFIG_ESQUEMA_DE_ABA) 'Retorna o valor do arquivo lido

        '----------------------------------------------------------------------------------------------------------------------------------


        'Aplicando a configuração ---------------------------------------------------------------------------------------------------------


        Select Case v_tipo_de_aba_definir



            Case v_esquema_de_aba_1

                FRM_NAVEGACAO.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock 'Esquema de aba
                FRM_NAVEGACAO.ButtonItem83.Text = "Usando"
                FRM_NAVEGACAO.ButtonItem84.Text = "Tipo 2"
                FRM_NAVEGACAO.ButtonItem85.Text = "Tipo 3"
                FRM_NAVEGACAO.ButtonItem86.Text = "Tipo 4"
                FRM_NAVEGACAO.ButtonItem87.Text = "Tipo 5"
                FRM_NAVEGACAO.ButtonItem88.Text = "Tipo 6"


            Case v_esquema_de_aba_2

                FRM_NAVEGACAO.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document 'Esquema de aba
                FRM_NAVEGACAO.ButtonItem83.Text = "Tipo 1"
                FRM_NAVEGACAO.ButtonItem84.Text = "Usando"
                FRM_NAVEGACAO.ButtonItem85.Text = "Tipo 3"
                FRM_NAVEGACAO.ButtonItem86.Text = "Tipo 4"
                FRM_NAVEGACAO.ButtonItem87.Text = "Tipo 5"
                FRM_NAVEGACAO.ButtonItem88.Text = "Tipo 6"


            Case v_esquema_de_aba_3

                FRM_NAVEGACAO.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document 'Esquema de aba
                FRM_NAVEGACAO.ButtonItem83.Text = "Tipo 1"
                FRM_NAVEGACAO.ButtonItem84.Text = "Tipo 2"
                FRM_NAVEGACAO.ButtonItem85.Text = "Usando"
                FRM_NAVEGACAO.ButtonItem86.Text = "Tipo 4"
                FRM_NAVEGACAO.ButtonItem87.Text = "Tipo 5"
                FRM_NAVEGACAO.ButtonItem88.Text = "Tipo 6"


            Case v_esquema_de_aba_4

                FRM_NAVEGACAO.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.SimulatedTheme 'Esquema de aba
                FRM_NAVEGACAO.ButtonItem83.Text = "Tipo 1"
                FRM_NAVEGACAO.ButtonItem84.Text = "Tipo 2"
                FRM_NAVEGACAO.ButtonItem85.Text = "Tipo 3"
                FRM_NAVEGACAO.ButtonItem86.Text = "Usando"
                FRM_NAVEGACAO.ButtonItem87.Text = "Tipo 5"
                FRM_NAVEGACAO.ButtonItem88.Text = "Tipo 6"


            Case v_esquema_de_aba_5

                FRM_NAVEGACAO.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005 'Esquema de aba
                FRM_NAVEGACAO.ButtonItem83.Text = "Tipo 1"
                FRM_NAVEGACAO.ButtonItem84.Text = "Tipo 2"
                FRM_NAVEGACAO.ButtonItem85.Text = "Tipo 3"
                FRM_NAVEGACAO.ButtonItem86.Text = "Tipo 4"
                FRM_NAVEGACAO.ButtonItem87.Text = "Usando"
                FRM_NAVEGACAO.ButtonItem88.Text = "Tipo 6"


            Case v_esquema_de_aba_6

                FRM_NAVEGACAO.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.RoundHeader 'Esquema de aba
                FRM_NAVEGACAO.ButtonItem83.Text = "Tipo 1"
                FRM_NAVEGACAO.ButtonItem84.Text = "Tipo 2"
                FRM_NAVEGACAO.ButtonItem85.Text = "Tipo 3"
                FRM_NAVEGACAO.ButtonItem86.Text = "Tipo 4"
                FRM_NAVEGACAO.ButtonItem87.Text = "Tipo 5"
                FRM_NAVEGACAO.ButtonItem88.Text = "Usando"


        End Select


        '----------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_barra_de_navegacao_Modulo_de_aplicar_configuracoes() 'Barra de navegação exibir ou não
        On Error Resume Next


        'Exibe ou não a barra de navegação -------------------------------------------------------------------------------------------------

        If (func_ler_valor(V_ARQ_CONFIG_BARRA_DE_NAVEGACAO) = v_barra_de_navegacao_exibir) Then


            FRM_NAVEGACAO.PanelEx1.Visible = True 'Exibe

            FRM_NAVEGACAO.ButtonItem65.Enabled = False 'Sim

            FRM_NAVEGACAO.ButtonItem66.Enabled = True 'Não


        Else


            FRM_NAVEGACAO.PanelEx1.Visible = False 'Não exibe

            FRM_NAVEGACAO.ButtonItem65.Enabled = True 'Sim

            FRM_NAVEGACAO.ButtonItem66.Enabled = False 'Não


        End If

        '-----------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_barra_de_status_Modulo_de_aplicar_configuracoes() 'Exibe ou não a barra de status
        On Error Resume Next


        'Exibe ou não a barra de status ----------------------------------------------------------------------------------------------------

        If (func_ler_valor(V_ARQ_CONFIG_BARRA_DE_STATUS) = v_barra_de_staus_exibir) Then


            FRM_NAVEGACAO.StatusStrip1.Visible = True 'Barra de status

            FRM_NAVEGACAO.ButtonItem67.Enabled = False 'Sim

            FRM_NAVEGACAO.ButtonItem68.Enabled = True 'Não


        Else


            FRM_NAVEGACAO.StatusStrip1.Visible = False 'Barra de status

            FRM_NAVEGACAO.ButtonItem67.Enabled = True 'Sim

            FRM_NAVEGACAO.ButtonItem68.Enabled = False 'Não


        End If

        '-----------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_carregar_vozes_Modulo_de_aplicar_configuracoes() 'Carregar as vozes
        On Error Resume Next

        Dim voz_nova As New SpeechLib.SpVoice 'Nova instância para vóz

        Dim vozes As ISpeechObjectToken 'Vozes





        'Inicializando variável -----------------------------------------------------

        V_VAL_VOZES_NO_SISTEMA = Nothing 'Limpando valor antigo

        '----------------------------------------------------------------------------


        'Varrendo e repassando valores encontrados ------------------------------------------------------------------------------------

        For Each vozes In voz_nova.GetVoices 'Buscando vozes


            V_VAL_VOZES_NO_SISTEMA = V_VAL_VOZES_NO_SISTEMA & vozes.GetDescription & v_separador_de_string 'Adicionando vozes


        Next

        '------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_inicializar_preferencias_de_motores() 'Inicializar as preferencias de motores layout engine
        On Error Resume Next

        Dim V_VAL_CONFIG_DESABILITA_EFEITOS_AVANCADOS_DE_NAVEGACAO As String = func_ler_valor(V_ARQ_CONFIG_DESABILITA_EFEITOS_AVANCADOS_DE_NAVEGACAO) 'Retorna o valor do arquivo lido






        'Verifica se pode ou nao carregar as preferencias dos motores geckofx ----------------------------------------------------------------------------------------

        If (V_VAL_CONFIG_DESABILITA_EFEITOS_AVANCADOS_DE_NAVEGACAO = "") Then


            V_VAL_CONFIG_DESABILITA_EFEITOS_AVANCADOS_DE_NAVEGACAO = False 'Desabilita caso nao tenha configurado ainda


        End If




        If (V_VAL_CONFIG_DESABILITA_EFEITOS_AVANCADOS_DE_NAVEGACAO = False) Then


            'Configuração da versão do navegador -----------------------------------------------------

            Skybound.Gecko.GeckoPreferences.User("general.useragent.extra.firefox") = "Firefox/3.6"

            '-----------------------------------------------------------------------------------------


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Exibir a página de erro do firefox ------------------------------------------------------

        Skybound.Gecko.GeckoPreferences.User("browser.xul.error_pages.enabled") = True

        '-----------------------------------------------------------------------------------------




        'Preferencias que fazem o gerenciador de downloads funcionar ---------------------------------------------------

        Skybound.Gecko.GeckoPreferences.User("browser.download.useDownloadDir") = False

        Skybound.Gecko.GeckoPreferences.User("browser.download.folderList") = 0

        Skybound.Gecko.GeckoPreferences.User("browser.download.manager.showAlertOnComplete") = True

        Skybound.Gecko.GeckoPreferences.User("browser.download.manager.showAlertInterval") = 2000

        Skybound.Gecko.GeckoPreferences.User("browser.download.manager.retention") = 2

        Skybound.Gecko.GeckoPreferences.User("browser.download.manager.showWhenStarting") = True

        Skybound.Gecko.GeckoPreferences.User("browser.download.manager.useWindow") = True

        Skybound.Gecko.GeckoPreferences.User("browser.download.manager.closeWhenDone") = False

        Skybound.Gecko.GeckoPreferences.User("browser.download.manager.openDelay") = 0

        Skybound.Gecko.GeckoPreferences.User("browser.download.manager.focusWhenStarting") = False

        Skybound.Gecko.GeckoPreferences.User("browser.download.manager.flashCount") = 2

        Skybound.Gecko.GeckoPreferences.User("alerts.slideIncrement") = 1

        Skybound.Gecko.GeckoPreferences.User("alerts.slideIncrementTime") = 10

        Skybound.Gecko.GeckoPreferences.User("alerts.totalOpenTime") = 4000

        Skybound.Gecko.GeckoPreferences.User("alerts.height") = 50

        '---------------------------------------------------------------------------------------------------------------



    End Sub

    Public Sub proc_limpar_cache_geckofx() 'Limpar cache do navegador ao inicializar geckofx
        On Error Resume Next

        Dim v_diretorio As String 'Diretório onde se localiza os arquivos a serem removidos






        'Obtendo o diretorio de cache geckofx --------------------------------------------------------------------------

        v_diretorio = Xpcom.ProfileDirectory 'Diretório

        '---------------------------------------------------------------------------------------------------------------




        'Verifica se limpa os arquivos de navegação --------------------------------------------------------------------

        If (func_ler_valor(V_ARQ_LIMPAR_DADOS_NAVEGACAO) = False) Then

            Exit Sub

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Limpar cache geckofx ------------------------------------------------------------------------------------------

        Kill(v_diretorio & "\*.*") 'Apagando todos os arquivos

        Kill(v_diretorio & "\Cache\*.*") 'Apagando todos os arquivos

        '---------------------------------------------------------------------------------------------------------------




        'Informando que ja removeu os arquivos -------------------------------------------------------------------------

        proc_salvar_valor(False, V_ARQ_LIMPAR_DADOS_NAVEGACAO) 'Salva a configuração

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_limpar_cache_de_historico_sites_visitados() 'Limpa o cache de historico de sites visitados
        On Error Resume Next

        Dim v_diretorio As String 'Diretório onde se localiza os arquivos a serem removidos






        'Obtendo o diretorio de cache geckofx --------------------------------------------------------------------------

        v_diretorio = V_PASTA_DE_CONFIGURACAO 'Diretório

        '---------------------------------------------------------------------------------------------------------------




        'Verifica se limpa os arquivos de navegação --------------------------------------------------------------------

        If (func_ler_valor(V_ARQ_LIMPAR_DADOS_NAVEGACAO_HISTORICO) = False) Then

            Exit Sub

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Limpar cache geckofx ------------------------------------------------------------------------------------------

        Kill(v_diretorio & "\*" & v_extencao_2 & "*") 'Apagando todos os arquivos

        My.Computer.FileSystem.DeleteFile(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_TITULO) 'Titulo

        My.Computer.FileSystem.DeleteFile(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_URL) 'Url

        My.Computer.FileSystem.DeleteFile(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_DATA) 'Data

        My.Computer.FileSystem.DeleteFile(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_NOMES_IMAGENS_SALVAS) 'Key de imagem

        '---------------------------------------------------------------------------------------------------------------




        'Informando que ja removeu os arquivos -------------------------------------------------------------------------

        proc_salvar_valor(False, V_ARQ_LIMPAR_DADOS_NAVEGACAO_HISTORICO) 'Salva a configuração

        '---------------------------------------------------------------------------------------------------------------


    End Sub






    'Carregar o historico de sites e imagens de sites visitados

    Public Sub proc_carregar_historico_de_sites_visitados() 'Carrega toda a lista de sites visitados
        On Error Resume Next


        v_lista_de_sites_visitados_titulo = func_ler_valor(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_TITULO) 'Retorna o valor do arquivo lido

        v_lista_de_sites_visitados_url = func_ler_valor(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_URL) 'Retorna o valor do arquivo lido

        v_data_da_visita = func_ler_valor(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_DATA) 'Retorna o valor do arquivo lido


    End Sub

    Public Sub proc_carregar_historico_de_sites_visitados_imagens_de_autocompletar() 'Carrega as imagens do recurso de autocompletar
        On Error Resume Next

        Dim v_url_das_imagens_de_historico As String 'Url das imagens do historico

        Dim v_array_urls_separadas_imagens_de_historico As Array 'Array das urls de endereços de imagens de historico

        Dim v_contador_1 As Integer = 0 'Contador 1

        Dim v_contador_2 As Integer 'Contador 2






        'Inicializando ---------------------------------------------------------------------------------------------------------------------------------------------

        v_url_das_imagens_de_historico = My.Computer.FileSystem.ReadAllText(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_NOMES_IMAGENS_SALVAS) 'Urls sendo lidas

        v_array_urls_separadas_imagens_de_historico = Split(v_url_das_imagens_de_historico, v_separador_de_string_2) 'Separadando...

        v_contador_2 = v_array_urls_separadas_imagens_de_historico.Length - 1 'Numero de itens lidos

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------




        'Varrendo e carregando configurações de historico ----------------------------------------------------------------------------------------------------------

        For v_contador_1 = v_contador_1 To v_contador_2

            Dim OBJ_IMAGEM_TEMP As Image = Nothing 'Imagem temporaria

            Dim V_CHAVE As String = Nothing 'Chave da imagem

            Dim OBJ_IMAGEM_TEMP_2 As Image = Nothing  'Imagem temporaria

            Dim V_CHAVE_2 As String = Nothing 'Chave da imagem

            Dim V_ORIGEM_DE_IMAGEM As String = Nothing 'Origem da imagem

            Dim V_IMAGEM_EXISTE_OU_NAO As Boolean 'Informa se a imagem existe ou nao






            'Historico de sites visitados imagem ----------------------------------------------------------------------------------------------

            '# CARREGANDO IMAGEM...

            V_ORIGEM_DE_IMAGEM = Nothing 'Limpa ultimo valor

            V_ORIGEM_DE_IMAGEM = V_PASTA_DE_CONFIGURACAO & "\" & v_contador_1 - 1 & v_extencao_2 'Origem da imagem

            V_IMAGEM_EXISTE_OU_NAO = func_retorne_se_arquivo_existe_ou_nao(V_ORIGEM_DE_IMAGEM) 'Analizando...




            'Verifica se a imagem existe ou não -------------------------------------------------------------------------


            If (v_contador_1 - 1 <> -1) Then 'Não permite adicionar imagem com indice -1, isto irá gerar pagina em branco




                If (V_IMAGEM_EXISTE_OU_NAO = True) Then


                    OBJ_IMAGEM_TEMP = Image.FromFile(V_ORIGEM_DE_IMAGEM) 'Carregando a imagem...


                Else


                    OBJ_IMAGEM_TEMP = FRM_NAVEGACAO.LST_2.Images.Item(0) 'Imagem em branco


                End If




            End If


            '------------------------------------------------------------------------------------------------------------




            '#DEFININDO URL OU CHAVE KEY DA IMAGEM

            V_CHAVE = v_array_urls_separadas_imagens_de_historico(v_contador_1 - 1) 'Carregando a chave




            '#ATUALIZANDO VALOR

            FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.RemoveByKey(V_CHAVE) 'Removendo...

            FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.Add(V_CHAVE, OBJ_IMAGEM_TEMP) 'Adicionando imagem a lista...


            '----------------------------------------------------------------------------------------------------------------------------------




            'Historico de sites visitados favicon ---------------------------------------------------------------------------------------------


            '# CARREGANDO IMAGEM...

            V_ORIGEM_DE_IMAGEM = Nothing 'Limpa ultimo valor

            V_ORIGEM_DE_IMAGEM = V_PASTA_DE_CONFIGURACAO & "\" & v_nome_generico_de_favicon & v_contador_1 - 1 & v_extencao_2 'Origem

            V_IMAGEM_EXISTE_OU_NAO = func_retorne_se_arquivo_existe_ou_nao(V_ORIGEM_DE_IMAGEM) 'Analizando...




            'Verifica se a imagem existe ou não -------------------------------------------------------------------------


            If (v_contador_1 - 1 <> -1) Then 'Não permite adicionar imagem com indice -1, isto irá gerar pagina em branco




                If (V_IMAGEM_EXISTE_OU_NAO = True) Then


                    OBJ_IMAGEM_TEMP_2 = Image.FromFile(V_ORIGEM_DE_IMAGEM) 'Carregando a imagem...


                Else


                    OBJ_IMAGEM_TEMP_2 = FRM_NAVEGACAO.LST_3.Images.Item(0) 'Imagem em branco


                End If




            End If


            '------------------------------------------------------------------------------------------------------------




            '#DEFININDO URL OU CHAVE KEY DA IMAGEM

            Dim V_CHAVE_INDEX As Integer = v_contador_1 - 1 'Informando o index da chave

            V_CHAVE_2 = v_array_urls_separadas_imagens_de_historico(V_CHAVE_INDEX) 'Carregando a chave




            '#ATUALIZANDO VALOR

            FRM_NAVEGACAO.LST_LISTA_DE_FAVICONS.Images.RemoveByKey(V_CHAVE_2) 'Removendo...

            FRM_NAVEGACAO.LST_LISTA_DE_FAVICONS.Images.Add(V_CHAVE_2, OBJ_IMAGEM_TEMP_2) 'Adicionando imagem a lista...


            '----------------------------------------------------------------------------------------------------------------------------------


        Next

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

































End Module
