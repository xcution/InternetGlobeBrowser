Module Modulo_de_funcoes_e_procedimentos


    'Variáveis basicas

    Dim v_dados_ram_backup As IO.Stream 'Vai conter os dados da ram

    Dim v_imagem_backup As System.Drawing.Image 'Imagem backup

    Dim v_texto_backup_ram As String 'Texto de backup da ram
















    'Retorna o site em visualização atualmente

    Public Function func_retorne_o_site_em_aberto() 'Retorna o endereço do site em aberto
        On Error Resume Next

        Dim v_valor_de_retorno As String = Nothing 'Informa o valor de retorno




        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_1.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_1.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_2.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_2.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_3.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_3.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_4.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_4.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_5.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_5.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_6.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_6.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_7.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_7.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_8.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_8.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_9.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_9.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_10.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_10.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_11.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_11.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_12.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_12.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_13.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_13.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_14.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_14.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_15.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_15.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_16.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_16.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_17.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_17.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_18.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_18.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_19.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_19.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_20.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_20.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_21.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_21.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_22.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_22.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_23.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_23.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_24.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_24.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_25.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_25.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_26.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_26.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_27.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_27.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_28.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_28.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_29.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_29.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_30.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_30.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_31.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_31.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_32.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_32.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_33.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_33.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_34.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_34.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_35.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_35.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_36.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_36.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_37.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_37.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_38.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_38.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_39.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_39.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_40.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_40.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_41.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_41.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_42.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_42.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_43.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_43.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_44.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_44.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_45.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_45.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_46.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_46.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_47.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_47.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_48.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_48.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_49.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_49.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_50.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_50.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_51.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_51.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_52.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_52.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_53.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_53.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_54.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_54.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_55.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_55.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_56.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_56.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_57.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_57.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_58.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_58.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_59.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_59.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_60.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_60.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_61.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_61.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_62.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_62.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_63.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_63.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_64.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_64.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_65.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_65.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_66.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_66.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_67.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_67.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_68.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_68.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_69.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_69.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_70.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_70.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_71.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_71.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_72.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_72.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_73.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_73.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_74.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_74.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_75.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_75.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_76.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_76.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_77.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_77.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_78.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_78.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_79.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_79.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_80.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_80.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_81.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_81.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_82.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_82.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_83.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_83.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_84.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_84.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_85.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_85.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_86.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_86.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_87.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_87.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_88.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_88.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_89.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_89.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_90.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_90.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_91.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_91.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_92.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_92.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_93.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_93.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_94.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_94.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_95.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_95.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_96.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_96.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_97.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_97.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_98.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_98.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_99.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_99.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_100.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_100.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_101.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_101.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_102.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_102.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_103.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_103.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_104.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_104.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_105.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_105.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_106.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_106.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_107.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_107.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_108.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_108.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_109.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_109.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_110.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_110.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_111.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_111.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_112.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_112.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_113.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_113.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_114.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_114.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_115.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_115.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_116.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_116.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_117.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_117.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_118.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_118.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_119.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_119.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_120.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_120.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_121.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_121.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_122.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_122.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_123.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_123.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_124.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_124.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_125.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_125.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_126.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_126.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_127.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_127.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_128.Url.AbsoluteUri 'Url absoluta
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_128.Url.AbsoluteUri 'Url absoluta
                End If
                Exit Select






        End Select


        'Retorno ---------------------------------------------------------------

        Return v_valor_de_retorno 'Valor de retorno

        '-----------------------------------------------------------------------


    End Function

    Public Function func_retorne_o_titulo_do_site_em_aberto() 'Retorna o titulo do site em aberto
        On Error Resume Next

        Dim v_valor_de_retorno As String = Nothing 'Informa o valor de retorno




        Select Case v_qual_motor_esta_em_uso


            Case 1
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_1.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_1.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 2
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_2.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_2.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 3
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_3.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_3.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 4
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_4.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_4.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 5
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_5.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_5.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 6
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_6.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_6.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 7
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_7.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_7.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 8
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_8.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_8.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 9
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_9.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_9.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 10
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_10.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_10.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 11
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_11.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_11.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 12
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_12.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_12.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 13
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_13.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_13.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 14
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_14.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_14.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 15
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_15.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_15.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 16
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_16.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_16.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 17
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_17.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_17.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 18
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_18.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_18.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 19
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_19.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_19.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 20
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_20.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_20.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 21
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_21.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_21.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 22
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_22.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_22.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 23
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_23.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_23.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 24
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_24.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_24.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 25
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_25.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_25.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 26
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_26.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_26.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 27
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_27.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_27.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 28
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_28.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_28.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 29
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_29.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_29.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 30
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_30.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_30.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 31
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_31.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_31.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 32
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_32.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_32.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 33
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_33.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_33.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 34
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_34.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_34.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 35
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_35.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_35.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 36
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_36.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_36.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 37
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_37.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_37.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 38
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_38.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_38.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 39
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_39.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_39.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 40
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_40.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_40.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 41
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_41.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_41.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 42
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_42.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_42.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 43
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_43.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_43.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 44
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_44.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_44.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 45
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_45.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_45.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 46
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_46.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_46.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 47
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_47.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_47.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 48
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_48.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_48.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 49
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_49.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_49.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 50
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_50.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_50.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 51
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_51.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_51.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 52
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_52.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_52.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 53
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_53.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_53.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 54
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_54.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_54.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 55
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_55.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_55.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 56
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_56.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_56.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 57
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_57.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_57.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 58
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_58.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_58.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 59
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_59.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_59.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 60
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_60.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_60.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 61
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_61.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_61.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 62
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_62.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_62.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 63
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_63.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_63.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 64
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_64.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_64.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 65
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_65.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_65.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 66
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_66.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_66.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 67
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_67.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_67.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 68
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_68.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_68.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 69
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_69.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_69.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 70
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_70.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_70.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 71
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_71.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_71.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 72
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_72.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_72.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 73
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_73.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_73.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 74
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_74.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_74.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 75
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_75.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_75.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 76
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_76.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_76.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 77
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_77.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_77.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 78
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_78.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_78.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 79
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_79.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_79.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 80
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_80.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_80.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 81
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_81.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_81.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 82
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_82.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_82.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 83
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_83.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_83.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 84
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_84.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_84.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 85
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_85.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_85.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 86
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_86.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_86.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 87
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_87.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_87.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 88
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_88.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_88.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 89
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_89.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_89.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 90
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_90.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_90.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 91
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_91.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_91.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 92
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_92.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_92.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 93
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_93.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_93.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 94
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_94.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_94.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 95
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_95.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_95.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 96
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_96.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_96.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 97
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_97.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_97.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 98
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_98.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_98.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 99
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_99.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_99.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 100
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_100.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_100.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 101
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_101.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_101.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 102
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_102.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_102.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 103
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_103.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_103.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 104
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_104.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_104.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 105
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_105.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_105.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 106
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_106.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_106.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 107
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_107.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_107.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 108
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_108.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_108.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 109
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_109.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_109.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 110
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_110.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_110.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 111
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_111.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_111.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 112
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_112.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_112.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 113
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_113.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_113.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 114
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_114.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_114.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 115
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_115.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_115.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 116
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_116.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_116.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 117
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_117.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_117.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 118
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_118.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_118.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 119
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_119.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_119.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 120
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_120.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_120.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 121
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_121.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_121.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 122
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_122.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_122.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 123
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_123.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_123.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 124
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_124.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_124.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 125
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_125.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_125.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 126
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_126.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_126.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 127
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_127.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_127.DocumentTitle 'Título do site
                End If
                Exit Select

            Case 128
                If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then
                    v_valor_de_retorno = OBJ_MOTOR_GECKOFX_128.DocumentTitle 'Título do site
                Else
                    v_valor_de_retorno = OBJ_MOTOR_WEB_BROWSER_128.DocumentTitle 'Título do site
                End If
                Exit Select







        End Select


        'Retorno ---------------------------------------------------------------

        Return v_valor_de_retorno 'Valor de retorno

        '-----------------------------------------------------------------------


    End Function

    Public Function func_retorne_se_arquivo_existe_ou_nao(ByVal v_destino_de_arquivo As String) 'Retorna se o arquivo existe ou nao
        On Error Resume Next

        Dim v_existir As Boolean 'Informa se o arquivo existe ou nao






        v_existir = My.Computer.FileSystem.FileExists(v_destino_de_arquivo) 'Verificando...

        Return v_existir 'Retorno


    End Function

    Public Sub proc_som_de_evento_ouvir(ByVal v_som As String) 'Ouvir o som de evento
        On Error Resume Next


        'Verifica se usa o som de sistema ------------------------------------------------------------------------------

        If (V_VAL_CONFIG_RECURSO_DE_SONS_DE_SISTEMA = True) Then

            My.Computer.Audio.Play(v_som, AudioPlayMode.Background) 'Executando o som

        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_informe_com_voz_sobre_protocolo_https_seguranca_pagina(ByVal v_end_da_pagina As String) 'Informa ao usuário se a página visitada é ou nao segura
        On Error Resume Next


        'Converte para minusculo ---------------------------------------------------------------------------------------

        v_end_da_pagina = v_end_da_pagina.ToLower 'Converter para minusculo

        '---------------------------------------------------------------------------------------------------------------




        'Analiza endereço de pagina ---------------------------------------------------------------------------------------------------------------------------------------

        If (v_end_da_pagina.StartsWith("https://") = True) Then


            proc_falar_texto_repassado_recurso_de_voz_direto(V_MS_30) 'Procedimento para leitura de texto repassado pelo usuário, sem saida ou entrada na caixa de texto.


        Else


            proc_falar_texto_repassado_recurso_de_voz_direto(V_MS_29) 'Procedimento para leitura de texto repassado pelo usuário, sem saida ou entrada na caixa de texto.


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram
        On Error Resume Next


        'Obtendo dados -----------------------------------------------------------------------------

        v_dados_ram_backup = My.Computer.Clipboard.GetAudioStream 'Obtendo dados de áudio

        v_imagem_backup = My.Computer.Clipboard.GetImage 'Obtendo dados de imagem

        v_texto_backup_ram = My.Computer.Clipboard.GetText 'Texto da memoria ram

        '-------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar
        On Error Resume Next


        'Obtendo dados -----------------------------------------------------------------------------

        My.Computer.Clipboard.SetAudio(v_dados_ram_backup) 'Restaurando dados de áudio

        My.Computer.Clipboard.SetImage(v_imagem_backup) 'Restaurando dados de imagem

        My.Computer.Clipboard.SetText(v_texto_backup_ram) 'Restaurando da memoria ram

        '-------------------------------------------------------------------------------------------


    End Sub

    Public Function func_retorne_motor_tts_sendo_usado_status() 'Retorna o valor do status de leitura do motor tts
        On Error Resume Next


        'Analiza o estado de leitura, e dá o retorno correto ----------------------------------------------------------------------------------

        If (OBJ_VOZ_DO_NAVEGADOR.Status.RunningState = SpeechLib.SpeechRunState.SRSEIsSpeaking) Then

            Return True 'Esta lendo

        Else

            Return False 'Nao esta lendo

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Function

    Public Sub proc_ler_texto_selecionado_pelo_item_da_barra_de_menus() 'Lê o texto selecionado pelo menu de aplicativos
        On Error Resume Next

        Dim v_texto_a_ser_lido As String = Nothing 'Informa o texto a ser lido

        Dim v_resposta_da_funcao As Boolean = func_retorne_motor_tts_sendo_usado_status() 'Retorna o valor do status de leitura do motor tts






        'Verifica o tipo de motor em uso -------------------------------------------------------------------------------

        If (v_tipo_de_motor_layout_engine_em_uso_agora = False) Then


            MsgBox(V_MS_31, MsgBoxStyle.Exclamation, "Alerta ao usúario") 'Mensagem

            Exit Sub 'Saindo...


        End If

        '---------------------------------------------------------------------------------------------------------------




        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Limpa o conteudo da ram ---------------------------------------

        My.Computer.Clipboard.Clear() 'Limpando...

        '---------------------------------------------------------------




        'Obtendo o texto selecionado -----------------------------------------------------------------------------------

        Select Case v_qual_motor_esta_em_uso

            Case 1
                OBJ_MOTOR_GECKOFX_1.CopySelection() 'Copiando o texto

            Case 2
                OBJ_MOTOR_GECKOFX_2.CopySelection() 'Copiando o texto

            Case 3
                OBJ_MOTOR_GECKOFX_3.CopySelection() 'Copiando o texto

            Case 4
                OBJ_MOTOR_GECKOFX_4.CopySelection() 'Copiando o texto

            Case 5
                OBJ_MOTOR_GECKOFX_5.CopySelection() 'Copiando o texto

            Case 6
                OBJ_MOTOR_GECKOFX_6.CopySelection() 'Copiando o texto

            Case 7
                OBJ_MOTOR_GECKOFX_7.CopySelection() 'Copiando o texto

            Case 8
                OBJ_MOTOR_GECKOFX_8.CopySelection() 'Copiando o texto

            Case 9
                OBJ_MOTOR_GECKOFX_9.CopySelection() 'Copiando o texto

            Case 10
                OBJ_MOTOR_GECKOFX_10.CopySelection() 'Copiando o texto

            Case 11
                OBJ_MOTOR_GECKOFX_11.CopySelection() 'Copiando o texto

            Case 12
                OBJ_MOTOR_GECKOFX_12.CopySelection() 'Copiando o texto

            Case 13
                OBJ_MOTOR_GECKOFX_13.CopySelection() 'Copiando o texto

            Case 14
                OBJ_MOTOR_GECKOFX_14.CopySelection() 'Copiando o texto

            Case 15
                OBJ_MOTOR_GECKOFX_15.CopySelection() 'Copiando o texto

            Case 16
                OBJ_MOTOR_GECKOFX_16.CopySelection() 'Copiando o texto

            Case 17
                OBJ_MOTOR_GECKOFX_17.CopySelection() 'Copiando o texto

            Case 18
                OBJ_MOTOR_GECKOFX_18.CopySelection() 'Copiando o texto

            Case 19
                OBJ_MOTOR_GECKOFX_19.CopySelection() 'Copiando o texto

            Case 20
                OBJ_MOTOR_GECKOFX_20.CopySelection() 'Copiando o texto

            Case 21
                OBJ_MOTOR_GECKOFX_21.CopySelection() 'Copiando o texto

            Case 22
                OBJ_MOTOR_GECKOFX_22.CopySelection() 'Copiando o texto

            Case 23
                OBJ_MOTOR_GECKOFX_23.CopySelection() 'Copiando o texto

            Case 24
                OBJ_MOTOR_GECKOFX_24.CopySelection() 'Copiando o texto

            Case 25
                OBJ_MOTOR_GECKOFX_25.CopySelection() 'Copiando o texto

            Case 26
                OBJ_MOTOR_GECKOFX_26.CopySelection() 'Copiando o texto

            Case 27
                OBJ_MOTOR_GECKOFX_27.CopySelection() 'Copiando o texto

            Case 28
                OBJ_MOTOR_GECKOFX_28.CopySelection() 'Copiando o texto

            Case 29
                OBJ_MOTOR_GECKOFX_29.CopySelection() 'Copiando o texto

            Case 30
                OBJ_MOTOR_GECKOFX_30.CopySelection() 'Copiando o texto

            Case 31
                OBJ_MOTOR_GECKOFX_31.CopySelection() 'Copiando o texto

            Case 32
                OBJ_MOTOR_GECKOFX_32.CopySelection() 'Copiando o texto

            Case 33
                OBJ_MOTOR_GECKOFX_33.CopySelection() 'Copiando o texto

            Case 34
                OBJ_MOTOR_GECKOFX_34.CopySelection() 'Copiando o texto

            Case 35
                OBJ_MOTOR_GECKOFX_35.CopySelection() 'Copiando o texto

            Case 36
                OBJ_MOTOR_GECKOFX_36.CopySelection() 'Copiando o texto

            Case 37
                OBJ_MOTOR_GECKOFX_37.CopySelection() 'Copiando o texto

            Case 38
                OBJ_MOTOR_GECKOFX_38.CopySelection() 'Copiando o texto

            Case 39
                OBJ_MOTOR_GECKOFX_39.CopySelection() 'Copiando o texto

            Case 40
                OBJ_MOTOR_GECKOFX_40.CopySelection() 'Copiando o texto

            Case 41
                OBJ_MOTOR_GECKOFX_41.CopySelection() 'Copiando o texto

            Case 42
                OBJ_MOTOR_GECKOFX_42.CopySelection() 'Copiando o texto

            Case 43
                OBJ_MOTOR_GECKOFX_43.CopySelection() 'Copiando o texto

            Case 44
                OBJ_MOTOR_GECKOFX_44.CopySelection() 'Copiando o texto

            Case 45
                OBJ_MOTOR_GECKOFX_45.CopySelection() 'Copiando o texto

            Case 46
                OBJ_MOTOR_GECKOFX_46.CopySelection() 'Copiando o texto

            Case 47
                OBJ_MOTOR_GECKOFX_47.CopySelection() 'Copiando o texto

            Case 48
                OBJ_MOTOR_GECKOFX_48.CopySelection() 'Copiando o texto

            Case 49
                OBJ_MOTOR_GECKOFX_49.CopySelection() 'Copiando o texto

            Case 50
                OBJ_MOTOR_GECKOFX_50.CopySelection() 'Copiando o texto

            Case 51
                OBJ_MOTOR_GECKOFX_51.CopySelection() 'Copiando o texto

            Case 52
                OBJ_MOTOR_GECKOFX_52.CopySelection() 'Copiando o texto

            Case 53
                OBJ_MOTOR_GECKOFX_53.CopySelection() 'Copiando o texto

            Case 54
                OBJ_MOTOR_GECKOFX_54.CopySelection() 'Copiando o texto

            Case 55
                OBJ_MOTOR_GECKOFX_55.CopySelection() 'Copiando o texto

            Case 56
                OBJ_MOTOR_GECKOFX_56.CopySelection() 'Copiando o texto

            Case 57
                OBJ_MOTOR_GECKOFX_57.CopySelection() 'Copiando o texto

            Case 58
                OBJ_MOTOR_GECKOFX_58.CopySelection() 'Copiando o texto

            Case 59
                OBJ_MOTOR_GECKOFX_59.CopySelection() 'Copiando o texto

            Case 60
                OBJ_MOTOR_GECKOFX_60.CopySelection() 'Copiando o texto

            Case 61
                OBJ_MOTOR_GECKOFX_61.CopySelection() 'Copiando o texto

            Case 62
                OBJ_MOTOR_GECKOFX_62.CopySelection() 'Copiando o texto

            Case 63
                OBJ_MOTOR_GECKOFX_63.CopySelection() 'Copiando o texto

            Case 64
                OBJ_MOTOR_GECKOFX_64.CopySelection() 'Copiando o texto

            Case 65
                OBJ_MOTOR_GECKOFX_65.CopySelection() 'Copiando o texto

            Case 66
                OBJ_MOTOR_GECKOFX_66.CopySelection() 'Copiando o texto

            Case 67
                OBJ_MOTOR_GECKOFX_67.CopySelection() 'Copiando o texto

            Case 68
                OBJ_MOTOR_GECKOFX_68.CopySelection() 'Copiando o texto

            Case 69
                OBJ_MOTOR_GECKOFX_69.CopySelection() 'Copiando o texto

            Case 70
                OBJ_MOTOR_GECKOFX_70.CopySelection() 'Copiando o texto

            Case 71
                OBJ_MOTOR_GECKOFX_71.CopySelection() 'Copiando o texto

            Case 72
                OBJ_MOTOR_GECKOFX_72.CopySelection() 'Copiando o texto

            Case 73
                OBJ_MOTOR_GECKOFX_73.CopySelection() 'Copiando o texto

            Case 74
                OBJ_MOTOR_GECKOFX_74.CopySelection() 'Copiando o texto

            Case 75
                OBJ_MOTOR_GECKOFX_75.CopySelection() 'Copiando o texto

            Case 76
                OBJ_MOTOR_GECKOFX_76.CopySelection() 'Copiando o texto

            Case 77
                OBJ_MOTOR_GECKOFX_77.CopySelection() 'Copiando o texto

            Case 78
                OBJ_MOTOR_GECKOFX_78.CopySelection() 'Copiando o texto

            Case 79
                OBJ_MOTOR_GECKOFX_79.CopySelection() 'Copiando o texto

            Case 80
                OBJ_MOTOR_GECKOFX_80.CopySelection() 'Copiando o texto

            Case 81
                OBJ_MOTOR_GECKOFX_81.CopySelection() 'Copiando o texto

            Case 82
                OBJ_MOTOR_GECKOFX_82.CopySelection() 'Copiando o texto

            Case 83
                OBJ_MOTOR_GECKOFX_83.CopySelection() 'Copiando o texto

            Case 84
                OBJ_MOTOR_GECKOFX_84.CopySelection() 'Copiando o texto

            Case 85
                OBJ_MOTOR_GECKOFX_85.CopySelection() 'Copiando o texto

            Case 86
                OBJ_MOTOR_GECKOFX_86.CopySelection() 'Copiando o texto

            Case 87
                OBJ_MOTOR_GECKOFX_87.CopySelection() 'Copiando o texto

            Case 88
                OBJ_MOTOR_GECKOFX_88.CopySelection() 'Copiando o texto

            Case 89
                OBJ_MOTOR_GECKOFX_89.CopySelection() 'Copiando o texto

            Case 90
                OBJ_MOTOR_GECKOFX_90.CopySelection() 'Copiando o texto

            Case 91
                OBJ_MOTOR_GECKOFX_91.CopySelection() 'Copiando o texto

            Case 92
                OBJ_MOTOR_GECKOFX_92.CopySelection() 'Copiando o texto

            Case 93
                OBJ_MOTOR_GECKOFX_93.CopySelection() 'Copiando o texto

            Case 94
                OBJ_MOTOR_GECKOFX_94.CopySelection() 'Copiando o texto

            Case 95
                OBJ_MOTOR_GECKOFX_95.CopySelection() 'Copiando o texto

            Case 96
                OBJ_MOTOR_GECKOFX_96.CopySelection() 'Copiando o texto

            Case 97
                OBJ_MOTOR_GECKOFX_97.CopySelection() 'Copiando o texto

            Case 98
                OBJ_MOTOR_GECKOFX_98.CopySelection() 'Copiando o texto

            Case 99
                OBJ_MOTOR_GECKOFX_99.CopySelection() 'Copiando o texto

            Case 100
                OBJ_MOTOR_GECKOFX_100.CopySelection() 'Copiando o texto

            Case 101
                OBJ_MOTOR_GECKOFX_101.CopySelection() 'Copiando o texto

            Case 102
                OBJ_MOTOR_GECKOFX_102.CopySelection() 'Copiando o texto

            Case 103
                OBJ_MOTOR_GECKOFX_103.CopySelection() 'Copiando o texto

            Case 104
                OBJ_MOTOR_GECKOFX_104.CopySelection() 'Copiando o texto

            Case 105
                OBJ_MOTOR_GECKOFX_105.CopySelection() 'Copiando o texto

            Case 106
                OBJ_MOTOR_GECKOFX_106.CopySelection() 'Copiando o texto

            Case 107
                OBJ_MOTOR_GECKOFX_107.CopySelection() 'Copiando o texto

            Case 108
                OBJ_MOTOR_GECKOFX_108.CopySelection() 'Copiando o texto

            Case 109
                OBJ_MOTOR_GECKOFX_109.CopySelection() 'Copiando o texto

            Case 110
                OBJ_MOTOR_GECKOFX_110.CopySelection() 'Copiando o texto

            Case 111
                OBJ_MOTOR_GECKOFX_111.CopySelection() 'Copiando o texto

            Case 112
                OBJ_MOTOR_GECKOFX_112.CopySelection() 'Copiando o texto

            Case 113
                OBJ_MOTOR_GECKOFX_113.CopySelection() 'Copiando o texto

            Case 114
                OBJ_MOTOR_GECKOFX_114.CopySelection() 'Copiando o texto

            Case 115
                OBJ_MOTOR_GECKOFX_115.CopySelection() 'Copiando o texto

            Case 116
                OBJ_MOTOR_GECKOFX_116.CopySelection() 'Copiando o texto

            Case 117
                OBJ_MOTOR_GECKOFX_117.CopySelection() 'Copiando o texto

            Case 118
                OBJ_MOTOR_GECKOFX_118.CopySelection() 'Copiando o texto

            Case 119
                OBJ_MOTOR_GECKOFX_119.CopySelection() 'Copiando o texto

            Case 120
                OBJ_MOTOR_GECKOFX_120.CopySelection() 'Copiando o texto

            Case 121
                OBJ_MOTOR_GECKOFX_121.CopySelection() 'Copiando o texto

            Case 122
                OBJ_MOTOR_GECKOFX_122.CopySelection() 'Copiando o texto

            Case 123
                OBJ_MOTOR_GECKOFX_123.CopySelection() 'Copiando o texto

            Case 124
                OBJ_MOTOR_GECKOFX_124.CopySelection() 'Copiando o texto

            Case 125
                OBJ_MOTOR_GECKOFX_125.CopySelection() 'Copiando o texto

            Case 126
                OBJ_MOTOR_GECKOFX_126.CopySelection() 'Copiando o texto

            Case 127
                OBJ_MOTOR_GECKOFX_127.CopySelection() 'Copiando o texto

            Case 128
                OBJ_MOTOR_GECKOFX_128.CopySelection() 'Copiando o texto

        End Select

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo o conteudo da ram -----------------------------------------------------

        v_texto_a_ser_lido = My.Computer.Clipboard.GetText 'Obtendo o texto...

        '-------------------------------------------------------------------------------




        'Verifica se há conteudo a ser lido ----------------------------------------------------------------------------

        If (v_texto_a_ser_lido = Nothing) And (v_resposta_da_funcao = False) Then


            MsgBox(V_MS_32, MsgBoxStyle.Exclamation, "Alerta ao usúario") 'Mensagem

            Exit Sub 'Saindo...


        End If

        '---------------------------------------------------------------------------------------------------------------




        'Informando que esta usando a caixa de entrada e saida de texto ------------------------------------------------

        V_USANDO_CAIXA_DE_ENTRADA_E_SAIDA_DE_TEXTO = True 'Informa que esta usando a caixa de entrada e saida de texto

        '---------------------------------------------------------------------------------------------------------------




        'Lendo o texto agora -------------------------------------------------------------------------------------------

        proc_falar_texto_repassado_recurso_de_voz(v_texto_a_ser_lido) 'Procedimento para leitura de texto repassado pelo usuário

        '---------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function func_obter_o_ip_local() 'Retorna o ip da maquina local
        On Error Resume Next

        Dim myHost As String = System.Net.Dns.GetHostName

        Dim myIPs As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(My.Computer.Name)

        Dim V_IP As String = Nothing 'Ip obtido






        'Varrendo ------------------------------------------------------------------------------------------------------

        For Each myIP As System.Net.IPAddress In myIPs.AddressList


            'Obtendo ip -------------------------------------------------------------

            V_IP = myIP.ToString 'Endereço ip

            '------------------------------------------------------------------------


        Next

        '---------------------------------------------------------------------------------------------------------------




        'Retorna o ip local -----------------------------------------------------

        If (V_IP <> Nothing) Then


            Return V_IP 'Retorno...


        Else


            V_IP = "Não obtido!" 'Retorno...


        End If

        '------------------------------------------------------------------------


    End Function

    Public Sub proc_informe_o_ip_local() 'Informa o ip local do computador
        On Error Resume Next

        Dim V_IP As String = V_MS_35 & func_obter_o_ip_local() 'Retorna o ip da maquina local







        'Informando o ip ao usuario ------------------------------------------------------------------------------------

        proc_chamar_mensagem_ao_usuario(V_IP, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function func_retorne_o_ip_do_site_em_visualizacao(ByVal v_end_do_site As String) 'Retorna o ip do site em visualização.
        On Error Resume Next

        Dim myHost As String = System.Net.Dns.GetHostName

        Dim myIPs As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(v_end_do_site)

        Dim V_IP As String = Nothing 'Ip obtido






        'Varrendo ------------------------------------------------------------------------------------------------------

        For Each myIP As System.Net.IPAddress In myIPs.AddressList


            'Obtendo ip ---------------------------------------------------

            V_IP = myIP.ToString 'Endereço ip

            '--------------------------------------------------------------


        Next

        '---------------------------------------------------------------------------------------------------------------




        'Retorna o ip local -----------------------------------------------------

        If (V_IP <> Nothing) Then


            Return V_IP 'Retorno...


        Else


            V_IP = "Não obtido!" 'Retorno...


        End If

        '------------------------------------------------------------------------


    End Function

    Public Sub proc_informe_o_ip_do_site_em_visualizacao(ByVal v_end_do_site As String) 'Informa o endereço ip do site em visualização.
        On Error Resume Next

        Dim V_IP As String = func_retorne_o_ip_do_site_em_visualizacao(v_end_do_site) 'Retorna o ip do site em visualização.

        Dim V_MENSAGEM As String = "O endereço ip do site: " & v_end_do_site & " é " & V_IP & "." 'Mensagem






        'Informando o ip ao usuario ------------------------------------------------------------------------------------

        proc_chamar_mensagem_ao_usuario(V_MENSAGEM, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_tirar_foto_do_site_em_visualizacao() 'Obtem a imagem do site em visualizacao
        On Error Resume Next

        Dim OBJ_IMAGEM As Image 'Objeto de imagem

        Dim DLG_SALVAR As New SaveFileDialog 'Diálogo salvar






        'Obtendo a imagem ---------------------------------------------------------------------------------------------------

        OBJ_IMAGEM = func_gerar_imagem_completa_site_visualizacao_geckofx() 'Gera a imagem completa do site em visualização

        '--------------------------------------------------------------------------------------------------------------------




        'Definindo propriedades basicas --------------------------------------------------------------------------------

        DLG_SALVAR.FileName = FRM_NAVEGACAO.Text  'Titulo da página

        DLG_SALVAR.Filter = "Tipo de imagem(*" & v_extencao_2 & ")|*" & v_extencao_2 'Extenção do arquivo

        '---------------------------------------------------------------------------------------------------------------




        'Verifica a janela de salvar página e depois qual motor salvar a pagina --------------------------------------------------------------------------------------

        If (DLG_SALVAR.ShowDialog = DialogResult.OK) Then


            OBJ_IMAGEM.Save(DLG_SALVAR.FileName & v_extencao_2) 'Salvando a imagem


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub


























End Module
