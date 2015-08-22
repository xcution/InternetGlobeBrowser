Module Modulo_de_eventos_usados_pelo_programa_geral

    'Eventos gerais usados pelo programa


    'Evento do recurso de autocompletar -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub GECKO_MOTOR_DE_AUTO_COMPLETAR_HIST_STATUS_TEXT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next


        'Abrir uma página em branco ----------------------------------------------------------------------------------------------

        FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.Navigate("javascript:document.write('Removendo...')") 'Abrindo...

        '-------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub GECK_MOTOR_DE_AUTO_COMPLETAR_HIST_ShowContextMenu(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoContextMenuEventArgs)
        On Error Resume Next


        'Verifica se o item foi selecionado pelo botão direito, e se é um link a ser aberto ----------------------------------------------------------------------

        If (FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.CanCopyLinkLocation = True) Then




            'Exibir menu de opçoes de abrir historico ----------------------------------------------------------------------

            FRM_NAVEGACAO.MNU_AUTOCOMPLETAR_IMAGEM.Show(FRM_NAVEGACAO.MousePosition) 'Abrindo...

            '---------------------------------------------------------------------------------------------------------------




            'Ocultar lista de sites em menu --------------------------------------------------------------------------------

            proc_ocultar_menu_autocompletar_barra_end_navegacao() 'Oculta o menu de autocompletar na barra de endereços

            '---------------------------------------------------------------------------------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub GECK_MOTOR_DE_AUTO_COMPLETAR_HIST_DOM_MOUSE_UP(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoDomMouseEventArgs)
        On Error Resume Next

        Dim v_url_a_abrir As String = FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.StatusText 'Obtendo a url






        'Não permite abrir página em branco ----------------------------------------------------------------------------------------------------------------------

        If (v_url_a_abrir <> Nothing) And (v_url_a_abrir <> "") And (e.Button = 0) Then


            proc_navegar(v_url_a_abrir, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

            AddHandler FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.StatusTextChanged, AddressOf GECKO_MOTOR_DE_AUTO_COMPLETAR_HIST_STATUS_TEXT 'Add evento


        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------------





    End Sub

    Public Sub GECKO_MOTOR_DE_AUTO_COMPLETAR_HIST_DOM_MOUSE_MOVE(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoDomMouseEventArgs)
        On Error Resume Next


        'Ocultar lista de sites em menu --------------------------------------------------------------------------------

        proc_ocultar_menu_autocompletar_barra_end_navegacao() 'Oculta o menu de autocompletar na barra de endereços

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

















































End Module
