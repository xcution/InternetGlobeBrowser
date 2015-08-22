Module Modulo_propriedades_tempo_de_execucao




    'Propriedades quando o carregamento estiver completo

    Private Sub proc_ocultar_barras_de_progresso_form_navegacao() 'Oculta as barras de progresso do formulario de navegação
        On Error Resume Next

        FRM_NAVEGACAO.ProgressBarX1.Visible = False 'Desabilita

        FRM_NAVEGACAO.ToolStripProgressBar1.Visible = False 'Desabilita

    End Sub

    Public Sub proc_exibir_barra_de_progresso_status_form_navegacao() 'Exibe a barra de progresso na barra de status
        On Error Resume Next

        FRM_NAVEGACAO.ToolStripProgressBar1.Visible = True 'Habilita

    End Sub

    Public Sub proc_informe_com_voz_sobre_carregamento_do_site() 'Informa com voz sobre o carregamento do site
        On Error Resume Next

        Dim v_endereco_bruto_url As String = func_retorne_o_site_em_aberto() 'Retorna o endereço do site em aberto

        v_endereco_bruto_url = v_endereco_bruto_url.ToLower 'Converte para minusculo

        Dim V_URL_ABSOLUTA As New Uri(v_endereco_bruto_url) 'Obtém a url absoluta do site

        Dim V_HOST_DO_SITE As String = V_URL_ABSOLUTA.Host 'Obtém o host do site

        Dim V_MENSAGEM_USUARIO_INFORME_1 As String = V_MS_26 & V_HOST_DO_SITE & V_MS_27 'Mensagem ao usuário

        Dim V_MENSAGEM_USUARIO_INFORME_2 As String = V_MS_26 & V_HOST_DO_SITE & V_MS_28 'Mensagem ao usuário

        Static V_ULTIMO_HOST_VISITADO As String 'Informa o endereço do ultimo host visitado






        'Analizador de condições ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_ULTIMO_HOST_VISITADO = V_HOST_DO_SITE) Or (V_URL_ABSOLUTA = Nothing) Or (V_HOST_DO_SITE = Nothing) Or (v_endereco_bruto_url = Nothing) Or (v_endereco_bruto_url = "about:blank") Or (V_VAL_CONFIG_INFORME_VOZ_ABRIR_SITE = False) Then


            Exit Sub 'Saindo...


        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Lendo informação ao usuário ---------------------------------------------------------------------------------------------------------------------------------------------------------------------


        If (v_endereco_bruto_url.StartsWith("https://") = True) Then


            proc_falar_texto_repassado_recurso_de_voz_direto(V_MENSAGEM_USUARIO_INFORME_1) 'Procedimento para leitura de texto repassado pelo usuário, sem saida ou entrada na caixa de texto.


        Else


            proc_falar_texto_repassado_recurso_de_voz_direto(V_MENSAGEM_USUARIO_INFORME_2) 'Procedimento para leitura de texto repassado pelo usuário, sem saida ou entrada na caixa de texto.


        End If


        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Atualizando endereço do ultimo host visitado ------------------------------------------------------------------

        V_ULTIMO_HOST_VISITADO = V_HOST_DO_SITE 'Atualizando...

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_informe_endereco_de_site_seguro_barra_de_status() 'Informa se o endereço do site em visualização é seguro, ou nao
        On Error Resume Next

        Dim V_SITE_EM_VISUALIZACAO As String = func_retorne_o_site_em_aberto() 'Retorna o endereço do site em aberto

        V_SITE_EM_VISUALIZACAO = V_SITE_EM_VISUALIZACAO.ToLower 'Converter para minusculo






        'Analizando ----------------------------------------------------------------------------------------------------

        If (V_SITE_EM_VISUALIZACAO.StartsWith("https://") = True) Then



            FRM_NAVEGACAO.ToolStripStatusLabel3.Image = FRM_NAVEGACAO.LST_3.Images.Item(3) 'Seguro



        Else



            FRM_NAVEGACAO.ToolStripStatusLabel3.Image = FRM_NAVEGACAO.LST_3.Images.Item(4) 'Inseguro



        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(ByVal v_item_a_atualizar As Integer) 'Atualiza propriedades pos carregamento do motor geckofx
        On Error Resume Next

        Dim v_titulo_da_pagina As String = Nothing 'Informa o titulo da página

        Dim v_url_da_pagina As String = Nothing 'Informa a url da página






        'Analizador de propriedades ------------------------------------------------------------------------------------------------

        If (V_PODE_CONTINUAR_EXECUTANDO_PROCEDIMENTOS_NORMAIS = False) Or (V_VAL_CONFIG_MODO_GEEK_ATIVADO = True) Then

            Exit Sub 'Saindo...

        End If

        '---------------------------------------------------------------------------------------------------------------------------




        'Selecionando motor e aplicando propriedades alteradas ---------------------------------------------------------

        Select Case v_item_a_atualizar


            Case 1
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_1.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_1.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_1.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_1.DocumentTitle 'Titulo da página
                tab1.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 2
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_2.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_2.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_2.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_2.DocumentTitle 'Titulo da página
                tab2.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 3
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_3.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_3.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_3.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_3.DocumentTitle 'Titulo da página
                tab3.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 4
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_4.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_4.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_4.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_4.DocumentTitle 'Titulo da página
                tab4.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 5
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_5.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_5.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_5.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_5.DocumentTitle 'Titulo da página
                tab5.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 6
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_6.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_6.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_6.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_6.DocumentTitle 'Titulo da página
                tab6.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 7
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_7.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_7.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_7.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_7.DocumentTitle 'Titulo da página
                tab7.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 8
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_8.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_8.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_8.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_8.DocumentTitle 'Titulo da página
                tab8.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 9
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_9.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_9.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_9.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_9.DocumentTitle 'Titulo da página
                tab9.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 10
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_10.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_10.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_10.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_10.DocumentTitle 'Titulo da página
                tab10.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 11
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_11.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_11.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_11.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_11.DocumentTitle 'Titulo da página
                tab11.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 12
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_12.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_12.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_12.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_12.DocumentTitle 'Titulo da página
                tab12.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 13
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_13.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_13.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_13.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_13.DocumentTitle 'Titulo da página
                tab13.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 14
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_14.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_14.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_14.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_14.DocumentTitle 'Titulo da página
                tab14.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 15
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_15.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_15.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_15.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_15.DocumentTitle 'Titulo da página
                tab15.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 16
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_16.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_16.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_16.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_16.DocumentTitle 'Titulo da página
                tab16.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 17
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_17.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_17.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_17.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_17.DocumentTitle 'Titulo da página
                tab17.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 18
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_18.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_18.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_18.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_18.DocumentTitle 'Titulo da página
                tab18.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 19
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_19.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_19.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_19.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_19.DocumentTitle 'Titulo da página
                tab19.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 20
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_20.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_20.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_20.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_20.DocumentTitle 'Titulo da página
                tab20.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 21
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_21.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_21.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_21.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_21.DocumentTitle 'Titulo da página
                tab21.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 22
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_22.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_22.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_22.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_22.DocumentTitle 'Titulo da página
                tab22.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 23
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_23.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_23.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_23.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_23.DocumentTitle 'Titulo da página
                tab23.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 24
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_24.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_24.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_24.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_24.DocumentTitle 'Titulo da página
                tab24.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 25
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_25.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_25.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_25.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_25.DocumentTitle 'Titulo da página
                tab25.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 26
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_26.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_26.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_26.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_26.DocumentTitle 'Titulo da página
                tab26.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 27
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_27.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_27.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_27.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_27.DocumentTitle 'Titulo da página
                tab27.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 28
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_28.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_28.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_28.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_28.DocumentTitle 'Titulo da página
                tab28.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 29
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_29.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_29.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_29.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_29.DocumentTitle 'Titulo da página
                tab29.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 30
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_30.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_30.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_30.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_30.DocumentTitle 'Titulo da página
                tab30.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 31
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_31.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_31.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_31.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_31.DocumentTitle 'Titulo da página
                tab31.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 32
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_32.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_32.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_32.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_32.DocumentTitle 'Titulo da página
                tab32.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 33
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_33.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_33.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_33.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_33.DocumentTitle 'Titulo da página
                tab33.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 34
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_34.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_34.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_34.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_34.DocumentTitle 'Titulo da página
                tab34.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 35
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_35.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_35.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_35.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_35.DocumentTitle 'Titulo da página
                tab35.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 36
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_36.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_36.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_36.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_36.DocumentTitle 'Titulo da página
                tab36.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 37
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_37.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_37.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_37.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_37.DocumentTitle 'Titulo da página
                tab37.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 38
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_38.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_38.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_38.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_38.DocumentTitle 'Titulo da página
                tab38.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 39
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_39.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_39.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_39.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_39.DocumentTitle 'Titulo da página
                tab39.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 40
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_40.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_40.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_40.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_40.DocumentTitle 'Titulo da página
                tab40.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 41
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_41.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_41.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_41.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_41.DocumentTitle 'Titulo da página
                tab41.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 42
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_42.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_42.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_42.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_42.DocumentTitle 'Titulo da página
                tab42.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 43
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_43.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_43.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_43.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_43.DocumentTitle 'Titulo da página
                tab43.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 44
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_44.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_44.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_44.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_44.DocumentTitle 'Titulo da página
                tab44.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 45
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_45.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_45.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_45.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_45.DocumentTitle 'Titulo da página
                tab45.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 46
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_46.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_46.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_46.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_46.DocumentTitle 'Titulo da página
                tab46.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 47
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_47.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_47.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_47.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_47.DocumentTitle 'Titulo da página
                tab47.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 48
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_48.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_48.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_48.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_48.DocumentTitle 'Titulo da página
                tab48.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 49
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_49.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_49.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_49.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_49.DocumentTitle 'Titulo da página
                tab49.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 50
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_50.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_50.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_50.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_50.DocumentTitle 'Titulo da página
                tab50.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 51
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_51.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_51.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_51.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_51.DocumentTitle 'Titulo da página
                tab51.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 52
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_52.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_52.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_52.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_52.DocumentTitle 'Titulo da página
                tab52.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 53
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_53.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_53.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_53.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_53.DocumentTitle 'Titulo da página
                tab53.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 54
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_54.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_54.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_54.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_54.DocumentTitle 'Titulo da página
                tab54.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 55
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_55.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_55.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_55.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_55.DocumentTitle 'Titulo da página
                tab55.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 56
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_56.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_56.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_56.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_56.DocumentTitle 'Titulo da página
                tab56.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 57
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_57.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_57.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_57.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_57.DocumentTitle 'Titulo da página
                tab57.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 58
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_58.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_58.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_58.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_58.DocumentTitle 'Titulo da página
                tab58.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 59
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_59.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_59.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_59.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_59.DocumentTitle 'Titulo da página
                tab59.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 60
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_60.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_60.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_60.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_60.DocumentTitle 'Titulo da página
                tab60.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 61
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_61.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_61.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_61.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_61.DocumentTitle 'Titulo da página
                tab61.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 62
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_62.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_62.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_62.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_62.DocumentTitle 'Titulo da página
                tab62.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 63
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_63.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_63.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_63.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_63.DocumentTitle 'Titulo da página
                tab63.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 64
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_64.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_64.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_64.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_64.DocumentTitle 'Titulo da página
                tab64.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 65
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_65.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_65.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_65.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_65.DocumentTitle 'Titulo da página
                tab65.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 66
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_66.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_66.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_66.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_66.DocumentTitle 'Titulo da página
                tab66.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 67
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_67.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_67.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_67.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_67.DocumentTitle 'Titulo da página
                tab67.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 68
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_68.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_68.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_68.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_68.DocumentTitle 'Titulo da página
                tab68.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 69
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_69.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_69.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_69.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_69.DocumentTitle 'Titulo da página
                tab69.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 70
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_70.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_70.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_70.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_70.DocumentTitle 'Titulo da página
                tab70.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 71
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_71.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_71.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_71.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_71.DocumentTitle 'Titulo da página
                tab71.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 72
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_72.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_72.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_72.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_72.DocumentTitle 'Titulo da página
                tab72.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 73
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_73.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_73.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_73.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_73.DocumentTitle 'Titulo da página
                tab73.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 74
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_74.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_74.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_74.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_74.DocumentTitle 'Titulo da página
                tab74.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 75
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_75.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_75.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_75.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_75.DocumentTitle 'Titulo da página
                tab75.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 76
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_76.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_76.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_76.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_76.DocumentTitle 'Titulo da página
                tab76.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 77
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_77.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_77.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_77.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_77.DocumentTitle 'Titulo da página
                tab77.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 78
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_78.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_78.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_78.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_78.DocumentTitle 'Titulo da página
                tab78.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 79
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_79.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_79.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_79.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_79.DocumentTitle 'Titulo da página
                tab79.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 80
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_80.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_80.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_80.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_80.DocumentTitle 'Titulo da página
                tab80.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 81
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_81.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_81.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_81.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_81.DocumentTitle 'Titulo da página
                tab81.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 82
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_82.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_82.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_82.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_82.DocumentTitle 'Titulo da página
                tab82.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 83
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_83.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_83.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_83.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_83.DocumentTitle 'Titulo da página
                tab83.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 84
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_84.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_84.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_84.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_84.DocumentTitle 'Titulo da página
                tab84.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 85
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_85.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_85.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_85.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_85.DocumentTitle 'Titulo da página
                tab85.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 86
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_86.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_86.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_86.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_86.DocumentTitle 'Titulo da página
                tab86.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 87
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_87.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_87.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_87.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_87.DocumentTitle 'Titulo da página
                tab87.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 88
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_88.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_88.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_88.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_88.DocumentTitle 'Titulo da página
                tab88.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 89
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_89.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_89.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_89.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_89.DocumentTitle 'Titulo da página
                tab89.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 90
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_90.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_90.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_90.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_90.DocumentTitle 'Titulo da página
                tab90.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 91
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_91.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_91.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_91.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_91.DocumentTitle 'Titulo da página
                tab91.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 92
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_92.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_92.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_92.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_92.DocumentTitle 'Titulo da página
                tab92.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 93
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_93.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_93.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_93.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_93.DocumentTitle 'Titulo da página
                tab93.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 94
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_94.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_94.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_94.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_94.DocumentTitle 'Titulo da página
                tab94.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 95
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_95.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_95.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_95.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_95.DocumentTitle 'Titulo da página
                tab95.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 96
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_96.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_96.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_96.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_96.DocumentTitle 'Titulo da página
                tab96.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 97
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_97.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_97.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_97.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_97.DocumentTitle 'Titulo da página
                tab97.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 98
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_98.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_98.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_98.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_98.DocumentTitle 'Titulo da página
                tab98.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 99
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_99.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_99.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_99.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_99.DocumentTitle 'Titulo da página
                tab99.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 100
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_100.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_100.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_100.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_100.DocumentTitle 'Titulo da página
                tab100.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 101
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_101.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_101.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_101.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_101.DocumentTitle 'Titulo da página
                tab101.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 102
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_102.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_102.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_102.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_102.DocumentTitle 'Titulo da página
                tab102.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 103
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_103.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_103.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_103.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_103.DocumentTitle 'Titulo da página
                tab103.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 104
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_104.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_104.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_104.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_104.DocumentTitle 'Titulo da página
                tab104.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 105
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_105.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_105.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_105.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_105.DocumentTitle 'Titulo da página
                tab105.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 106
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_106.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_106.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_106.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_106.DocumentTitle 'Titulo da página
                tab106.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 107
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_107.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_107.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_107.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_107.DocumentTitle 'Titulo da página
                tab107.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 108
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_108.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_108.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_108.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_108.DocumentTitle 'Titulo da página
                tab108.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 109
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_109.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_109.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_109.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_109.DocumentTitle 'Titulo da página
                tab109.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 110
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_110.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_110.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_110.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_110.DocumentTitle 'Titulo da página
                tab110.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 111
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_111.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_111.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_111.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_111.DocumentTitle 'Titulo da página
                tab111.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 112
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_112.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_112.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_112.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_112.DocumentTitle 'Titulo da página
                tab112.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 113
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_113.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_113.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_113.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_113.DocumentTitle 'Titulo da página
                tab113.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 114
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_114.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_114.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_114.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_114.DocumentTitle 'Titulo da página
                tab114.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 115
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_115.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_115.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_115.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_115.DocumentTitle 'Titulo da página
                tab115.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 116
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_116.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_116.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_116.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_116.DocumentTitle 'Titulo da página
                tab116.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 117
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_117.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_117.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_117.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_117.DocumentTitle 'Titulo da página
                tab117.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 118
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_118.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_118.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_118.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_118.DocumentTitle 'Titulo da página
                tab118.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 119
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_119.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_119.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_119.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_119.DocumentTitle 'Titulo da página
                tab119.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 120
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_120.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_120.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_120.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_120.DocumentTitle 'Titulo da página
                tab120.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 121
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_121.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_121.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_121.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_121.DocumentTitle 'Titulo da página
                tab121.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 122
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_122.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_122.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_122.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_122.DocumentTitle 'Titulo da página
                tab122.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 123
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_123.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_123.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_123.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_123.DocumentTitle 'Titulo da página
                tab123.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 124
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_124.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_124.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_124.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_124.DocumentTitle 'Titulo da página
                tab124.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 125
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_125.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_125.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_125.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_125.DocumentTitle 'Titulo da página
                tab125.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 126
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_126.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_126.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_126.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_126.DocumentTitle 'Titulo da página
                tab126.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 127
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_127.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_127.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_127.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_127.DocumentTitle 'Titulo da página
                tab127.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 128
                v_url_da_pagina = OBJ_MOTOR_GECKOFX_128.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_GECKOFX_128.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_GECKOFX_128.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_GECKOFX_128.DocumentTitle 'Titulo da página
                tab128.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select






        End Select

        '---------------------------------------------------------------------------------------------------------------




        'Informar sobre o carregamento do site com voz -----------------------------------------------------------------

        proc_informe_com_voz_sobre_carregamento_do_site() 'Informa com voz sobre o carregamento do site

        '---------------------------------------------------------------------------------------------------------------




        'Informa se o site é ou nao seguro ---------------------------------------------------------------------------------------------------------

        proc_informe_endereco_de_site_seguro_barra_de_status() 'Informa se o endereço do site em visualização é seguro, ou nao

        '-------------------------------------------------------------------------------------------------------------------------------------------




        'Atualiza o texto da aba -------------------------------------------------------------------------------------------------------------------------

        Proc_atualize_texto_referencia_de_aba(v_item_a_atualizar) 'Atualiza o texto da referencia da aba

        '-------------------------------------------------------------------------------------------------------------------------------------------------




        'Atualizando o titulo agora ------------------------------------------------------------------------------------

        FRM_NAVEGACAO.Text = v_titulo_da_pagina & v_versao_do_navegador 'Titulo da página

        '---------------------------------------------------------------------------------------------------------------




        'Atualizando a barra de endereços agora ------------------------------------------------------------------------

        If (FRM_NAVEGACAO.ComboBoxEx1.Focused = False) Then


            FRM_NAVEGACAO.ComboBoxEx1.Text = v_url_da_pagina 'Informando a url da página


        End If

        '---------------------------------------------------------------------------------------------------------------




        'Ocultar barras de progresso -----------------------------------------------------------------------------------

        proc_ocultar_barras_de_progresso_form_navegacao() 'Oculta as barras de progresso do formulario de navegação

        '---------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(ByVal v_item_a_atualizar As Integer) 'Atualiza propriedades pos carregamento do motor trident
        On Error Resume Next

        Dim v_titulo_da_pagina As String = Nothing 'Informa o titulo da página

        Dim v_url_da_pagina As String = Nothing 'Informa a url da página






        'Analizador de propriedades ------------------------------------------------------------------------------------------------

        If (V_PODE_CONTINUAR_EXECUTANDO_PROCEDIMENTOS_NORMAIS = False) Or (V_VAL_CONFIG_MODO_GEEK_ATIVADO = True) Then

            Exit Sub 'Saindo...

        End If

        '---------------------------------------------------------------------------------------------------------------------------




        'Selecionando motor e aplicando propriedades alteradas ---------------------------------------------------------

        Select Case v_item_a_atualizar


            Case 1
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_1.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_1.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_1.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_1.DocumentTitle 'Titulo da página
                tab1.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 2
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_2.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_2.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_2.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_2.DocumentTitle 'Titulo da página
                tab2.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 3
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_3.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_3.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_3.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_3.DocumentTitle 'Titulo da página
                tab3.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 4
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_4.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_4.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_4.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_4.DocumentTitle 'Titulo da página
                tab4.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 5
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_5.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_5.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_5.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_5.DocumentTitle 'Titulo da página
                tab5.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 6
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_6.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_6.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_6.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_6.DocumentTitle 'Titulo da página
                tab6.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 7
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_7.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_7.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_7.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_7.DocumentTitle 'Titulo da página
                tab7.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 8
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_8.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_8.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_8.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_8.DocumentTitle 'Titulo da página
                tab8.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 9
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_9.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_9.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_9.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_9.DocumentTitle 'Titulo da página
                tab9.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 10
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_10.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_10.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_10.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_10.DocumentTitle 'Titulo da página
                tab10.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 11
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_11.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_11.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_11.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_11.DocumentTitle 'Titulo da página
                tab11.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 12
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_12.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_12.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_12.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_12.DocumentTitle 'Titulo da página
                tab12.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 13
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_13.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_13.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_13.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_13.DocumentTitle 'Titulo da página
                tab13.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 14
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_14.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_14.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_14.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_14.DocumentTitle 'Titulo da página
                tab14.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 15
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_15.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_15.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_15.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_15.DocumentTitle 'Titulo da página
                tab15.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 16
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_16.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_16.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_16.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_16.DocumentTitle 'Titulo da página
                tab16.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 17
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_17.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_17.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_17.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_17.DocumentTitle 'Titulo da página
                tab17.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 18
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_18.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_18.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_18.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_18.DocumentTitle 'Titulo da página
                tab18.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 19
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_19.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_19.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_19.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_19.DocumentTitle 'Titulo da página
                tab19.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 20
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_20.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_20.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_20.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_20.DocumentTitle 'Titulo da página
                tab20.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 21
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_21.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_21.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_21.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_21.DocumentTitle 'Titulo da página
                tab21.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 22
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_22.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_22.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_22.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_22.DocumentTitle 'Titulo da página
                tab22.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 23
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_23.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_23.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_23.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_23.DocumentTitle 'Titulo da página
                tab23.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 24
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_24.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_24.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_24.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_24.DocumentTitle 'Titulo da página
                tab24.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 25
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_25.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_25.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_25.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_25.DocumentTitle 'Titulo da página
                tab25.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 26
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_26.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_26.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_26.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_26.DocumentTitle 'Titulo da página
                tab26.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 27
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_27.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_27.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_27.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_27.DocumentTitle 'Titulo da página
                tab27.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 28
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_28.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_28.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_28.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_28.DocumentTitle 'Titulo da página
                tab28.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 29
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_29.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_29.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_29.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_29.DocumentTitle 'Titulo da página
                tab29.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 30
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_30.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_30.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_30.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_30.DocumentTitle 'Titulo da página
                tab30.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 31
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_31.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_31.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_31.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_31.DocumentTitle 'Titulo da página
                tab31.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 32
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_32.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_32.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_32.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_32.DocumentTitle 'Titulo da página
                tab32.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 33
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_33.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_33.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_33.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_33.DocumentTitle 'Titulo da página
                tab33.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 34
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_34.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_34.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_34.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_34.DocumentTitle 'Titulo da página
                tab34.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 35
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_35.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_35.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_35.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_35.DocumentTitle 'Titulo da página
                tab35.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 36
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_36.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_36.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_36.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_36.DocumentTitle 'Titulo da página
                tab36.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 37
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_37.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_37.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_37.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_37.DocumentTitle 'Titulo da página
                tab37.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 38
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_38.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_38.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_38.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_38.DocumentTitle 'Titulo da página
                tab38.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 39
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_39.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_39.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_39.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_39.DocumentTitle 'Titulo da página
                tab39.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 40
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_40.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_40.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_40.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_40.DocumentTitle 'Titulo da página
                tab40.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 41
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_41.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_41.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_41.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_41.DocumentTitle 'Titulo da página
                tab41.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 42
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_42.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_42.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_42.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_42.DocumentTitle 'Titulo da página
                tab42.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 43
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_43.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_43.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_43.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_43.DocumentTitle 'Titulo da página
                tab43.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 44
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_44.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_44.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_44.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_44.DocumentTitle 'Titulo da página
                tab44.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 45
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_45.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_45.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_45.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_45.DocumentTitle 'Titulo da página
                tab45.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 46
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_46.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_46.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_46.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_46.DocumentTitle 'Titulo da página
                tab46.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 47
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_47.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_47.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_47.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_47.DocumentTitle 'Titulo da página
                tab47.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 48
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_48.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_48.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_48.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_48.DocumentTitle 'Titulo da página
                tab48.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 49
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_49.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_49.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_49.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_49.DocumentTitle 'Titulo da página
                tab49.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 50
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_50.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_50.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_50.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_50.DocumentTitle 'Titulo da página
                tab50.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 51
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_51.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_51.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_51.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_51.DocumentTitle 'Titulo da página
                tab51.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 52
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_52.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_52.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_52.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_52.DocumentTitle 'Titulo da página
                tab52.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 53
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_53.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_53.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_53.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_53.DocumentTitle 'Titulo da página
                tab53.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 54
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_54.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_54.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_54.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_54.DocumentTitle 'Titulo da página
                tab54.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 55
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_55.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_55.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_55.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_55.DocumentTitle 'Titulo da página
                tab55.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 56
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_56.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_56.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_56.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_56.DocumentTitle 'Titulo da página
                tab56.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 57
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_57.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_57.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_57.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_57.DocumentTitle 'Titulo da página
                tab57.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 58
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_58.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_58.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_58.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_58.DocumentTitle 'Titulo da página
                tab58.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 59
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_59.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_59.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_59.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_59.DocumentTitle 'Titulo da página
                tab59.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 60
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_60.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_60.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_60.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_60.DocumentTitle 'Titulo da página
                tab60.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 61
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_61.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_61.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_61.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_61.DocumentTitle 'Titulo da página
                tab61.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 62
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_62.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_62.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_62.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_62.DocumentTitle 'Titulo da página
                tab62.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 63
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_63.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_63.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_63.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_63.DocumentTitle 'Titulo da página
                tab63.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 64
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_64.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_64.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_64.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_64.DocumentTitle 'Titulo da página
                tab64.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 65
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_65.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_65.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_65.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_65.DocumentTitle 'Titulo da página
                tab65.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 66
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_66.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_66.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_66.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_66.DocumentTitle 'Titulo da página
                tab66.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 67
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_67.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_67.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_67.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_67.DocumentTitle 'Titulo da página
                tab67.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 68
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_68.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_68.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_68.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_68.DocumentTitle 'Titulo da página
                tab68.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 69
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_69.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_69.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_69.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_69.DocumentTitle 'Titulo da página
                tab69.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 70
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_70.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_70.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_70.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_70.DocumentTitle 'Titulo da página
                tab70.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 71
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_71.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_71.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_71.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_71.DocumentTitle 'Titulo da página
                tab71.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 72
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_72.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_72.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_72.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_72.DocumentTitle 'Titulo da página
                tab72.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 73
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_73.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_73.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_73.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_73.DocumentTitle 'Titulo da página
                tab73.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 74
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_74.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_74.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_74.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_74.DocumentTitle 'Titulo da página
                tab74.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 75
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_75.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_75.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_75.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_75.DocumentTitle 'Titulo da página
                tab75.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 76
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_76.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_76.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_76.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_76.DocumentTitle 'Titulo da página
                tab76.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 77
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_77.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_77.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_77.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_77.DocumentTitle 'Titulo da página
                tab77.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 78
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_78.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_78.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_78.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_78.DocumentTitle 'Titulo da página
                tab78.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 79
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_79.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_79.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_79.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_79.DocumentTitle 'Titulo da página
                tab79.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 80
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_80.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_80.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_80.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_80.DocumentTitle 'Titulo da página
                tab80.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 81
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_81.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_81.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_81.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_81.DocumentTitle 'Titulo da página
                tab81.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 82
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_82.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_82.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_82.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_82.DocumentTitle 'Titulo da página
                tab82.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 83
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_83.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_83.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_83.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_83.DocumentTitle 'Titulo da página
                tab83.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 84
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_84.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_84.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_84.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_84.DocumentTitle 'Titulo da página
                tab84.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 85
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_85.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_85.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_85.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_85.DocumentTitle 'Titulo da página
                tab85.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 86
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_86.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_86.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_86.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_86.DocumentTitle 'Titulo da página
                tab86.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 87
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_87.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_87.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_87.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_87.DocumentTitle 'Titulo da página
                tab87.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 88
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_88.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_88.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_88.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_88.DocumentTitle 'Titulo da página
                tab88.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 89
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_89.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_89.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_89.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_89.DocumentTitle 'Titulo da página
                tab89.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 90
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_90.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_90.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_90.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_90.DocumentTitle 'Titulo da página
                tab90.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 91
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_91.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_91.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_91.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_91.DocumentTitle 'Titulo da página
                tab91.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 92
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_92.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_92.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_92.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_92.DocumentTitle 'Titulo da página
                tab92.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 93
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_93.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_93.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_93.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_93.DocumentTitle 'Titulo da página
                tab93.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 94
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_94.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_94.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_94.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_94.DocumentTitle 'Titulo da página
                tab94.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 95
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_95.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_95.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_95.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_95.DocumentTitle 'Titulo da página
                tab95.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 96
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_96.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_96.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_96.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_96.DocumentTitle 'Titulo da página
                tab96.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 97
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_97.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_97.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_97.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_97.DocumentTitle 'Titulo da página
                tab97.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 98
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_98.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_98.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_98.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_98.DocumentTitle 'Titulo da página
                tab98.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 99
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_99.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_99.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_99.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_99.DocumentTitle 'Titulo da página
                tab99.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 100
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_100.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_100.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_100.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_100.DocumentTitle 'Titulo da página
                tab100.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 101
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_101.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_101.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_101.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_101.DocumentTitle 'Titulo da página
                tab101.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 102
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_102.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_102.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_102.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_102.DocumentTitle 'Titulo da página
                tab102.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 103
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_103.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_103.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_103.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_103.DocumentTitle 'Titulo da página
                tab103.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 104
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_104.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_104.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_104.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_104.DocumentTitle 'Titulo da página
                tab104.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 105
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_105.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_105.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_105.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_105.DocumentTitle 'Titulo da página
                tab105.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 106
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_106.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_106.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_106.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_106.DocumentTitle 'Titulo da página
                tab106.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 107
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_107.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_107.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_107.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_107.DocumentTitle 'Titulo da página
                tab107.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 108
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_108.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_108.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_108.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_108.DocumentTitle 'Titulo da página
                tab108.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 109
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_109.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_109.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_109.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_109.DocumentTitle 'Titulo da página
                tab109.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 110
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_110.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_110.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_110.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_110.DocumentTitle 'Titulo da página
                tab110.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 111
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_111.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_111.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_111.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_111.DocumentTitle 'Titulo da página
                tab111.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 112
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_112.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_112.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_112.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_112.DocumentTitle 'Titulo da página
                tab112.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 113
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_113.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_113.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_113.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_113.DocumentTitle 'Titulo da página
                tab113.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 114
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_114.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_114.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_114.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_114.DocumentTitle 'Titulo da página
                tab114.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 115
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_115.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_115.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_115.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_115.DocumentTitle 'Titulo da página
                tab115.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 116
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_116.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_116.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_116.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_116.DocumentTitle 'Titulo da página
                tab116.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 117
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_117.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_117.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_117.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_117.DocumentTitle 'Titulo da página
                tab117.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 118
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_118.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_118.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_118.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_118.DocumentTitle 'Titulo da página
                tab118.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 119
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_119.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_119.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_119.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_119.DocumentTitle 'Titulo da página
                tab119.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 120
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_120.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_120.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_120.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_120.DocumentTitle 'Titulo da página
                tab120.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 121
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_121.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_121.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_121.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_121.DocumentTitle 'Titulo da página
                tab121.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 122
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_122.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_122.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_122.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_122.DocumentTitle 'Titulo da página
                tab122.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 123
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_123.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_123.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_123.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_123.DocumentTitle 'Titulo da página
                tab123.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 124
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_124.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_124.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_124.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_124.DocumentTitle 'Titulo da página
                tab124.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 125
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_125.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_125.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_125.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_125.DocumentTitle 'Titulo da página
                tab125.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 126
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_126.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_126.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_126.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_126.DocumentTitle 'Titulo da página
                tab126.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 127
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_127.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_127.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_127.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_127.DocumentTitle 'Titulo da página
                tab127.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select

            Case 128
                v_url_da_pagina = OBJ_MOTOR_WEB_BROWSER_128.Url.AbsoluteUri 'Url da página
                FRM_NAVEGACAO.ButtonX1.Enabled = OBJ_MOTOR_WEB_BROWSER_128.CanGoBack 'Habilitado ou não
                FRM_NAVEGACAO.ButtonX2.Enabled = OBJ_MOTOR_WEB_BROWSER_128.CanGoForward 'Habilitado ou não
                v_titulo_da_pagina = OBJ_MOTOR_WEB_BROWSER_128.DocumentTitle 'Titulo da página
                tab128.Text = " " & v_titulo_da_pagina 'Título da tab
                Exit Select






        End Select

        '---------------------------------------------------------------------------------------------------------------




        'Informar sobre o carregamento do site com voz -----------------------------------------------------------------

        proc_informe_com_voz_sobre_carregamento_do_site() 'Informa com voz sobre o carregamento do site

        '---------------------------------------------------------------------------------------------------------------




        'Informa se o site é ou nao seguro ---------------------------------------------------------------------------------------------------------

        proc_informe_endereco_de_site_seguro_barra_de_status() 'Informa se o endereço do site em visualização é seguro, ou nao

        '-------------------------------------------------------------------------------------------------------------------------------------------




        'Atualiza o texto da aba -------------------------------------------------------------------------------------------------------------------------

        Proc_atualize_texto_referencia_de_aba(v_item_a_atualizar) 'Atualiza o texto da referencia da aba

        '-------------------------------------------------------------------------------------------------------------------------------------------------




        'Atualizando o titulo agora ------------------------------------------------------------------------------------

        FRM_NAVEGACAO.Text = v_titulo_da_pagina & v_versao_do_navegador 'Titulo da página

        '---------------------------------------------------------------------------------------------------------------




        'Atualizando a barra de endereços agora ------------------------------------------------------------------------

        If (FRM_NAVEGACAO.ComboBoxEx1.Focused = False) Then


            FRM_NAVEGACAO.ComboBoxEx1.Text = v_url_da_pagina 'Informando a url da página


        End If

        '---------------------------------------------------------------------------------------------------------------




        'Ocultar barras de progresso -----------------------------------------------------------------------------------

        proc_ocultar_barras_de_progresso_form_navegacao() 'Oculta as barras de progresso do formulario de navegação

        '---------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub Proc_atualize_propriedades_status_text_geckofx() 'Atualiza as propriedades do status text na barra de status
        On Error Resume Next

        Dim v_texto_de_status As String = Nothing 'Informa o texto de status text




        Select Case v_qual_motor_esta_em_uso

            Case 1
                v_texto_de_status = OBJ_MOTOR_GECKOFX_1.StatusText
                Exit Select

            Case 2
                v_texto_de_status = OBJ_MOTOR_GECKOFX_2.StatusText
                Exit Select

            Case 3
                v_texto_de_status = OBJ_MOTOR_GECKOFX_3.StatusText
                Exit Select

            Case 4
                v_texto_de_status = OBJ_MOTOR_GECKOFX_4.StatusText
                Exit Select

            Case 5
                v_texto_de_status = OBJ_MOTOR_GECKOFX_5.StatusText
                Exit Select

            Case 6
                v_texto_de_status = OBJ_MOTOR_GECKOFX_6.StatusText
                Exit Select

            Case 7
                v_texto_de_status = OBJ_MOTOR_GECKOFX_7.StatusText
                Exit Select

            Case 8
                v_texto_de_status = OBJ_MOTOR_GECKOFX_8.StatusText
                Exit Select

            Case 9
                v_texto_de_status = OBJ_MOTOR_GECKOFX_9.StatusText
                Exit Select

            Case 10
                v_texto_de_status = OBJ_MOTOR_GECKOFX_10.StatusText
                Exit Select

            Case 11
                v_texto_de_status = OBJ_MOTOR_GECKOFX_11.StatusText
                Exit Select

            Case 12
                v_texto_de_status = OBJ_MOTOR_GECKOFX_12.StatusText
                Exit Select

            Case 13
                v_texto_de_status = OBJ_MOTOR_GECKOFX_13.StatusText
                Exit Select

            Case 14
                v_texto_de_status = OBJ_MOTOR_GECKOFX_14.StatusText
                Exit Select

            Case 15
                v_texto_de_status = OBJ_MOTOR_GECKOFX_15.StatusText
                Exit Select

            Case 16
                v_texto_de_status = OBJ_MOTOR_GECKOFX_16.StatusText
                Exit Select

            Case 17
                v_texto_de_status = OBJ_MOTOR_GECKOFX_17.StatusText
                Exit Select

            Case 18
                v_texto_de_status = OBJ_MOTOR_GECKOFX_18.StatusText
                Exit Select

            Case 19
                v_texto_de_status = OBJ_MOTOR_GECKOFX_19.StatusText
                Exit Select

            Case 20
                v_texto_de_status = OBJ_MOTOR_GECKOFX_20.StatusText
                Exit Select

            Case 21
                v_texto_de_status = OBJ_MOTOR_GECKOFX_21.StatusText
                Exit Select

            Case 22
                v_texto_de_status = OBJ_MOTOR_GECKOFX_22.StatusText
                Exit Select

            Case 23
                v_texto_de_status = OBJ_MOTOR_GECKOFX_23.StatusText
                Exit Select

            Case 24
                v_texto_de_status = OBJ_MOTOR_GECKOFX_24.StatusText
                Exit Select

            Case 25
                v_texto_de_status = OBJ_MOTOR_GECKOFX_25.StatusText
                Exit Select

            Case 26
                v_texto_de_status = OBJ_MOTOR_GECKOFX_26.StatusText
                Exit Select

            Case 27
                v_texto_de_status = OBJ_MOTOR_GECKOFX_27.StatusText
                Exit Select

            Case 28
                v_texto_de_status = OBJ_MOTOR_GECKOFX_28.StatusText
                Exit Select

            Case 29
                v_texto_de_status = OBJ_MOTOR_GECKOFX_29.StatusText
                Exit Select

            Case 30
                v_texto_de_status = OBJ_MOTOR_GECKOFX_30.StatusText
                Exit Select

            Case 31
                v_texto_de_status = OBJ_MOTOR_GECKOFX_31.StatusText
                Exit Select

            Case 32
                v_texto_de_status = OBJ_MOTOR_GECKOFX_32.StatusText
                Exit Select

            Case 33
                v_texto_de_status = OBJ_MOTOR_GECKOFX_33.StatusText
                Exit Select

            Case 34
                v_texto_de_status = OBJ_MOTOR_GECKOFX_34.StatusText
                Exit Select

            Case 35
                v_texto_de_status = OBJ_MOTOR_GECKOFX_35.StatusText
                Exit Select

            Case 36
                v_texto_de_status = OBJ_MOTOR_GECKOFX_36.StatusText
                Exit Select

            Case 37
                v_texto_de_status = OBJ_MOTOR_GECKOFX_37.StatusText
                Exit Select

            Case 38
                v_texto_de_status = OBJ_MOTOR_GECKOFX_38.StatusText
                Exit Select

            Case 39
                v_texto_de_status = OBJ_MOTOR_GECKOFX_39.StatusText
                Exit Select

            Case 40
                v_texto_de_status = OBJ_MOTOR_GECKOFX_40.StatusText
                Exit Select

            Case 41
                v_texto_de_status = OBJ_MOTOR_GECKOFX_41.StatusText
                Exit Select

            Case 42
                v_texto_de_status = OBJ_MOTOR_GECKOFX_42.StatusText
                Exit Select

            Case 43
                v_texto_de_status = OBJ_MOTOR_GECKOFX_43.StatusText
                Exit Select

            Case 44
                v_texto_de_status = OBJ_MOTOR_GECKOFX_44.StatusText
                Exit Select

            Case 45
                v_texto_de_status = OBJ_MOTOR_GECKOFX_45.StatusText
                Exit Select

            Case 46
                v_texto_de_status = OBJ_MOTOR_GECKOFX_46.StatusText
                Exit Select

            Case 47
                v_texto_de_status = OBJ_MOTOR_GECKOFX_47.StatusText
                Exit Select

            Case 48
                v_texto_de_status = OBJ_MOTOR_GECKOFX_48.StatusText
                Exit Select

            Case 49
                v_texto_de_status = OBJ_MOTOR_GECKOFX_49.StatusText
                Exit Select

            Case 50
                v_texto_de_status = OBJ_MOTOR_GECKOFX_50.StatusText
                Exit Select

            Case 51
                v_texto_de_status = OBJ_MOTOR_GECKOFX_51.StatusText
                Exit Select

            Case 52
                v_texto_de_status = OBJ_MOTOR_GECKOFX_52.StatusText
                Exit Select

            Case 53
                v_texto_de_status = OBJ_MOTOR_GECKOFX_53.StatusText
                Exit Select

            Case 54
                v_texto_de_status = OBJ_MOTOR_GECKOFX_54.StatusText
                Exit Select

            Case 55
                v_texto_de_status = OBJ_MOTOR_GECKOFX_55.StatusText
                Exit Select

            Case 56
                v_texto_de_status = OBJ_MOTOR_GECKOFX_56.StatusText
                Exit Select

            Case 57
                v_texto_de_status = OBJ_MOTOR_GECKOFX_57.StatusText
                Exit Select

            Case 58
                v_texto_de_status = OBJ_MOTOR_GECKOFX_58.StatusText
                Exit Select

            Case 59
                v_texto_de_status = OBJ_MOTOR_GECKOFX_59.StatusText
                Exit Select

            Case 60
                v_texto_de_status = OBJ_MOTOR_GECKOFX_60.StatusText
                Exit Select

            Case 61
                v_texto_de_status = OBJ_MOTOR_GECKOFX_61.StatusText
                Exit Select

            Case 62
                v_texto_de_status = OBJ_MOTOR_GECKOFX_62.StatusText
                Exit Select

            Case 63
                v_texto_de_status = OBJ_MOTOR_GECKOFX_63.StatusText
                Exit Select

            Case 64
                v_texto_de_status = OBJ_MOTOR_GECKOFX_64.StatusText
                Exit Select

            Case 65
                v_texto_de_status = OBJ_MOTOR_GECKOFX_65.StatusText
                Exit Select

            Case 66
                v_texto_de_status = OBJ_MOTOR_GECKOFX_66.StatusText
                Exit Select

            Case 67
                v_texto_de_status = OBJ_MOTOR_GECKOFX_67.StatusText
                Exit Select

            Case 68
                v_texto_de_status = OBJ_MOTOR_GECKOFX_68.StatusText
                Exit Select

            Case 69
                v_texto_de_status = OBJ_MOTOR_GECKOFX_69.StatusText
                Exit Select

            Case 70
                v_texto_de_status = OBJ_MOTOR_GECKOFX_70.StatusText
                Exit Select

            Case 71
                v_texto_de_status = OBJ_MOTOR_GECKOFX_71.StatusText
                Exit Select

            Case 72
                v_texto_de_status = OBJ_MOTOR_GECKOFX_72.StatusText
                Exit Select

            Case 73
                v_texto_de_status = OBJ_MOTOR_GECKOFX_73.StatusText
                Exit Select

            Case 74
                v_texto_de_status = OBJ_MOTOR_GECKOFX_74.StatusText
                Exit Select

            Case 75
                v_texto_de_status = OBJ_MOTOR_GECKOFX_75.StatusText
                Exit Select

            Case 76
                v_texto_de_status = OBJ_MOTOR_GECKOFX_76.StatusText
                Exit Select

            Case 77
                v_texto_de_status = OBJ_MOTOR_GECKOFX_77.StatusText
                Exit Select

            Case 78
                v_texto_de_status = OBJ_MOTOR_GECKOFX_78.StatusText
                Exit Select

            Case 79
                v_texto_de_status = OBJ_MOTOR_GECKOFX_79.StatusText
                Exit Select

            Case 80
                v_texto_de_status = OBJ_MOTOR_GECKOFX_80.StatusText
                Exit Select

            Case 81
                v_texto_de_status = OBJ_MOTOR_GECKOFX_81.StatusText
                Exit Select

            Case 82
                v_texto_de_status = OBJ_MOTOR_GECKOFX_82.StatusText
                Exit Select

            Case 83
                v_texto_de_status = OBJ_MOTOR_GECKOFX_83.StatusText
                Exit Select

            Case 84
                v_texto_de_status = OBJ_MOTOR_GECKOFX_84.StatusText
                Exit Select

            Case 85
                v_texto_de_status = OBJ_MOTOR_GECKOFX_85.StatusText
                Exit Select

            Case 86
                v_texto_de_status = OBJ_MOTOR_GECKOFX_86.StatusText
                Exit Select

            Case 87
                v_texto_de_status = OBJ_MOTOR_GECKOFX_87.StatusText
                Exit Select

            Case 88
                v_texto_de_status = OBJ_MOTOR_GECKOFX_88.StatusText
                Exit Select

            Case 89
                v_texto_de_status = OBJ_MOTOR_GECKOFX_89.StatusText
                Exit Select

            Case 90
                v_texto_de_status = OBJ_MOTOR_GECKOFX_90.StatusText
                Exit Select

            Case 91
                v_texto_de_status = OBJ_MOTOR_GECKOFX_91.StatusText
                Exit Select

            Case 92
                v_texto_de_status = OBJ_MOTOR_GECKOFX_92.StatusText
                Exit Select

            Case 93
                v_texto_de_status = OBJ_MOTOR_GECKOFX_93.StatusText
                Exit Select

            Case 94
                v_texto_de_status = OBJ_MOTOR_GECKOFX_94.StatusText
                Exit Select

            Case 95
                v_texto_de_status = OBJ_MOTOR_GECKOFX_95.StatusText
                Exit Select

            Case 96
                v_texto_de_status = OBJ_MOTOR_GECKOFX_96.StatusText
                Exit Select

            Case 97
                v_texto_de_status = OBJ_MOTOR_GECKOFX_97.StatusText
                Exit Select

            Case 98
                v_texto_de_status = OBJ_MOTOR_GECKOFX_98.StatusText
                Exit Select

            Case 99
                v_texto_de_status = OBJ_MOTOR_GECKOFX_99.StatusText
                Exit Select

            Case 100
                v_texto_de_status = OBJ_MOTOR_GECKOFX_100.StatusText
                Exit Select

            Case 101
                v_texto_de_status = OBJ_MOTOR_GECKOFX_101.StatusText
                Exit Select

            Case 102
                v_texto_de_status = OBJ_MOTOR_GECKOFX_102.StatusText
                Exit Select

            Case 103
                v_texto_de_status = OBJ_MOTOR_GECKOFX_103.StatusText
                Exit Select

            Case 104
                v_texto_de_status = OBJ_MOTOR_GECKOFX_104.StatusText
                Exit Select

            Case 105
                v_texto_de_status = OBJ_MOTOR_GECKOFX_105.StatusText
                Exit Select

            Case 106
                v_texto_de_status = OBJ_MOTOR_GECKOFX_106.StatusText
                Exit Select

            Case 107
                v_texto_de_status = OBJ_MOTOR_GECKOFX_107.StatusText
                Exit Select

            Case 108
                v_texto_de_status = OBJ_MOTOR_GECKOFX_108.StatusText
                Exit Select

            Case 109
                v_texto_de_status = OBJ_MOTOR_GECKOFX_109.StatusText
                Exit Select

            Case 110
                v_texto_de_status = OBJ_MOTOR_GECKOFX_110.StatusText
                Exit Select

            Case 111
                v_texto_de_status = OBJ_MOTOR_GECKOFX_111.StatusText
                Exit Select

            Case 112
                v_texto_de_status = OBJ_MOTOR_GECKOFX_112.StatusText
                Exit Select

            Case 113
                v_texto_de_status = OBJ_MOTOR_GECKOFX_113.StatusText
                Exit Select

            Case 114
                v_texto_de_status = OBJ_MOTOR_GECKOFX_114.StatusText
                Exit Select

            Case 115
                v_texto_de_status = OBJ_MOTOR_GECKOFX_115.StatusText
                Exit Select

            Case 116
                v_texto_de_status = OBJ_MOTOR_GECKOFX_116.StatusText
                Exit Select

            Case 117
                v_texto_de_status = OBJ_MOTOR_GECKOFX_117.StatusText
                Exit Select

            Case 118
                v_texto_de_status = OBJ_MOTOR_GECKOFX_118.StatusText
                Exit Select

            Case 119
                v_texto_de_status = OBJ_MOTOR_GECKOFX_119.StatusText
                Exit Select

            Case 120
                v_texto_de_status = OBJ_MOTOR_GECKOFX_120.StatusText
                Exit Select

            Case 121
                v_texto_de_status = OBJ_MOTOR_GECKOFX_121.StatusText
                Exit Select

            Case 122
                v_texto_de_status = OBJ_MOTOR_GECKOFX_122.StatusText
                Exit Select

            Case 123
                v_texto_de_status = OBJ_MOTOR_GECKOFX_123.StatusText
                Exit Select

            Case 124
                v_texto_de_status = OBJ_MOTOR_GECKOFX_124.StatusText
                Exit Select

            Case 125
                v_texto_de_status = OBJ_MOTOR_GECKOFX_125.StatusText
                Exit Select

            Case 126
                v_texto_de_status = OBJ_MOTOR_GECKOFX_126.StatusText
                Exit Select

            Case 127
                v_texto_de_status = OBJ_MOTOR_GECKOFX_127.StatusText
                Exit Select

            Case 128
                v_texto_de_status = OBJ_MOTOR_GECKOFX_128.StatusText
                Exit Select

            


        End Select


        'Repassando o valor para a barra de status ---------------------------------------------------------------------

        FRM_NAVEGACAO.ToolStripStatusLabel2.Text = v_texto_de_status 'Texto de status

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status
        On Error Resume Next

        Dim v_texto_de_status As String = Nothing 'Informa o texto de status text




        Select Case v_qual_motor_esta_em_uso

            Case 1
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_1.StatusText
                Exit Select

            Case 2
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_2.StatusText
                Exit Select

            Case 3
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_3.StatusText
                Exit Select

            Case 4
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_4.StatusText
                Exit Select

            Case 5
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_5.StatusText
                Exit Select

            Case 6
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_6.StatusText
                Exit Select

            Case 7
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_7.StatusText
                Exit Select

            Case 8
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_8.StatusText
                Exit Select

            Case 9
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_9.StatusText
                Exit Select

            Case 10
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_10.StatusText
                Exit Select

            Case 11
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_11.StatusText
                Exit Select

            Case 12
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_12.StatusText
                Exit Select

            Case 13
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_13.StatusText
                Exit Select

            Case 14
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_14.StatusText
                Exit Select

            Case 15
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_15.StatusText
                Exit Select

            Case 16
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_16.StatusText
                Exit Select

            Case 17
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_17.StatusText
                Exit Select

            Case 18
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_18.StatusText
                Exit Select

            Case 19
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_19.StatusText
                Exit Select

            Case 20
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_20.StatusText
                Exit Select

            Case 21
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_21.StatusText
                Exit Select

            Case 22
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_22.StatusText
                Exit Select

            Case 23
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_23.StatusText
                Exit Select

            Case 24
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_24.StatusText
                Exit Select

            Case 25
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_25.StatusText
                Exit Select

            Case 26
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_26.StatusText
                Exit Select

            Case 27
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_27.StatusText
                Exit Select

            Case 28
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_28.StatusText
                Exit Select

            Case 29
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_29.StatusText
                Exit Select

            Case 30
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_30.StatusText
                Exit Select

            Case 31
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_31.StatusText
                Exit Select

            Case 32
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_32.StatusText
                Exit Select

            Case 33
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_33.StatusText
                Exit Select

            Case 34
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_34.StatusText
                Exit Select

            Case 35
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_35.StatusText
                Exit Select

            Case 36
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_36.StatusText
                Exit Select

            Case 37
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_37.StatusText
                Exit Select

            Case 38
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_38.StatusText
                Exit Select

            Case 39
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_39.StatusText
                Exit Select

            Case 40
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_40.StatusText
                Exit Select

            Case 41
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_41.StatusText
                Exit Select

            Case 42
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_42.StatusText
                Exit Select

            Case 43
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_43.StatusText
                Exit Select

            Case 44
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_44.StatusText
                Exit Select

            Case 45
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_45.StatusText
                Exit Select

            Case 46
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_46.StatusText
                Exit Select

            Case 47
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_47.StatusText
                Exit Select

            Case 48
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_48.StatusText
                Exit Select

            Case 49
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_49.StatusText
                Exit Select

            Case 50
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_50.StatusText
                Exit Select

            Case 51
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_51.StatusText
                Exit Select

            Case 52
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_52.StatusText
                Exit Select

            Case 53
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_53.StatusText
                Exit Select

            Case 54
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_54.StatusText
                Exit Select

            Case 55
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_55.StatusText
                Exit Select

            Case 56
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_56.StatusText
                Exit Select

            Case 57
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_57.StatusText
                Exit Select

            Case 58
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_58.StatusText
                Exit Select

            Case 59
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_59.StatusText
                Exit Select

            Case 60
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_60.StatusText
                Exit Select

            Case 61
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_61.StatusText
                Exit Select

            Case 62
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_62.StatusText
                Exit Select

            Case 63
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_63.StatusText
                Exit Select

            Case 64
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_64.StatusText
                Exit Select

            Case 65
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_65.StatusText
                Exit Select

            Case 66
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_66.StatusText
                Exit Select

            Case 67
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_67.StatusText
                Exit Select

            Case 68
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_68.StatusText
                Exit Select

            Case 69
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_69.StatusText
                Exit Select

            Case 70
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_70.StatusText
                Exit Select

            Case 71
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_71.StatusText
                Exit Select

            Case 72
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_72.StatusText
                Exit Select

            Case 73
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_73.StatusText
                Exit Select

            Case 74
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_74.StatusText
                Exit Select

            Case 75
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_75.StatusText
                Exit Select

            Case 76
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_76.StatusText
                Exit Select

            Case 77
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_77.StatusText
                Exit Select

            Case 78
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_78.StatusText
                Exit Select

            Case 79
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_79.StatusText
                Exit Select

            Case 80
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_80.StatusText
                Exit Select

            Case 81
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_81.StatusText
                Exit Select

            Case 82
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_82.StatusText
                Exit Select

            Case 83
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_83.StatusText
                Exit Select

            Case 84
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_84.StatusText
                Exit Select

            Case 85
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_85.StatusText
                Exit Select

            Case 86
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_86.StatusText
                Exit Select

            Case 87
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_87.StatusText
                Exit Select

            Case 88
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_88.StatusText
                Exit Select

            Case 89
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_89.StatusText
                Exit Select

            Case 90
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_90.StatusText
                Exit Select

            Case 91
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_91.StatusText
                Exit Select

            Case 92
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_92.StatusText
                Exit Select

            Case 93
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_93.StatusText
                Exit Select

            Case 94
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_94.StatusText
                Exit Select

            Case 95
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_95.StatusText
                Exit Select

            Case 96
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_96.StatusText
                Exit Select

            Case 97
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_97.StatusText
                Exit Select

            Case 98
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_98.StatusText
                Exit Select

            Case 99
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_99.StatusText
                Exit Select

            Case 100
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_100.StatusText
                Exit Select

            Case 101
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_101.StatusText
                Exit Select

            Case 102
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_102.StatusText
                Exit Select

            Case 103
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_103.StatusText
                Exit Select

            Case 104
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_104.StatusText
                Exit Select

            Case 105
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_105.StatusText
                Exit Select

            Case 106
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_106.StatusText
                Exit Select

            Case 107
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_107.StatusText
                Exit Select

            Case 108
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_108.StatusText
                Exit Select

            Case 109
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_109.StatusText
                Exit Select

            Case 110
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_110.StatusText
                Exit Select

            Case 111
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_111.StatusText
                Exit Select

            Case 112
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_112.StatusText
                Exit Select

            Case 113
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_113.StatusText
                Exit Select

            Case 114
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_114.StatusText
                Exit Select

            Case 115
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_115.StatusText
                Exit Select

            Case 116
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_116.StatusText
                Exit Select

            Case 117
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_117.StatusText
                Exit Select

            Case 118
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_118.StatusText
                Exit Select

            Case 119
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_119.StatusText
                Exit Select

            Case 120
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_120.StatusText
                Exit Select

            Case 121
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_121.StatusText
                Exit Select

            Case 122
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_122.StatusText
                Exit Select

            Case 123
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_123.StatusText
                Exit Select

            Case 124
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_124.StatusText
                Exit Select

            Case 125
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_125.StatusText
                Exit Select

            Case 126
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_126.StatusText
                Exit Select

            Case 127
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_127.StatusText
                Exit Select

            Case 128
                v_texto_de_status = OBJ_MOTOR_WEB_BROWSER_128.StatusText
                Exit Select

            


        End Select


        'Repassando o valor para a barra de status ---------------------------------------------------------------------

        FRM_NAVEGACAO.ToolStripStatusLabel2.Text = v_texto_de_status 'Texto de status

        proc_iniciar_teste_site_online(v_texto_de_status) 'Inicia o teste do site online

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub Proc_exibir_ou_ocultar_barra_de_progresso(ByVal v_valor As Boolean) 'Oculta ou exibe a barra de carregamento
        On Error Resume Next

        FRM_NAVEGACAO.ProgressBarX1.Visible = v_valor 'Valor da exibição da barra de progresso

    End Sub

    Public Sub Proc_atualize_texto_referencia_de_aba(ByVal v_item_a_atualizar As String) 'Atualiza o texto da referencia da aba
        On Error Resume Next


        Select Case v_item_a_atualizar

            Case 1
                Tool_aba_referencia_1.Text = " " & tab1.Text
                Exit Select

            Case 2
                Tool_aba_referencia_2.Text = " " & tab2.Text
                Exit Select

            Case 3
                Tool_aba_referencia_3.Text = " " & tab3.Text
                Exit Select

            Case 4
                Tool_aba_referencia_4.Text = " " & tab4.Text
                Exit Select

            Case 5
                Tool_aba_referencia_5.Text = " " & tab5.Text
                Exit Select

            Case 6
                Tool_aba_referencia_6.Text = " " & tab6.Text
                Exit Select

            Case 7
                Tool_aba_referencia_7.Text = " " & tab7.Text
                Exit Select

            Case 8
                Tool_aba_referencia_8.Text = " " & tab8.Text
                Exit Select

            Case 9
                Tool_aba_referencia_9.Text = " " & tab9.Text
                Exit Select

            Case 10
                Tool_aba_referencia_10.Text = " " & tab10.Text
                Exit Select

            Case 11
                Tool_aba_referencia_11.Text = " " & tab11.Text
                Exit Select

            Case 12
                Tool_aba_referencia_12.Text = " " & tab12.Text
                Exit Select

            Case 13
                Tool_aba_referencia_13.Text = " " & tab13.Text
                Exit Select

            Case 14
                Tool_aba_referencia_14.Text = " " & tab14.Text
                Exit Select

            Case 15
                Tool_aba_referencia_15.Text = " " & tab15.Text
                Exit Select

            Case 16
                Tool_aba_referencia_16.Text = " " & tab16.Text
                Exit Select

            Case 17
                Tool_aba_referencia_17.Text = " " & tab17.Text
                Exit Select

            Case 18
                Tool_aba_referencia_18.Text = " " & tab18.Text
                Exit Select

            Case 19
                Tool_aba_referencia_19.Text = " " & tab19.Text
                Exit Select

            Case 20
                Tool_aba_referencia_20.Text = " " & tab20.Text
                Exit Select

            Case 21
                Tool_aba_referencia_21.Text = " " & tab21.Text
                Exit Select

            Case 22
                Tool_aba_referencia_22.Text = " " & tab22.Text
                Exit Select

            Case 23
                Tool_aba_referencia_23.Text = " " & tab23.Text
                Exit Select

            Case 24
                Tool_aba_referencia_24.Text = " " & tab24.Text
                Exit Select

            Case 25
                Tool_aba_referencia_25.Text = " " & tab25.Text
                Exit Select

            Case 26
                Tool_aba_referencia_26.Text = " " & tab26.Text
                Exit Select

            Case 27
                Tool_aba_referencia_27.Text = " " & tab27.Text
                Exit Select

            Case 28
                Tool_aba_referencia_28.Text = " " & tab28.Text
                Exit Select

            Case 29
                Tool_aba_referencia_29.Text = " " & tab29.Text
                Exit Select

            Case 30
                Tool_aba_referencia_30.Text = " " & tab30.Text
                Exit Select

            Case 31
                Tool_aba_referencia_31.Text = " " & tab31.Text
                Exit Select

            Case 32
                Tool_aba_referencia_32.Text = " " & tab32.Text
                Exit Select

            Case 33
                Tool_aba_referencia_33.Text = " " & tab33.Text
                Exit Select

            Case 34
                Tool_aba_referencia_34.Text = " " & tab34.Text
                Exit Select

            Case 35
                Tool_aba_referencia_35.Text = " " & tab35.Text
                Exit Select

            Case 36
                Tool_aba_referencia_36.Text = " " & tab36.Text
                Exit Select

            Case 37
                Tool_aba_referencia_37.Text = " " & tab37.Text
                Exit Select

            Case 38
                Tool_aba_referencia_38.Text = " " & tab38.Text
                Exit Select

            Case 39
                Tool_aba_referencia_39.Text = " " & tab39.Text
                Exit Select

            Case 40
                Tool_aba_referencia_40.Text = " " & tab40.Text
                Exit Select

            Case 41
                Tool_aba_referencia_41.Text = " " & tab41.Text
                Exit Select

            Case 42
                Tool_aba_referencia_42.Text = " " & tab42.Text
                Exit Select

            Case 43
                Tool_aba_referencia_43.Text = " " & tab43.Text
                Exit Select

            Case 44
                Tool_aba_referencia_44.Text = " " & tab44.Text
                Exit Select

            Case 45
                Tool_aba_referencia_45.Text = " " & tab45.Text
                Exit Select

            Case 46
                Tool_aba_referencia_46.Text = " " & tab46.Text
                Exit Select

            Case 47
                Tool_aba_referencia_47.Text = " " & tab47.Text
                Exit Select

            Case 48
                Tool_aba_referencia_48.Text = " " & tab48.Text
                Exit Select

            Case 49
                Tool_aba_referencia_49.Text = " " & tab49.Text
                Exit Select

            Case 50
                Tool_aba_referencia_50.Text = " " & tab50.Text
                Exit Select

            Case 51
                Tool_aba_referencia_51.Text = " " & tab51.Text
                Exit Select

            Case 52
                Tool_aba_referencia_52.Text = " " & tab52.Text
                Exit Select

            Case 53
                Tool_aba_referencia_53.Text = " " & tab53.Text
                Exit Select

            Case 54
                Tool_aba_referencia_54.Text = " " & tab54.Text
                Exit Select

            Case 55
                Tool_aba_referencia_55.Text = " " & tab55.Text
                Exit Select

            Case 56
                Tool_aba_referencia_56.Text = " " & tab56.Text
                Exit Select

            Case 57
                Tool_aba_referencia_57.Text = " " & tab57.Text
                Exit Select

            Case 58
                Tool_aba_referencia_58.Text = " " & tab58.Text
                Exit Select

            Case 59
                Tool_aba_referencia_59.Text = " " & tab59.Text
                Exit Select

            Case 60
                Tool_aba_referencia_60.Text = " " & tab60.Text
                Exit Select

            Case 61
                Tool_aba_referencia_61.Text = " " & tab61.Text
                Exit Select

            Case 62
                Tool_aba_referencia_62.Text = " " & tab62.Text
                Exit Select

            Case 63
                Tool_aba_referencia_63.Text = " " & tab63.Text
                Exit Select

            Case 64
                Tool_aba_referencia_64.Text = " " & tab64.Text
                Exit Select

            Case 65
                Tool_aba_referencia_65.Text = " " & tab65.Text
                Exit Select

            Case 66
                Tool_aba_referencia_66.Text = " " & tab66.Text
                Exit Select

            Case 67
                Tool_aba_referencia_67.Text = " " & tab67.Text
                Exit Select

            Case 68
                Tool_aba_referencia_68.Text = " " & tab68.Text
                Exit Select

            Case 69
                Tool_aba_referencia_69.Text = " " & tab69.Text
                Exit Select

            Case 70
                Tool_aba_referencia_70.Text = " " & tab70.Text
                Exit Select

            Case 71
                Tool_aba_referencia_71.Text = " " & tab71.Text
                Exit Select

            Case 72
                Tool_aba_referencia_72.Text = " " & tab72.Text
                Exit Select

            Case 73
                Tool_aba_referencia_73.Text = " " & tab73.Text
                Exit Select

            Case 74
                Tool_aba_referencia_74.Text = " " & tab74.Text
                Exit Select

            Case 75
                Tool_aba_referencia_75.Text = " " & tab75.Text
                Exit Select

            Case 76
                Tool_aba_referencia_76.Text = " " & tab76.Text
                Exit Select

            Case 77
                Tool_aba_referencia_77.Text = " " & tab77.Text
                Exit Select

            Case 78
                Tool_aba_referencia_78.Text = " " & tab78.Text
                Exit Select

            Case 79
                Tool_aba_referencia_79.Text = " " & tab79.Text
                Exit Select

            Case 80
                Tool_aba_referencia_80.Text = " " & tab80.Text
                Exit Select

            Case 81
                Tool_aba_referencia_81.Text = " " & tab81.Text
                Exit Select

            Case 82
                Tool_aba_referencia_82.Text = " " & tab82.Text
                Exit Select

            Case 83
                Tool_aba_referencia_83.Text = " " & tab83.Text
                Exit Select

            Case 84
                Tool_aba_referencia_84.Text = " " & tab84.Text
                Exit Select

            Case 85
                Tool_aba_referencia_85.Text = " " & tab85.Text
                Exit Select

            Case 86
                Tool_aba_referencia_86.Text = " " & tab86.Text
                Exit Select

            Case 87
                Tool_aba_referencia_87.Text = " " & tab87.Text
                Exit Select

            Case 88
                Tool_aba_referencia_88.Text = " " & tab88.Text
                Exit Select

            Case 89
                Tool_aba_referencia_89.Text = " " & tab89.Text
                Exit Select

            Case 90
                Tool_aba_referencia_90.Text = " " & tab90.Text
                Exit Select

            Case 91
                Tool_aba_referencia_91.Text = " " & tab91.Text
                Exit Select

            Case 92
                Tool_aba_referencia_92.Text = " " & tab92.Text
                Exit Select

            Case 93
                Tool_aba_referencia_93.Text = " " & tab93.Text
                Exit Select

            Case 94
                Tool_aba_referencia_94.Text = " " & tab94.Text
                Exit Select

            Case 95
                Tool_aba_referencia_95.Text = " " & tab95.Text
                Exit Select

            Case 96
                Tool_aba_referencia_96.Text = " " & tab96.Text
                Exit Select

            Case 97
                Tool_aba_referencia_97.Text = " " & tab97.Text
                Exit Select

            Case 98
                Tool_aba_referencia_98.Text = " " & tab98.Text
                Exit Select

            Case 99
                Tool_aba_referencia_99.Text = " " & tab99.Text
                Exit Select

            Case 100
                Tool_aba_referencia_100.Text = " " & tab100.Text
                Exit Select

            Case 101
                Tool_aba_referencia_101.Text = " " & tab101.Text
                Exit Select

            Case 102
                Tool_aba_referencia_102.Text = " " & tab102.Text
                Exit Select

            Case 103
                Tool_aba_referencia_103.Text = " " & tab103.Text
                Exit Select

            Case 104
                Tool_aba_referencia_104.Text = " " & tab104.Text
                Exit Select

            Case 105
                Tool_aba_referencia_105.Text = " " & tab105.Text
                Exit Select

            Case 106
                Tool_aba_referencia_106.Text = " " & tab106.Text
                Exit Select

            Case 107
                Tool_aba_referencia_107.Text = " " & tab107.Text
                Exit Select

            Case 108
                Tool_aba_referencia_108.Text = " " & tab108.Text
                Exit Select

            Case 109
                Tool_aba_referencia_109.Text = " " & tab109.Text
                Exit Select

            Case 110
                Tool_aba_referencia_110.Text = " " & tab110.Text
                Exit Select

            Case 111
                Tool_aba_referencia_111.Text = " " & tab111.Text
                Exit Select

            Case 112
                Tool_aba_referencia_112.Text = " " & tab112.Text
                Exit Select

            Case 113
                Tool_aba_referencia_113.Text = " " & tab113.Text
                Exit Select

            Case 114
                Tool_aba_referencia_114.Text = " " & tab114.Text
                Exit Select

            Case 115
                Tool_aba_referencia_115.Text = " " & tab115.Text
                Exit Select

            Case 116
                Tool_aba_referencia_116.Text = " " & tab116.Text
                Exit Select

            Case 117
                Tool_aba_referencia_117.Text = " " & tab117.Text
                Exit Select

            Case 118
                Tool_aba_referencia_118.Text = " " & tab118.Text
                Exit Select

            Case 119
                Tool_aba_referencia_119.Text = " " & tab119.Text
                Exit Select

            Case 120
                Tool_aba_referencia_120.Text = " " & tab120.Text
                Exit Select

            Case 121
                Tool_aba_referencia_121.Text = " " & tab121.Text
                Exit Select

            Case 122
                Tool_aba_referencia_122.Text = " " & tab122.Text
                Exit Select

            Case 123
                Tool_aba_referencia_123.Text = " " & tab123.Text
                Exit Select

            Case 124
                Tool_aba_referencia_124.Text = " " & tab124.Text
                Exit Select

            Case 125
                Tool_aba_referencia_125.Text = " " & tab125.Text
                Exit Select

            Case 126
                Tool_aba_referencia_126.Text = " " & tab126.Text
                Exit Select

            Case 127
                Tool_aba_referencia_127.Text = " " & tab127.Text
                Exit Select

            Case 128
                Tool_aba_referencia_128.Text = " " & tab128.Text
                Exit Select





        End Select


    End Sub





    'Relacionado ao favicon ----------------------------------------------------------------------------------------------

    Public OBJ_IMG_FAVICON_TEMP As Image 'Imagem de favicon temporaria

    Public V_SITE_DO_FAVICON As String 'Site que contem o favicon













    'Parte que somente exibe sem salvar

    Public Sub Proc_obter_favicon_de_site() 'Obtem o favicon do site
        On Error Resume Next

        OBJ_IMG_FAVICON_TEMP = Nothing 'Limpando ultimo valor

        OBJ_IMG_FAVICON_TEMP = func_gerar_favicon_de_web_sites(V_SITE_DO_FAVICON) 'Gera o favicon da página visitada

    End Sub

    Public Sub Proc_mostra_favicon_baixado() 'Mostra o favicon baixado
        On Error Resume Next


        'Atualizando o favicon no botao de favicon ---------------------------------------------------------------------

        FRM_NAVEGACAO.ButtonX3.Image = OBJ_IMG_FAVICON_TEMP 'Atualizando...

        FRM_NAVEGACAO.ButtonX3.Tooltip = V_SITE_DO_FAVICON 'Informando o site

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    '---------------------------------------------------------------------------------------------------------------------







    'Executador de propriedades

    Public Sub Proc_atualizar_propriedades_site_carregar_completo(ByVal v_item_a_atualizar As Integer) 'Atualiza as propriedades quando a pagina estiver carregada por completo
        On Error Resume Next


        'Selecionando atualizador de propriedades -------------------------------------------------------------------------------------------------------------------------------------------

        If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then


            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_item_a_atualizar) 'Atualiza propriedades pos carregamento do motor geckofx


        Else


            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_item_a_atualizar) 'Atualiza propriedades pos carregamento do motor trident


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub




























End Module
