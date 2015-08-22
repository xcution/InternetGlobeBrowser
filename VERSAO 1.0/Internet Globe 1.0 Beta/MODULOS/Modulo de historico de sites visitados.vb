Imports System.Threading




Module Modulo_de_historico_de_sites_visitados



    'Variáveis de processamento temporario -----------------------------------------------------------------------------

    Public v_lista_de_sites_visitados_titulo As String = "" 'Titulo de sites visitados

    Public v_lista_de_sites_visitados_url As String = "" 'Url de sites visitados

    Public v_data_da_visita As String = "" 'Data de sites visitados

    Public v_datas_diferentes As String = "" 'Informa quais datas sao diferentes

    '-------------------------------------------------------------------------------------------------------------------




    'Arrays ------------------------------------------------------------------------------------------------------------

    Public array_lista_de_sites_visitados_titulo As Array  'Titulo de sites visitados array

    Public array_lista_de_sites_visitados_url As Array 'Url de sites visitados array

    Public array_data_da_visita As Array  'Data de sites visitados array

    '-------------------------------------------------------------------------------------------------------------------


















    'Trabalhando com o histórico de sites visitados pelo usuario

    Public Sub proc_separar_arrays_de_informacoes_sobre_historico() 'Separa arrays de informações de historico
        On Error Resume Next


        'Separando valores ---------------------------------------------------------------------------------------------------------------------------------------

        array_lista_de_sites_visitados_titulo = Split(v_lista_de_sites_visitados_titulo, v_separador_de_string_2) 'Titulo

        array_lista_de_sites_visitados_url = Split(v_lista_de_sites_visitados_url, v_separador_de_string_2) 'Url

        array_data_da_visita = Split(v_data_da_visita, v_separador_de_string_2) 'Data

        '---------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_separar_datas_diferentes() 'Separa as datas diferentes
        On Error Resume Next

        Dim v_quantidade_de_itens_no_historico As Integer = array_data_da_visita.Length 'Obtendo a quantidade de itens no historico

        Dim v_contador As Integer = 0 'Contador de looping




        'Varrendo e obtendo datas diferentes ------------------------------------------------------------------------------------------------------

        For v_contador = v_contador To v_quantidade_de_itens_no_historico




            If (v_datas_diferentes.Contains(array_data_da_visita(v_contador)) = False) Then


                v_datas_diferentes = v_datas_diferentes & array_data_da_visita(v_contador) & v_separador_de_string_2 'Separando datas


            End If




        Next

        '------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function func_retorne_data_pela_url(ByVal v_url_hist_encont As String) 'Retorna a data da url informada
        On Error Resume Next

        Dim v_contador_1 As Integer = 0 'Contador de inicio

        Dim v_contador_2 As Integer = array_lista_de_sites_visitados_url.Length 'Contador de fim




        'Varrendo e encontrando ----------------------------------------------------------------------------------------

        For v_contador_1 = v_contador_1 To v_contador_2


            If (v_url_hist_encont = array_lista_de_sites_visitados_url(v_contador_1)) Then


                Return array_data_da_visita(v_contador_1) 'Retorno

                Exit Function



            End If


        Next

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Function func_retorne_titulo_por_url_de_historico_atual(ByVal v_url As String) 'Retorna o titulo da url pelo valor da url
        On Error Resume Next

        Dim v_contador As Integer = 0 'Contador de looping

        Dim v_valor_de_retorno As String = "" 'Valor de retorno






        'Não permite valores nulos -----------------------------------------------

        If (v_url = Nothing) Or (v_url = "") Then

            Return "" 'Retorno

            Exit Function 'Saida


        End If

        '-------------------------------------------------------------------------




        'Separando valores ---------------------------------------------------------------------------------------------------------------------------------------

        proc_separar_arrays_de_informacoes_sobre_historico() 'Separa arrays de informações de historico

        '---------------------------------------------------------------------------------------------------------------------------------------------------------




        'Varrendo e analizando -----------------------------------------------------------------------------------------------------------------------------------

        For v_contador = v_contador To array_lista_de_sites_visitados_url.Length


            'Comparando e analizando ------------------------------------------------------------------------------------------

            If (array_lista_de_sites_visitados_url(v_contador) = v_url) Then


                v_valor_de_retorno = array_lista_de_sites_visitados_titulo(v_contador) 'Obtendo valor de retorno

                Exit For 'Saindo do looping


            End If

            '------------------------------------------------------------------------------------------------------------------


        Next

        '---------------------------------------------------------------------------------------------------------------------------------------------------------




        'Retorno ------------------------------------------------------------


        Return v_valor_de_retorno 'Retorno

        '--------------------------------------------------------------------


    End Function









    'Trabalhando com o recurso autocompletar na barra de endereços

    '# INFORMADOS

    Public v_filtrar_dados_do_autocompletar As Boolean 'Informa se deve ou não filtrar dados do autocompletar

    Public v_filtro_informado_pelo_usuario_autocompletar As String = "" 'Informa o texto informado pelo usuario para o recurso de autocompletar




    '# FILTRADOS

    Public v_titulos_autocompletar_filtrados As String = "" 'Informa os titulos filtrados do recurso autocompletar

    Public v_urls_autocompletar_filtrados As String = "" 'Informa as urls filtrados do recurso autocompletar

    Dim v_pode_parar_thread As Boolean = True 'Informa se pode ou nao parar o thread




    '# THREAD

    Public V_MULTI_THREAD As Thread 'Multithread segundo plano










    'Procedimentos do recurso autocompletar

    Private Sub proc_criar_pagina_de_recurso_autocompletar_historico(ByVal v_url_do_historico As String, ByVal v_titulo_da_pagina As String) 'Cria a próxima página do recurso de autocompletar
        On Error Resume Next

        Dim v_index_da_imagem As Integer = FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.IndexOfKey(v_url_do_historico) 'Index da imagem do historico

        Dim v_comando_html_1 As String = "<a href=""" & v_url_do_historico & """>" & "<img src=""" & v_index_da_imagem & v_extencao_2 & """ title=""" & v_titulo_da_pagina & """ border=""1"">" & "</a>" & vbCrLf & vbCrLf 'Código html a ser adicionado

        Dim v_endereco_salvar_imagem_atualizada As String = V_PASTA_DE_CONFIGURACAO & "\" & v_index_da_imagem & v_extencao_2 'Obtendo endereço de imagem






        'Não permite titulo em branco ---------------------------------------

        If (v_titulo_da_pagina = Nothing) Then


            Exit Sub 'Saindo...


        End If

        '--------------------------------------------------------------------




        'Verifica se imagem existe e salva em caso de nao existir ------------------------------------------------------------------------------------------------

        If (My.Computer.FileSystem.FileExists(v_endereco_salvar_imagem_atualizada) = False) And (v_titulo_da_pagina <> Nothing) Then


            Dim obj_imagem_de_historico As Image = FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.Item(v_index_da_imagem) 'Obtendo a imagem

            obj_imagem_de_historico.Save(v_endereco_salvar_imagem_atualizada) 'Salvando nova imagem para atualização


        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------------




        'Salvando conteudo de html -------------------------------------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.WriteAllText(V_ARQ_PAGINA_DE_RECURSO_AUTO_COMPLETAR_HISTORICO, v_comando_html_1, True) 'Salvando...

        '---------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_abrir_pagina_de_recurso_autocompletar_historico() 'Abre a página do recurso de autocompletar do historico
        On Error Resume Next

        FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.Navigate(V_ARQ_PAGINA_DE_RECURSO_AUTO_COMPLETAR_HISTORICO) 'Abrindo arquivo de historico de autocompletar

    End Sub

    Public Sub proc_processar_dados_autocompletar_ja_filtrados() 'Processa os dados ja filtrados
        On Error Resume Next

        Dim OBJ_ITEM As ToolStripMenuItem 'Menu

        Dim array_tit As Array 'Array de titulo

        Dim array_url As Array 'Array de url

        Dim v_contador_1 As Integer 'Contador 1

        Dim v_contador_2 As Integer 'Contador 2

        'Criando coordenadas de inicialização do menu de contexto de sites visitados -----------------------------------------------------------------------

        Dim v_p As New Point(FRM_NAVEGACAO.ComboBoxEx1.Location.X - 155, FRM_NAVEGACAO.ComboBoxEx1.Location.Y + 11) 'Criando ponto de localização

        Dim v_ponto As New Point(FRM_NAVEGACAO.ComboBoxEx1.PointToScreen(v_p)) 'Ponto global

        '---------------------------------------------------------------------------------------------------------------------------------------------------

        Dim v_comando_html_1 As String = "<html>" & vbCrLf & "<head>" & vbCrLf & "<title>Resultados</title>" & vbCrLf & "</head>" & vbCrLf & "<body vlink='#99CCFF' link='#99CCFF' alink='#99CCFF'><br><center>" & vbCrLf

        Dim v_comando_html_2 As String = "</center><br></body>" & vbCrLf & "</html>" 'Código 2








        'Separando arrays agora ----------------------------------------------------------------------

        array_tit = Split(v_titulos_autocompletar_filtrados, v_separador_de_string_2) 'Titulo

        array_url = Split(v_urls_autocompletar_filtrados, v_separador_de_string_2) 'Url

        '---------------------------------------------------------------------------------------------




        'Inicializando contadores --------------------------------------------------------------------

        v_contador_1 = 0 'Contador 1

        v_contador_2 = array_tit.Length - 1 'Contador 2

        '---------------------------------------------------------------------------------------------




        'Limpando itens antigos ----------------------------------------------------------------------

        FRM_NAVEGACAO.mnu_autoCompletar.Items.Clear() 'Limpando...

        '---------------------------------------------------------------------------------------------




        'Não permitir adicionar itens em branco ------------------------------------------------------

        If (array_tit.Length <= 1) Then


            FRM_NAVEGACAO.mnu_autoCompletar.Close() 'Fechando caso ja esteje aberto

            Exit Sub


        End If

        '---------------------------------------------------------------------------------------------




        'Removendo arquivo antigo --------------------------------------------------------------------

        proc_remover_arquivo(V_ARQ_PAGINA_DE_RECURSO_AUTO_COMPLETAR_HISTORICO) 'Remove um arquivo

        '---------------------------------------------------------------------------------------------




        'Aplicando html inicial da página ---------------------------------------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.WriteAllText(V_ARQ_PAGINA_DE_RECURSO_AUTO_COMPLETAR_HISTORICO, v_comando_html_1, True) 'Aplicando codigo html

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Varrendo e adicionando novo item --------------------------------------------------------------------------------------------------------------------------------

        For v_contador_1 = v_contador_1 To v_contador_2




            If (array_url(v_contador_1) <> Nothing) And (array_url(v_contador_1) <> "") And (array_url(v_contador_1) <> "about:blank") Then




                'Adicionando item visitado -------------------------------------------------------------------------------------------------------------------------------

                If (v_contador_1 <= 9) Then


                    OBJ_ITEM = New ToolStripMenuItem 'Novo menu




                    OBJ_ITEM.ToolTipText = array_url(v_contador_1) 'Informando o tooltip

                    OBJ_ITEM.Text = array_tit(v_contador_1) & vbCrLf & array_url(v_contador_1) 'Texto

                    FRM_NAVEGACAO.mnu_autoCompletar.Items.Add("-") 'Separador

                    FRM_NAVEGACAO.mnu_autoCompletar.Items.Add(OBJ_ITEM) 'Adicionando novo item

                    FRM_NAVEGACAO.mnu_autoCompletar.Items.Add("-") 'Separador

                    Dim V_INDEX_IMAGEM As Integer = FRM_NAVEGACAO.LST_LISTA_DE_FAVICONS.Images.IndexOfKey(array_url(v_contador_1)) 'Obtendo o index do favicon

                    OBJ_ITEM.Image = FRM_NAVEGACAO.LST_LISTA_DE_FAVICONS.Images.Item(V_INDEX_IMAGEM) 'Repassando o index do favicon como imagem

                    '---------------------------------------------------------------------------------------------------------------------------------------------------------


                End If




                'Criando dados do recurso de autocompletar ---------------------------------------------------------------------------------------------------------------

                proc_criar_pagina_de_recurso_autocompletar_historico(array_url(v_contador_1), array_tit(v_contador_1)) 'Cria a próxima página do recurso de autocompletar

                '---------------------------------------------------------------------------------------------------------------------------------------------------------




            End If




        Next

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Aplicando html final da página -----------------------------------------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.WriteAllText(V_ARQ_PAGINA_DE_RECURSO_AUTO_COMPLETAR_HISTORICO, v_comando_html_2, True) 'Aplicando codigo html

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Definindo tamanho do autocomplete -----------------------------------------------------------

        FRM_NAVEGACAO.mnu_autoCompletar.Width = FRM_NAVEGACAO.ComboBoxEx1.Width + 67 'Tamanho do menu

        FRM_NAVEGACAO.mnu_autoCompletar.Height = (FRM_NAVEGACAO.Height * 0.7) 'Largura do menu

        '---------------------------------------------------------------------------------------------




        'Não permitir o autoclose --------------------------------------------------------------------

        FRM_NAVEGACAO.mnu_autoCompletar.AutoClose = False 'Não permite o autoclose

        '---------------------------------------------------------------------------------------------




        'Abrindo autocompletar -----------------------------------------------------------------------

        FRM_NAVEGACAO.mnu_autoCompletar.Show(v_ponto) 'Abrindo...

        '---------------------------------------------------------------------------------------------




        'Abrindo a página -------------------------------------------------------------------------------------------------------

        proc_abrir_pagina_de_recurso_autocompletar_historico() 'Abre a página do recurso de autocompletar do historico

        '------------------------------------------------------------------------------------------------------------------------













    End Sub

    Public Sub proc_separar_itens_recurso_autocompletar() 'Separa os itens do recurso de autocompletar
        On Error Resume Next

        Dim v_contador_1 As Integer 'Contador de inicio

        Dim v_contador_2 As Integer 'Contador de fim

        Dim v_texto_de_comparacao_1 As String = "" 'Informa o texto de comparaçao de filtro titulo

        Dim v_texto_de_comparacao_2 As String = "" 'Informa o texto de comparaçao de filtro url






        'Separando os arrays -----------------------------------------------------------------------------

        proc_separar_arrays_de_informacoes_sobre_historico() 'Separa arrays de informações de historico

        '-------------------------------------------------------------------------------------------------




        'Inicializando contadores --------------------------------------------------------------

        v_contador_1 = 0 'Contador de inicio

        v_contador_2 = array_lista_de_sites_visitados_titulo.Length 'Contador de fim

        '---------------------------------------------------------------------------------------




        'Zerando valores antigos ---------------------------------------------------------------

        v_titulos_autocompletar_filtrados = "" 'Títulos

        v_urls_autocompletar_filtrados = "" 'Urls

        '---------------------------------------------------------------------------------------




        'Informa que os itens devem ser filtrados ---------------------------------------------------------------------------------------------

        If (v_filtrar_dados_do_autocompletar = True) Then






            'Varrendo itens -------------------------------------------------------------------------------------------------------------------

            For v_contador_1 = v_contador_1 To v_contador_2




                'Informa que não pode parar o thread ------------------------------------------------------------------------------------------

                v_pode_parar_thread = False 'Informa que não pode parar o thread

                '------------------------------------------------------------------------------------------------------------------------------




                'Obtendo valores --------------------------------------------------------------------------------

                v_texto_de_comparacao_1 = array_lista_de_sites_visitados_titulo(v_contador_1) 'Título

                v_texto_de_comparacao_2 = array_lista_de_sites_visitados_url(v_contador_1) 'Url

                '------------------------------------------------------------------------------------------------




                'Verificando valor lido e comparando valores --------------------------------------------------------------------------------------------------------------------------------------------------------

                If (v_texto_de_comparacao_1.Contains(v_filtro_informado_pelo_usuario_autocompletar) = True) Or (v_texto_de_comparacao_2.Contains(v_filtro_informado_pelo_usuario_autocompletar) = True) Then



                    v_titulos_autocompletar_filtrados = v_titulos_autocompletar_filtrados & v_texto_de_comparacao_1 & v_separador_de_string_2 'Título

                    v_urls_autocompletar_filtrados = v_urls_autocompletar_filtrados & v_texto_de_comparacao_2 & v_separador_de_string_2 'Url



                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            Next

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------






        Else






            'Varrendo itens -------------------------------------------------------------------------------------------------------------------

            For v_contador_1 = v_contador_1 To v_contador_2




                'Obtendo valores --------------------------------------------------------------------------------

                v_texto_de_comparacao_1 = array_lista_de_sites_visitados_titulo(v_contador_1) 'Título

                v_texto_de_comparacao_2 = array_lista_de_sites_visitados_url(v_contador_1) 'Url

                '------------------------------------------------------------------------------------------------




                v_titulos_autocompletar_filtrados = v_titulos_autocompletar_filtrados & v_texto_de_comparacao_1 & v_separador_de_string_2 'Título

                v_urls_autocompletar_filtrados = v_urls_autocompletar_filtrados & v_texto_de_comparacao_2 & v_separador_de_string_2 'Url




            Next

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Informa que pode parar o thread -------------------------------------------------------------------------------------------------------------------------

        v_pode_parar_thread = True 'Informa que pode parar o thread

        '---------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_executador_auto_completar(ByVal v_filtrar As Boolean, ByVal v_filtro As String) 'Executador do autocompletar
        On Error Resume Next


        'Verifica se o modo geek está ativado --------------------------------------------------------------------------

        If (V_VAL_CONFIG_MODO_GEEK_ATIVADO = True) Then


            Exit Sub 'Saindo...


        End If

        '---------------------------------------------------------------------------------------------------------------




        'Removendo evento ----------------------------------------------------------------------------------------------------------------------------------------

        RemoveHandler FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.StatusTextChanged, AddressOf GECKO_MOTOR_DE_AUTO_COMPLETAR_HIST_STATUS_TEXT 'Add evento

        '---------------------------------------------------------------------------------------------------------------------------------------------------------




        'Definindo valores iniciais ----------------------------------------------------------------------------

        v_filtrar_dados_do_autocompletar = v_filtrar 'Utilizar filtro ou nao

        v_filtro_informado_pelo_usuario_autocompletar = v_filtro 'Informando o filtro

        '-------------------------------------------------------------------------------------------------------




        'Verifica se pode ou nao parar o thread ------------------------------------------------------------------------------------------------------------------

        If (v_pode_parar_thread = True) Then



            '---------------------------------------------------------------

            V_MULTI_THREAD.Abort() 'Termina thread já iniciado

            '---------------------------------------------------------------




            'Definindo valores de thread e executando --------------------------------------------------------------

            V_MULTI_THREAD = New Thread(AddressOf proc_separar_itens_recurso_autocompletar) 'Novo thread

            V_MULTI_THREAD.IsBackground = True 'Em plano de fundo

            V_MULTI_THREAD.Start() 'Iniciando thread

            '-------------------------------------------------------------------------------------------------------




            'Processa os dados filtrados ---------------------------------------------------------------------------

            proc_processar_dados_autocompletar_ja_filtrados() 'Processa os dados ja filtrados

            '-------------------------------------------------------------------------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    


    'Responsavel por gerar imagem do recurso autocompletar

    Private Sub proc_analisa_quantidade_de_itens_no_historico() 'Analisa a quantidade de itens no historico, e remove se necessário
        On Error Resume Next

        Dim v_quantidade_de_itens_atual As Integer 'Informa a quantidade de itens já no histórico

        Dim v_contador As Integer = 0 'Contador inicial






        'Obtendo valor de dados -------------------------------------------------------------------------------------------------

        v_quantidade_de_itens_atual = FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.Count 'Obtendo quantidade

        '------------------------------------------------------------------------------------------------------------------------





        'Verifica se a quantidade é maior ---------------------------------------------------------------------------------------

        If (v_quantidade_de_itens_atual >= v_quantidade_maxima_de_itens_de_historico_que_pode_ser_salvo) Then




            'Separando informcoes sobre historico -------------------------------------------------------------------------------

            proc_separar_arrays_de_informacoes_sobre_historico() 'Separa arrays de informações de historico

            '--------------------------------------------------------------------------------------------------------------------




            For v_contador = v_contador To v_quantidade_maxima_de_itens_de_historico_que_pode_ser_salvo


                Dim v_valor_a_remover_url As String = array_lista_de_sites_visitados_url(v_contador) 'Valor a remover

                Dim v_valor_a_remover_titulo As String = array_lista_de_sites_visitados_titulo(v_contador) 'Valor a remover

                Dim v_valor_a_remover_data As String = array_data_da_visita(v_contador) 'Valor a remover






                'Atualiza os valores das variáveis ---------------------------------------------------------------------------------------------------------------------------------------------

                v_lista_de_sites_visitados_titulo = v_lista_de_sites_visitados_titulo.Replace(v_valor_a_remover_titulo & v_separador_de_string_2, Nothing) 'Lista de títulos

                v_lista_de_sites_visitados_url = v_lista_de_sites_visitados_url.Replace(v_valor_a_remover_url & v_separador_de_string_2, Nothing) 'Lista de urls

                v_data_da_visita = v_data_da_visita.Replace(v_valor_a_remover_data & v_separador_de_string_2, Nothing) 'Lista de datas

                '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





                'Removendo imagens da lista ------------------------------------------------------------------------------------

                FRM_NAVEGACAO.LST_LISTA_DE_FAVICONS.Images.RemoveByKey(v_valor_a_remover_url) 'Removendo...

                FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.RemoveByKey(v_valor_a_remover_url) 'Removendo...

                '---------------------------------------------------------------------------------------------------------------




                'Removendo imagens em disco ------------------------------------------------------------------------------------------------------------------------------------------------------------------

                Dim v_endereco_da_imagem_de_hist_para_salvar_nova_img As String = V_PASTA_DE_CONFIGURACAO & "\" & v_contador & v_extencao_2 'Endereço de salvar a imagem

                Dim v_endereco_da_imagem_de_hist_para_salvar_nova_img_favicon As String = V_PASTA_DE_CONFIGURACAO & "\" & v_nome_generico_de_favicon & v_extencao_2 'Endereço de salvar a imagem




                proc_remover_arquivo(v_endereco_da_imagem_de_hist_para_salvar_nova_img) 'Remove um arquivo

                proc_remover_arquivo(v_endereco_da_imagem_de_hist_para_salvar_nova_img_favicon) 'Remove um arquivo

                '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





            Next




        End If

        '------------------------------------------------------------------------------------------------------------------------



    End Sub

    Public Sub Proc_atualizar_lista_de_favicons(ByVal OBJ_IMAGEM As Image, ByVal V_CHAVE_KEY As String) 'Atualiza o favicon na listagem
        On Error Resume Next


        'Nao permite adicionar chave nula ---------------------

        If (V_CHAVE_KEY = Nothing) Then

            Exit Sub 'Saindo do procedimento

        End If

        '------------------------------------------------------




        'Adicionando imagem a lista de imagens ----------------------------------------------------------------------------------------

        FRM_NAVEGACAO.LST_LISTA_DE_FAVICONS.Images.RemoveByKey(V_CHAVE_KEY) 'Removendo...

        FRM_NAVEGACAO.LST_LISTA_DE_FAVICONS.Images.Add(V_CHAVE_KEY, OBJ_IMAGEM) 'Adicionando imagem a lista...

        '------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_favicon_iniciar_gerar() 'Inicia o processo de gerar o favicon do site, na barra de endereços
        On Error Resume Next


        'Atualizando favicon ------------------------------------------------------------------------

        V_SITE_DO_FAVICON = func_retorne_o_site_em_aberto() 'Retorna o endereço do site em aberto

        FRM_NAVEGACAO.BCK_FAVICON_IMAGEM.CancelAsync() 'Cancela operação

        FRM_NAVEGACAO.BCK_FAVICON_IMAGEM.RunWorkerAsync() 'Atualizando

        '--------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_gerar_e_atualiza_imagem_do_historico_de_sites_visitados_pelo_navegador(ByVal v_titulo_img As String, ByVal v_url_img As String, ByVal v_data_img As String) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        On Error Resume Next

        Dim OBJ_IMAGEM As Image = Nothing 'Imagem a ser atualizada






        'Não permite atualizar itens nulos sem valor -----------------------------------------------------------------------------------------------------------------------------------------------------------

        If (v_titulo_img = Nothing) Or (v_url_img = Nothing) Or (v_data_img = Nothing) Or (v_tipo_de_motor_layout_engine_em_uso_agora = Nothing) Or (V_VAL_CONFIG_MODO_GEEK_ATIVADO = True) Then

            Exit Sub 'Saindo do procedimento

        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Gerando favicon -----------------------------------------------------------------------------------------------

        proc_favicon_iniciar_gerar() 'Inicia o processo de gerar o favicon do site, na barra de endereços

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo a imagem do historico -------------------------------------------------------------------------------------------------

        If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then


            OBJ_IMAGEM = func_gerar_imagem_da_pagina_motores_geckofx(v_qual_motor_esta_em_uso) 'Gera a imagem da página em visualização

            OBJ_IMAGEM = func_gerar_miniatura_de_imagem_obtida(256, OBJ_IMAGEM) 'Gera a miniatura da imagem baixada pelo navegador


        Else


            OBJ_IMAGEM = FRM_NAVEGACAO.LST_2.Images.Item(0) 'Obtendo a imagem

            OBJ_IMAGEM = func_gerar_miniatura_de_imagem_obtida(256, OBJ_IMAGEM) 'Gera a miniatura da imagem baixada pelo navegador


        End If

        '------------------------------------------------------------------------------------------------------------------------------




        'Nao permite adicionar duplicatas de sites e nem conteudo em branco -------------------------------------------------------------------------------------------------------------------

        If (v_lista_de_sites_visitados_url.Contains(v_url_img) = True) Or (v_url_img.Contains(V_PAGINA_EM_BRANCO_ABRIR) = True) Or (v_url_img = Nothing) Or (v_url_img = "") Then


            Exit Sub 'Saindo...


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Adicionando imagem a lista de imagens ----------------------------------------------------------------------------------------

        FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.RemoveByKey(v_url_img) 'Removendo...

        FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.Add(v_url_img, OBJ_IMAGEM) 'Adicionando imagem a lista...

        '------------------------------------------------------------------------------------------------------------------------------




        'Atualiza os valores das variáveis ---------------------------------------------------------------------------------------------

        v_lista_de_sites_visitados_titulo = v_lista_de_sites_visitados_titulo & v_titulo_img & v_separador_de_string_2 'Lista de títulos

        v_lista_de_sites_visitados_url = v_lista_de_sites_visitados_url & v_url_img & v_separador_de_string_2 'Lista de urls

        v_data_da_visita = v_data_da_visita & v_data_img & v_separador_de_string_2 'Lista de datas

        '-------------------------------------------------------------------------------------------------------------------------------




        'Não permite ultrapassar o valor máximo de itens no historico ---------------------------------------------------------------------------------------------

        proc_analisa_quantidade_de_itens_no_historico() 'Analisa a quantidade de itens no historico, e remove se necessário

        '----------------------------------------------------------------------------------------------------------------------------------------------------------














    End Sub

    Public Sub proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(ByVal v_titulo_img As String, ByVal v_url_img As String, ByVal v_data_img As String, ByVal v_numero_da_aba_escolhida As Integer) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        On Error Resume Next

        Dim OBJ_IMAGEM As Image = Nothing 'Imagem a ser atualizada






        'Atualizando dados de sessao ---------------------------------------------------------------------------------------------------

        proc_atualize_variaveis_de_sessao(v_url_img, v_numero_da_aba_escolhida) 'Atualiza as variáveis de sessao

        proc_salvar_sessao_de_navegacao_atual() 'Salva a sessão de navegação atual

        '-------------------------------------------------------------------------------------------------------------------------------




        'Gerando favicon -----------------------------------------------------------------------------------------------

        proc_favicon_iniciar_gerar() 'Inicia o processo de gerar o favicon do site, na barra de endereços

        '---------------------------------------------------------------------------------------------------------------




        'Nao permite adicionar duplicatas de sites e nem conteudo em branco ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (v_lista_de_sites_visitados_url.Contains(v_url_img) = True) Or (v_url_img.Contains(V_PAGINA_EM_BRANCO_ABRIR) = True) Or (v_url_img = Nothing) Or (v_url_img = "") Or (v_titulo_img = Nothing) Or (v_url_img = Nothing) Or (v_data_img = Nothing) Or (V_VAL_CONFIG_MODO_GEEK_ATIVADO = True) Then


            Exit Sub 'Saindo...


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Obtendo a imagem do historico -------------------------------------------------------------------------------------------------

        OBJ_IMAGEM = func_gerar_imagem_da_pagina_motores_geckofx(v_numero_da_aba_escolhida) 'Gera a imagem da página em visualização

        OBJ_IMAGEM = func_gerar_miniatura_de_imagem_obtida(256, OBJ_IMAGEM) 'Gera a miniatura da imagem baixada pelo navegador

        '------------------------------------------------------------------------------------------------------------------------------




        'Adicionando imagem a lista de imagens ----------------------------------------------------------------------------------------

        FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.RemoveByKey(v_url_img) 'Removendo...

        FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.Add(v_url_img, OBJ_IMAGEM) 'Adicionando imagem a lista...

        '------------------------------------------------------------------------------------------------------------------------------




        'Atualiza os valores das variáveis ---------------------------------------------------------------------------------------------

        v_lista_de_sites_visitados_titulo = v_lista_de_sites_visitados_titulo & v_titulo_img & v_separador_de_string_2 'Lista de títulos

        v_lista_de_sites_visitados_url = v_lista_de_sites_visitados_url & v_url_img & v_separador_de_string_2 'Lista de urls

        v_data_da_visita = v_data_da_visita & v_data_img & v_separador_de_string_2 'Lista de datas

        '-------------------------------------------------------------------------------------------------------------------------------




        'Não permite ultrapassar o valor máximo de itens no historico ---------------------------------------------------------------------------------------------

        proc_analisa_quantidade_de_itens_no_historico() 'Analisa a quantidade de itens no historico, e remove se necessário

        '----------------------------------------------------------------------------------------------------------------------------------------------------------















    End Sub

    Public Sub proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(ByVal v_titulo_img As String, ByVal v_url_img As String, ByVal v_data_img As String, ByVal v_numero_da_aba_escolhida As Integer) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        On Error Resume Next

        Dim OBJ_IMAGEM As Image = Nothing 'Imagem a ser atualizada






        'Atualizando dados de sessao ---------------------------------------------------------------------------------------------------

        proc_atualize_variaveis_de_sessao(v_url_img, v_numero_da_aba_escolhida) 'Atualiza as variáveis de sessao

        proc_salvar_sessao_de_navegacao_atual() 'Salva a sessão de navegação atual

        '-------------------------------------------------------------------------------------------------------------------------------




        'Gerando favicon -----------------------------------------------------------------------------------------------

        proc_favicon_iniciar_gerar() 'Inicia o processo de gerar o favicon do site, na barra de endereços

        '---------------------------------------------------------------------------------------------------------------




        'Nao permite adicionar duplicatas de sites e nem conteudo em branco ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (v_lista_de_sites_visitados_url.Contains(v_url_img) = True) Or (v_url_img.Contains(V_PAGINA_EM_BRANCO_ABRIR) = True) Or (v_url_img = Nothing) Or (v_url_img = "") Or (v_titulo_img = Nothing) Or (v_url_img = Nothing) Or (v_data_img = Nothing) Or (V_VAL_CONFIG_MODO_GEEK_ATIVADO = True) Then


            Exit Sub 'Saindo...


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Obtendo a imagem do historico -------------------------------------------------------------------------------------------------

        OBJ_IMAGEM = FRM_NAVEGACAO.LST_2.Images.Item(0) 'Obtendo a imagem

        OBJ_IMAGEM = func_gerar_miniatura_de_imagem_obtida(256, OBJ_IMAGEM) 'Gera a miniatura da imagem baixada pelo navegador

        '------------------------------------------------------------------------------------------------------------------------------




        'Adicionando imagem a lista de imagens ----------------------------------------------------------------------------------------

        FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.RemoveByKey(v_url_img) 'Removendo...

        FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.Add(v_url_img, OBJ_IMAGEM) 'Adicionando imagem a lista...

        '------------------------------------------------------------------------------------------------------------------------------




        'Atualiza os valores das variáveis ---------------------------------------------------------------------------------------------

        v_lista_de_sites_visitados_titulo = v_lista_de_sites_visitados_titulo & v_titulo_img & v_separador_de_string_2 'Lista de títulos

        v_lista_de_sites_visitados_url = v_lista_de_sites_visitados_url & v_url_img & v_separador_de_string_2 'Lista de urls

        v_data_da_visita = v_data_da_visita & v_data_img & v_separador_de_string_2 'Lista de datas

        '-------------------------------------------------------------------------------------------------------------------------------




        'Não permite ultrapassar o valor máximo de itens no historico ---------------------------------------------------------------------------------------------

        proc_analisa_quantidade_de_itens_no_historico() 'Analisa a quantidade de itens no historico, e remove se necessário

        '----------------------------------------------------------------------------------------------------------------------------------------------------------















    End Sub










    'Remover todo o historico com um único comando

    Public Sub proc_remover_todo_o_historico_de_navegacao() 'Remove todo o historico de navegação
        On Error Resume Next


        'Limpando variáveis -----------------------------------------------------------------------------------------

        v_lista_de_sites_visitados_titulo = Nothing 'Limpando variável

        v_lista_de_sites_visitados_url = Nothing 'Limpando variável

        v_data_da_visita = Nothing 'Limpando variável

        v_datas_diferentes = Nothing 'Limpando variável

        array_lista_de_sites_visitados_titulo = Nothing 'Limpando variável

        array_lista_de_sites_visitados_url = Nothing 'Limpando variável

        array_data_da_visita = Nothing 'Limpando variável

        '------------------------------------------------------------------------------------------------------------




        'Limpando controles -----------------------------------------------------------------------------------------

        FRM_NAVEGACAO.LST_LISTA_DE_FAVICONS.Images.Clear() 'Limpando controle

        FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.Clear() 'Limpando controle

        '------------------------------------------------------------------------------------------------------------




        'Limpando arquivos ------------------------------------------------------------------------------------------


        '# LIMPANDO...

        My.Computer.FileSystem.DeleteFile(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_TITULO) 'Titulo

        My.Computer.FileSystem.DeleteFile(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_URL) 'Url

        My.Computer.FileSystem.DeleteFile(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_DATA) 'Data

        My.Computer.FileSystem.DeleteFile(V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_NOMES_IMAGENS_SALVAS) 'Key de imagem

        '------------------------------------------------------------------------------------------------------------




        'Informa para limpar os arquivos na proxima inicializacao ------------------------------------------------------

        proc_salvar_valor(True, V_ARQ_LIMPAR_DADOS_NAVEGACAO) 'Salva a configuração

        '---------------------------------------------------------------------------------------------------------------




        'Informa para limpar os arquivos na proxima inicializacao ------------------------------------------------------

        proc_salvar_valor(True, V_ARQ_LIMPAR_DADOS_NAVEGACAO_HISTORICO) 'Salva a configuração

        '---------------------------------------------------------------------------------------------------------------




        'Mensagem ao usuário ----------------------------------------------------------------------------------------

        MsgBox(V_MS_33, MsgBoxStyle.Information) 'Mensagem ao usuário

        '------------------------------------------------------------------------------------------------------------


    End Sub








    


























End Module
