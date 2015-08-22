Imports System.Diagnostics




Module Modulo_de_acoes_basicas


    'Parte primaria da visualização de impressao

    Public V_QUANTIDADE_DE_ITENS_VISUALIZAR_IMPRESSAO As Integer = 0 'Informa a quantidade de itens do visualizar impressao

    Public V_CONTADOR_DE_PAGINAS_A_IMPRIMIR As Integer = 0 'Informa o contador de paginas a serem impressas










    'Exibir o codigo fonte da página

    Public Sub proc_exibir_codigo_fonte_da_pagina() 'Exibe o codigo fonte da pagina
        On Error Resume Next

        Dim OBJ_JAN_CODIGO_FONTE As New Skybound.Gecko.ChromeDialog 'Nova janela de exibir codigo fonte

        Dim V_ARQ_TEMP_CODIGO_TRIDENT As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\arq_temp_trident_cod_font.txt" 'Arquivo temporario de codigo fonte






        'Selecionando opção -------------------------------------------------------------------------------------------------------------------

        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_1.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_1.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_2.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_2.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_3.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_3.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_4.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_4.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_5.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_5.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_6.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_6.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_7.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_7.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_8.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_8.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_9.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_9.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_10.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_10.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_11.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_11.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_12.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_12.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_13.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_13.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_14.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_14.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_15.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_15.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_16.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_16.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_17.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_17.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_18.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_18.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_19.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_19.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_20.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_20.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_21.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_21.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_22.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_22.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_23.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_23.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_24.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_24.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_25.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_25.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_26.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_26.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_27.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_27.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_28.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_28.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_29.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_29.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_30.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_30.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_31.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_31.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_32.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_32.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_33.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_33.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_34.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_34.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_35.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_35.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_36.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_36.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_37.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_37.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_38.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_38.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_39.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_39.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_40.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_40.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_41.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_41.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_42.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_42.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_43.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_43.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_44.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_44.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_45.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_45.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_46.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_46.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_47.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_47.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_48.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_48.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_49.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_49.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_50.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_50.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_51.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_51.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_52.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_52.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_53.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_53.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_54.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_54.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_55.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_55.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_56.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_56.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_57.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_57.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_58.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_58.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_59.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_59.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_60.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_60.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_61.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_61.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_62.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_62.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_63.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_63.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_64.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_64.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_65.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_65.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_66.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_66.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_67.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_67.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_68.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_68.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_69.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_69.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_70.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_70.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_71.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_71.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_72.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_72.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_73.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_73.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_74.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_74.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_75.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_75.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_76.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_76.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_77.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_77.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_78.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_78.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_79.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_79.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_80.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_80.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_81.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_81.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_82.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_82.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_83.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_83.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_84.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_84.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_85.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_85.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_86.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_86.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_87.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_87.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_88.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_88.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_89.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_89.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_90.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_90.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_91.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_91.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_92.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_92.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_93.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_93.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_94.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_94.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_95.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_95.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_96.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_96.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_97.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_97.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_98.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_98.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_99.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_99.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_100.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_100.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_101.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_101.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_102.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_102.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_103.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_103.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_104.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_104.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_105.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_105.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_106.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_106.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_107.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_107.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_108.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_108.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_109.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_109.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_110.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_110.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_111.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_111.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_112.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_112.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_113.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_113.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_114.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_114.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_115.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_115.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_116.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_116.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_117.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_117.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_118.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_118.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_119.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_119.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_120.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_120.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_121.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_121.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_122.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_122.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_123.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_123.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_124.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_124.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_125.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_125.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_126.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_126.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_127.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_127.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_128.ViewSource()
                Else
                    proc_salvar_valor(OBJ_MOTOR_WEB_BROWSER_128.DocumentText, V_ARQ_TEMP_CODIGO_TRIDENT) 'Salva a configuração
                    System.Diagnostics.Process.Start("notepad.exe", V_ARQ_TEMP_CODIGO_TRIDENT) 'Abrindo...
                End If
                Exit Select




        End Select

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub




    'Salvar a página e complemento

    Public Sub proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
        On Error Resume Next

        Dim DLG_SALVAR As New SaveFileDialog 'Diálogo salvar

        Dim v_complemento As String = vbCrLf & vbCrLf & "Tamanho em kilobytes do arquivo: " 'Complemento

        Dim v_tamanho_arq As Long 'Tamanho do arquivo







        'Definindo propriedades basicas --------------------------------------------------------------------------------

        DLG_SALVAR.FileName = FRM_NAVEGACAO.Text  'Titulo da página

        DLG_SALVAR.Filter = "Extenção do arquivo(*" & v_extencao_1 & ")|*" & v_extencao_1 'Extenção do arquivo

        '---------------------------------------------------------------------------------------------------------------



        'Verifica a janela de salvar página e depois qual motor salvar a pagina --------------------------------------------------------------------------------------

        If (DLG_SALVAR.ShowDialog = DialogResult.OK) Then




            Select Case v_qual_motor_esta_em_uso


                Case 1
                    OBJ_MOTOR_GECKOFX_1.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 2
                    OBJ_MOTOR_GECKOFX_2.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 3
                    OBJ_MOTOR_GECKOFX_3.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 4
                    OBJ_MOTOR_GECKOFX_4.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 5
                    OBJ_MOTOR_GECKOFX_5.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 6
                    OBJ_MOTOR_GECKOFX_6.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 7
                    OBJ_MOTOR_GECKOFX_7.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 8
                    OBJ_MOTOR_GECKOFX_8.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 9
                    OBJ_MOTOR_GECKOFX_9.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 10
                    OBJ_MOTOR_GECKOFX_10.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 11
                    OBJ_MOTOR_GECKOFX_11.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 12
                    OBJ_MOTOR_GECKOFX_12.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 13
                    OBJ_MOTOR_GECKOFX_13.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 14
                    OBJ_MOTOR_GECKOFX_14.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 15
                    OBJ_MOTOR_GECKOFX_15.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 16
                    OBJ_MOTOR_GECKOFX_16.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 17
                    OBJ_MOTOR_GECKOFX_17.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 18
                    OBJ_MOTOR_GECKOFX_18.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 19
                    OBJ_MOTOR_GECKOFX_19.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 20
                    OBJ_MOTOR_GECKOFX_20.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 21
                    OBJ_MOTOR_GECKOFX_21.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 22
                    OBJ_MOTOR_GECKOFX_22.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 23
                    OBJ_MOTOR_GECKOFX_23.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 24
                    OBJ_MOTOR_GECKOFX_24.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 25
                    OBJ_MOTOR_GECKOFX_25.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 26
                    OBJ_MOTOR_GECKOFX_26.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 27
                    OBJ_MOTOR_GECKOFX_27.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 28
                    OBJ_MOTOR_GECKOFX_28.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 29
                    OBJ_MOTOR_GECKOFX_29.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 30
                    OBJ_MOTOR_GECKOFX_30.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 31
                    OBJ_MOTOR_GECKOFX_31.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 32
                    OBJ_MOTOR_GECKOFX_32.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 33
                    OBJ_MOTOR_GECKOFX_33.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 34
                    OBJ_MOTOR_GECKOFX_34.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 35
                    OBJ_MOTOR_GECKOFX_35.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 36
                    OBJ_MOTOR_GECKOFX_36.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 37
                    OBJ_MOTOR_GECKOFX_37.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 38
                    OBJ_MOTOR_GECKOFX_38.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 39
                    OBJ_MOTOR_GECKOFX_39.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 40
                    OBJ_MOTOR_GECKOFX_40.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 41
                    OBJ_MOTOR_GECKOFX_41.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 42
                    OBJ_MOTOR_GECKOFX_42.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 43
                    OBJ_MOTOR_GECKOFX_43.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 44
                    OBJ_MOTOR_GECKOFX_44.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 45
                    OBJ_MOTOR_GECKOFX_45.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 46
                    OBJ_MOTOR_GECKOFX_46.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 47
                    OBJ_MOTOR_GECKOFX_47.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 48
                    OBJ_MOTOR_GECKOFX_48.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 49
                    OBJ_MOTOR_GECKOFX_49.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 50
                    OBJ_MOTOR_GECKOFX_50.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 51
                    OBJ_MOTOR_GECKOFX_51.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 52
                    OBJ_MOTOR_GECKOFX_52.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 53
                    OBJ_MOTOR_GECKOFX_53.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 54
                    OBJ_MOTOR_GECKOFX_54.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 55
                    OBJ_MOTOR_GECKOFX_55.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 56
                    OBJ_MOTOR_GECKOFX_56.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 57
                    OBJ_MOTOR_GECKOFX_57.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 58
                    OBJ_MOTOR_GECKOFX_58.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 59
                    OBJ_MOTOR_GECKOFX_59.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 60
                    OBJ_MOTOR_GECKOFX_60.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 61
                    OBJ_MOTOR_GECKOFX_61.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 62
                    OBJ_MOTOR_GECKOFX_62.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 63
                    OBJ_MOTOR_GECKOFX_63.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 64
                    OBJ_MOTOR_GECKOFX_64.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 65
                    OBJ_MOTOR_GECKOFX_65.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 66
                    OBJ_MOTOR_GECKOFX_66.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 67
                    OBJ_MOTOR_GECKOFX_67.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 68
                    OBJ_MOTOR_GECKOFX_68.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 69
                    OBJ_MOTOR_GECKOFX_69.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 70
                    OBJ_MOTOR_GECKOFX_70.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 71
                    OBJ_MOTOR_GECKOFX_71.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 72
                    OBJ_MOTOR_GECKOFX_72.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 73
                    OBJ_MOTOR_GECKOFX_73.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 74
                    OBJ_MOTOR_GECKOFX_74.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 75
                    OBJ_MOTOR_GECKOFX_75.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 76
                    OBJ_MOTOR_GECKOFX_76.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 77
                    OBJ_MOTOR_GECKOFX_77.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 78
                    OBJ_MOTOR_GECKOFX_78.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 79
                    OBJ_MOTOR_GECKOFX_79.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 80
                    OBJ_MOTOR_GECKOFX_80.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 81
                    OBJ_MOTOR_GECKOFX_81.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 82
                    OBJ_MOTOR_GECKOFX_82.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 83
                    OBJ_MOTOR_GECKOFX_83.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 84
                    OBJ_MOTOR_GECKOFX_84.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 85
                    OBJ_MOTOR_GECKOFX_85.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 86
                    OBJ_MOTOR_GECKOFX_86.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 87
                    OBJ_MOTOR_GECKOFX_87.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 88
                    OBJ_MOTOR_GECKOFX_88.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 89
                    OBJ_MOTOR_GECKOFX_89.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 90
                    OBJ_MOTOR_GECKOFX_90.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 91
                    OBJ_MOTOR_GECKOFX_91.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 92
                    OBJ_MOTOR_GECKOFX_92.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 93
                    OBJ_MOTOR_GECKOFX_93.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 94
                    OBJ_MOTOR_GECKOFX_94.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 95
                    OBJ_MOTOR_GECKOFX_95.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 96
                    OBJ_MOTOR_GECKOFX_96.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 97
                    OBJ_MOTOR_GECKOFX_97.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 98
                    OBJ_MOTOR_GECKOFX_98.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 99
                    OBJ_MOTOR_GECKOFX_99.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 100
                    OBJ_MOTOR_GECKOFX_100.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 101
                    OBJ_MOTOR_GECKOFX_101.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 102
                    OBJ_MOTOR_GECKOFX_102.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 103
                    OBJ_MOTOR_GECKOFX_103.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 104
                    OBJ_MOTOR_GECKOFX_104.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 105
                    OBJ_MOTOR_GECKOFX_105.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 106
                    OBJ_MOTOR_GECKOFX_106.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 107
                    OBJ_MOTOR_GECKOFX_107.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 108
                    OBJ_MOTOR_GECKOFX_108.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 109
                    OBJ_MOTOR_GECKOFX_109.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 110
                    OBJ_MOTOR_GECKOFX_110.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 111
                    OBJ_MOTOR_GECKOFX_111.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 112
                    OBJ_MOTOR_GECKOFX_112.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 113
                    OBJ_MOTOR_GECKOFX_113.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 114
                    OBJ_MOTOR_GECKOFX_114.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 115
                    OBJ_MOTOR_GECKOFX_115.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 116
                    OBJ_MOTOR_GECKOFX_116.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 117
                    OBJ_MOTOR_GECKOFX_117.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 118
                    OBJ_MOTOR_GECKOFX_118.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 119
                    OBJ_MOTOR_GECKOFX_119.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 120
                    OBJ_MOTOR_GECKOFX_120.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 121
                    OBJ_MOTOR_GECKOFX_121.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 122
                    OBJ_MOTOR_GECKOFX_122.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 123
                    OBJ_MOTOR_GECKOFX_123.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 124
                    OBJ_MOTOR_GECKOFX_124.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 125
                    OBJ_MOTOR_GECKOFX_125.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 126
                    OBJ_MOTOR_GECKOFX_126.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 127
                    OBJ_MOTOR_GECKOFX_127.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                Case 128
                    OBJ_MOTOR_GECKOFX_128.SaveDocument(DLG_SALVAR.FileName & v_extencao_1)
                    Exit Select

                




            End Select



            v_tamanho_arq = My.Computer.FileSystem.GetFileInfo(DLG_SALVAR.FileName & v_extencao_1).Length / 1024  'Obtendo o tamanho do arquivo



            'Informando que a página foi salva com sucesso ------------------------------------------------------------------------------------------------------

            proc_chamar_mensagem_ao_usuario(V_MS_1 & v_complemento & v_tamanho_arq & " Kilobytes", v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

            '----------------------------------------------------------------------------------------------------------------------------------------------------



        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_salvar_pagina() 'Salva a página em visualização
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_1.ShowSaveAsDialog()
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_2.ShowSaveAsDialog()
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_3.ShowSaveAsDialog()
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_4.ShowSaveAsDialog()
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_5.ShowSaveAsDialog()
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_6.ShowSaveAsDialog()
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_7.ShowSaveAsDialog()
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_8.ShowSaveAsDialog()
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_9.ShowSaveAsDialog()
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_10.ShowSaveAsDialog()
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_11.ShowSaveAsDialog()
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_12.ShowSaveAsDialog()
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_13.ShowSaveAsDialog()
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_14.ShowSaveAsDialog()
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_15.ShowSaveAsDialog()
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_16.ShowSaveAsDialog()
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_17.ShowSaveAsDialog()
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_18.ShowSaveAsDialog()
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_19.ShowSaveAsDialog()
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_20.ShowSaveAsDialog()
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_21.ShowSaveAsDialog()
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_22.ShowSaveAsDialog()
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_23.ShowSaveAsDialog()
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_24.ShowSaveAsDialog()
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_25.ShowSaveAsDialog()
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_26.ShowSaveAsDialog()
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_27.ShowSaveAsDialog()
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_28.ShowSaveAsDialog()
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_29.ShowSaveAsDialog()
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_30.ShowSaveAsDialog()
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_31.ShowSaveAsDialog()
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_32.ShowSaveAsDialog()
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_33.ShowSaveAsDialog()
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_34.ShowSaveAsDialog()
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_35.ShowSaveAsDialog()
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_36.ShowSaveAsDialog()
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_37.ShowSaveAsDialog()
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_38.ShowSaveAsDialog()
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_39.ShowSaveAsDialog()
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_40.ShowSaveAsDialog()
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_41.ShowSaveAsDialog()
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_42.ShowSaveAsDialog()
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_43.ShowSaveAsDialog()
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_44.ShowSaveAsDialog()
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_45.ShowSaveAsDialog()
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_46.ShowSaveAsDialog()
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_47.ShowSaveAsDialog()
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_48.ShowSaveAsDialog()
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_49.ShowSaveAsDialog()
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_50.ShowSaveAsDialog()
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_51.ShowSaveAsDialog()
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_52.ShowSaveAsDialog()
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_53.ShowSaveAsDialog()
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_54.ShowSaveAsDialog()
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_55.ShowSaveAsDialog()
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_56.ShowSaveAsDialog()
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_57.ShowSaveAsDialog()
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_58.ShowSaveAsDialog()
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_59.ShowSaveAsDialog()
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_60.ShowSaveAsDialog()
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_61.ShowSaveAsDialog()
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_62.ShowSaveAsDialog()
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_63.ShowSaveAsDialog()
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_64.ShowSaveAsDialog()
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_65.ShowSaveAsDialog()
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_66.ShowSaveAsDialog()
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_67.ShowSaveAsDialog()
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_68.ShowSaveAsDialog()
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_69.ShowSaveAsDialog()
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_70.ShowSaveAsDialog()
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_71.ShowSaveAsDialog()
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_72.ShowSaveAsDialog()
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_73.ShowSaveAsDialog()
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_74.ShowSaveAsDialog()
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_75.ShowSaveAsDialog()
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_76.ShowSaveAsDialog()
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_77.ShowSaveAsDialog()
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_78.ShowSaveAsDialog()
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_79.ShowSaveAsDialog()
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_80.ShowSaveAsDialog()
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_81.ShowSaveAsDialog()
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_82.ShowSaveAsDialog()
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_83.ShowSaveAsDialog()
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_84.ShowSaveAsDialog()
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_85.ShowSaveAsDialog()
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_86.ShowSaveAsDialog()
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_87.ShowSaveAsDialog()
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_88.ShowSaveAsDialog()
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_89.ShowSaveAsDialog()
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_90.ShowSaveAsDialog()
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_91.ShowSaveAsDialog()
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_92.ShowSaveAsDialog()
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_93.ShowSaveAsDialog()
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_94.ShowSaveAsDialog()
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_95.ShowSaveAsDialog()
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_96.ShowSaveAsDialog()
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_97.ShowSaveAsDialog()
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_98.ShowSaveAsDialog()
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_99.ShowSaveAsDialog()
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_100.ShowSaveAsDialog()
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_101.ShowSaveAsDialog()
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_102.ShowSaveAsDialog()
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_103.ShowSaveAsDialog()
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_104.ShowSaveAsDialog()
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_105.ShowSaveAsDialog()
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_106.ShowSaveAsDialog()
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_107.ShowSaveAsDialog()
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_108.ShowSaveAsDialog()
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_109.ShowSaveAsDialog()
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_110.ShowSaveAsDialog()
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_111.ShowSaveAsDialog()
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_112.ShowSaveAsDialog()
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_113.ShowSaveAsDialog()
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_114.ShowSaveAsDialog()
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_115.ShowSaveAsDialog()
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_116.ShowSaveAsDialog()
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_117.ShowSaveAsDialog()
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_118.ShowSaveAsDialog()
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_119.ShowSaveAsDialog()
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_120.ShowSaveAsDialog()
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_121.ShowSaveAsDialog()
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_122.ShowSaveAsDialog()
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_123.ShowSaveAsDialog()
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_124.ShowSaveAsDialog()
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_125.ShowSaveAsDialog()
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_126.ShowSaveAsDialog()
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_127.ShowSaveAsDialog()
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_salvar_pagina_geckofx() 'Salva a página no modo geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_128.ShowSaveAsDialog()
                End If
                Exit Select

            




        End Select




    End Sub




    'Abrir página salva

    Public Sub proc_abrir_pagina_salva() 'Abre a página salva no HD
        On Error Resume Next

        Dim DLG_ABRIR As New OpenFileDialog 'Janela de abrir




        'Definindo propriedades ------------------------------------------------------------------------------------

        DLG_ABRIR.Filter = "Extenção do arquivo(*" & v_extencao_1 & ")|*" & v_extencao_1 'Extenção do arquivo

        '-----------------------------------------------------------------------------------------------------------


        'Abrindo diálogo e posteriormente a página salva ----------------------------------------------------------------------------------------------------

        If (DLG_ABRIR.ShowDialog = DialogResult.OK) Then


            proc_navegar(DLG_ABRIR.FileName, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub




    'Configurar página

    Public Sub proc_configurar_pagina() 'Configurar página
        On Error Resume Next


        If (v_tipo_de_motor_layout_engine_em_uso_agora = False) Then




            Select Case v_qual_motor_esta_em_uso


                Case 1
                    OBJ_MOTOR_WEB_BROWSER_1.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 2
                    OBJ_MOTOR_WEB_BROWSER_2.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 3
                    OBJ_MOTOR_WEB_BROWSER_3.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 4
                    OBJ_MOTOR_WEB_BROWSER_4.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 5
                    OBJ_MOTOR_WEB_BROWSER_5.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 6
                    OBJ_MOTOR_WEB_BROWSER_6.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 7
                    OBJ_MOTOR_WEB_BROWSER_7.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 8
                    OBJ_MOTOR_WEB_BROWSER_8.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 9
                    OBJ_MOTOR_WEB_BROWSER_9.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 10
                    OBJ_MOTOR_WEB_BROWSER_10.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 11
                    OBJ_MOTOR_WEB_BROWSER_11.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 12
                    OBJ_MOTOR_WEB_BROWSER_12.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 13
                    OBJ_MOTOR_WEB_BROWSER_13.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 14
                    OBJ_MOTOR_WEB_BROWSER_14.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 15
                    OBJ_MOTOR_WEB_BROWSER_15.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 16
                    OBJ_MOTOR_WEB_BROWSER_16.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 17
                    OBJ_MOTOR_WEB_BROWSER_17.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 18
                    OBJ_MOTOR_WEB_BROWSER_18.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 19
                    OBJ_MOTOR_WEB_BROWSER_19.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 20
                    OBJ_MOTOR_WEB_BROWSER_20.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 21
                    OBJ_MOTOR_WEB_BROWSER_21.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 22
                    OBJ_MOTOR_WEB_BROWSER_22.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 23
                    OBJ_MOTOR_WEB_BROWSER_23.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 24
                    OBJ_MOTOR_WEB_BROWSER_24.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 25
                    OBJ_MOTOR_WEB_BROWSER_25.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 26
                    OBJ_MOTOR_WEB_BROWSER_26.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 27
                    OBJ_MOTOR_WEB_BROWSER_27.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 28
                    OBJ_MOTOR_WEB_BROWSER_28.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 29
                    OBJ_MOTOR_WEB_BROWSER_29.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 30
                    OBJ_MOTOR_WEB_BROWSER_30.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 31
                    OBJ_MOTOR_WEB_BROWSER_31.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 32
                    OBJ_MOTOR_WEB_BROWSER_32.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 33
                    OBJ_MOTOR_WEB_BROWSER_33.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 34
                    OBJ_MOTOR_WEB_BROWSER_34.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 35
                    OBJ_MOTOR_WEB_BROWSER_35.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 36
                    OBJ_MOTOR_WEB_BROWSER_36.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 37
                    OBJ_MOTOR_WEB_BROWSER_37.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 38
                    OBJ_MOTOR_WEB_BROWSER_38.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 39
                    OBJ_MOTOR_WEB_BROWSER_39.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 40
                    OBJ_MOTOR_WEB_BROWSER_40.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 41
                    OBJ_MOTOR_WEB_BROWSER_41.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 42
                    OBJ_MOTOR_WEB_BROWSER_42.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 43
                    OBJ_MOTOR_WEB_BROWSER_43.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 44
                    OBJ_MOTOR_WEB_BROWSER_44.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 45
                    OBJ_MOTOR_WEB_BROWSER_45.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 46
                    OBJ_MOTOR_WEB_BROWSER_46.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 47
                    OBJ_MOTOR_WEB_BROWSER_47.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 48
                    OBJ_MOTOR_WEB_BROWSER_48.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 49
                    OBJ_MOTOR_WEB_BROWSER_49.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 50
                    OBJ_MOTOR_WEB_BROWSER_50.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 51
                    OBJ_MOTOR_WEB_BROWSER_51.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 52
                    OBJ_MOTOR_WEB_BROWSER_52.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 53
                    OBJ_MOTOR_WEB_BROWSER_53.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 54
                    OBJ_MOTOR_WEB_BROWSER_54.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 55
                    OBJ_MOTOR_WEB_BROWSER_55.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 56
                    OBJ_MOTOR_WEB_BROWSER_56.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 57
                    OBJ_MOTOR_WEB_BROWSER_57.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 58
                    OBJ_MOTOR_WEB_BROWSER_58.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 59
                    OBJ_MOTOR_WEB_BROWSER_59.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 60
                    OBJ_MOTOR_WEB_BROWSER_60.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 61
                    OBJ_MOTOR_WEB_BROWSER_61.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 62
                    OBJ_MOTOR_WEB_BROWSER_62.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 63
                    OBJ_MOTOR_WEB_BROWSER_63.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 64
                    OBJ_MOTOR_WEB_BROWSER_64.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 65
                    OBJ_MOTOR_WEB_BROWSER_65.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 66
                    OBJ_MOTOR_WEB_BROWSER_66.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 67
                    OBJ_MOTOR_WEB_BROWSER_67.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 68
                    OBJ_MOTOR_WEB_BROWSER_68.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 69
                    OBJ_MOTOR_WEB_BROWSER_69.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 70
                    OBJ_MOTOR_WEB_BROWSER_70.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 71
                    OBJ_MOTOR_WEB_BROWSER_71.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 72
                    OBJ_MOTOR_WEB_BROWSER_72.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 73
                    OBJ_MOTOR_WEB_BROWSER_73.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 74
                    OBJ_MOTOR_WEB_BROWSER_74.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 75
                    OBJ_MOTOR_WEB_BROWSER_75.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 76
                    OBJ_MOTOR_WEB_BROWSER_76.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 77
                    OBJ_MOTOR_WEB_BROWSER_77.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 78
                    OBJ_MOTOR_WEB_BROWSER_78.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 79
                    OBJ_MOTOR_WEB_BROWSER_79.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 80
                    OBJ_MOTOR_WEB_BROWSER_80.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 81
                    OBJ_MOTOR_WEB_BROWSER_81.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 82
                    OBJ_MOTOR_WEB_BROWSER_82.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 83
                    OBJ_MOTOR_WEB_BROWSER_83.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 84
                    OBJ_MOTOR_WEB_BROWSER_84.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 85
                    OBJ_MOTOR_WEB_BROWSER_85.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 86
                    OBJ_MOTOR_WEB_BROWSER_86.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 87
                    OBJ_MOTOR_WEB_BROWSER_87.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 88
                    OBJ_MOTOR_WEB_BROWSER_88.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 89
                    OBJ_MOTOR_WEB_BROWSER_89.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 90
                    OBJ_MOTOR_WEB_BROWSER_90.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 91
                    OBJ_MOTOR_WEB_BROWSER_91.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 92
                    OBJ_MOTOR_WEB_BROWSER_92.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 93
                    OBJ_MOTOR_WEB_BROWSER_93.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 94
                    OBJ_MOTOR_WEB_BROWSER_94.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 95
                    OBJ_MOTOR_WEB_BROWSER_95.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 96
                    OBJ_MOTOR_WEB_BROWSER_96.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 97
                    OBJ_MOTOR_WEB_BROWSER_97.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 98
                    OBJ_MOTOR_WEB_BROWSER_98.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 99
                    OBJ_MOTOR_WEB_BROWSER_99.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 100
                    OBJ_MOTOR_WEB_BROWSER_100.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 101
                    OBJ_MOTOR_WEB_BROWSER_101.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 102
                    OBJ_MOTOR_WEB_BROWSER_102.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 103
                    OBJ_MOTOR_WEB_BROWSER_103.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 104
                    OBJ_MOTOR_WEB_BROWSER_104.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 105
                    OBJ_MOTOR_WEB_BROWSER_105.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 106
                    OBJ_MOTOR_WEB_BROWSER_106.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 107
                    OBJ_MOTOR_WEB_BROWSER_107.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 108
                    OBJ_MOTOR_WEB_BROWSER_108.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 109
                    OBJ_MOTOR_WEB_BROWSER_109.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 110
                    OBJ_MOTOR_WEB_BROWSER_110.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 111
                    OBJ_MOTOR_WEB_BROWSER_111.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 112
                    OBJ_MOTOR_WEB_BROWSER_112.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 113
                    OBJ_MOTOR_WEB_BROWSER_113.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 114
                    OBJ_MOTOR_WEB_BROWSER_114.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 115
                    OBJ_MOTOR_WEB_BROWSER_115.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 116
                    OBJ_MOTOR_WEB_BROWSER_116.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 117
                    OBJ_MOTOR_WEB_BROWSER_117.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 118
                    OBJ_MOTOR_WEB_BROWSER_118.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 119
                    OBJ_MOTOR_WEB_BROWSER_119.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 120
                    OBJ_MOTOR_WEB_BROWSER_120.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 121
                    OBJ_MOTOR_WEB_BROWSER_121.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 122
                    OBJ_MOTOR_WEB_BROWSER_122.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 123
                    OBJ_MOTOR_WEB_BROWSER_123.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 124
                    OBJ_MOTOR_WEB_BROWSER_124.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 125
                    OBJ_MOTOR_WEB_BROWSER_125.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 126
                    OBJ_MOTOR_WEB_BROWSER_126.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 127
                    OBJ_MOTOR_WEB_BROWSER_127.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                Case 128
                    OBJ_MOTOR_WEB_BROWSER_128.ShowPageSetupDialog() 'Janela de configurar página
                    Exit Select
                



            End Select




        Else



            proc_chamar_mensagem_ao_usuario(V_MS_2, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario



        End If


    End Sub




    'Visualizar impressão

    Public Sub proc_dividir_imagem(ByVal OBJ_IMAGEM_BITMAP_ORIGINAL As Bitmap, ByVal V_TAMANHO_DA_PAGINA As Integer) 'Procedimento de divisão de imagem
        On Error Resume Next

        Dim V_ALTURA As Integer = OBJ_IMAGEM_BITMAP_ORIGINAL.Height 'Altura da imagem

        Dim V_LARGURA As Integer = OBJ_IMAGEM_BITMAP_ORIGINAL.Width 'Largura da imagem

        Dim V_ALTURA_DA_FOLHA As Integer = V_TAMANHO_DA_PAGINA 'Altura da folha já definida

        Dim V_QUANTIDADE_DE_DIVISOES_POSSIVEIS As Integer = (V_ALTURA / V_ALTURA_DA_FOLHA) + 1 'Obtendo a quantidade de divisoes da imagem

        Dim V_TAMANHO_DE_CADA_PARTE As Integer = (V_ALTURA / V_QUANTIDADE_DE_DIVISOES_POSSIVEIS)  'Obtendo o tamanho de cada parte

        Dim V_CONTADOR As Integer = 0 'Contador de recorte

        V_QUANTIDADE_DE_ITENS_VISUALIZAR_IMPRESSAO = V_QUANTIDADE_DE_DIVISOES_POSSIVEIS 'Informa a quantidade de paginas de impressao




        'Modo landscape ativado ----------------------------------------------------------------------------------------

        FRM_NAVEGACAO.m_PrintDocument.DefaultPageSettings.Landscape = True 'Landscape ativado

        '---------------------------------------------------------------------------------------------------------------




        'Inicializando loop para separação de imagem ------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To V_QUANTIDADE_DE_DIVISOES_POSSIVEIS


            Dim V_RETANGULO As New RectangleF(0, V_TAMANHO_DE_CADA_PARTE * V_CONTADOR, V_LARGURA, V_TAMANHO_DE_CADA_PARTE) 'Novo retangulo

            Dim OBJ_IMG_IMAGE_TEMP As New Bitmap(V_LARGURA, V_TAMANHO_DE_CADA_PARTE) 'Nova imagem bitmap

            Dim G As Graphics = Graphics.FromImage(OBJ_IMG_IMAGE_TEMP) 'Novo grafico






            'Definindo imagem do grafico

            G.DrawImage(OBJ_IMAGEM_BITMAP_ORIGINAL, 0, 0, V_RETANGULO, GraphicsUnit.Pixel) 'Definindo imagem do grafico


            'Salvando a imagem temporaria

            My.Computer.FileSystem.DeleteFile(V_PASTA_DE_CONFIGURACAO & "\" & v_nome_generico_de_imagem_de_impressao & V_CONTADOR & v_extencao_2) 'Removendo temporario

            OBJ_IMG_IMAGE_TEMP.Save(V_PASTA_DE_CONFIGURACAO & "\" & v_nome_generico_de_imagem_de_impressao & V_CONTADOR & v_extencao_2) 'Salvando...



        Next

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function func_retorne_a_altura_da_pagina_do_motor_geckofx() 'Retorna a altura da pagina do motor geckofx
        On Error Resume Next

        Dim v_retorno As Integer 'Retorno






        Select Case v_qual_motor_esta_em_uso


            Case 1
                v_retorno = OBJ_MOTOR_GECKOFX_1.Document.Body.ClientHeight
                Exit Select

            Case 2
                v_retorno = OBJ_MOTOR_GECKOFX_2.Document.Body.ClientHeight
                Exit Select

            Case 3
                v_retorno = OBJ_MOTOR_GECKOFX_3.Document.Body.ClientHeight
                Exit Select

            Case 4
                v_retorno = OBJ_MOTOR_GECKOFX_4.Document.Body.ClientHeight
                Exit Select

            Case 5
                v_retorno = OBJ_MOTOR_GECKOFX_5.Document.Body.ClientHeight
                Exit Select

            Case 6
                v_retorno = OBJ_MOTOR_GECKOFX_6.Document.Body.ClientHeight
                Exit Select

            Case 7
                v_retorno = OBJ_MOTOR_GECKOFX_7.Document.Body.ClientHeight
                Exit Select

            Case 8
                v_retorno = OBJ_MOTOR_GECKOFX_8.Document.Body.ClientHeight
                Exit Select

            Case 9
                v_retorno = OBJ_MOTOR_GECKOFX_9.Document.Body.ClientHeight
                Exit Select

            Case 10
                v_retorno = OBJ_MOTOR_GECKOFX_10.Document.Body.ClientHeight
                Exit Select

            Case 11
                v_retorno = OBJ_MOTOR_GECKOFX_11.Document.Body.ClientHeight
                Exit Select

            Case 12
                v_retorno = OBJ_MOTOR_GECKOFX_12.Document.Body.ClientHeight
                Exit Select

            Case 13
                v_retorno = OBJ_MOTOR_GECKOFX_13.Document.Body.ClientHeight
                Exit Select

            Case 14
                v_retorno = OBJ_MOTOR_GECKOFX_14.Document.Body.ClientHeight
                Exit Select

            Case 15
                v_retorno = OBJ_MOTOR_GECKOFX_15.Document.Body.ClientHeight
                Exit Select

            Case 16
                v_retorno = OBJ_MOTOR_GECKOFX_16.Document.Body.ClientHeight
                Exit Select

            Case 17
                v_retorno = OBJ_MOTOR_GECKOFX_17.Document.Body.ClientHeight
                Exit Select

            Case 18
                v_retorno = OBJ_MOTOR_GECKOFX_18.Document.Body.ClientHeight
                Exit Select

            Case 19
                v_retorno = OBJ_MOTOR_GECKOFX_19.Document.Body.ClientHeight
                Exit Select

            Case 20
                v_retorno = OBJ_MOTOR_GECKOFX_20.Document.Body.ClientHeight
                Exit Select

            Case 21
                v_retorno = OBJ_MOTOR_GECKOFX_21.Document.Body.ClientHeight
                Exit Select

            Case 22
                v_retorno = OBJ_MOTOR_GECKOFX_22.Document.Body.ClientHeight
                Exit Select

            Case 23
                v_retorno = OBJ_MOTOR_GECKOFX_23.Document.Body.ClientHeight
                Exit Select

            Case 24
                v_retorno = OBJ_MOTOR_GECKOFX_24.Document.Body.ClientHeight
                Exit Select

            Case 25
                v_retorno = OBJ_MOTOR_GECKOFX_25.Document.Body.ClientHeight
                Exit Select

            Case 26
                v_retorno = OBJ_MOTOR_GECKOFX_26.Document.Body.ClientHeight
                Exit Select

            Case 27
                v_retorno = OBJ_MOTOR_GECKOFX_27.Document.Body.ClientHeight
                Exit Select

            Case 28
                v_retorno = OBJ_MOTOR_GECKOFX_28.Document.Body.ClientHeight
                Exit Select

            Case 29
                v_retorno = OBJ_MOTOR_GECKOFX_29.Document.Body.ClientHeight
                Exit Select

            Case 30
                v_retorno = OBJ_MOTOR_GECKOFX_30.Document.Body.ClientHeight
                Exit Select

            Case 31
                v_retorno = OBJ_MOTOR_GECKOFX_31.Document.Body.ClientHeight
                Exit Select

            Case 32
                v_retorno = OBJ_MOTOR_GECKOFX_32.Document.Body.ClientHeight
                Exit Select

            Case 33
                v_retorno = OBJ_MOTOR_GECKOFX_33.Document.Body.ClientHeight
                Exit Select

            Case 34
                v_retorno = OBJ_MOTOR_GECKOFX_34.Document.Body.ClientHeight
                Exit Select

            Case 35
                v_retorno = OBJ_MOTOR_GECKOFX_35.Document.Body.ClientHeight
                Exit Select

            Case 36
                v_retorno = OBJ_MOTOR_GECKOFX_36.Document.Body.ClientHeight
                Exit Select

            Case 37
                v_retorno = OBJ_MOTOR_GECKOFX_37.Document.Body.ClientHeight
                Exit Select

            Case 38
                v_retorno = OBJ_MOTOR_GECKOFX_38.Document.Body.ClientHeight
                Exit Select

            Case 39
                v_retorno = OBJ_MOTOR_GECKOFX_39.Document.Body.ClientHeight
                Exit Select

            Case 40
                v_retorno = OBJ_MOTOR_GECKOFX_40.Document.Body.ClientHeight
                Exit Select

            Case 41
                v_retorno = OBJ_MOTOR_GECKOFX_41.Document.Body.ClientHeight
                Exit Select

            Case 42
                v_retorno = OBJ_MOTOR_GECKOFX_42.Document.Body.ClientHeight
                Exit Select

            Case 43
                v_retorno = OBJ_MOTOR_GECKOFX_43.Document.Body.ClientHeight
                Exit Select

            Case 44
                v_retorno = OBJ_MOTOR_GECKOFX_44.Document.Body.ClientHeight
                Exit Select

            Case 45
                v_retorno = OBJ_MOTOR_GECKOFX_45.Document.Body.ClientHeight
                Exit Select

            Case 46
                v_retorno = OBJ_MOTOR_GECKOFX_46.Document.Body.ClientHeight
                Exit Select

            Case 47
                v_retorno = OBJ_MOTOR_GECKOFX_47.Document.Body.ClientHeight
                Exit Select

            Case 48
                v_retorno = OBJ_MOTOR_GECKOFX_48.Document.Body.ClientHeight
                Exit Select

            Case 49
                v_retorno = OBJ_MOTOR_GECKOFX_49.Document.Body.ClientHeight
                Exit Select

            Case 50
                v_retorno = OBJ_MOTOR_GECKOFX_50.Document.Body.ClientHeight
                Exit Select

            Case 51
                v_retorno = OBJ_MOTOR_GECKOFX_51.Document.Body.ClientHeight
                Exit Select

            Case 52
                v_retorno = OBJ_MOTOR_GECKOFX_52.Document.Body.ClientHeight
                Exit Select

            Case 53
                v_retorno = OBJ_MOTOR_GECKOFX_53.Document.Body.ClientHeight
                Exit Select

            Case 54
                v_retorno = OBJ_MOTOR_GECKOFX_54.Document.Body.ClientHeight
                Exit Select

            Case 55
                v_retorno = OBJ_MOTOR_GECKOFX_55.Document.Body.ClientHeight
                Exit Select

            Case 56
                v_retorno = OBJ_MOTOR_GECKOFX_56.Document.Body.ClientHeight
                Exit Select

            Case 57
                v_retorno = OBJ_MOTOR_GECKOFX_57.Document.Body.ClientHeight
                Exit Select

            Case 58
                v_retorno = OBJ_MOTOR_GECKOFX_58.Document.Body.ClientHeight
                Exit Select

            Case 59
                v_retorno = OBJ_MOTOR_GECKOFX_59.Document.Body.ClientHeight
                Exit Select

            Case 60
                v_retorno = OBJ_MOTOR_GECKOFX_60.Document.Body.ClientHeight
                Exit Select

            Case 61
                v_retorno = OBJ_MOTOR_GECKOFX_61.Document.Body.ClientHeight
                Exit Select

            Case 62
                v_retorno = OBJ_MOTOR_GECKOFX_62.Document.Body.ClientHeight
                Exit Select

            Case 63
                v_retorno = OBJ_MOTOR_GECKOFX_63.Document.Body.ClientHeight
                Exit Select

            Case 64
                v_retorno = OBJ_MOTOR_GECKOFX_64.Document.Body.ClientHeight
                Exit Select

            Case 65
                v_retorno = OBJ_MOTOR_GECKOFX_65.Document.Body.ClientHeight
                Exit Select

            Case 66
                v_retorno = OBJ_MOTOR_GECKOFX_66.Document.Body.ClientHeight
                Exit Select

            Case 67
                v_retorno = OBJ_MOTOR_GECKOFX_67.Document.Body.ClientHeight
                Exit Select

            Case 68
                v_retorno = OBJ_MOTOR_GECKOFX_68.Document.Body.ClientHeight
                Exit Select

            Case 69
                v_retorno = OBJ_MOTOR_GECKOFX_69.Document.Body.ClientHeight
                Exit Select

            Case 70
                v_retorno = OBJ_MOTOR_GECKOFX_70.Document.Body.ClientHeight
                Exit Select

            Case 71
                v_retorno = OBJ_MOTOR_GECKOFX_71.Document.Body.ClientHeight
                Exit Select

            Case 72
                v_retorno = OBJ_MOTOR_GECKOFX_72.Document.Body.ClientHeight
                Exit Select

            Case 73
                v_retorno = OBJ_MOTOR_GECKOFX_73.Document.Body.ClientHeight
                Exit Select

            Case 74
                v_retorno = OBJ_MOTOR_GECKOFX_74.Document.Body.ClientHeight
                Exit Select

            Case 75
                v_retorno = OBJ_MOTOR_GECKOFX_75.Document.Body.ClientHeight
                Exit Select

            Case 76
                v_retorno = OBJ_MOTOR_GECKOFX_76.Document.Body.ClientHeight
                Exit Select

            Case 77
                v_retorno = OBJ_MOTOR_GECKOFX_77.Document.Body.ClientHeight
                Exit Select

            Case 78
                v_retorno = OBJ_MOTOR_GECKOFX_78.Document.Body.ClientHeight
                Exit Select

            Case 79
                v_retorno = OBJ_MOTOR_GECKOFX_79.Document.Body.ClientHeight
                Exit Select

            Case 80
                v_retorno = OBJ_MOTOR_GECKOFX_80.Document.Body.ClientHeight
                Exit Select

            Case 81
                v_retorno = OBJ_MOTOR_GECKOFX_81.Document.Body.ClientHeight
                Exit Select

            Case 82
                v_retorno = OBJ_MOTOR_GECKOFX_82.Document.Body.ClientHeight
                Exit Select

            Case 83
                v_retorno = OBJ_MOTOR_GECKOFX_83.Document.Body.ClientHeight
                Exit Select

            Case 84
                v_retorno = OBJ_MOTOR_GECKOFX_84.Document.Body.ClientHeight
                Exit Select

            Case 85
                v_retorno = OBJ_MOTOR_GECKOFX_85.Document.Body.ClientHeight
                Exit Select

            Case 86
                v_retorno = OBJ_MOTOR_GECKOFX_86.Document.Body.ClientHeight
                Exit Select

            Case 87
                v_retorno = OBJ_MOTOR_GECKOFX_87.Document.Body.ClientHeight
                Exit Select

            Case 88
                v_retorno = OBJ_MOTOR_GECKOFX_88.Document.Body.ClientHeight
                Exit Select

            Case 89
                v_retorno = OBJ_MOTOR_GECKOFX_89.Document.Body.ClientHeight
                Exit Select

            Case 90
                v_retorno = OBJ_MOTOR_GECKOFX_90.Document.Body.ClientHeight
                Exit Select

            Case 91
                v_retorno = OBJ_MOTOR_GECKOFX_91.Document.Body.ClientHeight
                Exit Select

            Case 92
                v_retorno = OBJ_MOTOR_GECKOFX_92.Document.Body.ClientHeight
                Exit Select

            Case 93
                v_retorno = OBJ_MOTOR_GECKOFX_93.Document.Body.ClientHeight
                Exit Select

            Case 94
                v_retorno = OBJ_MOTOR_GECKOFX_94.Document.Body.ClientHeight
                Exit Select

            Case 95
                v_retorno = OBJ_MOTOR_GECKOFX_95.Document.Body.ClientHeight
                Exit Select

            Case 96
                v_retorno = OBJ_MOTOR_GECKOFX_96.Document.Body.ClientHeight
                Exit Select

            Case 97
                v_retorno = OBJ_MOTOR_GECKOFX_97.Document.Body.ClientHeight
                Exit Select

            Case 98
                v_retorno = OBJ_MOTOR_GECKOFX_98.Document.Body.ClientHeight
                Exit Select

            Case 99
                v_retorno = OBJ_MOTOR_GECKOFX_99.Document.Body.ClientHeight
                Exit Select

            Case 100
                v_retorno = OBJ_MOTOR_GECKOFX_100.Document.Body.ClientHeight
                Exit Select

            Case 101
                v_retorno = OBJ_MOTOR_GECKOFX_101.Document.Body.ClientHeight
                Exit Select

            Case 102
                v_retorno = OBJ_MOTOR_GECKOFX_102.Document.Body.ClientHeight
                Exit Select

            Case 103
                v_retorno = OBJ_MOTOR_GECKOFX_103.Document.Body.ClientHeight
                Exit Select

            Case 104
                v_retorno = OBJ_MOTOR_GECKOFX_104.Document.Body.ClientHeight
                Exit Select

            Case 105
                v_retorno = OBJ_MOTOR_GECKOFX_105.Document.Body.ClientHeight
                Exit Select

            Case 106
                v_retorno = OBJ_MOTOR_GECKOFX_106.Document.Body.ClientHeight
                Exit Select

            Case 107
                v_retorno = OBJ_MOTOR_GECKOFX_107.Document.Body.ClientHeight
                Exit Select

            Case 108
                v_retorno = OBJ_MOTOR_GECKOFX_108.Document.Body.ClientHeight
                Exit Select

            Case 109
                v_retorno = OBJ_MOTOR_GECKOFX_109.Document.Body.ClientHeight
                Exit Select

            Case 110
                v_retorno = OBJ_MOTOR_GECKOFX_110.Document.Body.ClientHeight
                Exit Select

            Case 111
                v_retorno = OBJ_MOTOR_GECKOFX_111.Document.Body.ClientHeight
                Exit Select

            Case 112
                v_retorno = OBJ_MOTOR_GECKOFX_112.Document.Body.ClientHeight
                Exit Select

            Case 113
                v_retorno = OBJ_MOTOR_GECKOFX_113.Document.Body.ClientHeight
                Exit Select

            Case 114
                v_retorno = OBJ_MOTOR_GECKOFX_114.Document.Body.ClientHeight
                Exit Select

            Case 115
                v_retorno = OBJ_MOTOR_GECKOFX_115.Document.Body.ClientHeight
                Exit Select

            Case 116
                v_retorno = OBJ_MOTOR_GECKOFX_116.Document.Body.ClientHeight
                Exit Select

            Case 117
                v_retorno = OBJ_MOTOR_GECKOFX_117.Document.Body.ClientHeight
                Exit Select

            Case 118
                v_retorno = OBJ_MOTOR_GECKOFX_118.Document.Body.ClientHeight
                Exit Select

            Case 119
                v_retorno = OBJ_MOTOR_GECKOFX_119.Document.Body.ClientHeight
                Exit Select

            Case 120
                v_retorno = OBJ_MOTOR_GECKOFX_120.Document.Body.ClientHeight
                Exit Select

            Case 121
                v_retorno = OBJ_MOTOR_GECKOFX_121.Document.Body.ClientHeight
                Exit Select

            Case 122
                v_retorno = OBJ_MOTOR_GECKOFX_122.Document.Body.ClientHeight
                Exit Select

            Case 123
                v_retorno = OBJ_MOTOR_GECKOFX_123.Document.Body.ClientHeight
                Exit Select

            Case 124
                v_retorno = OBJ_MOTOR_GECKOFX_124.Document.Body.ClientHeight
                Exit Select

            Case 125
                v_retorno = OBJ_MOTOR_GECKOFX_125.Document.Body.ClientHeight
                Exit Select

            Case 126
                v_retorno = OBJ_MOTOR_GECKOFX_126.Document.Body.ClientHeight
                Exit Select

            Case 127
                v_retorno = OBJ_MOTOR_GECKOFX_127.Document.Body.ClientHeight
                Exit Select

            Case 128
                v_retorno = OBJ_MOTOR_GECKOFX_128.Document.Body.ClientHeight
                Exit Select

            




        End Select




        'Retorno -----------------------------------

        Return v_retorno

        '-------------------------------------------


    End Function

    Public Function func_retorne_a_largura_da_pagina_do_motor_geckofx() 'Retorna a largura da pagina do motor geckofx
        On Error Resume Next

        Dim v_retorno As Integer 'Retorno






        Select Case v_qual_motor_esta_em_uso


            Case 1
                v_retorno = OBJ_MOTOR_GECKOFX_1.Document.Body.ClientWidth
                Exit Select

            Case 2
                v_retorno = OBJ_MOTOR_GECKOFX_2.Document.Body.ClientWidth
                Exit Select

            Case 3
                v_retorno = OBJ_MOTOR_GECKOFX_3.Document.Body.ClientWidth
                Exit Select

            Case 4
                v_retorno = OBJ_MOTOR_GECKOFX_4.Document.Body.ClientWidth
                Exit Select

            Case 5
                v_retorno = OBJ_MOTOR_GECKOFX_5.Document.Body.ClientWidth
                Exit Select

            Case 6
                v_retorno = OBJ_MOTOR_GECKOFX_6.Document.Body.ClientWidth
                Exit Select

            Case 7
                v_retorno = OBJ_MOTOR_GECKOFX_7.Document.Body.ClientWidth
                Exit Select

            Case 8
                v_retorno = OBJ_MOTOR_GECKOFX_8.Document.Body.ClientWidth
                Exit Select

            Case 9
                v_retorno = OBJ_MOTOR_GECKOFX_9.Document.Body.ClientWidth
                Exit Select

            Case 10
                v_retorno = OBJ_MOTOR_GECKOFX_10.Document.Body.ClientWidth
                Exit Select

            Case 11
                v_retorno = OBJ_MOTOR_GECKOFX_11.Document.Body.ClientWidth
                Exit Select

            Case 12
                v_retorno = OBJ_MOTOR_GECKOFX_12.Document.Body.ClientWidth
                Exit Select

            Case 13
                v_retorno = OBJ_MOTOR_GECKOFX_13.Document.Body.ClientWidth
                Exit Select

            Case 14
                v_retorno = OBJ_MOTOR_GECKOFX_14.Document.Body.ClientWidth
                Exit Select

            Case 15
                v_retorno = OBJ_MOTOR_GECKOFX_15.Document.Body.ClientWidth
                Exit Select

            Case 16
                v_retorno = OBJ_MOTOR_GECKOFX_16.Document.Body.ClientWidth
                Exit Select

            Case 17
                v_retorno = OBJ_MOTOR_GECKOFX_17.Document.Body.ClientWidth
                Exit Select

            Case 18
                v_retorno = OBJ_MOTOR_GECKOFX_18.Document.Body.ClientWidth
                Exit Select

            Case 19
                v_retorno = OBJ_MOTOR_GECKOFX_19.Document.Body.ClientWidth
                Exit Select

            Case 20
                v_retorno = OBJ_MOTOR_GECKOFX_20.Document.Body.ClientWidth
                Exit Select

            Case 21
                v_retorno = OBJ_MOTOR_GECKOFX_21.Document.Body.ClientWidth
                Exit Select

            Case 22
                v_retorno = OBJ_MOTOR_GECKOFX_22.Document.Body.ClientWidth
                Exit Select

            Case 23
                v_retorno = OBJ_MOTOR_GECKOFX_23.Document.Body.ClientWidth
                Exit Select

            Case 24
                v_retorno = OBJ_MOTOR_GECKOFX_24.Document.Body.ClientWidth
                Exit Select

            Case 25
                v_retorno = OBJ_MOTOR_GECKOFX_25.Document.Body.ClientWidth
                Exit Select

            Case 26
                v_retorno = OBJ_MOTOR_GECKOFX_26.Document.Body.ClientWidth
                Exit Select

            Case 27
                v_retorno = OBJ_MOTOR_GECKOFX_27.Document.Body.ClientWidth
                Exit Select

            Case 28
                v_retorno = OBJ_MOTOR_GECKOFX_28.Document.Body.ClientWidth
                Exit Select

            Case 29
                v_retorno = OBJ_MOTOR_GECKOFX_29.Document.Body.ClientWidth
                Exit Select

            Case 30
                v_retorno = OBJ_MOTOR_GECKOFX_30.Document.Body.ClientWidth
                Exit Select

            Case 31
                v_retorno = OBJ_MOTOR_GECKOFX_31.Document.Body.ClientWidth
                Exit Select

            Case 32
                v_retorno = OBJ_MOTOR_GECKOFX_32.Document.Body.ClientWidth
                Exit Select

            Case 33
                v_retorno = OBJ_MOTOR_GECKOFX_33.Document.Body.ClientWidth
                Exit Select

            Case 34
                v_retorno = OBJ_MOTOR_GECKOFX_34.Document.Body.ClientWidth
                Exit Select

            Case 35
                v_retorno = OBJ_MOTOR_GECKOFX_35.Document.Body.ClientWidth
                Exit Select

            Case 36
                v_retorno = OBJ_MOTOR_GECKOFX_36.Document.Body.ClientWidth
                Exit Select

            Case 37
                v_retorno = OBJ_MOTOR_GECKOFX_37.Document.Body.ClientWidth
                Exit Select

            Case 38
                v_retorno = OBJ_MOTOR_GECKOFX_38.Document.Body.ClientWidth
                Exit Select

            Case 39
                v_retorno = OBJ_MOTOR_GECKOFX_39.Document.Body.ClientWidth
                Exit Select

            Case 40
                v_retorno = OBJ_MOTOR_GECKOFX_40.Document.Body.ClientWidth
                Exit Select

            Case 41
                v_retorno = OBJ_MOTOR_GECKOFX_41.Document.Body.ClientWidth
                Exit Select

            Case 42
                v_retorno = OBJ_MOTOR_GECKOFX_42.Document.Body.ClientWidth
                Exit Select

            Case 43
                v_retorno = OBJ_MOTOR_GECKOFX_43.Document.Body.ClientWidth
                Exit Select

            Case 44
                v_retorno = OBJ_MOTOR_GECKOFX_44.Document.Body.ClientWidth
                Exit Select

            Case 45
                v_retorno = OBJ_MOTOR_GECKOFX_45.Document.Body.ClientWidth
                Exit Select

            Case 46
                v_retorno = OBJ_MOTOR_GECKOFX_46.Document.Body.ClientWidth
                Exit Select

            Case 47
                v_retorno = OBJ_MOTOR_GECKOFX_47.Document.Body.ClientWidth
                Exit Select

            Case 48
                v_retorno = OBJ_MOTOR_GECKOFX_48.Document.Body.ClientWidth
                Exit Select

            Case 49
                v_retorno = OBJ_MOTOR_GECKOFX_49.Document.Body.ClientWidth
                Exit Select

            Case 50
                v_retorno = OBJ_MOTOR_GECKOFX_50.Document.Body.ClientWidth
                Exit Select

            Case 51
                v_retorno = OBJ_MOTOR_GECKOFX_51.Document.Body.ClientWidth
                Exit Select

            Case 52
                v_retorno = OBJ_MOTOR_GECKOFX_52.Document.Body.ClientWidth
                Exit Select

            Case 53
                v_retorno = OBJ_MOTOR_GECKOFX_53.Document.Body.ClientWidth
                Exit Select

            Case 54
                v_retorno = OBJ_MOTOR_GECKOFX_54.Document.Body.ClientWidth
                Exit Select

            Case 55
                v_retorno = OBJ_MOTOR_GECKOFX_55.Document.Body.ClientWidth
                Exit Select

            Case 56
                v_retorno = OBJ_MOTOR_GECKOFX_56.Document.Body.ClientWidth
                Exit Select

            Case 57
                v_retorno = OBJ_MOTOR_GECKOFX_57.Document.Body.ClientWidth
                Exit Select

            Case 58
                v_retorno = OBJ_MOTOR_GECKOFX_58.Document.Body.ClientWidth
                Exit Select

            Case 59
                v_retorno = OBJ_MOTOR_GECKOFX_59.Document.Body.ClientWidth
                Exit Select

            Case 60
                v_retorno = OBJ_MOTOR_GECKOFX_60.Document.Body.ClientWidth
                Exit Select

            Case 61
                v_retorno = OBJ_MOTOR_GECKOFX_61.Document.Body.ClientWidth
                Exit Select

            Case 62
                v_retorno = OBJ_MOTOR_GECKOFX_62.Document.Body.ClientWidth
                Exit Select

            Case 63
                v_retorno = OBJ_MOTOR_GECKOFX_63.Document.Body.ClientWidth
                Exit Select

            Case 64
                v_retorno = OBJ_MOTOR_GECKOFX_64.Document.Body.ClientWidth
                Exit Select

            Case 65
                v_retorno = OBJ_MOTOR_GECKOFX_65.Document.Body.ClientWidth
                Exit Select

            Case 66
                v_retorno = OBJ_MOTOR_GECKOFX_66.Document.Body.ClientWidth
                Exit Select

            Case 67
                v_retorno = OBJ_MOTOR_GECKOFX_67.Document.Body.ClientWidth
                Exit Select

            Case 68
                v_retorno = OBJ_MOTOR_GECKOFX_68.Document.Body.ClientWidth
                Exit Select

            Case 69
                v_retorno = OBJ_MOTOR_GECKOFX_69.Document.Body.ClientWidth
                Exit Select

            Case 70
                v_retorno = OBJ_MOTOR_GECKOFX_70.Document.Body.ClientWidth
                Exit Select

            Case 71
                v_retorno = OBJ_MOTOR_GECKOFX_71.Document.Body.ClientWidth
                Exit Select

            Case 72
                v_retorno = OBJ_MOTOR_GECKOFX_72.Document.Body.ClientWidth
                Exit Select

            Case 73
                v_retorno = OBJ_MOTOR_GECKOFX_73.Document.Body.ClientWidth
                Exit Select

            Case 74
                v_retorno = OBJ_MOTOR_GECKOFX_74.Document.Body.ClientWidth
                Exit Select

            Case 75
                v_retorno = OBJ_MOTOR_GECKOFX_75.Document.Body.ClientWidth
                Exit Select

            Case 76
                v_retorno = OBJ_MOTOR_GECKOFX_76.Document.Body.ClientWidth
                Exit Select

            Case 77
                v_retorno = OBJ_MOTOR_GECKOFX_77.Document.Body.ClientWidth
                Exit Select

            Case 78
                v_retorno = OBJ_MOTOR_GECKOFX_78.Document.Body.ClientWidth
                Exit Select

            Case 79
                v_retorno = OBJ_MOTOR_GECKOFX_79.Document.Body.ClientWidth
                Exit Select

            Case 80
                v_retorno = OBJ_MOTOR_GECKOFX_80.Document.Body.ClientWidth
                Exit Select

            Case 81
                v_retorno = OBJ_MOTOR_GECKOFX_81.Document.Body.ClientWidth
                Exit Select

            Case 82
                v_retorno = OBJ_MOTOR_GECKOFX_82.Document.Body.ClientWidth
                Exit Select

            Case 83
                v_retorno = OBJ_MOTOR_GECKOFX_83.Document.Body.ClientWidth
                Exit Select

            Case 84
                v_retorno = OBJ_MOTOR_GECKOFX_84.Document.Body.ClientWidth
                Exit Select

            Case 85
                v_retorno = OBJ_MOTOR_GECKOFX_85.Document.Body.ClientWidth
                Exit Select

            Case 86
                v_retorno = OBJ_MOTOR_GECKOFX_86.Document.Body.ClientWidth
                Exit Select

            Case 87
                v_retorno = OBJ_MOTOR_GECKOFX_87.Document.Body.ClientWidth
                Exit Select

            Case 88
                v_retorno = OBJ_MOTOR_GECKOFX_88.Document.Body.ClientWidth
                Exit Select

            Case 89
                v_retorno = OBJ_MOTOR_GECKOFX_89.Document.Body.ClientWidth
                Exit Select

            Case 90
                v_retorno = OBJ_MOTOR_GECKOFX_90.Document.Body.ClientWidth
                Exit Select

            Case 91
                v_retorno = OBJ_MOTOR_GECKOFX_91.Document.Body.ClientWidth
                Exit Select

            Case 92
                v_retorno = OBJ_MOTOR_GECKOFX_92.Document.Body.ClientWidth
                Exit Select

            Case 93
                v_retorno = OBJ_MOTOR_GECKOFX_93.Document.Body.ClientWidth
                Exit Select

            Case 94
                v_retorno = OBJ_MOTOR_GECKOFX_94.Document.Body.ClientWidth
                Exit Select

            Case 95
                v_retorno = OBJ_MOTOR_GECKOFX_95.Document.Body.ClientWidth
                Exit Select

            Case 96
                v_retorno = OBJ_MOTOR_GECKOFX_96.Document.Body.ClientWidth
                Exit Select

            Case 97
                v_retorno = OBJ_MOTOR_GECKOFX_97.Document.Body.ClientWidth
                Exit Select

            Case 98
                v_retorno = OBJ_MOTOR_GECKOFX_98.Document.Body.ClientWidth
                Exit Select

            Case 99
                v_retorno = OBJ_MOTOR_GECKOFX_99.Document.Body.ClientWidth
                Exit Select

            Case 100
                v_retorno = OBJ_MOTOR_GECKOFX_100.Document.Body.ClientWidth
                Exit Select

            Case 101
                v_retorno = OBJ_MOTOR_GECKOFX_101.Document.Body.ClientWidth
                Exit Select

            Case 102
                v_retorno = OBJ_MOTOR_GECKOFX_102.Document.Body.ClientWidth
                Exit Select

            Case 103
                v_retorno = OBJ_MOTOR_GECKOFX_103.Document.Body.ClientWidth
                Exit Select

            Case 104
                v_retorno = OBJ_MOTOR_GECKOFX_104.Document.Body.ClientWidth
                Exit Select

            Case 105
                v_retorno = OBJ_MOTOR_GECKOFX_105.Document.Body.ClientWidth
                Exit Select

            Case 106
                v_retorno = OBJ_MOTOR_GECKOFX_106.Document.Body.ClientWidth
                Exit Select

            Case 107
                v_retorno = OBJ_MOTOR_GECKOFX_107.Document.Body.ClientWidth
                Exit Select

            Case 108
                v_retorno = OBJ_MOTOR_GECKOFX_108.Document.Body.ClientWidth
                Exit Select

            Case 109
                v_retorno = OBJ_MOTOR_GECKOFX_109.Document.Body.ClientWidth
                Exit Select

            Case 110
                v_retorno = OBJ_MOTOR_GECKOFX_110.Document.Body.ClientWidth
                Exit Select

            Case 111
                v_retorno = OBJ_MOTOR_GECKOFX_111.Document.Body.ClientWidth
                Exit Select

            Case 112
                v_retorno = OBJ_MOTOR_GECKOFX_112.Document.Body.ClientWidth
                Exit Select

            Case 113
                v_retorno = OBJ_MOTOR_GECKOFX_113.Document.Body.ClientWidth
                Exit Select

            Case 114
                v_retorno = OBJ_MOTOR_GECKOFX_114.Document.Body.ClientWidth
                Exit Select

            Case 115
                v_retorno = OBJ_MOTOR_GECKOFX_115.Document.Body.ClientWidth
                Exit Select

            Case 116
                v_retorno = OBJ_MOTOR_GECKOFX_116.Document.Body.ClientWidth
                Exit Select

            Case 117
                v_retorno = OBJ_MOTOR_GECKOFX_117.Document.Body.ClientWidth
                Exit Select

            Case 118
                v_retorno = OBJ_MOTOR_GECKOFX_118.Document.Body.ClientWidth
                Exit Select

            Case 119
                v_retorno = OBJ_MOTOR_GECKOFX_119.Document.Body.ClientWidth
                Exit Select

            Case 120
                v_retorno = OBJ_MOTOR_GECKOFX_120.Document.Body.ClientWidth
                Exit Select

            Case 121
                v_retorno = OBJ_MOTOR_GECKOFX_121.Document.Body.ClientWidth
                Exit Select

            Case 122
                v_retorno = OBJ_MOTOR_GECKOFX_122.Document.Body.ClientWidth
                Exit Select

            Case 123
                v_retorno = OBJ_MOTOR_GECKOFX_123.Document.Body.ClientWidth
                Exit Select

            Case 124
                v_retorno = OBJ_MOTOR_GECKOFX_124.Document.Body.ClientWidth
                Exit Select

            Case 125
                v_retorno = OBJ_MOTOR_GECKOFX_125.Document.Body.ClientWidth
                Exit Select

            Case 126
                v_retorno = OBJ_MOTOR_GECKOFX_126.Document.Body.ClientWidth
                Exit Select

            Case 127
                v_retorno = OBJ_MOTOR_GECKOFX_127.Document.Body.ClientWidth
                Exit Select

            Case 128
                v_retorno = OBJ_MOTOR_GECKOFX_128.Document.Body.ClientWidth
                Exit Select

            




        End Select




        'Retorno -----------------------------------

        Return v_retorno

        '-------------------------------------------


    End Function

    Public Sub proc_visualizar_impressao() 'Visualizar impressão
        On Error Resume Next

        Dim V_IMAGEM_DE_TRABALHO As Image = func_gerar_imagem_completa_site_visualizacao_geckofx() 'Gera a imagem completa do site em visualização

        Dim V_AL, V_LAR As Integer 'Largura e altura

        Dim V_ESCALA As Single 'Escala do calculo de divisao

        Dim V_TAMANHO_DA_PAGINA As Single 'Informa o tamanho da pagina






        'Calculando tamanho --------------------------------------------------------------------------------------------

        V_AL = func_retorne_a_altura_da_pagina_do_motor_geckofx() 'Retorna a altura da pagina do motor geckofx

        V_LAR = func_retorne_a_largura_da_pagina_do_motor_geckofx() 'Retorna a largura da pagina do motor geckofx

        V_ESCALA = (V_AL / V_LAR) 'Obtendo a escala

        V_TAMANHO_DA_PAGINA = V_AL / V_ESCALA 'Obtendo o tamanho da pagina


        'Não permite imagem menor que o valor informado abaixo ser divida em duas partes

        If (V_AL < 1024) Then

            V_TAMANHO_DA_PAGINA = V_AL * 2 'Recalculando valor...

        End If

        '---------------------------------------------------------------------------------------------------------------



        'Dividindo imagem em partes separadas --------------------------------------------------------------------------

        proc_dividir_imagem(V_IMAGEM_DE_TRABALHO, V_TAMANHO_DA_PAGINA) 'Procedimento de divisão de imagem

        '--------------------------------------------------------------------------------------------------------------


        'Visualizando impressao ----------------------------------------------------------------------

        FRM_NAVEGACAO.prt_visualizar_impressao.ShowDialog() 'Visualizando...

        '---------------------------------------------------------------------------------------------


    End Sub







    'Imprimir página

    Private Sub proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
        On Error Resume Next

        Dim V_IMAGEM_DE_TRABALHO As Image = func_gerar_imagem_completa_site_visualizacao_geckofx() 'Gera a imagem completa do site em visualização

        Dim V_AL, V_LAR As Integer 'Largura e altura

        Dim V_ESCALA As Single 'Escala do calculo de divisao

        Dim V_TAMANHO_DA_PAGINA As Single 'Informa o tamanho da pagina






        'Calculando tamanho --------------------------------------------------------------------------------------------

        V_AL = func_retorne_a_altura_da_pagina_do_motor_geckofx() 'Retorna a altura da pagina do motor geckofx

        V_LAR = func_retorne_a_largura_da_pagina_do_motor_geckofx() 'Retorna a largura da pagina do motor geckofx

        V_ESCALA = (V_AL / V_LAR) 'Obtendo a escala

        V_TAMANHO_DA_PAGINA = V_AL / V_ESCALA 'Obtendo o tamanho da pagina


        'Não permite imagem menor que o valor informado abaixo ser divida em duas partes

        If (V_AL < 1024) Then

            V_TAMANHO_DA_PAGINA = V_AL * 2 'Recalculando valor...

        End If

        '---------------------------------------------------------------------------------------------------------------



        'Dividindo imagem em partes separadas --------------------------------------------------------------------------

        proc_dividir_imagem(V_IMAGEM_DE_TRABALHO, V_TAMANHO_DA_PAGINA) 'Procedimento de divisão de imagem

        '--------------------------------------------------------------------------------------------------------------


        'Visualizando impressao ----------------------------------------------------------------------

        FRM_NAVEGACAO.m_PrintDocument.Print() 'Imprimindo imagens

        '---------------------------------------------------------------------------------------------

    End Sub

    Public Sub proc_imprimir_a_pagina() 'Imprimir página
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_1.Print() 'Imprimir trident
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_2.Print() 'Imprimir trident
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_3.Print() 'Imprimir trident
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_4.Print() 'Imprimir trident
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_5.Print() 'Imprimir trident
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_6.Print() 'Imprimir trident
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_7.Print() 'Imprimir trident
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_8.Print() 'Imprimir trident
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_9.Print() 'Imprimir trident
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_10.Print() 'Imprimir trident
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_11.Print() 'Imprimir trident
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_12.Print() 'Imprimir trident
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_13.Print() 'Imprimir trident
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_14.Print() 'Imprimir trident
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_15.Print() 'Imprimir trident
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_16.Print() 'Imprimir trident
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_17.Print() 'Imprimir trident
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_18.Print() 'Imprimir trident
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_19.Print() 'Imprimir trident
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_20.Print() 'Imprimir trident
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_21.Print() 'Imprimir trident
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_22.Print() 'Imprimir trident
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_23.Print() 'Imprimir trident
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_24.Print() 'Imprimir trident
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_25.Print() 'Imprimir trident
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_26.Print() 'Imprimir trident
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_27.Print() 'Imprimir trident
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_28.Print() 'Imprimir trident
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_29.Print() 'Imprimir trident
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_30.Print() 'Imprimir trident
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_31.Print() 'Imprimir trident
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_32.Print() 'Imprimir trident
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_33.Print() 'Imprimir trident
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_34.Print() 'Imprimir trident
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_35.Print() 'Imprimir trident
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_36.Print() 'Imprimir trident
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_37.Print() 'Imprimir trident
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_38.Print() 'Imprimir trident
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_39.Print() 'Imprimir trident
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_40.Print() 'Imprimir trident
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_41.Print() 'Imprimir trident
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_42.Print() 'Imprimir trident
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_43.Print() 'Imprimir trident
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_44.Print() 'Imprimir trident
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_45.Print() 'Imprimir trident
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_46.Print() 'Imprimir trident
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_47.Print() 'Imprimir trident
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_48.Print() 'Imprimir trident
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_49.Print() 'Imprimir trident
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_50.Print() 'Imprimir trident
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_51.Print() 'Imprimir trident
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_52.Print() 'Imprimir trident
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_53.Print() 'Imprimir trident
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_54.Print() 'Imprimir trident
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_55.Print() 'Imprimir trident
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_56.Print() 'Imprimir trident
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_57.Print() 'Imprimir trident
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_58.Print() 'Imprimir trident
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_59.Print() 'Imprimir trident
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_60.Print() 'Imprimir trident
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_61.Print() 'Imprimir trident
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_62.Print() 'Imprimir trident
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_63.Print() 'Imprimir trident
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_64.Print() 'Imprimir trident
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_65.Print() 'Imprimir trident
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_66.Print() 'Imprimir trident
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_67.Print() 'Imprimir trident
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_68.Print() 'Imprimir trident
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_69.Print() 'Imprimir trident
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_70.Print() 'Imprimir trident
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_71.Print() 'Imprimir trident
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_72.Print() 'Imprimir trident
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_73.Print() 'Imprimir trident
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_74.Print() 'Imprimir trident
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_75.Print() 'Imprimir trident
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_76.Print() 'Imprimir trident
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_77.Print() 'Imprimir trident
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_78.Print() 'Imprimir trident
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_79.Print() 'Imprimir trident
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_80.Print() 'Imprimir trident
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_81.Print() 'Imprimir trident
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_82.Print() 'Imprimir trident
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_83.Print() 'Imprimir trident
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_84.Print() 'Imprimir trident
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_85.Print() 'Imprimir trident
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_86.Print() 'Imprimir trident
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_87.Print() 'Imprimir trident
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_88.Print() 'Imprimir trident
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_89.Print() 'Imprimir trident
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_90.Print() 'Imprimir trident
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_91.Print() 'Imprimir trident
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_92.Print() 'Imprimir trident
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_93.Print() 'Imprimir trident
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_94.Print() 'Imprimir trident
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_95.Print() 'Imprimir trident
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_96.Print() 'Imprimir trident
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_97.Print() 'Imprimir trident
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_98.Print() 'Imprimir trident
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_99.Print() 'Imprimir trident
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_100.Print() 'Imprimir trident
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_101.Print() 'Imprimir trident
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_102.Print() 'Imprimir trident
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_103.Print() 'Imprimir trident
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_104.Print() 'Imprimir trident
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_105.Print() 'Imprimir trident
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_106.Print() 'Imprimir trident
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_107.Print() 'Imprimir trident
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_108.Print() 'Imprimir trident
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_109.Print() 'Imprimir trident
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_110.Print() 'Imprimir trident
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_111.Print() 'Imprimir trident
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_112.Print() 'Imprimir trident
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_113.Print() 'Imprimir trident
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_114.Print() 'Imprimir trident
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_115.Print() 'Imprimir trident
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_116.Print() 'Imprimir trident
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_117.Print() 'Imprimir trident
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_118.Print() 'Imprimir trident
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_119.Print() 'Imprimir trident
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_120.Print() 'Imprimir trident
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_121.Print() 'Imprimir trident
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_122.Print() 'Imprimir trident
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_123.Print() 'Imprimir trident
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_124.Print() 'Imprimir trident
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_125.Print() 'Imprimir trident
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_126.Print() 'Imprimir trident
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_127.Print() 'Imprimir trident
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    proc_complemento_de_impressao_geckofx() 'Complemento de impressao do geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_128.Print() 'Imprimir trident
                End If
                Exit Select

            




        End Select


    End Sub





    'Refazer e desfazer

    Public Sub proc_desfazer_acao() 'Desfazer ação
        On Error Resume Next



        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_1.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_1.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_2.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_2.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_3.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_3.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_4.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_4.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_5.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_5.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_6.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_6.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_7.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_7.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_8.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_8.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_9.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_9.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_10.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_10.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_11.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_11.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_12.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_12.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_13.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_13.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_14.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_14.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_15.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_15.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_16.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_16.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_17.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_17.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_18.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_18.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_19.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_19.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_20.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_20.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_21.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_21.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_22.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_22.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_23.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_23.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_24.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_24.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_25.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_25.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_26.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_26.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_27.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_27.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_28.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_28.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_29.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_29.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_30.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_30.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_31.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_31.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_32.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_32.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_33.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_33.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_34.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_34.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_35.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_35.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_36.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_36.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_37.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_37.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_38.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_38.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_39.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_39.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_40.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_40.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_41.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_41.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_42.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_42.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_43.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_43.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_44.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_44.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_45.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_45.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_46.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_46.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_47.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_47.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_48.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_48.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_49.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_49.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_50.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_50.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_51.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_51.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_52.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_52.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_53.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_53.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_54.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_54.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_55.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_55.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_56.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_56.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_57.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_57.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_58.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_58.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_59.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_59.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_60.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_60.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_61.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_61.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_62.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_62.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_63.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_63.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_64.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_64.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_65.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_65.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_66.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_66.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_67.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_67.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_68.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_68.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_69.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_69.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_70.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_70.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_71.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_71.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_72.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_72.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_73.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_73.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_74.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_74.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_75.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_75.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_76.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_76.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_77.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_77.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_78.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_78.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_79.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_79.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_80.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_80.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_81.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_81.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_82.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_82.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_83.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_83.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_84.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_84.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_85.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_85.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_86.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_86.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_87.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_87.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_88.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_88.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_89.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_89.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_90.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_90.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_91.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_91.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_92.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_92.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_93.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_93.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_94.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_94.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_95.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_95.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_96.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_96.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_97.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_97.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_98.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_98.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_99.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_99.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_100.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_100.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_101.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_101.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_102.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_102.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_103.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_103.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_104.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_104.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_105.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_105.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_106.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_106.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_107.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_107.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_108.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_108.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_109.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_109.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_110.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_110.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_111.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_111.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_112.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_112.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_113.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_113.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_114.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_114.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_115.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_115.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_116.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_116.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_117.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_117.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_118.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_118.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_119.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_119.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_120.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_120.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_121.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_121.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_122.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_122.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_123.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_123.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_124.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_124.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_125.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_125.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_126.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_126.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_127.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_127.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_128.Undo() 'Desfazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_128.Document.ExecCommand("Undo", False, DBNull.Value) 'Desfazer em trident 
                End If
                Exit Select

            




        End Select


    End Sub

    Public Sub proc_refazer_acao() 'Refazer ação
        On Error Resume Next



        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_1.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_1.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_2.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_2.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_3.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_3.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_4.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_4.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_5.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_5.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_6.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_6.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_7.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_7.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_8.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_8.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_9.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_9.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_10.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_10.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_11.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_11.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_12.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_12.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_13.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_13.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_14.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_14.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_15.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_15.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_16.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_16.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_17.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_17.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_18.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_18.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_19.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_19.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_20.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_20.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_21.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_21.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_22.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_22.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_23.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_23.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_24.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_24.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_25.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_25.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_26.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_26.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_27.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_27.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_28.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_28.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_29.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_29.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_30.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_30.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_31.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_31.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_32.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_32.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_33.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_33.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_34.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_34.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_35.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_35.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_36.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_36.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_37.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_37.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_38.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_38.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_39.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_39.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_40.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_40.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_41.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_41.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_42.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_42.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_43.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_43.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_44.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_44.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_45.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_45.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_46.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_46.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_47.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_47.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_48.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_48.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_49.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_49.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_50.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_50.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_51.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_51.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_52.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_52.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_53.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_53.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_54.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_54.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_55.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_55.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_56.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_56.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_57.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_57.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_58.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_58.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_59.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_59.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_60.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_60.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_61.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_61.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_62.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_62.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_63.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_63.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_64.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_64.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_65.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_65.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_66.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_66.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_67.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_67.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_68.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_68.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_69.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_69.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_70.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_70.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_71.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_71.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_72.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_72.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_73.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_73.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_74.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_74.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_75.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_75.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_76.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_76.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_77.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_77.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_78.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_78.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_79.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_79.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_80.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_80.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_81.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_81.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_82.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_82.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_83.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_83.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_84.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_84.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_85.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_85.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_86.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_86.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_87.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_87.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_88.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_88.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_89.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_89.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_90.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_90.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_91.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_91.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_92.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_92.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_93.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_93.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_94.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_94.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_95.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_95.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_96.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_96.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_97.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_97.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_98.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_98.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_99.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_99.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_100.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_100.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_101.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_101.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_102.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_102.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_103.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_103.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_104.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_104.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_105.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_105.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_106.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_106.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_107.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_107.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_108.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_108.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_109.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_109.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_110.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_110.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_111.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_111.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_112.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_112.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_113.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_113.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_114.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_114.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_115.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_115.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_116.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_116.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_117.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_117.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_118.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_118.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_119.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_119.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_120.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_120.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_121.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_121.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_122.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_122.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_123.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_123.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_124.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_124.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_125.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_125.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_126.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_126.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_127.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_127.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_128.Redo() 'Refazer em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_128.Document.ExecCommand("Redo", True, DBNull.Value) 'Refazer em trident 
                End If
                Exit Select

            




        End Select


    End Sub






    'Recortar, copiar, e colar, selecionar etc...

    Public Sub proc_recortar_acao() 'Recortar ação
        On Error Resume Next



        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_1.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_1.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_2.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_2.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_3.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_3.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_4.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_4.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_5.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_5.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_6.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_6.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_7.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_7.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_8.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_8.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_9.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_9.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_10.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_10.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_11.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_11.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_12.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_12.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_13.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_13.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_14.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_14.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_15.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_15.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_16.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_16.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_17.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_17.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_18.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_18.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_19.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_19.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_20.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_20.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_21.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_21.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_22.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_22.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_23.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_23.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_24.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_24.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_25.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_25.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_26.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_26.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_27.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_27.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_28.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_28.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_29.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_29.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_30.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_30.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_31.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_31.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_32.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_32.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_33.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_33.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_34.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_34.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_35.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_35.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_36.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_36.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_37.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_37.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_38.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_38.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_39.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_39.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_40.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_40.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_41.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_41.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_42.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_42.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_43.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_43.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_44.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_44.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_45.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_45.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_46.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_46.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_47.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_47.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_48.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_48.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_49.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_49.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_50.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_50.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_51.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_51.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_52.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_52.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_53.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_53.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_54.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_54.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_55.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_55.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_56.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_56.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_57.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_57.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_58.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_58.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_59.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_59.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_60.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_60.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_61.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_61.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_62.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_62.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_63.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_63.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_64.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_64.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_65.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_65.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_66.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_66.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_67.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_67.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_68.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_68.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_69.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_69.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_70.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_70.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_71.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_71.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_72.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_72.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_73.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_73.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_74.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_74.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_75.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_75.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_76.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_76.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_77.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_77.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_78.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_78.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_79.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_79.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_80.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_80.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_81.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_81.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_82.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_82.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_83.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_83.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_84.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_84.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_85.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_85.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_86.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_86.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_87.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_87.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_88.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_88.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_89.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_89.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_90.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_90.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_91.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_91.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_92.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_92.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_93.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_93.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_94.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_94.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_95.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_95.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_96.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_96.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_97.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_97.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_98.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_98.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_99.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_99.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_100.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_100.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_101.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_101.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_102.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_102.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_103.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_103.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_104.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_104.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_105.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_105.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_106.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_106.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_107.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_107.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_108.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_108.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_109.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_109.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_110.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_110.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_111.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_111.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_112.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_112.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_113.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_113.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_114.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_114.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_115.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_115.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_116.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_116.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_117.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_117.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_118.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_118.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_119.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_119.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_120.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_120.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_121.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_121.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_122.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_122.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_123.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_123.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_124.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_124.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_125.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_125.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_126.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_126.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_127.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_127.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_128.CutSelection() 'Recortar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_128.Document.ExecCommand("Cut", False, DBNull.Value) 'Recortar seleção trident 
                End If
                Exit Select

            




        End Select


    End Sub

    Public Sub proc_copiar_acao() 'Copiar ação
        On Error Resume Next



        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_1.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_1.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_2.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_2.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_3.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_3.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_4.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_4.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_5.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_5.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_6.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_6.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_7.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_7.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_8.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_8.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_9.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_9.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_10.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_10.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_11.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_11.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_12.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_12.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_13.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_13.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_14.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_14.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_15.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_15.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_16.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_16.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_17.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_17.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_18.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_18.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_19.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_19.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_20.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_20.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_21.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_21.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_22.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_22.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_23.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_23.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_24.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_24.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_25.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_25.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_26.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_26.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_27.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_27.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_28.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_28.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_29.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_29.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_30.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_30.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_31.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_31.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_32.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_32.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_33.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_33.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_34.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_34.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_35.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_35.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_36.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_36.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_37.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_37.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_38.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_38.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_39.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_39.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_40.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_40.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_41.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_41.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_42.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_42.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_43.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_43.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_44.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_44.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_45.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_45.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_46.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_46.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_47.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_47.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_48.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_48.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_49.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_49.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_50.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_50.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_51.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_51.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_52.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_52.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_53.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_53.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_54.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_54.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_55.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_55.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_56.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_56.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_57.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_57.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_58.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_58.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_59.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_59.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_60.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_60.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_61.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_61.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_62.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_62.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_63.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_63.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_64.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_64.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_65.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_65.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_66.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_66.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_67.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_67.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_68.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_68.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_69.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_69.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_70.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_70.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_71.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_71.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_72.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_72.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_73.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_73.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_74.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_74.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_75.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_75.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_76.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_76.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_77.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_77.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_78.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_78.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_79.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_79.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_80.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_80.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_81.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_81.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_82.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_82.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_83.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_83.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_84.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_84.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_85.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_85.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_86.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_86.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_87.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_87.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_88.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_88.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_89.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_89.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_90.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_90.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_91.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_91.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_92.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_92.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_93.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_93.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_94.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_94.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_95.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_95.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_96.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_96.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_97.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_97.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_98.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_98.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_99.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_99.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_100.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_100.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_101.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_101.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_102.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_102.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_103.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_103.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_104.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_104.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_105.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_105.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_106.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_106.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_107.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_107.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_108.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_108.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_109.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_109.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_110.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_110.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_111.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_111.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_112.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_112.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_113.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_113.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_114.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_114.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_115.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_115.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_116.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_116.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_117.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_117.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_118.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_118.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_119.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_119.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_120.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_120.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_121.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_121.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_122.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_122.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_123.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_123.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_124.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_124.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_125.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_125.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_126.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_126.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_127.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_127.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_128.CopySelection() 'Copiar seleção geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_128.Document.ExecCommand("Copy", False, DBNull.Value) 'Copiar seleção trident 
                End If
                Exit Select

            




        End Select


    End Sub

    Public Sub proc_colar_acao() 'Colar ação
        On Error Resume Next



        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_1.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_1.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_2.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_2.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_3.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_3.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_4.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_4.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_5.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_5.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_6.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_6.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_7.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_7.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_8.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_8.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_9.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_9.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_10.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_10.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_11.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_11.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_12.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_12.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_13.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_13.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_14.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_14.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_15.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_15.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_16.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_16.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_17.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_17.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_18.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_18.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_19.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_19.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_20.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_20.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_21.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_21.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_22.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_22.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_23.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_23.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_24.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_24.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_25.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_25.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_26.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_26.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_27.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_27.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_28.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_28.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_29.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_29.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_30.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_30.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_31.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_31.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_32.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_32.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_33.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_33.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_34.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_34.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_35.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_35.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_36.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_36.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_37.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_37.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_38.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_38.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_39.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_39.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_40.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_40.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_41.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_41.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_42.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_42.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_43.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_43.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_44.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_44.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_45.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_45.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_46.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_46.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_47.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_47.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_48.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_48.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_49.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_49.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_50.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_50.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_51.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_51.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_52.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_52.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_53.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_53.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_54.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_54.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_55.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_55.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_56.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_56.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_57.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_57.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_58.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_58.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_59.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_59.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_60.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_60.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_61.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_61.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_62.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_62.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_63.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_63.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_64.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_64.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_65.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_65.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_66.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_66.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_67.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_67.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_68.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_68.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_69.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_69.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_70.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_70.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_71.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_71.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_72.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_72.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_73.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_73.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_74.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_74.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_75.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_75.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_76.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_76.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_77.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_77.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_78.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_78.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_79.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_79.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_80.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_80.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_81.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_81.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_82.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_82.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_83.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_83.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_84.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_84.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_85.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_85.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_86.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_86.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_87.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_87.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_88.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_88.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_89.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_89.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_90.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_90.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_91.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_91.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_92.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_92.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_93.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_93.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_94.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_94.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_95.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_95.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_96.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_96.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_97.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_97.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_98.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_98.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_99.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_99.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_100.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_100.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_101.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_101.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_102.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_102.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_103.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_103.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_104.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_104.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_105.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_105.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_106.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_106.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_107.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_107.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_108.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_108.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_109.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_109.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_110.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_110.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_111.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_111.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_112.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_112.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_113.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_113.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_114.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_114.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_115.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_115.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_116.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_116.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_117.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_117.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_118.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_118.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_119.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_119.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_120.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_120.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_121.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_121.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_122.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_122.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_123.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_123.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_124.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_124.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_125.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_125.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_126.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_126.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_127.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_127.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_128.Paste() 'Colar em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_128.Document.ExecCommand("Paste", False, DBNull.Value) 'Colar em trident
                End If
                Exit Select

            




        End Select


    End Sub

    Public Sub proc_deletar_acao() 'Deletar ação
        On Error Resume Next


        'Variáveis de backup -------------------------------------------------------------------------------------------

        Dim v_texto_backup As String = My.Computer.Clipboard.GetText 'Texto

        '---------------------------------------------------------------------------------------------------------------




        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_1.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_1.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_2.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_2.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_3.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_3.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_4.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_4.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_5.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_5.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_6.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_6.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_7.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_7.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_8.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_8.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_9.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_9.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_10.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_10.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_11.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_11.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_12.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_12.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_13.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_13.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_14.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_14.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_15.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_15.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_16.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_16.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_17.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_17.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_18.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_18.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_19.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_19.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_20.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_20.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_21.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_21.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_22.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_22.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_23.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_23.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_24.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_24.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_25.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_25.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_26.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_26.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_27.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_27.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_28.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_28.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_29.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_29.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_30.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_30.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_31.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_31.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_32.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_32.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_33.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_33.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_34.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_34.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_35.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_35.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_36.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_36.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_37.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_37.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_38.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_38.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_39.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_39.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_40.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_40.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_41.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_41.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_42.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_42.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_43.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_43.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_44.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_44.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_45.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_45.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_46.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_46.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_47.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_47.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_48.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_48.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_49.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_49.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_50.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_50.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_51.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_51.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_52.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_52.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_53.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_53.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_54.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_54.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_55.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_55.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_56.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_56.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_57.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_57.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_58.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_58.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_59.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_59.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_60.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_60.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_61.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_61.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_62.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_62.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_63.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_63.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_64.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_64.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_65.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_65.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_66.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_66.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_67.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_67.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_68.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_68.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_69.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_69.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_70.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_70.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_71.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_71.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_72.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_72.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_73.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_73.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_74.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_74.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_75.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_75.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_76.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_76.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_77.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_77.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_78.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_78.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_79.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_79.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_80.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_80.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_81.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_81.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_82.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_82.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_83.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_83.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_84.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_84.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_85.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_85.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_86.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_86.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_87.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_87.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_88.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_88.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_89.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_89.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_90.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_90.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_91.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_91.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_92.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_92.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_93.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_93.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_94.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_94.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_95.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_95.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_96.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_96.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_97.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_97.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_98.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_98.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_99.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_99.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_100.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_100.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_101.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_101.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_102.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_102.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_103.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_103.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_104.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_104.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_105.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_105.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_106.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_106.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_107.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_107.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_108.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_108.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_109.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_109.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_110.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_110.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_111.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_111.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_112.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_112.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_113.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_113.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_114.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_114.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_115.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_115.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_116.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_116.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_117.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_117.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_118.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_118.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_119.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_119.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_120.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_120.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_121.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_121.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_122.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_122.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_123.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_123.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_124.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_124.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_125.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_125.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_126.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_126.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_127.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_127.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_128.CutSelection() 'Recortando texto
                Else
                    OBJ_MOTOR_WEB_BROWSER_128.Document.ExecCommand("Delete", False, DBNull.Value) 'Deletar em trident
                End If
                Exit Select

            




        End Select




        'Restaurando backups -------------------------------------------------------------------------------------------

        My.Computer.Clipboard.SetText(v_texto_backup) 'Texto

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_selecionar_tudo_acao() 'Selecionar tudo ação
        On Error Resume Next



        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_1.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_1.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_2.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_2.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_3.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_3.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_4.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_4.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_5.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_5.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_6.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_6.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_7.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_7.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_8.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_8.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_9.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_9.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_10.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_10.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_11.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_11.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_12.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_12.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_13.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_13.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_14.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_14.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_15.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_15.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_16.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_16.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_17.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_17.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_18.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_18.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_19.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_19.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_20.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_20.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_21.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_21.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_22.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_22.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_23.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_23.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_24.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_24.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_25.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_25.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_26.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_26.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_27.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_27.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_28.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_28.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_29.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_29.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_30.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_30.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_31.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_31.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_32.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_32.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_33.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_33.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_34.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_34.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_35.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_35.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_36.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_36.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_37.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_37.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_38.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_38.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_39.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_39.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_40.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_40.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_41.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_41.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_42.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_42.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_43.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_43.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_44.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_44.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_45.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_45.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_46.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_46.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_47.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_47.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_48.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_48.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_49.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_49.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_50.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_50.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_51.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_51.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_52.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_52.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_53.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_53.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_54.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_54.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_55.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_55.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_56.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_56.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_57.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_57.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_58.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_58.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_59.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_59.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_60.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_60.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_61.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_61.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_62.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_62.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_63.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_63.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_64.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_64.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_65.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_65.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_66.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_66.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_67.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_67.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_68.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_68.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_69.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_69.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_70.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_70.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_71.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_71.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_72.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_72.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_73.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_73.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_74.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_74.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_75.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_75.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_76.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_76.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_77.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_77.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_78.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_78.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_79.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_79.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_80.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_80.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_81.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_81.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_82.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_82.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_83.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_83.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_84.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_84.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_85.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_85.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_86.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_86.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_87.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_87.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_88.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_88.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_89.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_89.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_90.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_90.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_91.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_91.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_92.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_92.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_93.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_93.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_94.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_94.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_95.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_95.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_96.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_96.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_97.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_97.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_98.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_98.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_99.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_99.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_100.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_100.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_101.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_101.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_102.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_102.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_103.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_103.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_104.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_104.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_105.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_105.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_106.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_106.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_107.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_107.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_108.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_108.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_109.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_109.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_110.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_110.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_111.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_111.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_112.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_112.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_113.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_113.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_114.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_114.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_115.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_115.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_116.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_116.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_117.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_117.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_118.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_118.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_119.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_119.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_120.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_120.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_121.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_121.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_122.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_122.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_123.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_123.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_124.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_124.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_125.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_125.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_126.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_126.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_127.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_127.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_128.SelectAll() 'Selecionar tudo em geckofx
                Else
                    OBJ_MOTOR_WEB_BROWSER_128.Document.ExecCommand("Selectall", False, DBNull.Value) 'Selecionar tudo em trident
                End If
                Exit Select

            




        End Select


    End Sub

    Public Sub proc_encontrar_sentenca(ByVal v_sentenca As String) 'Encontra a frase especificada
        On Error Resume Next

        Dim v_comando_javascript As String = "javascript:window.find('" & v_sentenca & "');void(0);" 'Texto a ser encontrado




        'Não permite buscar valor vazio -----------------------------------

        If (v_sentenca = "") Or (v_sentenca = Nothing) Then


            Exit Sub 'Saindo...


        End If

        '------------------------------------------------------------------



        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_1.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_1.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_2.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_2.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_3.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_3.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_4.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_4.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_5.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_5.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_6.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_6.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_7.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_7.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_8.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_8.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_9.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_9.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_10.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_10.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_11.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_11.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_12.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_12.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_13.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_13.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_14.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_14.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_15.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_15.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_16.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_16.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_17.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_17.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_18.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_18.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_19.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_19.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_20.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_20.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_21.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_21.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_22.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_22.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_23.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_23.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_24.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_24.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_25.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_25.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_26.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_26.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_27.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_27.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_28.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_28.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_29.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_29.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_30.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_30.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_31.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_31.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_32.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_32.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_33.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_33.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_34.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_34.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_35.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_35.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_36.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_36.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_37.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_37.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_38.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_38.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_39.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_39.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_40.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_40.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_41.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_41.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_42.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_42.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_43.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_43.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_44.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_44.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_45.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_45.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_46.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_46.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_47.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_47.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_48.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_48.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_49.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_49.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_50.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_50.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_51.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_51.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_52.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_52.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_53.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_53.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_54.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_54.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_55.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_55.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_56.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_56.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_57.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_57.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_58.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_58.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_59.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_59.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_60.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_60.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_61.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_61.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_62.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_62.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_63.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_63.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_64.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_64.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_65.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_65.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_66.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_66.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_67.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_67.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_68.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_68.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_69.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_69.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_70.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_70.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_71.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_71.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_72.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_72.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_73.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_73.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_74.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_74.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_75.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_75.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_76.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_76.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_77.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_77.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_78.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_78.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_79.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_79.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_80.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_80.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_81.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_81.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_82.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_82.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_83.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_83.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_84.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_84.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_85.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_85.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_86.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_86.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_87.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_87.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_88.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_88.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_89.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_89.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_90.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_90.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_91.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_91.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_92.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_92.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_93.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_93.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_94.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_94.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_95.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_95.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_96.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_96.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_97.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_97.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_98.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_98.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_99.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_99.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_100.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_100.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_101.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_101.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_102.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_102.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_103.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_103.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_104.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_104.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_105.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_105.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_106.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_106.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_107.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_107.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_108.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_108.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_109.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_109.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_110.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_110.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_111.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_111.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_112.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_112.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_113.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_113.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_114.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_114.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_115.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_115.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_116.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_116.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_117.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_117.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_118.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_118.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_119.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_119.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_120.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_120.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_121.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_121.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_122.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_122.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_123.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_123.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_124.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_124.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_125.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_125.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_126.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_126.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_127.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_127.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_128.Focus() 'Movendo o foco para o motor geckofx
                    OBJ_MOTOR_GECKOFX_128.Navigate(v_comando_javascript) 'Encontrando o texto
                End If
                Exit Select

            




        End Select


    End Sub







    'Exibir downloads

    Public Sub proc_exibir_lista_de_downloads() 'Exibir lista de downloads
        On Error Resume Next

        Dim v_nova_janela As New Skybound.Gecko.ChromeDialog 'Nova janela de diálogo




        'Definindo propriedades da janela ---------------------------------------------------------------------------------------

        v_nova_janela.Name = "Downloads" 'Nome

        v_nova_janela.StartPosition = FormStartPosition.CenterScreen 'Posição inicial

        v_nova_janela.ShowInTaskbar = True 'Exibir na barra de tarefas

        v_nova_janela.ShowIcon = True 'Exibir icone

        v_nova_janela.Icon = frm_navegacao.Icon 'Ícone

        v_nova_janela.Show() 'Exibindo

        v_nova_janela.WebBrowser.Navigate("chrome://mozapps/content/downloads/downloads.xul") 'Indo para a página de downloads

        '-------------------------------------------------------------------------------------------------------------------------

    End Sub




    'Exibir propriedades da página

    Public Sub proc_exibir_propriedades_da_pagina() 'Exibe as propriedades da página
        On Error Resume Next



        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_1.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_1.ShowPropertiesDialog() 'Propriedades da pagina
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_2.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_2.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_3.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_3.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_4.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_4.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_5.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_5.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_6.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_6.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_7.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_7.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_8.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_8.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_9.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_9.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_10.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_10.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_11.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_11.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_12.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_12.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_13.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_13.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_14.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_14.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_15.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_15.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_16.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_16.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_17.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_17.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_18.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_18.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_19.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_19.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_20.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_20.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_21.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_21.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_22.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_22.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_23.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_23.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_24.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_24.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_25.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_25.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_26.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_26.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_27.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_27.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_28.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_28.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_29.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_29.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_30.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_30.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_31.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_31.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_32.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_32.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_33.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_33.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_34.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_34.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_35.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_35.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_36.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_36.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_37.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_37.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_38.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_38.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_39.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_39.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_40.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_40.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_41.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_41.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_42.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_42.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_43.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_43.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_44.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_44.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_45.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_45.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_46.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_46.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_47.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_47.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_48.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_48.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_49.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_49.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_50.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_50.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_51.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_51.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_52.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_52.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_53.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_53.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_54.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_54.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_55.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_55.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_56.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_56.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_57.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_57.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_58.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_58.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_59.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_59.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_60.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_60.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_61.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_61.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_62.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_62.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_63.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_63.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_64.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_64.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_65.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_65.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_66.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_66.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_67.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_67.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_68.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_68.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_69.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_69.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_70.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_70.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_71.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_71.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_72.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_72.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_73.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_73.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_74.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_74.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_75.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_75.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_76.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_76.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_77.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_77.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_78.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_78.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_79.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_79.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_80.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_80.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_81.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_81.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_82.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_82.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_83.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_83.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_84.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_84.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_85.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_85.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_86.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_86.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_87.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_87.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_88.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_88.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_89.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_89.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_90.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_90.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_91.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_91.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_92.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_92.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_93.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_93.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_94.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_94.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_95.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_95.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_96.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_96.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_97.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_97.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_98.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_98.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_99.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_99.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_100.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_100.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_101.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_101.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_102.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_102.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_103.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_103.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_104.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_104.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_105.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_105.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_106.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_106.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_107.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_107.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_108.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_108.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_109.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_109.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_110.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_110.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_111.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_111.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_112.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_112.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_113.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_113.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_114.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_114.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_115.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_115.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_116.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_116.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_117.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_117.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_118.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_118.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_119.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_119.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_120.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_120.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_121.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_121.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_122.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_122.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_123.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_123.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_124.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_124.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_125.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_125.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_126.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_126.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_127.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_127.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    OBJ_MOTOR_GECKOFX_128.ShowPageProperties() 'Propriedades da página
                Else
                    OBJ_MOTOR_WEB_BROWSER_128.ShowPropertiesDialog() 'Propriedades da pagina 
                End If
                Exit Select

            




        End Select


    End Sub

    Public Sub proc_pesquisar(ByVal v_valor_pesquisa As String) 'Pesquisar conteúdo informado
        On Error Resume Next

        Dim v_endereco_url As String = Nothing 'Informa o endereço url de pesquisa gerado




        'Não pesquisar valor em branco ---------------------------------

        If (v_valor_pesquisa = Nothing) Then


            Exit Sub 'Saindo...


        End If

        '---------------------------------------------------------------


        Select Case V_VAL_OPCAO_DE_PESQUISA_NA_WEB 'Verificar opçao para poder escolher o site de pesquisa

            Case 1
                v_endereco_url = "http://www.google.com.br/search?source=ig&hl=pt-BR&rlz=1G1SMSN_PT-BRBR392&=&q=" & v_valor_pesquisa & "&btnG=Pesquisa+Google" 'Endereço completo da pesquisa

            Case 2
                v_endereco_url = "http://br.search.yahoo.com/search?vc=&p=" & v_valor_pesquisa & "&toggle=1&cop=mss&ei=UTF-8&fr=yfp-t-707" 'Endereço completo da pesquisa

            Case 3
                v_endereco_url = "http://www.youtube.com/results?search_query=" & v_valor_pesquisa & "&aq=f" 'Endereço completo da pesquisa

            Case 4
                v_endereco_url = "http://www.orkut.com.br/Main#UniversalSearch?origin=is&q=" & v_valor_pesquisa & "" 'Endereço completo da pesquisa

            Case 5
                v_endereco_url = "http://pt.wikipedia.org/wiki/" & v_valor_pesquisa & "" 'Endereço completo da pesquisa

            Case 6
                v_endereco_url = "http://minilua.com/busca.html?cx=partner-pub-7654667834819503%3A7cairk3zzta&cof=FORID%3A10&ie=UTF-8&q=" & v_valor_pesquisa & "&sa=Pesquisar#395" 'Endereço completo da pesquisa

            Case 7
                v_endereco_url = "http://www.megavideo.com/?c=search&s=" & v_valor_pesquisa & "" 'Endereço completo da pesquisa

            Case 8
                v_endereco_url = "http://www.crack.ms/cracks/search.crack?software=" & v_valor_pesquisa & "&mode=AND" 'Endereço completo da pesquisa

            Case 0
                v_endereco_url = "http://www.msete.com.br/sphider-1.3.5/search.php?search=1&query=" & v_valor_pesquisa & "&=Buscar" 'Endereço completo da pesquisa


        End Select


        'Abrindo pesquisa agora ----------------------------------------------------------------------------------------

        proc_navegar(v_endereco_url, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

        '---------------------------------------------------------------------------------------------------------------


    End Sub





    'Referente ao menu de contexto da barra de endereços

    Public Sub proc_ocultar_menu_autocompletar_barra_end_navegacao() 'Oculta o menu de autocompletar na barra de endereços
        On Error Resume Next

        FRM_NAVEGACAO.mnu_autoCompletar.Close() 'Fechando...

    End Sub




    'Referente ao recurso autocompletar

    Public Sub proc_ocultar_aba_de_historico_autocompletar(ByVal v_sim_ou_nao As Boolean) 'Habilita ou desabilita a aba de historico
        On Error Resume Next

        FRM_NAVEGACAO.TabItem5.Visible = v_sim_ou_nao 'Aplicando configuração

    End Sub





    'Zoom na página

    Public Sub proc_zoom_na_pagina_motor_geckofx(ByVal v_valor As Single) 'Atualiza o valor de zoom na pagina do geckofx
        On Error Resume Next


        'Aplicando valor de zoom no motor em visualização --------------------------------------------------------------

        Select Case v_qual_motor_esta_em_uso

            Case 1
                OBJ_MOTOR_GECKOFX_1.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 2
                OBJ_MOTOR_GECKOFX_2.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 3
                OBJ_MOTOR_GECKOFX_3.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 4
                OBJ_MOTOR_GECKOFX_4.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 5
                OBJ_MOTOR_GECKOFX_5.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 6
                OBJ_MOTOR_GECKOFX_6.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 7
                OBJ_MOTOR_GECKOFX_7.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 8
                OBJ_MOTOR_GECKOFX_8.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 9
                OBJ_MOTOR_GECKOFX_9.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 10
                OBJ_MOTOR_GECKOFX_10.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 11
                OBJ_MOTOR_GECKOFX_11.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 12
                OBJ_MOTOR_GECKOFX_12.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 13
                OBJ_MOTOR_GECKOFX_13.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 14
                OBJ_MOTOR_GECKOFX_14.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 15
                OBJ_MOTOR_GECKOFX_15.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 16
                OBJ_MOTOR_GECKOFX_16.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 17
                OBJ_MOTOR_GECKOFX_17.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 18
                OBJ_MOTOR_GECKOFX_18.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 19
                OBJ_MOTOR_GECKOFX_19.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 20
                OBJ_MOTOR_GECKOFX_20.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 21
                OBJ_MOTOR_GECKOFX_21.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 22
                OBJ_MOTOR_GECKOFX_22.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 23
                OBJ_MOTOR_GECKOFX_23.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 24
                OBJ_MOTOR_GECKOFX_24.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 25
                OBJ_MOTOR_GECKOFX_25.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 26
                OBJ_MOTOR_GECKOFX_26.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 27
                OBJ_MOTOR_GECKOFX_27.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 28
                OBJ_MOTOR_GECKOFX_28.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 29
                OBJ_MOTOR_GECKOFX_29.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 30
                OBJ_MOTOR_GECKOFX_30.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 31
                OBJ_MOTOR_GECKOFX_31.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 32
                OBJ_MOTOR_GECKOFX_32.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 33
                OBJ_MOTOR_GECKOFX_33.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 34
                OBJ_MOTOR_GECKOFX_34.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 35
                OBJ_MOTOR_GECKOFX_35.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 36
                OBJ_MOTOR_GECKOFX_36.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 37
                OBJ_MOTOR_GECKOFX_37.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 38
                OBJ_MOTOR_GECKOFX_38.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 39
                OBJ_MOTOR_GECKOFX_39.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 40
                OBJ_MOTOR_GECKOFX_40.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 41
                OBJ_MOTOR_GECKOFX_41.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 42
                OBJ_MOTOR_GECKOFX_42.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 43
                OBJ_MOTOR_GECKOFX_43.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 44
                OBJ_MOTOR_GECKOFX_44.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 45
                OBJ_MOTOR_GECKOFX_45.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 46
                OBJ_MOTOR_GECKOFX_46.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 47
                OBJ_MOTOR_GECKOFX_47.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 48
                OBJ_MOTOR_GECKOFX_48.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 49
                OBJ_MOTOR_GECKOFX_49.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 50
                OBJ_MOTOR_GECKOFX_50.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 51
                OBJ_MOTOR_GECKOFX_51.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 52
                OBJ_MOTOR_GECKOFX_52.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 53
                OBJ_MOTOR_GECKOFX_53.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 54
                OBJ_MOTOR_GECKOFX_54.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 55
                OBJ_MOTOR_GECKOFX_55.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 56
                OBJ_MOTOR_GECKOFX_56.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 57
                OBJ_MOTOR_GECKOFX_57.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 58
                OBJ_MOTOR_GECKOFX_58.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 59
                OBJ_MOTOR_GECKOFX_59.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 60
                OBJ_MOTOR_GECKOFX_60.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 61
                OBJ_MOTOR_GECKOFX_61.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 62
                OBJ_MOTOR_GECKOFX_62.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 63
                OBJ_MOTOR_GECKOFX_63.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 64
                OBJ_MOTOR_GECKOFX_64.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 65
                OBJ_MOTOR_GECKOFX_65.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 66
                OBJ_MOTOR_GECKOFX_66.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 67
                OBJ_MOTOR_GECKOFX_67.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 68
                OBJ_MOTOR_GECKOFX_68.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 69
                OBJ_MOTOR_GECKOFX_69.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 70
                OBJ_MOTOR_GECKOFX_70.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 71
                OBJ_MOTOR_GECKOFX_71.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 72
                OBJ_MOTOR_GECKOFX_72.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 73
                OBJ_MOTOR_GECKOFX_73.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 74
                OBJ_MOTOR_GECKOFX_74.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 75
                OBJ_MOTOR_GECKOFX_75.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 76
                OBJ_MOTOR_GECKOFX_76.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 77
                OBJ_MOTOR_GECKOFX_77.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 78
                OBJ_MOTOR_GECKOFX_78.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 79
                OBJ_MOTOR_GECKOFX_79.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 80
                OBJ_MOTOR_GECKOFX_80.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 81
                OBJ_MOTOR_GECKOFX_81.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 82
                OBJ_MOTOR_GECKOFX_82.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 83
                OBJ_MOTOR_GECKOFX_83.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 84
                OBJ_MOTOR_GECKOFX_84.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 85
                OBJ_MOTOR_GECKOFX_85.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 86
                OBJ_MOTOR_GECKOFX_86.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 87
                OBJ_MOTOR_GECKOFX_87.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 88
                OBJ_MOTOR_GECKOFX_88.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 89
                OBJ_MOTOR_GECKOFX_89.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 90
                OBJ_MOTOR_GECKOFX_90.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 91
                OBJ_MOTOR_GECKOFX_91.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 92
                OBJ_MOTOR_GECKOFX_92.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 93
                OBJ_MOTOR_GECKOFX_93.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 94
                OBJ_MOTOR_GECKOFX_94.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 95
                OBJ_MOTOR_GECKOFX_95.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 96
                OBJ_MOTOR_GECKOFX_96.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 97
                OBJ_MOTOR_GECKOFX_97.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 98
                OBJ_MOTOR_GECKOFX_98.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 99
                OBJ_MOTOR_GECKOFX_99.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 100
                OBJ_MOTOR_GECKOFX_100.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 101
                OBJ_MOTOR_GECKOFX_101.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 102
                OBJ_MOTOR_GECKOFX_102.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 103
                OBJ_MOTOR_GECKOFX_103.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 104
                OBJ_MOTOR_GECKOFX_104.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 105
                OBJ_MOTOR_GECKOFX_105.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 106
                OBJ_MOTOR_GECKOFX_106.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 107
                OBJ_MOTOR_GECKOFX_107.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 108
                OBJ_MOTOR_GECKOFX_108.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 109
                OBJ_MOTOR_GECKOFX_109.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 110
                OBJ_MOTOR_GECKOFX_110.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 111
                OBJ_MOTOR_GECKOFX_111.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 112
                OBJ_MOTOR_GECKOFX_112.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 113
                OBJ_MOTOR_GECKOFX_113.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 114
                OBJ_MOTOR_GECKOFX_114.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 115
                OBJ_MOTOR_GECKOFX_115.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 116
                OBJ_MOTOR_GECKOFX_116.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 117
                OBJ_MOTOR_GECKOFX_117.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 118
                OBJ_MOTOR_GECKOFX_118.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 119
                OBJ_MOTOR_GECKOFX_119.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 120
                OBJ_MOTOR_GECKOFX_120.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 121
                OBJ_MOTOR_GECKOFX_121.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 122
                OBJ_MOTOR_GECKOFX_122.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 123
                OBJ_MOTOR_GECKOFX_123.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 124
                OBJ_MOTOR_GECKOFX_124.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 125
                OBJ_MOTOR_GECKOFX_125.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 126
                OBJ_MOTOR_GECKOFX_126.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 127
                OBJ_MOTOR_GECKOFX_127.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            Case 128
                OBJ_MOTOR_GECKOFX_128.Window.TextZoom = v_valor 'Aplicando valor de zoom
                Exit Select

            



        End Select

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Enum Exec
        OLECMDID_OPTICAL_ZOOM = 63
    End Enum

    Private Enum ExecOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum

    Public Sub proc_zoom_na_pagina_motor_trident(ByVal v_valor As Single) 'Atualiza o valor de zoom na pagina do trident


        'Não permite ser maior para nao travar o computador ---------------------------------------------------------------------------------------

        If (v_valor > 125) Then


            MsgBox("Ops! este zoom não é permitido no modo de compatibilidade.", MsgBoxStyle.Information, "Informação!") 'Mensagem

            Exit Sub 'Saindo...


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------





        'Aplicando valor de zoom no motor em visualização --------------------------------------------------------------

        Select Case v_qual_motor_esta_em_uso


            Case 1
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_1.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 2
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_2.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 3
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_3.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 4
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_4.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 5
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_5.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 6
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_6.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 7
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_7.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 8
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_8.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 9
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_9.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 10
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_10.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 11
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_11.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 12
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_12.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 13
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_13.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 14
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_14.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 15
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_15.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 16
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_16.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 17
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_17.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 18
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_18.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 19
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_19.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 20
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_20.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 21
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_21.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 22
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_22.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 23
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_23.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 24
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_24.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 25
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_25.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 26
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_26.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 27
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_27.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 28
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_28.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 29
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_29.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 30
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_30.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 31
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_31.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 32
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_32.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 33
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_33.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 34
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_34.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 35
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_35.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 36
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_36.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 37
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_37.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 38
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_38.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 39
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_39.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 40
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_40.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 41
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_41.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 42
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_42.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 43
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_43.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 44
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_44.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 45
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_45.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 46
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_46.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 47
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_47.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 48
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_48.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 49
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_49.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 50
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_50.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 51
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_51.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 52
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_52.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 53
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_53.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 54
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_54.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 55
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_55.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 56
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_56.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 57
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_57.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 58
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_58.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 59
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_59.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 60
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_60.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 61
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_61.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 62
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_62.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 63
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_63.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 64
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_64.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 65
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_65.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 66
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_66.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 67
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_67.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 68
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_68.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 69
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_69.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 70
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_70.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 71
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_71.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 72
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_72.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 73
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_73.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 74
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_74.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 75
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_75.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 76
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_76.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 77
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_77.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 78
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_78.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 79
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_79.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 80
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_80.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 81
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_81.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 82
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_82.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 83
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_83.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 84
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_84.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 85
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_85.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 86
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_86.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 87
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_87.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 88
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_88.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 89
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_89.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 90
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_90.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 91
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_91.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 92
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_92.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 93
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_93.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 94
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_94.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 95
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_95.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 96
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_96.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 97
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_97.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 98
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_98.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 99
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_99.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 100
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_100.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 101
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_101.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 102
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_102.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 103
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_103.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 104
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_104.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 105
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_105.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 106
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_106.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 107
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_107.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 108
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_108.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 109
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_109.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 110
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_110.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 111
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_111.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 112
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_112.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 113
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_113.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 114
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_114.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 115
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_115.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 116
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_116.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 117
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_117.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 118
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_118.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 119
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_119.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 120
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_120.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 121
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_121.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 122
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_122.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 123
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_123.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 124
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_124.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 125
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_125.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 126
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_126.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 127
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_127.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select

            Case 128
                Try
                    Dim factor As Int32 = CType(v_valor, Integer)
                    Dim [ActiveXInstance] As Object = OBJ_MOTOR_WEB_BROWSER_128.ActiveXInstance()
                    [ActiveXInstance].ExecWB(63, 2, DirectCast(factor, Object), IntPtr.Zero)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Exit Select






        End Select

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(ByVal v_valor As Single) 'Altera o valor do zoom na página do motor selecionado
        On Error Resume Next


        'Atualiza o valor de zoom no motor layout engine em visualização -----------------------------------------------

        If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then


            proc_zoom_na_pagina_motor_geckofx(v_valor) 'Atualiza o valor de zoom na pagina do geckofx


        Else

            v_valor = v_valor * 100 'Atualizando valor real de zoom

            proc_zoom_na_pagina_motor_trident(v_valor) 'Atualiza o valor de zoom na pagina do trident


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub






    'Pop-up

    Public Sub proc_permitir_pop_up_proxima_vez_abrir_pagina(ByVal v_host As String) 'Permite abrir a pop-up da proxima vez que a pagina for carregada
        On Error Resume Next

        Dim V_LISTA As String 'Lista de sites permitidos a abrirem pop-ups

        



        'Atualiza a lista ----------------------------------------------------------------------------------------------

        V_LISTA = func_ler_valor(V_ARQ_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS) 'Retorna o valor do arquivo lido

        '---------------------------------------------------------------------------------------------------------------


        'Salva a nova configuração -------------------------------------------------------------------------------------

        If (V_LISTA.Contains(v_host) = False) Then


            proc_salvar_valor(3, V_ARQ_CONFIG_POP_UP_ACAO) 'Salva a configuração

            V_LISTA = V_LISTA & v_host & v_separador_de_string 'Atualiza a lista

            proc_salvar_valor(V_LISTA, V_ARQ_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS) 'Salva a configuração


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub









    'Referente a abas da referencia

    Public Sub proc_focar_aba_de_motor_via_referencia_de_aba(ByVal v_referencia_nome As String) 'Foca a aba do motor via a aba de referencia
        On Error Resume Next


        Select Case v_referencia_nome

            Case v_nome_generico_da_tab_referencia & 1
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab1
                Exit Select

            Case v_nome_generico_da_tab_referencia & 2
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab2
                Exit Select

            Case v_nome_generico_da_tab_referencia & 3
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab3
                Exit Select

            Case v_nome_generico_da_tab_referencia & 4
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab4
                Exit Select

            Case v_nome_generico_da_tab_referencia & 5
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab5
                Exit Select

            Case v_nome_generico_da_tab_referencia & 6
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab6
                Exit Select

            Case v_nome_generico_da_tab_referencia & 7
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab7
                Exit Select

            Case v_nome_generico_da_tab_referencia & 8
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab8
                Exit Select

            Case v_nome_generico_da_tab_referencia & 9
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab9
                Exit Select

            Case v_nome_generico_da_tab_referencia & 10
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab10
                Exit Select

            Case v_nome_generico_da_tab_referencia & 11
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab11
                Exit Select

            Case v_nome_generico_da_tab_referencia & 12
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab12
                Exit Select

            Case v_nome_generico_da_tab_referencia & 13
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab13
                Exit Select

            Case v_nome_generico_da_tab_referencia & 14
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab14
                Exit Select

            Case v_nome_generico_da_tab_referencia & 15
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab15
                Exit Select

            Case v_nome_generico_da_tab_referencia & 16
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab16
                Exit Select

            Case v_nome_generico_da_tab_referencia & 17
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab17
                Exit Select

            Case v_nome_generico_da_tab_referencia & 18
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab18
                Exit Select

            Case v_nome_generico_da_tab_referencia & 19
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab19
                Exit Select

            Case v_nome_generico_da_tab_referencia & 20
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab20
                Exit Select

            Case v_nome_generico_da_tab_referencia & 21
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab21
                Exit Select

            Case v_nome_generico_da_tab_referencia & 22
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab22
                Exit Select

            Case v_nome_generico_da_tab_referencia & 23
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab23
                Exit Select

            Case v_nome_generico_da_tab_referencia & 24
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab24
                Exit Select

            Case v_nome_generico_da_tab_referencia & 25
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab25
                Exit Select

            Case v_nome_generico_da_tab_referencia & 26
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab26
                Exit Select

            Case v_nome_generico_da_tab_referencia & 27
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab27
                Exit Select

            Case v_nome_generico_da_tab_referencia & 28
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab28
                Exit Select

            Case v_nome_generico_da_tab_referencia & 29
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab29
                Exit Select

            Case v_nome_generico_da_tab_referencia & 30
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab30
                Exit Select

            Case v_nome_generico_da_tab_referencia & 31
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab31
                Exit Select

            Case v_nome_generico_da_tab_referencia & 32
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab32
                Exit Select

            Case v_nome_generico_da_tab_referencia & 33
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab33
                Exit Select

            Case v_nome_generico_da_tab_referencia & 34
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab34
                Exit Select

            Case v_nome_generico_da_tab_referencia & 35
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab35
                Exit Select

            Case v_nome_generico_da_tab_referencia & 36
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab36
                Exit Select

            Case v_nome_generico_da_tab_referencia & 37
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab37
                Exit Select

            Case v_nome_generico_da_tab_referencia & 38
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab38
                Exit Select

            Case v_nome_generico_da_tab_referencia & 39
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab39
                Exit Select

            Case v_nome_generico_da_tab_referencia & 40
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab40
                Exit Select

            Case v_nome_generico_da_tab_referencia & 41
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab41
                Exit Select

            Case v_nome_generico_da_tab_referencia & 42
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab42
                Exit Select

            Case v_nome_generico_da_tab_referencia & 43
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab43
                Exit Select

            Case v_nome_generico_da_tab_referencia & 44
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab44
                Exit Select

            Case v_nome_generico_da_tab_referencia & 45
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab45
                Exit Select

            Case v_nome_generico_da_tab_referencia & 46
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab46
                Exit Select

            Case v_nome_generico_da_tab_referencia & 47
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab47
                Exit Select

            Case v_nome_generico_da_tab_referencia & 48
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab48
                Exit Select

            Case v_nome_generico_da_tab_referencia & 49
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab49
                Exit Select

            Case v_nome_generico_da_tab_referencia & 50
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab50
                Exit Select

            Case v_nome_generico_da_tab_referencia & 51
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab51
                Exit Select

            Case v_nome_generico_da_tab_referencia & 52
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab52
                Exit Select

            Case v_nome_generico_da_tab_referencia & 53
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab53
                Exit Select

            Case v_nome_generico_da_tab_referencia & 54
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab54
                Exit Select

            Case v_nome_generico_da_tab_referencia & 55
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab55
                Exit Select

            Case v_nome_generico_da_tab_referencia & 56
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab56
                Exit Select

            Case v_nome_generico_da_tab_referencia & 57
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab57
                Exit Select

            Case v_nome_generico_da_tab_referencia & 58
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab58
                Exit Select

            Case v_nome_generico_da_tab_referencia & 59
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab59
                Exit Select

            Case v_nome_generico_da_tab_referencia & 60
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab60
                Exit Select

            Case v_nome_generico_da_tab_referencia & 61
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab61
                Exit Select

            Case v_nome_generico_da_tab_referencia & 62
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab62
                Exit Select

            Case v_nome_generico_da_tab_referencia & 63
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab63
                Exit Select

            Case v_nome_generico_da_tab_referencia & 64
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab64
                Exit Select

            Case v_nome_generico_da_tab_referencia & 65
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab65
                Exit Select

            Case v_nome_generico_da_tab_referencia & 66
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab66
                Exit Select

            Case v_nome_generico_da_tab_referencia & 67
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab67
                Exit Select

            Case v_nome_generico_da_tab_referencia & 68
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab68
                Exit Select

            Case v_nome_generico_da_tab_referencia & 69
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab69
                Exit Select

            Case v_nome_generico_da_tab_referencia & 70
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab70
                Exit Select

            Case v_nome_generico_da_tab_referencia & 71
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab71
                Exit Select

            Case v_nome_generico_da_tab_referencia & 72
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab72
                Exit Select

            Case v_nome_generico_da_tab_referencia & 73
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab73
                Exit Select

            Case v_nome_generico_da_tab_referencia & 74
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab74
                Exit Select

            Case v_nome_generico_da_tab_referencia & 75
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab75
                Exit Select

            Case v_nome_generico_da_tab_referencia & 76
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab76
                Exit Select

            Case v_nome_generico_da_tab_referencia & 77
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab77
                Exit Select

            Case v_nome_generico_da_tab_referencia & 78
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab78
                Exit Select

            Case v_nome_generico_da_tab_referencia & 79
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab79
                Exit Select

            Case v_nome_generico_da_tab_referencia & 80
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab80
                Exit Select

            Case v_nome_generico_da_tab_referencia & 81
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab81
                Exit Select

            Case v_nome_generico_da_tab_referencia & 82
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab82
                Exit Select

            Case v_nome_generico_da_tab_referencia & 83
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab83
                Exit Select

            Case v_nome_generico_da_tab_referencia & 84
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab84
                Exit Select

            Case v_nome_generico_da_tab_referencia & 85
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab85
                Exit Select

            Case v_nome_generico_da_tab_referencia & 86
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab86
                Exit Select

            Case v_nome_generico_da_tab_referencia & 87
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab87
                Exit Select

            Case v_nome_generico_da_tab_referencia & 88
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab88
                Exit Select

            Case v_nome_generico_da_tab_referencia & 89
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab89
                Exit Select

            Case v_nome_generico_da_tab_referencia & 90
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab90
                Exit Select

            Case v_nome_generico_da_tab_referencia & 91
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab91
                Exit Select

            Case v_nome_generico_da_tab_referencia & 92
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab92
                Exit Select

            Case v_nome_generico_da_tab_referencia & 93
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab93
                Exit Select

            Case v_nome_generico_da_tab_referencia & 94
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab94
                Exit Select

            Case v_nome_generico_da_tab_referencia & 95
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab95
                Exit Select

            Case v_nome_generico_da_tab_referencia & 96
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab96
                Exit Select

            Case v_nome_generico_da_tab_referencia & 97
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab97
                Exit Select

            Case v_nome_generico_da_tab_referencia & 98
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab98
                Exit Select

            Case v_nome_generico_da_tab_referencia & 99
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab99
                Exit Select

            Case v_nome_generico_da_tab_referencia & 100
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab100
                Exit Select

            Case v_nome_generico_da_tab_referencia & 101
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab101
                Exit Select

            Case v_nome_generico_da_tab_referencia & 102
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab102
                Exit Select

            Case v_nome_generico_da_tab_referencia & 103
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab103
                Exit Select

            Case v_nome_generico_da_tab_referencia & 104
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab104
                Exit Select

            Case v_nome_generico_da_tab_referencia & 105
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab105
                Exit Select

            Case v_nome_generico_da_tab_referencia & 106
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab106
                Exit Select

            Case v_nome_generico_da_tab_referencia & 107
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab107
                Exit Select

            Case v_nome_generico_da_tab_referencia & 108
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab108
                Exit Select

            Case v_nome_generico_da_tab_referencia & 109
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab109
                Exit Select

            Case v_nome_generico_da_tab_referencia & 110
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab110
                Exit Select

            Case v_nome_generico_da_tab_referencia & 111
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab111
                Exit Select

            Case v_nome_generico_da_tab_referencia & 112
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab112
                Exit Select

            Case v_nome_generico_da_tab_referencia & 113
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab113
                Exit Select

            Case v_nome_generico_da_tab_referencia & 114
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab114
                Exit Select

            Case v_nome_generico_da_tab_referencia & 115
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab115
                Exit Select

            Case v_nome_generico_da_tab_referencia & 116
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab116
                Exit Select

            Case v_nome_generico_da_tab_referencia & 117
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab117
                Exit Select

            Case v_nome_generico_da_tab_referencia & 118
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab118
                Exit Select

            Case v_nome_generico_da_tab_referencia & 119
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab119
                Exit Select

            Case v_nome_generico_da_tab_referencia & 120
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab120
                Exit Select

            Case v_nome_generico_da_tab_referencia & 121
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab121
                Exit Select

            Case v_nome_generico_da_tab_referencia & 122
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab122
                Exit Select

            Case v_nome_generico_da_tab_referencia & 123
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab123
                Exit Select

            Case v_nome_generico_da_tab_referencia & 124
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab124
                Exit Select

            Case v_nome_generico_da_tab_referencia & 125
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab125
                Exit Select

            Case v_nome_generico_da_tab_referencia & 126
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab126
                Exit Select

            Case v_nome_generico_da_tab_referencia & 127
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab127
                Exit Select

            Case v_nome_generico_da_tab_referencia & 128
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab128
                Exit Select

            



        End Select


    End Sub


    







    'Opçoes do menu editar

    Public Sub proc_menu_editar_exibir_itens_corretos() 'Exibe os itens corretos do menu editar
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso

            Case 1
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_1.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_1.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_1.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_1.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_1.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_1.CanCutSelection 'Recortar
                Exit Select

            Case 2
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_2.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_2.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_2.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_2.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_2.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_2.CanCutSelection 'Recortar
                Exit Select

            Case 3
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_3.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_3.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_3.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_3.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_3.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_3.CanCutSelection 'Recortar
                Exit Select

            Case 4
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_4.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_4.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_4.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_4.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_4.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_4.CanCutSelection 'Recortar
                Exit Select

            Case 5
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_5.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_5.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_5.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_5.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_5.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_5.CanCutSelection 'Recortar
                Exit Select

            Case 6
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_6.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_6.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_6.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_6.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_6.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_6.CanCutSelection 'Recortar
                Exit Select

            Case 7
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_7.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_7.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_7.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_7.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_7.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_7.CanCutSelection 'Recortar
                Exit Select

            Case 8
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_8.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_8.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_8.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_8.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_8.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_8.CanCutSelection 'Recortar
                Exit Select

            Case 9
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_9.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_9.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_9.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_9.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_9.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_9.CanCutSelection 'Recortar
                Exit Select

            Case 10
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_10.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_10.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_10.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_10.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_10.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_10.CanCutSelection 'Recortar
                Exit Select

            Case 11
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_11.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_11.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_11.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_11.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_11.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_11.CanCutSelection 'Recortar
                Exit Select

            Case 12
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_12.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_12.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_12.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_12.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_12.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_12.CanCutSelection 'Recortar
                Exit Select

            Case 13
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_13.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_13.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_13.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_13.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_13.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_13.CanCutSelection 'Recortar
                Exit Select

            Case 14
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_14.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_14.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_14.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_14.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_14.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_14.CanCutSelection 'Recortar
                Exit Select

            Case 15
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_15.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_15.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_15.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_15.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_15.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_15.CanCutSelection 'Recortar
                Exit Select

            Case 16
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_16.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_16.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_16.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_16.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_16.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_16.CanCutSelection 'Recortar
                Exit Select

            Case 17
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_17.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_17.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_17.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_17.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_17.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_17.CanCutSelection 'Recortar
                Exit Select

            Case 18
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_18.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_18.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_18.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_18.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_18.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_18.CanCutSelection 'Recortar
                Exit Select

            Case 19
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_19.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_19.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_19.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_19.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_19.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_19.CanCutSelection 'Recortar
                Exit Select

            Case 20
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_20.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_20.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_20.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_20.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_20.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_20.CanCutSelection 'Recortar
                Exit Select

            Case 21
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_21.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_21.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_21.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_21.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_21.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_21.CanCutSelection 'Recortar
                Exit Select

            Case 22
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_22.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_22.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_22.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_22.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_22.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_22.CanCutSelection 'Recortar
                Exit Select

            Case 23
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_23.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_23.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_23.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_23.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_23.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_23.CanCutSelection 'Recortar
                Exit Select

            Case 24
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_24.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_24.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_24.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_24.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_24.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_24.CanCutSelection 'Recortar
                Exit Select

            Case 25
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_25.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_25.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_25.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_25.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_25.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_25.CanCutSelection 'Recortar
                Exit Select

            Case 26
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_26.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_26.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_26.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_26.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_26.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_26.CanCutSelection 'Recortar
                Exit Select

            Case 27
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_27.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_27.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_27.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_27.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_27.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_27.CanCutSelection 'Recortar
                Exit Select

            Case 28
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_28.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_28.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_28.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_28.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_28.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_28.CanCutSelection 'Recortar
                Exit Select

            Case 29
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_29.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_29.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_29.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_29.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_29.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_29.CanCutSelection 'Recortar
                Exit Select

            Case 30
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_30.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_30.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_30.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_30.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_30.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_30.CanCutSelection 'Recortar
                Exit Select

            Case 31
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_31.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_31.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_31.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_31.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_31.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_31.CanCutSelection 'Recortar
                Exit Select

            Case 32
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_32.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_32.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_32.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_32.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_32.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_32.CanCutSelection 'Recortar
                Exit Select

            Case 33
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_33.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_33.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_33.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_33.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_33.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_33.CanCutSelection 'Recortar
                Exit Select

            Case 34
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_34.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_34.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_34.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_34.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_34.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_34.CanCutSelection 'Recortar
                Exit Select

            Case 35
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_35.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_35.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_35.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_35.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_35.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_35.CanCutSelection 'Recortar
                Exit Select

            Case 36
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_36.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_36.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_36.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_36.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_36.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_36.CanCutSelection 'Recortar
                Exit Select

            Case 37
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_37.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_37.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_37.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_37.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_37.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_37.CanCutSelection 'Recortar
                Exit Select

            Case 38
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_38.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_38.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_38.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_38.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_38.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_38.CanCutSelection 'Recortar
                Exit Select

            Case 39
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_39.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_39.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_39.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_39.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_39.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_39.CanCutSelection 'Recortar
                Exit Select

            Case 40
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_40.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_40.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_40.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_40.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_40.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_40.CanCutSelection 'Recortar
                Exit Select

            Case 41
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_41.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_41.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_41.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_41.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_41.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_41.CanCutSelection 'Recortar
                Exit Select

            Case 42
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_42.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_42.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_42.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_42.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_42.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_42.CanCutSelection 'Recortar
                Exit Select

            Case 43
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_43.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_43.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_43.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_43.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_43.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_43.CanCutSelection 'Recortar
                Exit Select

            Case 44
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_44.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_44.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_44.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_44.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_44.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_44.CanCutSelection 'Recortar
                Exit Select

            Case 45
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_45.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_45.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_45.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_45.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_45.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_45.CanCutSelection 'Recortar
                Exit Select

            Case 46
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_46.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_46.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_46.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_46.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_46.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_46.CanCutSelection 'Recortar
                Exit Select

            Case 47
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_47.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_47.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_47.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_47.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_47.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_47.CanCutSelection 'Recortar
                Exit Select

            Case 48
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_48.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_48.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_48.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_48.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_48.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_48.CanCutSelection 'Recortar
                Exit Select

            Case 49
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_49.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_49.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_49.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_49.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_49.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_49.CanCutSelection 'Recortar
                Exit Select

            Case 50
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_50.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_50.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_50.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_50.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_50.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_50.CanCutSelection 'Recortar
                Exit Select

            Case 51
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_51.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_51.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_51.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_51.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_51.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_51.CanCutSelection 'Recortar
                Exit Select

            Case 52
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_52.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_52.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_52.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_52.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_52.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_52.CanCutSelection 'Recortar
                Exit Select

            Case 53
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_53.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_53.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_53.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_53.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_53.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_53.CanCutSelection 'Recortar
                Exit Select

            Case 54
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_54.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_54.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_54.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_54.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_54.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_54.CanCutSelection 'Recortar
                Exit Select

            Case 55
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_55.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_55.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_55.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_55.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_55.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_55.CanCutSelection 'Recortar
                Exit Select

            Case 56
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_56.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_56.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_56.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_56.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_56.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_56.CanCutSelection 'Recortar
                Exit Select

            Case 57
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_57.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_57.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_57.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_57.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_57.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_57.CanCutSelection 'Recortar
                Exit Select

            Case 58
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_58.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_58.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_58.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_58.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_58.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_58.CanCutSelection 'Recortar
                Exit Select

            Case 59
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_59.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_59.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_59.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_59.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_59.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_59.CanCutSelection 'Recortar
                Exit Select

            Case 60
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_60.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_60.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_60.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_60.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_60.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_60.CanCutSelection 'Recortar
                Exit Select

            Case 61
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_61.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_61.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_61.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_61.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_61.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_61.CanCutSelection 'Recortar
                Exit Select

            Case 62
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_62.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_62.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_62.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_62.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_62.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_62.CanCutSelection 'Recortar
                Exit Select

            Case 63
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_63.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_63.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_63.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_63.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_63.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_63.CanCutSelection 'Recortar
                Exit Select

            Case 64
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_64.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_64.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_64.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_64.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_64.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_64.CanCutSelection 'Recortar
                Exit Select

            Case 65
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_65.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_65.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_65.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_65.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_65.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_65.CanCutSelection 'Recortar
                Exit Select

            Case 66
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_66.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_66.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_66.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_66.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_66.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_66.CanCutSelection 'Recortar
                Exit Select

            Case 67
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_67.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_67.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_67.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_67.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_67.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_67.CanCutSelection 'Recortar
                Exit Select

            Case 68
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_68.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_68.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_68.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_68.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_68.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_68.CanCutSelection 'Recortar
                Exit Select

            Case 69
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_69.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_69.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_69.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_69.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_69.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_69.CanCutSelection 'Recortar
                Exit Select

            Case 70
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_70.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_70.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_70.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_70.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_70.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_70.CanCutSelection 'Recortar
                Exit Select

            Case 71
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_71.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_71.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_71.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_71.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_71.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_71.CanCutSelection 'Recortar
                Exit Select

            Case 72
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_72.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_72.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_72.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_72.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_72.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_72.CanCutSelection 'Recortar
                Exit Select

            Case 73
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_73.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_73.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_73.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_73.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_73.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_73.CanCutSelection 'Recortar
                Exit Select

            Case 74
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_74.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_74.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_74.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_74.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_74.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_74.CanCutSelection 'Recortar
                Exit Select

            Case 75
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_75.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_75.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_75.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_75.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_75.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_75.CanCutSelection 'Recortar
                Exit Select

            Case 76
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_76.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_76.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_76.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_76.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_76.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_76.CanCutSelection 'Recortar
                Exit Select

            Case 77
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_77.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_77.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_77.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_77.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_77.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_77.CanCutSelection 'Recortar
                Exit Select

            Case 78
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_78.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_78.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_78.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_78.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_78.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_78.CanCutSelection 'Recortar
                Exit Select

            Case 79
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_79.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_79.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_79.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_79.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_79.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_79.CanCutSelection 'Recortar
                Exit Select

            Case 80
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_80.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_80.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_80.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_80.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_80.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_80.CanCutSelection 'Recortar
                Exit Select

            Case 81
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_81.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_81.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_81.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_81.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_81.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_81.CanCutSelection 'Recortar
                Exit Select

            Case 82
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_82.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_82.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_82.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_82.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_82.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_82.CanCutSelection 'Recortar
                Exit Select

            Case 83
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_83.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_83.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_83.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_83.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_83.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_83.CanCutSelection 'Recortar
                Exit Select

            Case 84
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_84.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_84.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_84.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_84.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_84.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_84.CanCutSelection 'Recortar
                Exit Select

            Case 85
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_85.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_85.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_85.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_85.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_85.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_85.CanCutSelection 'Recortar
                Exit Select

            Case 86
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_86.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_86.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_86.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_86.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_86.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_86.CanCutSelection 'Recortar
                Exit Select

            Case 87
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_87.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_87.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_87.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_87.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_87.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_87.CanCutSelection 'Recortar
                Exit Select

            Case 88
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_88.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_88.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_88.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_88.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_88.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_88.CanCutSelection 'Recortar
                Exit Select

            Case 89
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_89.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_89.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_89.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_89.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_89.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_89.CanCutSelection 'Recortar
                Exit Select

            Case 90
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_90.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_90.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_90.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_90.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_90.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_90.CanCutSelection 'Recortar
                Exit Select

            Case 91
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_91.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_91.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_91.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_91.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_91.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_91.CanCutSelection 'Recortar
                Exit Select

            Case 92
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_92.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_92.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_92.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_92.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_92.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_92.CanCutSelection 'Recortar
                Exit Select

            Case 93
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_93.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_93.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_93.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_93.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_93.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_93.CanCutSelection 'Recortar
                Exit Select

            Case 94
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_94.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_94.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_94.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_94.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_94.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_94.CanCutSelection 'Recortar
                Exit Select

            Case 95
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_95.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_95.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_95.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_95.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_95.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_95.CanCutSelection 'Recortar
                Exit Select

            Case 96
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_96.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_96.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_96.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_96.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_96.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_96.CanCutSelection 'Recortar
                Exit Select

            Case 97
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_97.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_97.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_97.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_97.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_97.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_97.CanCutSelection 'Recortar
                Exit Select

            Case 98
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_98.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_98.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_98.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_98.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_98.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_98.CanCutSelection 'Recortar
                Exit Select

            Case 99
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_99.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_99.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_99.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_99.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_99.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_99.CanCutSelection 'Recortar
                Exit Select

            Case 100
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_100.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_100.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_100.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_100.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_100.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_100.CanCutSelection 'Recortar
                Exit Select

            Case 101
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_101.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_101.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_101.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_101.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_101.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_101.CanCutSelection 'Recortar
                Exit Select

            Case 102
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_102.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_102.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_102.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_102.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_102.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_102.CanCutSelection 'Recortar
                Exit Select

            Case 103
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_103.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_103.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_103.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_103.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_103.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_103.CanCutSelection 'Recortar
                Exit Select

            Case 104
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_104.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_104.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_104.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_104.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_104.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_104.CanCutSelection 'Recortar
                Exit Select

            Case 105
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_105.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_105.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_105.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_105.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_105.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_105.CanCutSelection 'Recortar
                Exit Select

            Case 106
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_106.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_106.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_106.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_106.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_106.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_106.CanCutSelection 'Recortar
                Exit Select

            Case 107
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_107.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_107.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_107.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_107.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_107.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_107.CanCutSelection 'Recortar
                Exit Select

            Case 108
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_108.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_108.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_108.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_108.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_108.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_108.CanCutSelection 'Recortar
                Exit Select

            Case 109
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_109.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_109.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_109.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_109.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_109.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_109.CanCutSelection 'Recortar
                Exit Select

            Case 110
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_110.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_110.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_110.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_110.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_110.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_110.CanCutSelection 'Recortar
                Exit Select

            Case 111
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_111.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_111.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_111.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_111.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_111.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_111.CanCutSelection 'Recortar
                Exit Select

            Case 112
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_112.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_112.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_112.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_112.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_112.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_112.CanCutSelection 'Recortar
                Exit Select

            Case 113
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_113.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_113.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_113.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_113.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_113.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_113.CanCutSelection 'Recortar
                Exit Select

            Case 114
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_114.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_114.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_114.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_114.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_114.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_114.CanCutSelection 'Recortar
                Exit Select

            Case 115
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_115.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_115.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_115.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_115.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_115.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_115.CanCutSelection 'Recortar
                Exit Select

            Case 116
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_116.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_116.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_116.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_116.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_116.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_116.CanCutSelection 'Recortar
                Exit Select

            Case 117
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_117.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_117.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_117.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_117.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_117.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_117.CanCutSelection 'Recortar
                Exit Select

            Case 118
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_118.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_118.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_118.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_118.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_118.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_118.CanCutSelection 'Recortar
                Exit Select

            Case 119
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_119.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_119.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_119.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_119.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_119.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_119.CanCutSelection 'Recortar
                Exit Select

            Case 120
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_120.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_120.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_120.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_120.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_120.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_120.CanCutSelection 'Recortar
                Exit Select

            Case 121
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_121.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_121.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_121.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_121.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_121.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_121.CanCutSelection 'Recortar
                Exit Select

            Case 122
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_122.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_122.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_122.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_122.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_122.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_122.CanCutSelection 'Recortar
                Exit Select

            Case 123
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_123.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_123.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_123.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_123.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_123.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_123.CanCutSelection 'Recortar
                Exit Select

            Case 124
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_124.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_124.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_124.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_124.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_124.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_124.CanCutSelection 'Recortar
                Exit Select

            Case 125
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_125.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_125.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_125.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_125.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_125.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_125.CanCutSelection 'Recortar
                Exit Select

            Case 126
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_126.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_126.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_126.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_126.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_126.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_126.CanCutSelection 'Recortar
                Exit Select

            Case 127
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_127.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_127.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_127.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_127.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_127.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_127.CanCutSelection 'Recortar
                Exit Select

            Case 128
                FRM_NAVEGACAO.ButtonItem18.Enabled = OBJ_MOTOR_GECKOFX_128.CanUndo 'Desfazer
                FRM_NAVEGACAO.ButtonItem19.Enabled = OBJ_MOTOR_GECKOFX_128.CanRedo 'Refazer
                FRM_NAVEGACAO.ButtonItem20.Enabled = OBJ_MOTOR_GECKOFX_128.CanCutSelection 'Recortar
                FRM_NAVEGACAO.ButtonItem21.Enabled = OBJ_MOTOR_GECKOFX_128.CanCopySelection 'Copiar
                FRM_NAVEGACAO.ButtonItem22.Enabled = OBJ_MOTOR_GECKOFX_128.CanPaste 'Colar
                FRM_NAVEGACAO.ButtonItem23.Enabled = OBJ_MOTOR_GECKOFX_128.CanCutSelection 'Recortar
                Exit Select

        End Select


    End Sub




    'Opcoes do menu historico

    Public Sub proc_menu_historico_exibir_itens_corretos() 'Exibe os itens corretos do menu historico
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso

            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_1.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_1.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_1.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_1.CanGoForward 'Avançar

                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_2.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_2.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_2.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_2.CanGoForward 'Avançar

                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_3.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_3.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_3.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_3.CanGoForward 'Avançar

                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_4.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_4.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_4.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_4.CanGoForward 'Avançar

                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_5.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_5.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_5.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_5.CanGoForward 'Avançar

                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_6.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_6.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_6.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_6.CanGoForward 'Avançar

                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_7.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_7.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_7.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_7.CanGoForward 'Avançar

                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_8.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_8.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_8.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_8.CanGoForward 'Avançar

                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_9.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_9.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_9.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_9.CanGoForward 'Avançar

                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_10.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_10.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_10.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_10.CanGoForward 'Avançar

                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_11.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_11.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_11.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_11.CanGoForward 'Avançar

                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_12.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_12.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_12.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_12.CanGoForward 'Avançar

                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_13.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_13.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_13.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_13.CanGoForward 'Avançar

                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_14.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_14.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_14.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_14.CanGoForward 'Avançar

                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_15.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_15.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_15.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_15.CanGoForward 'Avançar

                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_16.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_16.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_16.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_16.CanGoForward 'Avançar

                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_17.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_17.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_17.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_17.CanGoForward 'Avançar

                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_18.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_18.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_18.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_18.CanGoForward 'Avançar

                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_19.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_19.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_19.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_19.CanGoForward 'Avançar

                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_20.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_20.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_20.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_20.CanGoForward 'Avançar

                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_21.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_21.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_21.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_21.CanGoForward 'Avançar

                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_22.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_22.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_22.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_22.CanGoForward 'Avançar

                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_23.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_23.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_23.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_23.CanGoForward 'Avançar

                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_24.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_24.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_24.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_24.CanGoForward 'Avançar

                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_25.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_25.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_25.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_25.CanGoForward 'Avançar

                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_26.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_26.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_26.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_26.CanGoForward 'Avançar

                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_27.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_27.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_27.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_27.CanGoForward 'Avançar

                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_28.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_28.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_28.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_28.CanGoForward 'Avançar

                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_29.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_29.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_29.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_29.CanGoForward 'Avançar

                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_30.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_30.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_30.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_30.CanGoForward 'Avançar

                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_31.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_31.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_31.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_31.CanGoForward 'Avançar

                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_32.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_32.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_32.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_32.CanGoForward 'Avançar

                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_33.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_33.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_33.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_33.CanGoForward 'Avançar

                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_34.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_34.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_34.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_34.CanGoForward 'Avançar

                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_35.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_35.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_35.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_35.CanGoForward 'Avançar

                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_36.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_36.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_36.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_36.CanGoForward 'Avançar

                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_37.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_37.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_37.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_37.CanGoForward 'Avançar

                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_38.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_38.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_38.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_38.CanGoForward 'Avançar

                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_39.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_39.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_39.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_39.CanGoForward 'Avançar

                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_40.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_40.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_40.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_40.CanGoForward 'Avançar

                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_41.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_41.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_41.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_41.CanGoForward 'Avançar

                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_42.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_42.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_42.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_42.CanGoForward 'Avançar

                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_43.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_43.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_43.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_43.CanGoForward 'Avançar

                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_44.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_44.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_44.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_44.CanGoForward 'Avançar

                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_45.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_45.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_45.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_45.CanGoForward 'Avançar

                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_46.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_46.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_46.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_46.CanGoForward 'Avançar

                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_47.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_47.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_47.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_47.CanGoForward 'Avançar

                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_48.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_48.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_48.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_48.CanGoForward 'Avançar

                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_49.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_49.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_49.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_49.CanGoForward 'Avançar

                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_50.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_50.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_50.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_50.CanGoForward 'Avançar

                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_51.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_51.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_51.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_51.CanGoForward 'Avançar

                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_52.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_52.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_52.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_52.CanGoForward 'Avançar

                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_53.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_53.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_53.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_53.CanGoForward 'Avançar

                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_54.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_54.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_54.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_54.CanGoForward 'Avançar

                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_55.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_55.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_55.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_55.CanGoForward 'Avançar

                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_56.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_56.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_56.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_56.CanGoForward 'Avançar

                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_57.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_57.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_57.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_57.CanGoForward 'Avançar

                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_58.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_58.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_58.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_58.CanGoForward 'Avançar

                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_59.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_59.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_59.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_59.CanGoForward 'Avançar

                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_60.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_60.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_60.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_60.CanGoForward 'Avançar

                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_61.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_61.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_61.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_61.CanGoForward 'Avançar

                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_62.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_62.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_62.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_62.CanGoForward 'Avançar

                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_63.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_63.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_63.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_63.CanGoForward 'Avançar

                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_64.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_64.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_64.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_64.CanGoForward 'Avançar

                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_65.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_65.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_65.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_65.CanGoForward 'Avançar

                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_66.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_66.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_66.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_66.CanGoForward 'Avançar

                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_67.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_67.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_67.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_67.CanGoForward 'Avançar

                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_68.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_68.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_68.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_68.CanGoForward 'Avançar

                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_69.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_69.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_69.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_69.CanGoForward 'Avançar

                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_70.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_70.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_70.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_70.CanGoForward 'Avançar

                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_71.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_71.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_71.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_71.CanGoForward 'Avançar

                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_72.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_72.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_72.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_72.CanGoForward 'Avançar

                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_73.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_73.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_73.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_73.CanGoForward 'Avançar

                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_74.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_74.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_74.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_74.CanGoForward 'Avançar

                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_75.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_75.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_75.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_75.CanGoForward 'Avançar

                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_76.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_76.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_76.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_76.CanGoForward 'Avançar

                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_77.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_77.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_77.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_77.CanGoForward 'Avançar

                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_78.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_78.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_78.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_78.CanGoForward 'Avançar

                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_79.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_79.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_79.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_79.CanGoForward 'Avançar

                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_80.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_80.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_80.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_80.CanGoForward 'Avançar

                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_81.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_81.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_81.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_81.CanGoForward 'Avançar

                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_82.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_82.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_82.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_82.CanGoForward 'Avançar

                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_83.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_83.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_83.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_83.CanGoForward 'Avançar

                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_84.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_84.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_84.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_84.CanGoForward 'Avançar

                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_85.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_85.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_85.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_85.CanGoForward 'Avançar

                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_86.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_86.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_86.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_86.CanGoForward 'Avançar

                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_87.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_87.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_87.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_87.CanGoForward 'Avançar

                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_88.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_88.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_88.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_88.CanGoForward 'Avançar

                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_89.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_89.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_89.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_89.CanGoForward 'Avançar

                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_90.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_90.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_90.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_90.CanGoForward 'Avançar

                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_91.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_91.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_91.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_91.CanGoForward 'Avançar

                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_92.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_92.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_92.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_92.CanGoForward 'Avançar

                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_93.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_93.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_93.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_93.CanGoForward 'Avançar

                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_94.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_94.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_94.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_94.CanGoForward 'Avançar

                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_95.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_95.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_95.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_95.CanGoForward 'Avançar

                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_96.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_96.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_96.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_96.CanGoForward 'Avançar

                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_97.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_97.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_97.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_97.CanGoForward 'Avançar

                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_98.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_98.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_98.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_98.CanGoForward 'Avançar

                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_99.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_99.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_99.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_99.CanGoForward 'Avançar

                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_100.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_100.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_100.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_100.CanGoForward 'Avançar

                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_101.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_101.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_101.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_101.CanGoForward 'Avançar

                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_102.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_102.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_102.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_102.CanGoForward 'Avançar

                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_103.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_103.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_103.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_103.CanGoForward 'Avançar

                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_104.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_104.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_104.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_104.CanGoForward 'Avançar

                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_105.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_105.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_105.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_105.CanGoForward 'Avançar

                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_106.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_106.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_106.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_106.CanGoForward 'Avançar

                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_107.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_107.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_107.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_107.CanGoForward 'Avançar

                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_108.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_108.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_108.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_108.CanGoForward 'Avançar

                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_109.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_109.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_109.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_109.CanGoForward 'Avançar

                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_110.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_110.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_110.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_110.CanGoForward 'Avançar

                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_111.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_111.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_111.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_111.CanGoForward 'Avançar

                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_112.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_112.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_112.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_112.CanGoForward 'Avançar

                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_113.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_113.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_113.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_113.CanGoForward 'Avançar

                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_114.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_114.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_114.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_114.CanGoForward 'Avançar

                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_115.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_115.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_115.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_115.CanGoForward 'Avançar

                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_116.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_116.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_116.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_116.CanGoForward 'Avançar

                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_117.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_117.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_117.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_117.CanGoForward 'Avançar

                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_118.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_118.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_118.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_118.CanGoForward 'Avançar

                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_119.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_119.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_119.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_119.CanGoForward 'Avançar

                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_120.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_120.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_120.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_120.CanGoForward 'Avançar

                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_121.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_121.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_121.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_121.CanGoForward 'Avançar

                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_122.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_122.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_122.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_122.CanGoForward 'Avançar

                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_123.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_123.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_123.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_123.CanGoForward 'Avançar

                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_124.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_124.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_124.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_124.CanGoForward 'Avançar

                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_125.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_125.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_125.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_125.CanGoForward 'Avançar

                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_126.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_126.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_126.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_126.CanGoForward 'Avançar

                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_127.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_127.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_127.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_127.CanGoForward 'Avançar

                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_GECKOFX_128.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_GECKOFX_128.CanGoForward 'Avançar

                Else

                    FRM_NAVEGACAO.ButtonItem36.Enabled = OBJ_MOTOR_WEB_BROWSER_128.CanGoBack 'Voltar
                    FRM_NAVEGACAO.ButtonItem37.Enabled = OBJ_MOTOR_WEB_BROWSER_128.CanGoForward 'Avançar

                End If
                Exit Select

        End Select


    End Sub








    'Referente ao menu do botao direito para editar a imagem com o editor de imagens

    Dim V_INDEX_DA_IMAGEM_SALVA As Integer 'Informa o index da imagem salva






    Public Sub proc_editar_imagem_com_editor_de_imagens() 'Edita a imagem com o editor de imagens
        On Error Resume Next

        Dim OBJ_IMAGEM_RECUPERADA As Image 'Imagem recuperada da ram

        Dim V_END_ARQUIVO_DA_IMAGEM As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "imagem_ps" & V_INDEX_DA_IMAGEM_SALVA & ".jpg" 'Obtendo o endereço da imagem






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Atualizando index ---------------------------------------------------------------------------------------------

        V_INDEX_DA_IMAGEM_SALVA = V_INDEX_DA_IMAGEM_SALVA + 1 'Atualizando...

        '---------------------------------------------------------------------------------------------------------------



        'Obtendo dados da imagem ---------------------------------------------------------------------------------------


        Select Case v_qual_motor_esta_em_uso




            Case 1
                OBJ_MOTOR_GECKOFX_1.CopyImageContents() 'Copiando imagem para a ram

            Case 2
                OBJ_MOTOR_GECKOFX_2.CopyImageContents() 'Copiando imagem para a ram

            Case 3
                OBJ_MOTOR_GECKOFX_3.CopyImageContents() 'Copiando imagem para a ram

            Case 4
                OBJ_MOTOR_GECKOFX_4.CopyImageContents() 'Copiando imagem para a ram

            Case 5
                OBJ_MOTOR_GECKOFX_5.CopyImageContents() 'Copiando imagem para a ram

            Case 6
                OBJ_MOTOR_GECKOFX_6.CopyImageContents() 'Copiando imagem para a ram

            Case 7
                OBJ_MOTOR_GECKOFX_7.CopyImageContents() 'Copiando imagem para a ram

            Case 8
                OBJ_MOTOR_GECKOFX_8.CopyImageContents() 'Copiando imagem para a ram

            Case 9
                OBJ_MOTOR_GECKOFX_9.CopyImageContents() 'Copiando imagem para a ram

            Case 10
                OBJ_MOTOR_GECKOFX_10.CopyImageContents() 'Copiando imagem para a ram

            Case 11
                OBJ_MOTOR_GECKOFX_11.CopyImageContents() 'Copiando imagem para a ram

            Case 12
                OBJ_MOTOR_GECKOFX_12.CopyImageContents() 'Copiando imagem para a ram

            Case 13
                OBJ_MOTOR_GECKOFX_13.CopyImageContents() 'Copiando imagem para a ram

            Case 14
                OBJ_MOTOR_GECKOFX_14.CopyImageContents() 'Copiando imagem para a ram

            Case 15
                OBJ_MOTOR_GECKOFX_15.CopyImageContents() 'Copiando imagem para a ram

            Case 16
                OBJ_MOTOR_GECKOFX_16.CopyImageContents() 'Copiando imagem para a ram

            Case 17
                OBJ_MOTOR_GECKOFX_17.CopyImageContents() 'Copiando imagem para a ram

            Case 18
                OBJ_MOTOR_GECKOFX_18.CopyImageContents() 'Copiando imagem para a ram

            Case 19
                OBJ_MOTOR_GECKOFX_19.CopyImageContents() 'Copiando imagem para a ram

            Case 20
                OBJ_MOTOR_GECKOFX_20.CopyImageContents() 'Copiando imagem para a ram

            Case 21
                OBJ_MOTOR_GECKOFX_21.CopyImageContents() 'Copiando imagem para a ram

            Case 22
                OBJ_MOTOR_GECKOFX_22.CopyImageContents() 'Copiando imagem para a ram

            Case 23
                OBJ_MOTOR_GECKOFX_23.CopyImageContents() 'Copiando imagem para a ram

            Case 24
                OBJ_MOTOR_GECKOFX_24.CopyImageContents() 'Copiando imagem para a ram

            Case 25
                OBJ_MOTOR_GECKOFX_25.CopyImageContents() 'Copiando imagem para a ram

            Case 26
                OBJ_MOTOR_GECKOFX_26.CopyImageContents() 'Copiando imagem para a ram

            Case 27
                OBJ_MOTOR_GECKOFX_27.CopyImageContents() 'Copiando imagem para a ram

            Case 28
                OBJ_MOTOR_GECKOFX_28.CopyImageContents() 'Copiando imagem para a ram

            Case 29
                OBJ_MOTOR_GECKOFX_29.CopyImageContents() 'Copiando imagem para a ram

            Case 30
                OBJ_MOTOR_GECKOFX_30.CopyImageContents() 'Copiando imagem para a ram

            Case 31
                OBJ_MOTOR_GECKOFX_31.CopyImageContents() 'Copiando imagem para a ram

            Case 32
                OBJ_MOTOR_GECKOFX_32.CopyImageContents() 'Copiando imagem para a ram

            Case 33
                OBJ_MOTOR_GECKOFX_33.CopyImageContents() 'Copiando imagem para a ram

            Case 34
                OBJ_MOTOR_GECKOFX_34.CopyImageContents() 'Copiando imagem para a ram

            Case 35
                OBJ_MOTOR_GECKOFX_35.CopyImageContents() 'Copiando imagem para a ram

            Case 36
                OBJ_MOTOR_GECKOFX_36.CopyImageContents() 'Copiando imagem para a ram

            Case 37
                OBJ_MOTOR_GECKOFX_37.CopyImageContents() 'Copiando imagem para a ram

            Case 38
                OBJ_MOTOR_GECKOFX_38.CopyImageContents() 'Copiando imagem para a ram

            Case 39
                OBJ_MOTOR_GECKOFX_39.CopyImageContents() 'Copiando imagem para a ram

            Case 40
                OBJ_MOTOR_GECKOFX_40.CopyImageContents() 'Copiando imagem para a ram

            Case 41
                OBJ_MOTOR_GECKOFX_41.CopyImageContents() 'Copiando imagem para a ram

            Case 42
                OBJ_MOTOR_GECKOFX_42.CopyImageContents() 'Copiando imagem para a ram

            Case 43
                OBJ_MOTOR_GECKOFX_43.CopyImageContents() 'Copiando imagem para a ram

            Case 44
                OBJ_MOTOR_GECKOFX_44.CopyImageContents() 'Copiando imagem para a ram

            Case 45
                OBJ_MOTOR_GECKOFX_45.CopyImageContents() 'Copiando imagem para a ram

            Case 46
                OBJ_MOTOR_GECKOFX_46.CopyImageContents() 'Copiando imagem para a ram

            Case 47
                OBJ_MOTOR_GECKOFX_47.CopyImageContents() 'Copiando imagem para a ram

            Case 48
                OBJ_MOTOR_GECKOFX_48.CopyImageContents() 'Copiando imagem para a ram

            Case 49
                OBJ_MOTOR_GECKOFX_49.CopyImageContents() 'Copiando imagem para a ram

            Case 50
                OBJ_MOTOR_GECKOFX_50.CopyImageContents() 'Copiando imagem para a ram

            Case 51
                OBJ_MOTOR_GECKOFX_51.CopyImageContents() 'Copiando imagem para a ram

            Case 52
                OBJ_MOTOR_GECKOFX_52.CopyImageContents() 'Copiando imagem para a ram

            Case 53
                OBJ_MOTOR_GECKOFX_53.CopyImageContents() 'Copiando imagem para a ram

            Case 54
                OBJ_MOTOR_GECKOFX_54.CopyImageContents() 'Copiando imagem para a ram

            Case 55
                OBJ_MOTOR_GECKOFX_55.CopyImageContents() 'Copiando imagem para a ram

            Case 56
                OBJ_MOTOR_GECKOFX_56.CopyImageContents() 'Copiando imagem para a ram

            Case 57
                OBJ_MOTOR_GECKOFX_57.CopyImageContents() 'Copiando imagem para a ram

            Case 58
                OBJ_MOTOR_GECKOFX_58.CopyImageContents() 'Copiando imagem para a ram

            Case 59
                OBJ_MOTOR_GECKOFX_59.CopyImageContents() 'Copiando imagem para a ram

            Case 60
                OBJ_MOTOR_GECKOFX_60.CopyImageContents() 'Copiando imagem para a ram

            Case 61
                OBJ_MOTOR_GECKOFX_61.CopyImageContents() 'Copiando imagem para a ram

            Case 62
                OBJ_MOTOR_GECKOFX_62.CopyImageContents() 'Copiando imagem para a ram

            Case 63
                OBJ_MOTOR_GECKOFX_63.CopyImageContents() 'Copiando imagem para a ram

            Case 64
                OBJ_MOTOR_GECKOFX_64.CopyImageContents() 'Copiando imagem para a ram

            Case 65
                OBJ_MOTOR_GECKOFX_65.CopyImageContents() 'Copiando imagem para a ram

            Case 66
                OBJ_MOTOR_GECKOFX_66.CopyImageContents() 'Copiando imagem para a ram

            Case 67
                OBJ_MOTOR_GECKOFX_67.CopyImageContents() 'Copiando imagem para a ram

            Case 68
                OBJ_MOTOR_GECKOFX_68.CopyImageContents() 'Copiando imagem para a ram

            Case 69
                OBJ_MOTOR_GECKOFX_69.CopyImageContents() 'Copiando imagem para a ram

            Case 70
                OBJ_MOTOR_GECKOFX_70.CopyImageContents() 'Copiando imagem para a ram

            Case 71
                OBJ_MOTOR_GECKOFX_71.CopyImageContents() 'Copiando imagem para a ram

            Case 72
                OBJ_MOTOR_GECKOFX_72.CopyImageContents() 'Copiando imagem para a ram

            Case 73
                OBJ_MOTOR_GECKOFX_73.CopyImageContents() 'Copiando imagem para a ram

            Case 74
                OBJ_MOTOR_GECKOFX_74.CopyImageContents() 'Copiando imagem para a ram

            Case 75
                OBJ_MOTOR_GECKOFX_75.CopyImageContents() 'Copiando imagem para a ram

            Case 76
                OBJ_MOTOR_GECKOFX_76.CopyImageContents() 'Copiando imagem para a ram

            Case 77
                OBJ_MOTOR_GECKOFX_77.CopyImageContents() 'Copiando imagem para a ram

            Case 78
                OBJ_MOTOR_GECKOFX_78.CopyImageContents() 'Copiando imagem para a ram

            Case 79
                OBJ_MOTOR_GECKOFX_79.CopyImageContents() 'Copiando imagem para a ram

            Case 80
                OBJ_MOTOR_GECKOFX_80.CopyImageContents() 'Copiando imagem para a ram

            Case 81
                OBJ_MOTOR_GECKOFX_81.CopyImageContents() 'Copiando imagem para a ram

            Case 82
                OBJ_MOTOR_GECKOFX_82.CopyImageContents() 'Copiando imagem para a ram

            Case 83
                OBJ_MOTOR_GECKOFX_83.CopyImageContents() 'Copiando imagem para a ram

            Case 84
                OBJ_MOTOR_GECKOFX_84.CopyImageContents() 'Copiando imagem para a ram

            Case 85
                OBJ_MOTOR_GECKOFX_85.CopyImageContents() 'Copiando imagem para a ram

            Case 86
                OBJ_MOTOR_GECKOFX_86.CopyImageContents() 'Copiando imagem para a ram

            Case 87
                OBJ_MOTOR_GECKOFX_87.CopyImageContents() 'Copiando imagem para a ram

            Case 88
                OBJ_MOTOR_GECKOFX_88.CopyImageContents() 'Copiando imagem para a ram

            Case 89
                OBJ_MOTOR_GECKOFX_89.CopyImageContents() 'Copiando imagem para a ram

            Case 90
                OBJ_MOTOR_GECKOFX_90.CopyImageContents() 'Copiando imagem para a ram

            Case 91
                OBJ_MOTOR_GECKOFX_91.CopyImageContents() 'Copiando imagem para a ram

            Case 92
                OBJ_MOTOR_GECKOFX_92.CopyImageContents() 'Copiando imagem para a ram

            Case 93
                OBJ_MOTOR_GECKOFX_93.CopyImageContents() 'Copiando imagem para a ram

            Case 94
                OBJ_MOTOR_GECKOFX_94.CopyImageContents() 'Copiando imagem para a ram

            Case 95
                OBJ_MOTOR_GECKOFX_95.CopyImageContents() 'Copiando imagem para a ram

            Case 96
                OBJ_MOTOR_GECKOFX_96.CopyImageContents() 'Copiando imagem para a ram

            Case 97
                OBJ_MOTOR_GECKOFX_97.CopyImageContents() 'Copiando imagem para a ram

            Case 98
                OBJ_MOTOR_GECKOFX_98.CopyImageContents() 'Copiando imagem para a ram

            Case 99
                OBJ_MOTOR_GECKOFX_99.CopyImageContents() 'Copiando imagem para a ram

            Case 100
                OBJ_MOTOR_GECKOFX_100.CopyImageContents() 'Copiando imagem para a ram

            Case 101
                OBJ_MOTOR_GECKOFX_101.CopyImageContents() 'Copiando imagem para a ram

            Case 102
                OBJ_MOTOR_GECKOFX_102.CopyImageContents() 'Copiando imagem para a ram

            Case 103
                OBJ_MOTOR_GECKOFX_103.CopyImageContents() 'Copiando imagem para a ram

            Case 104
                OBJ_MOTOR_GECKOFX_104.CopyImageContents() 'Copiando imagem para a ram

            Case 105
                OBJ_MOTOR_GECKOFX_105.CopyImageContents() 'Copiando imagem para a ram

            Case 106
                OBJ_MOTOR_GECKOFX_106.CopyImageContents() 'Copiando imagem para a ram

            Case 107
                OBJ_MOTOR_GECKOFX_107.CopyImageContents() 'Copiando imagem para a ram

            Case 108
                OBJ_MOTOR_GECKOFX_108.CopyImageContents() 'Copiando imagem para a ram

            Case 109
                OBJ_MOTOR_GECKOFX_109.CopyImageContents() 'Copiando imagem para a ram

            Case 110
                OBJ_MOTOR_GECKOFX_110.CopyImageContents() 'Copiando imagem para a ram

            Case 111
                OBJ_MOTOR_GECKOFX_111.CopyImageContents() 'Copiando imagem para a ram

            Case 112
                OBJ_MOTOR_GECKOFX_112.CopyImageContents() 'Copiando imagem para a ram

            Case 113
                OBJ_MOTOR_GECKOFX_113.CopyImageContents() 'Copiando imagem para a ram

            Case 114
                OBJ_MOTOR_GECKOFX_114.CopyImageContents() 'Copiando imagem para a ram

            Case 115
                OBJ_MOTOR_GECKOFX_115.CopyImageContents() 'Copiando imagem para a ram

            Case 116
                OBJ_MOTOR_GECKOFX_116.CopyImageContents() 'Copiando imagem para a ram

            Case 117
                OBJ_MOTOR_GECKOFX_117.CopyImageContents() 'Copiando imagem para a ram

            Case 118
                OBJ_MOTOR_GECKOFX_118.CopyImageContents() 'Copiando imagem para a ram

            Case 119
                OBJ_MOTOR_GECKOFX_119.CopyImageContents() 'Copiando imagem para a ram

            Case 120
                OBJ_MOTOR_GECKOFX_120.CopyImageContents() 'Copiando imagem para a ram

            Case 121
                OBJ_MOTOR_GECKOFX_121.CopyImageContents() 'Copiando imagem para a ram

            Case 122
                OBJ_MOTOR_GECKOFX_122.CopyImageContents() 'Copiando imagem para a ram

            Case 123
                OBJ_MOTOR_GECKOFX_123.CopyImageContents() 'Copiando imagem para a ram

            Case 124
                OBJ_MOTOR_GECKOFX_124.CopyImageContents() 'Copiando imagem para a ram

            Case 125
                OBJ_MOTOR_GECKOFX_125.CopyImageContents() 'Copiando imagem para a ram

            Case 126
                OBJ_MOTOR_GECKOFX_126.CopyImageContents() 'Copiando imagem para a ram

            Case 127
                OBJ_MOTOR_GECKOFX_127.CopyImageContents() 'Copiando imagem para a ram

            Case 128
                OBJ_MOTOR_GECKOFX_128.CopyImageContents() 'Copiando imagem para a ram




        End Select





        OBJ_IMAGEM_RECUPERADA = My.Computer.Clipboard.GetImage 'Obtendo a imagem

        OBJ_IMAGEM_RECUPERADA.Save(V_END_ARQUIVO_DA_IMAGEM) 'Salvando a imagem



        '---------------------------------------------------------------------------------------------------------------




        'Abrindo programa ----------------------------------------------------------------------------------------------

        proc_chamar_aplicativo_photo_sete(True, V_END_ARQUIVO_DA_IMAGEM) 'Chamar o aplicativo photo sete

        '---------------------------------------------------------------------------------------------------------------



        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub










    'Refere a mostrar o endereço ip do site e o do proprio computador

    Public Sub proc_exibir_end_ip_de_site_e_proprio_end_ip(ByVal V_END_SITE As String, ByVal V_POSICAO As Point) 'Exibe endereço de site e o proprio end ip.
        On Error Resume Next

        Dim OBJ_MENU_DE_CONTEXTO As New ContextMenuStrip 'Novo menu de contexto

        Dim V_IP_COMPUTADOR As String = Nothing 'Informa o endereço ip tanto do computador local, quanto do site

        Dim V_IP_SITE As String = Nothing 'Informa o endereço ip tanto do computador local, quanto do site






        'Obtendo ip local e ip do site ---------------------------------------------------------------------------------

        V_IP_COMPUTADOR = func_obter_o_ip_local() 'Retorna o ip da maquina local

        V_IP_SITE = func_retorne_o_ip_do_site_em_visualizacao(V_END_SITE) 'Retorna o ip do site em visualização.

        '---------------------------------------------------------------------------------------------------------------




        'Adicionando itens e exibindo o menu ---------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.RenderMode = ToolStripRenderMode.System 'Modo do menu

        OBJ_MENU_DE_CONTEXTO.Items.Add("Ip do computador: " & V_IP_COMPUTADOR) 'Local

        OBJ_MENU_DE_CONTEXTO.Items.Add("Ip do site: " & V_END_SITE & ": " & V_IP_SITE) 'Do site

        OBJ_MENU_DE_CONTEXTO.Show(V_POSICAO) 'Exibindo o menu de contexto

        '---------------------------------------------------------------------------------------------------------------


    End Sub






























End Module
