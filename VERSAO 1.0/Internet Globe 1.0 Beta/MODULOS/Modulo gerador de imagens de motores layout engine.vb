Module Modulo_gerador_de_imagens_de_motores_layout_engine



    'Geradores de imagens

    '# GERA IMAGEM DE SITE COMPLETO

    Public V_TAMANHO_DO_MOTOR_ATUALMENTE As New Size 'Informa o tamanho do motor layout engine

    Public V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO As New Size 'Informa o tamanho da pagina em visualização









    'Procedimentos basicos de manipulação de imagem

    Private Sub proc_calcular_tamanho_do_motor_e_da_pagina() 'Calcula o tamanho do motor layout engine e da pagina original
        On Error Resume Next


        'Selecionando motor geckofx e gerando imagem ---------------------------------------------------------------------------------------------------------------------------------------------------------------

        Select Case v_qual_motor_esta_em_uso

            Case 1
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_1.Width, OBJ_MOTOR_GECKOFX_1.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_1.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_1.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 2
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_2.Width, OBJ_MOTOR_GECKOFX_2.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_2.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_2.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 3
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_3.Width, OBJ_MOTOR_GECKOFX_3.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_3.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_3.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 4
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_4.Width, OBJ_MOTOR_GECKOFX_4.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_4.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_4.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 5
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_5.Width, OBJ_MOTOR_GECKOFX_5.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_5.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_5.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 6
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_6.Width, OBJ_MOTOR_GECKOFX_6.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_6.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_6.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 7
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_7.Width, OBJ_MOTOR_GECKOFX_7.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_7.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_7.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 8
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_8.Width, OBJ_MOTOR_GECKOFX_8.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_8.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_8.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 9
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_9.Width, OBJ_MOTOR_GECKOFX_9.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_9.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_9.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 10
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_10.Width, OBJ_MOTOR_GECKOFX_10.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_10.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_10.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 11
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_11.Width, OBJ_MOTOR_GECKOFX_11.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_11.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_11.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 12
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_12.Width, OBJ_MOTOR_GECKOFX_12.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_12.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_12.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 13
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_13.Width, OBJ_MOTOR_GECKOFX_13.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_13.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_13.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 14
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_14.Width, OBJ_MOTOR_GECKOFX_14.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_14.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_14.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 15
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_15.Width, OBJ_MOTOR_GECKOFX_15.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_15.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_15.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 16
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_16.Width, OBJ_MOTOR_GECKOFX_16.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_16.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_16.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 17
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_17.Width, OBJ_MOTOR_GECKOFX_17.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_17.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_17.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 18
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_18.Width, OBJ_MOTOR_GECKOFX_18.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_18.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_18.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 19
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_19.Width, OBJ_MOTOR_GECKOFX_19.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_19.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_19.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 20
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_20.Width, OBJ_MOTOR_GECKOFX_20.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_20.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_20.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 21
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_21.Width, OBJ_MOTOR_GECKOFX_21.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_21.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_21.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 22
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_22.Width, OBJ_MOTOR_GECKOFX_22.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_22.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_22.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 23
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_23.Width, OBJ_MOTOR_GECKOFX_23.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_23.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_23.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 24
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_24.Width, OBJ_MOTOR_GECKOFX_24.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_24.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_24.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 25
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_25.Width, OBJ_MOTOR_GECKOFX_25.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_25.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_25.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 26
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_26.Width, OBJ_MOTOR_GECKOFX_26.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_26.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_26.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 27
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_27.Width, OBJ_MOTOR_GECKOFX_27.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_27.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_27.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 28
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_28.Width, OBJ_MOTOR_GECKOFX_28.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_28.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_28.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 29
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_29.Width, OBJ_MOTOR_GECKOFX_29.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_29.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_29.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 30
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_30.Width, OBJ_MOTOR_GECKOFX_30.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_30.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_30.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 31
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_31.Width, OBJ_MOTOR_GECKOFX_31.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_31.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_31.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 32
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_32.Width, OBJ_MOTOR_GECKOFX_32.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_32.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_32.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 33
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_33.Width, OBJ_MOTOR_GECKOFX_33.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_33.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_33.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 34
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_34.Width, OBJ_MOTOR_GECKOFX_34.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_34.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_34.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 35
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_35.Width, OBJ_MOTOR_GECKOFX_35.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_35.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_35.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 36
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_36.Width, OBJ_MOTOR_GECKOFX_36.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_36.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_36.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 37
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_37.Width, OBJ_MOTOR_GECKOFX_37.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_37.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_37.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 38
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_38.Width, OBJ_MOTOR_GECKOFX_38.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_38.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_38.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 39
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_39.Width, OBJ_MOTOR_GECKOFX_39.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_39.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_39.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 40
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_40.Width, OBJ_MOTOR_GECKOFX_40.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_40.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_40.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 41
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_41.Width, OBJ_MOTOR_GECKOFX_41.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_41.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_41.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 42
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_42.Width, OBJ_MOTOR_GECKOFX_42.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_42.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_42.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 43
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_43.Width, OBJ_MOTOR_GECKOFX_43.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_43.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_43.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 44
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_44.Width, OBJ_MOTOR_GECKOFX_44.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_44.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_44.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 45
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_45.Width, OBJ_MOTOR_GECKOFX_45.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_45.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_45.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 46
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_46.Width, OBJ_MOTOR_GECKOFX_46.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_46.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_46.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 47
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_47.Width, OBJ_MOTOR_GECKOFX_47.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_47.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_47.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 48
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_48.Width, OBJ_MOTOR_GECKOFX_48.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_48.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_48.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 49
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_49.Width, OBJ_MOTOR_GECKOFX_49.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_49.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_49.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 50
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_50.Width, OBJ_MOTOR_GECKOFX_50.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_50.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_50.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 51
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_51.Width, OBJ_MOTOR_GECKOFX_51.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_51.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_51.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 52
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_52.Width, OBJ_MOTOR_GECKOFX_52.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_52.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_52.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 53
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_53.Width, OBJ_MOTOR_GECKOFX_53.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_53.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_53.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 54
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_54.Width, OBJ_MOTOR_GECKOFX_54.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_54.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_54.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 55
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_55.Width, OBJ_MOTOR_GECKOFX_55.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_55.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_55.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 56
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_56.Width, OBJ_MOTOR_GECKOFX_56.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_56.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_56.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 57
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_57.Width, OBJ_MOTOR_GECKOFX_57.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_57.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_57.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 58
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_58.Width, OBJ_MOTOR_GECKOFX_58.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_58.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_58.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 59
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_59.Width, OBJ_MOTOR_GECKOFX_59.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_59.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_59.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 60
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_60.Width, OBJ_MOTOR_GECKOFX_60.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_60.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_60.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 61
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_61.Width, OBJ_MOTOR_GECKOFX_61.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_61.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_61.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 62
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_62.Width, OBJ_MOTOR_GECKOFX_62.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_62.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_62.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 63
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_63.Width, OBJ_MOTOR_GECKOFX_63.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_63.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_63.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 64
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_64.Width, OBJ_MOTOR_GECKOFX_64.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_64.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_64.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 65
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_65.Width, OBJ_MOTOR_GECKOFX_65.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_65.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_65.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 66
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_66.Width, OBJ_MOTOR_GECKOFX_66.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_66.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_66.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 67
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_67.Width, OBJ_MOTOR_GECKOFX_67.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_67.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_67.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 68
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_68.Width, OBJ_MOTOR_GECKOFX_68.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_68.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_68.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 69
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_69.Width, OBJ_MOTOR_GECKOFX_69.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_69.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_69.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 70
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_70.Width, OBJ_MOTOR_GECKOFX_70.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_70.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_70.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 71
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_71.Width, OBJ_MOTOR_GECKOFX_71.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_71.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_71.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 72
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_72.Width, OBJ_MOTOR_GECKOFX_72.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_72.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_72.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 73
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_73.Width, OBJ_MOTOR_GECKOFX_73.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_73.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_73.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 74
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_74.Width, OBJ_MOTOR_GECKOFX_74.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_74.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_74.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 75
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_75.Width, OBJ_MOTOR_GECKOFX_75.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_75.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_75.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 76
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_76.Width, OBJ_MOTOR_GECKOFX_76.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_76.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_76.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 77
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_77.Width, OBJ_MOTOR_GECKOFX_77.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_77.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_77.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 78
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_78.Width, OBJ_MOTOR_GECKOFX_78.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_78.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_78.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 79
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_79.Width, OBJ_MOTOR_GECKOFX_79.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_79.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_79.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 80
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_80.Width, OBJ_MOTOR_GECKOFX_80.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_80.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_80.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 81
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_81.Width, OBJ_MOTOR_GECKOFX_81.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_81.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_81.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 82
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_82.Width, OBJ_MOTOR_GECKOFX_82.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_82.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_82.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 83
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_83.Width, OBJ_MOTOR_GECKOFX_83.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_83.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_83.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 84
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_84.Width, OBJ_MOTOR_GECKOFX_84.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_84.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_84.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 85
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_85.Width, OBJ_MOTOR_GECKOFX_85.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_85.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_85.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 86
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_86.Width, OBJ_MOTOR_GECKOFX_86.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_86.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_86.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 87
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_87.Width, OBJ_MOTOR_GECKOFX_87.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_87.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_87.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 88
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_88.Width, OBJ_MOTOR_GECKOFX_88.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_88.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_88.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 89
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_89.Width, OBJ_MOTOR_GECKOFX_89.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_89.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_89.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 90
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_90.Width, OBJ_MOTOR_GECKOFX_90.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_90.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_90.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 91
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_91.Width, OBJ_MOTOR_GECKOFX_91.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_91.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_91.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 92
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_92.Width, OBJ_MOTOR_GECKOFX_92.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_92.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_92.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 93
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_93.Width, OBJ_MOTOR_GECKOFX_93.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_93.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_93.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 94
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_94.Width, OBJ_MOTOR_GECKOFX_94.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_94.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_94.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 95
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_95.Width, OBJ_MOTOR_GECKOFX_95.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_95.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_95.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 96
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_96.Width, OBJ_MOTOR_GECKOFX_96.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_96.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_96.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 97
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_97.Width, OBJ_MOTOR_GECKOFX_97.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_97.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_97.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 98
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_98.Width, OBJ_MOTOR_GECKOFX_98.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_98.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_98.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 99
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_99.Width, OBJ_MOTOR_GECKOFX_99.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_99.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_99.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 100
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_100.Width, OBJ_MOTOR_GECKOFX_100.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_100.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_100.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 101
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_101.Width, OBJ_MOTOR_GECKOFX_101.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_101.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_101.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 102
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_102.Width, OBJ_MOTOR_GECKOFX_102.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_102.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_102.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 103
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_103.Width, OBJ_MOTOR_GECKOFX_103.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_103.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_103.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 104
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_104.Width, OBJ_MOTOR_GECKOFX_104.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_104.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_104.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 105
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_105.Width, OBJ_MOTOR_GECKOFX_105.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_105.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_105.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 106
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_106.Width, OBJ_MOTOR_GECKOFX_106.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_106.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_106.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 107
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_107.Width, OBJ_MOTOR_GECKOFX_107.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_107.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_107.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 108
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_108.Width, OBJ_MOTOR_GECKOFX_108.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_108.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_108.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 109
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_109.Width, OBJ_MOTOR_GECKOFX_109.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_109.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_109.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 110
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_110.Width, OBJ_MOTOR_GECKOFX_110.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_110.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_110.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 111
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_111.Width, OBJ_MOTOR_GECKOFX_111.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_111.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_111.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 112
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_112.Width, OBJ_MOTOR_GECKOFX_112.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_112.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_112.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 113
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_113.Width, OBJ_MOTOR_GECKOFX_113.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_113.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_113.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 114
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_114.Width, OBJ_MOTOR_GECKOFX_114.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_114.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_114.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 115
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_115.Width, OBJ_MOTOR_GECKOFX_115.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_115.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_115.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 116
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_116.Width, OBJ_MOTOR_GECKOFX_116.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_116.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_116.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 117
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_117.Width, OBJ_MOTOR_GECKOFX_117.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_117.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_117.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 118
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_118.Width, OBJ_MOTOR_GECKOFX_118.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_118.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_118.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 119
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_119.Width, OBJ_MOTOR_GECKOFX_119.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_119.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_119.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 120
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_120.Width, OBJ_MOTOR_GECKOFX_120.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_120.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_120.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 121
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_121.Width, OBJ_MOTOR_GECKOFX_121.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_121.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_121.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 122
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_122.Width, OBJ_MOTOR_GECKOFX_122.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_122.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_122.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 123
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_123.Width, OBJ_MOTOR_GECKOFX_123.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_123.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_123.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 124
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_124.Width, OBJ_MOTOR_GECKOFX_124.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_124.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_124.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 125
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_125.Width, OBJ_MOTOR_GECKOFX_125.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_125.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_125.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 126
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_126.Width, OBJ_MOTOR_GECKOFX_126.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_126.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_126.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 127
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_127.Width, OBJ_MOTOR_GECKOFX_127.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_127.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_127.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            Case 128
                V_TAMANHO_DO_MOTOR_ATUALMENTE = New Size(OBJ_MOTOR_GECKOFX_128.Width, OBJ_MOTOR_GECKOFX_128.Height) 'Tamanho original
                V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = New Size(OBJ_MOTOR_GECKOFX_128.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_128.Document.Body.ClientHeight) 'Tamanho da pagina
                Exit Select

            



        End Select

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_motor_tamanho_da_pagina() 'Coloca o motor do tamanho da pagina em visualização
        On Error Resume Next


        'Selecionando motor geckofx e gerando imagem ---------------------------------------------------------------------------------------------------------------------------------------------------------------

        Select Case v_qual_motor_esta_em_uso

            Case 1
                OBJ_MOTOR_GECKOFX_1.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_1.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 2
                OBJ_MOTOR_GECKOFX_2.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_2.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 3
                OBJ_MOTOR_GECKOFX_3.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_3.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 4
                OBJ_MOTOR_GECKOFX_4.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_4.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 5
                OBJ_MOTOR_GECKOFX_5.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_5.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 6
                OBJ_MOTOR_GECKOFX_6.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_6.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 7
                OBJ_MOTOR_GECKOFX_7.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_7.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 8
                OBJ_MOTOR_GECKOFX_8.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_8.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 9
                OBJ_MOTOR_GECKOFX_9.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_9.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 10
                OBJ_MOTOR_GECKOFX_10.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_10.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 11
                OBJ_MOTOR_GECKOFX_11.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_11.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 12
                OBJ_MOTOR_GECKOFX_12.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_12.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 13
                OBJ_MOTOR_GECKOFX_13.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_13.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 14
                OBJ_MOTOR_GECKOFX_14.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_14.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 15
                OBJ_MOTOR_GECKOFX_15.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_15.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 16
                OBJ_MOTOR_GECKOFX_16.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_16.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 17
                OBJ_MOTOR_GECKOFX_17.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_17.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 18
                OBJ_MOTOR_GECKOFX_18.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_18.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 19
                OBJ_MOTOR_GECKOFX_19.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_19.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 20
                OBJ_MOTOR_GECKOFX_20.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_20.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 21
                OBJ_MOTOR_GECKOFX_21.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_21.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 22
                OBJ_MOTOR_GECKOFX_22.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_22.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 23
                OBJ_MOTOR_GECKOFX_23.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_23.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 24
                OBJ_MOTOR_GECKOFX_24.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_24.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 25
                OBJ_MOTOR_GECKOFX_25.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_25.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 26
                OBJ_MOTOR_GECKOFX_26.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_26.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 27
                OBJ_MOTOR_GECKOFX_27.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_27.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 28
                OBJ_MOTOR_GECKOFX_28.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_28.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 29
                OBJ_MOTOR_GECKOFX_29.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_29.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 30
                OBJ_MOTOR_GECKOFX_30.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_30.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 31
                OBJ_MOTOR_GECKOFX_31.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_31.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 32
                OBJ_MOTOR_GECKOFX_32.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_32.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 33
                OBJ_MOTOR_GECKOFX_33.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_33.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 34
                OBJ_MOTOR_GECKOFX_34.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_34.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 35
                OBJ_MOTOR_GECKOFX_35.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_35.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 36
                OBJ_MOTOR_GECKOFX_36.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_36.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 37
                OBJ_MOTOR_GECKOFX_37.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_37.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 38
                OBJ_MOTOR_GECKOFX_38.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_38.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 39
                OBJ_MOTOR_GECKOFX_39.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_39.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 40
                OBJ_MOTOR_GECKOFX_40.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_40.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 41
                OBJ_MOTOR_GECKOFX_41.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_41.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 42
                OBJ_MOTOR_GECKOFX_42.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_42.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 43
                OBJ_MOTOR_GECKOFX_43.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_43.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 44
                OBJ_MOTOR_GECKOFX_44.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_44.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 45
                OBJ_MOTOR_GECKOFX_45.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_45.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 46
                OBJ_MOTOR_GECKOFX_46.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_46.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 47
                OBJ_MOTOR_GECKOFX_47.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_47.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 48
                OBJ_MOTOR_GECKOFX_48.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_48.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 49
                OBJ_MOTOR_GECKOFX_49.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_49.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 50
                OBJ_MOTOR_GECKOFX_50.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_50.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 51
                OBJ_MOTOR_GECKOFX_51.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_51.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 52
                OBJ_MOTOR_GECKOFX_52.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_52.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 53
                OBJ_MOTOR_GECKOFX_53.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_53.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 54
                OBJ_MOTOR_GECKOFX_54.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_54.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 55
                OBJ_MOTOR_GECKOFX_55.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_55.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 56
                OBJ_MOTOR_GECKOFX_56.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_56.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 57
                OBJ_MOTOR_GECKOFX_57.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_57.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 58
                OBJ_MOTOR_GECKOFX_58.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_58.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 59
                OBJ_MOTOR_GECKOFX_59.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_59.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 60
                OBJ_MOTOR_GECKOFX_60.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_60.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 61
                OBJ_MOTOR_GECKOFX_61.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_61.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 62
                OBJ_MOTOR_GECKOFX_62.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_62.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 63
                OBJ_MOTOR_GECKOFX_63.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_63.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 64
                OBJ_MOTOR_GECKOFX_64.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_64.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 65
                OBJ_MOTOR_GECKOFX_65.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_65.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 66
                OBJ_MOTOR_GECKOFX_66.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_66.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 67
                OBJ_MOTOR_GECKOFX_67.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_67.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 68
                OBJ_MOTOR_GECKOFX_68.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_68.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 69
                OBJ_MOTOR_GECKOFX_69.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_69.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 70
                OBJ_MOTOR_GECKOFX_70.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_70.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 71
                OBJ_MOTOR_GECKOFX_71.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_71.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 72
                OBJ_MOTOR_GECKOFX_72.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_72.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 73
                OBJ_MOTOR_GECKOFX_73.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_73.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 74
                OBJ_MOTOR_GECKOFX_74.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_74.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 75
                OBJ_MOTOR_GECKOFX_75.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_75.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 76
                OBJ_MOTOR_GECKOFX_76.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_76.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 77
                OBJ_MOTOR_GECKOFX_77.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_77.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 78
                OBJ_MOTOR_GECKOFX_78.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_78.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 79
                OBJ_MOTOR_GECKOFX_79.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_79.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 80
                OBJ_MOTOR_GECKOFX_80.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_80.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 81
                OBJ_MOTOR_GECKOFX_81.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_81.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 82
                OBJ_MOTOR_GECKOFX_82.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_82.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 83
                OBJ_MOTOR_GECKOFX_83.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_83.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 84
                OBJ_MOTOR_GECKOFX_84.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_84.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 85
                OBJ_MOTOR_GECKOFX_85.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_85.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 86
                OBJ_MOTOR_GECKOFX_86.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_86.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 87
                OBJ_MOTOR_GECKOFX_87.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_87.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 88
                OBJ_MOTOR_GECKOFX_88.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_88.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 89
                OBJ_MOTOR_GECKOFX_89.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_89.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 90
                OBJ_MOTOR_GECKOFX_90.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_90.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 91
                OBJ_MOTOR_GECKOFX_91.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_91.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 92
                OBJ_MOTOR_GECKOFX_92.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_92.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 93
                OBJ_MOTOR_GECKOFX_93.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_93.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 94
                OBJ_MOTOR_GECKOFX_94.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_94.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 95
                OBJ_MOTOR_GECKOFX_95.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_95.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 96
                OBJ_MOTOR_GECKOFX_96.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_96.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 97
                OBJ_MOTOR_GECKOFX_97.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_97.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 98
                OBJ_MOTOR_GECKOFX_98.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_98.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 99
                OBJ_MOTOR_GECKOFX_99.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_99.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 100
                OBJ_MOTOR_GECKOFX_100.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_100.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 101
                OBJ_MOTOR_GECKOFX_101.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_101.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 102
                OBJ_MOTOR_GECKOFX_102.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_102.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 103
                OBJ_MOTOR_GECKOFX_103.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_103.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 104
                OBJ_MOTOR_GECKOFX_104.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_104.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 105
                OBJ_MOTOR_GECKOFX_105.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_105.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 106
                OBJ_MOTOR_GECKOFX_106.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_106.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 107
                OBJ_MOTOR_GECKOFX_107.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_107.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 108
                OBJ_MOTOR_GECKOFX_108.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_108.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 109
                OBJ_MOTOR_GECKOFX_109.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_109.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 110
                OBJ_MOTOR_GECKOFX_110.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_110.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 111
                OBJ_MOTOR_GECKOFX_111.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_111.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 112
                OBJ_MOTOR_GECKOFX_112.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_112.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 113
                OBJ_MOTOR_GECKOFX_113.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_113.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 114
                OBJ_MOTOR_GECKOFX_114.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_114.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 115
                OBJ_MOTOR_GECKOFX_115.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_115.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 116
                OBJ_MOTOR_GECKOFX_116.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_116.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 117
                OBJ_MOTOR_GECKOFX_117.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_117.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 118
                OBJ_MOTOR_GECKOFX_118.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_118.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 119
                OBJ_MOTOR_GECKOFX_119.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_119.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 120
                OBJ_MOTOR_GECKOFX_120.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_120.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 121
                OBJ_MOTOR_GECKOFX_121.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_121.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 122
                OBJ_MOTOR_GECKOFX_122.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_122.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 123
                OBJ_MOTOR_GECKOFX_123.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_123.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 124
                OBJ_MOTOR_GECKOFX_124.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_124.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 125
                OBJ_MOTOR_GECKOFX_125.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_125.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 126
                OBJ_MOTOR_GECKOFX_126.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_126.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 127
                OBJ_MOTOR_GECKOFX_127.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_127.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            Case 128
                OBJ_MOTOR_GECKOFX_128.Dock = DockStyle.None 'Nao ocupar a tela toda
                OBJ_MOTOR_GECKOFX_128.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho do site
                Exit Select

            



        End Select

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_motor_tamanho_original() 'Atualiza o motor para o tamanho original
        On Error Resume Next


        'Selecionando motor geckofx e gerando imagem ---------------------------------------------------------------------------------------------------------------------------------------------------------------

        Select Case v_qual_motor_esta_em_uso

            Case 1
                OBJ_MOTOR_GECKOFX_1.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_1.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 2
                OBJ_MOTOR_GECKOFX_2.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_2.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 3
                OBJ_MOTOR_GECKOFX_3.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_3.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 4
                OBJ_MOTOR_GECKOFX_4.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_4.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 5
                OBJ_MOTOR_GECKOFX_5.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_5.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 6
                OBJ_MOTOR_GECKOFX_6.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_6.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 7
                OBJ_MOTOR_GECKOFX_7.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_7.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 8
                OBJ_MOTOR_GECKOFX_8.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_8.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 9
                OBJ_MOTOR_GECKOFX_9.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_9.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 10
                OBJ_MOTOR_GECKOFX_10.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_10.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 11
                OBJ_MOTOR_GECKOFX_11.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_11.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 12
                OBJ_MOTOR_GECKOFX_12.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_12.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 13
                OBJ_MOTOR_GECKOFX_13.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_13.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 14
                OBJ_MOTOR_GECKOFX_14.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_14.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 15
                OBJ_MOTOR_GECKOFX_15.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_15.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 16
                OBJ_MOTOR_GECKOFX_16.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_16.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 17
                OBJ_MOTOR_GECKOFX_17.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_17.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 18
                OBJ_MOTOR_GECKOFX_18.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_18.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 19
                OBJ_MOTOR_GECKOFX_19.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_19.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 20
                OBJ_MOTOR_GECKOFX_20.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_20.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 21
                OBJ_MOTOR_GECKOFX_21.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_21.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 22
                OBJ_MOTOR_GECKOFX_22.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_22.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 23
                OBJ_MOTOR_GECKOFX_23.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_23.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 24
                OBJ_MOTOR_GECKOFX_24.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_24.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 25
                OBJ_MOTOR_GECKOFX_25.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_25.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 26
                OBJ_MOTOR_GECKOFX_26.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_26.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 27
                OBJ_MOTOR_GECKOFX_27.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_27.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 28
                OBJ_MOTOR_GECKOFX_28.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_28.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 29
                OBJ_MOTOR_GECKOFX_29.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_29.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 30
                OBJ_MOTOR_GECKOFX_30.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_30.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 31
                OBJ_MOTOR_GECKOFX_31.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_31.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 32
                OBJ_MOTOR_GECKOFX_32.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_32.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 33
                OBJ_MOTOR_GECKOFX_33.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_33.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 34
                OBJ_MOTOR_GECKOFX_34.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_34.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 35
                OBJ_MOTOR_GECKOFX_35.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_35.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 36
                OBJ_MOTOR_GECKOFX_36.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_36.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 37
                OBJ_MOTOR_GECKOFX_37.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_37.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 38
                OBJ_MOTOR_GECKOFX_38.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_38.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 39
                OBJ_MOTOR_GECKOFX_39.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_39.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 40
                OBJ_MOTOR_GECKOFX_40.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_40.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 41
                OBJ_MOTOR_GECKOFX_41.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_41.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 42
                OBJ_MOTOR_GECKOFX_42.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_42.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 43
                OBJ_MOTOR_GECKOFX_43.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_43.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 44
                OBJ_MOTOR_GECKOFX_44.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_44.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 45
                OBJ_MOTOR_GECKOFX_45.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_45.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 46
                OBJ_MOTOR_GECKOFX_46.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_46.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 47
                OBJ_MOTOR_GECKOFX_47.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_47.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 48
                OBJ_MOTOR_GECKOFX_48.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_48.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 49
                OBJ_MOTOR_GECKOFX_49.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_49.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 50
                OBJ_MOTOR_GECKOFX_50.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_50.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 51
                OBJ_MOTOR_GECKOFX_51.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_51.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 52
                OBJ_MOTOR_GECKOFX_52.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_52.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 53
                OBJ_MOTOR_GECKOFX_53.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_53.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 54
                OBJ_MOTOR_GECKOFX_54.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_54.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 55
                OBJ_MOTOR_GECKOFX_55.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_55.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 56
                OBJ_MOTOR_GECKOFX_56.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_56.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 57
                OBJ_MOTOR_GECKOFX_57.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_57.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 58
                OBJ_MOTOR_GECKOFX_58.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_58.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 59
                OBJ_MOTOR_GECKOFX_59.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_59.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 60
                OBJ_MOTOR_GECKOFX_60.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_60.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 61
                OBJ_MOTOR_GECKOFX_61.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_61.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 62
                OBJ_MOTOR_GECKOFX_62.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_62.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 63
                OBJ_MOTOR_GECKOFX_63.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_63.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 64
                OBJ_MOTOR_GECKOFX_64.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_64.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 65
                OBJ_MOTOR_GECKOFX_65.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_65.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 66
                OBJ_MOTOR_GECKOFX_66.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_66.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 67
                OBJ_MOTOR_GECKOFX_67.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_67.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 68
                OBJ_MOTOR_GECKOFX_68.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_68.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 69
                OBJ_MOTOR_GECKOFX_69.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_69.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 70
                OBJ_MOTOR_GECKOFX_70.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_70.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 71
                OBJ_MOTOR_GECKOFX_71.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_71.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 72
                OBJ_MOTOR_GECKOFX_72.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_72.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 73
                OBJ_MOTOR_GECKOFX_73.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_73.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 74
                OBJ_MOTOR_GECKOFX_74.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_74.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 75
                OBJ_MOTOR_GECKOFX_75.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_75.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 76
                OBJ_MOTOR_GECKOFX_76.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_76.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 77
                OBJ_MOTOR_GECKOFX_77.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_77.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 78
                OBJ_MOTOR_GECKOFX_78.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_78.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 79
                OBJ_MOTOR_GECKOFX_79.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_79.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 80
                OBJ_MOTOR_GECKOFX_80.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_80.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 81
                OBJ_MOTOR_GECKOFX_81.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_81.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 82
                OBJ_MOTOR_GECKOFX_82.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_82.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 83
                OBJ_MOTOR_GECKOFX_83.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_83.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 84
                OBJ_MOTOR_GECKOFX_84.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_84.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 85
                OBJ_MOTOR_GECKOFX_85.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_85.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 86
                OBJ_MOTOR_GECKOFX_86.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_86.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 87
                OBJ_MOTOR_GECKOFX_87.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_87.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 88
                OBJ_MOTOR_GECKOFX_88.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_88.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 89
                OBJ_MOTOR_GECKOFX_89.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_89.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 90
                OBJ_MOTOR_GECKOFX_90.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_90.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 91
                OBJ_MOTOR_GECKOFX_91.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_91.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 92
                OBJ_MOTOR_GECKOFX_92.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_92.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 93
                OBJ_MOTOR_GECKOFX_93.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_93.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 94
                OBJ_MOTOR_GECKOFX_94.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_94.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 95
                OBJ_MOTOR_GECKOFX_95.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_95.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 96
                OBJ_MOTOR_GECKOFX_96.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_96.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 97
                OBJ_MOTOR_GECKOFX_97.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_97.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 98
                OBJ_MOTOR_GECKOFX_98.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_98.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 99
                OBJ_MOTOR_GECKOFX_99.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_99.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 100
                OBJ_MOTOR_GECKOFX_100.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_100.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 101
                OBJ_MOTOR_GECKOFX_101.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_101.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 102
                OBJ_MOTOR_GECKOFX_102.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_102.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 103
                OBJ_MOTOR_GECKOFX_103.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_103.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 104
                OBJ_MOTOR_GECKOFX_104.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_104.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 105
                OBJ_MOTOR_GECKOFX_105.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_105.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 106
                OBJ_MOTOR_GECKOFX_106.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_106.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 107
                OBJ_MOTOR_GECKOFX_107.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_107.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 108
                OBJ_MOTOR_GECKOFX_108.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_108.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 109
                OBJ_MOTOR_GECKOFX_109.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_109.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 110
                OBJ_MOTOR_GECKOFX_110.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_110.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 111
                OBJ_MOTOR_GECKOFX_111.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_111.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 112
                OBJ_MOTOR_GECKOFX_112.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_112.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 113
                OBJ_MOTOR_GECKOFX_113.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_113.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 114
                OBJ_MOTOR_GECKOFX_114.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_114.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 115
                OBJ_MOTOR_GECKOFX_115.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_115.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 116
                OBJ_MOTOR_GECKOFX_116.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_116.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 117
                OBJ_MOTOR_GECKOFX_117.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_117.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 118
                OBJ_MOTOR_GECKOFX_118.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_118.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 119
                OBJ_MOTOR_GECKOFX_119.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_119.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 120
                OBJ_MOTOR_GECKOFX_120.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_120.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 121
                OBJ_MOTOR_GECKOFX_121.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_121.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 122
                OBJ_MOTOR_GECKOFX_122.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_122.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 123
                OBJ_MOTOR_GECKOFX_123.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_123.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 124
                OBJ_MOTOR_GECKOFX_124.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_124.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 125
                OBJ_MOTOR_GECKOFX_125.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_125.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 126
                OBJ_MOTOR_GECKOFX_126.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_126.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 127
                OBJ_MOTOR_GECKOFX_127.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_127.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            Case 128
                OBJ_MOTOR_GECKOFX_128.Dock = DockStyle.Fill 'Ocupar toda a tela
                OBJ_MOTOR_GECKOFX_128.Size = New Size(V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO) 'Tamanho original do motor
                Exit Select

            



        End Select

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function func_gerar_imagem_completa_site_visualizacao_geckofx() 'Gera a imagem completa do site em visualização
        On Error Resume Next

        Dim OBJ_IMAGEM_TEMP_1 As Image = Nothing 'Ojeto imagem temporario 1






        'Calcula tamanho da pagina e coloca o motor do tamanho da pagina do site --------------------------------------------------------------

        proc_calcular_tamanho_do_motor_e_da_pagina() 'Calcula o tamanho do motor layout engine e da pagina original

        proc_motor_tamanho_da_pagina() 'Coloca o motor do tamanho da pagina em visualização

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Selecionando motor geckofx e gerando imagem ---------------------------------------------------------------------------------------------------------------------------------------------------------------

        Select Case v_qual_motor_esta_em_uso


            Case 1
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_1.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_1.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_1.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_1.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_1.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 2
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_2.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_2.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_2.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_2.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_2.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 3
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_3.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_3.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_3.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_3.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_3.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 4
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_4.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_4.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_4.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_4.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_4.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 5
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_5.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_5.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_5.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_5.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_5.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 6
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_6.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_6.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_6.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_6.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_6.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 7
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_7.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_7.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_7.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_7.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_7.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 8
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_8.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_8.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_8.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_8.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_8.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 9
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_9.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_9.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_9.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_9.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_9.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 10
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_10.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_10.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_10.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_10.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_10.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 11
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_11.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_11.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_11.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_11.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_11.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 12
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_12.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_12.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_12.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_12.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_12.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 13
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_13.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_13.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_13.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_13.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_13.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 14
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_14.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_14.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_14.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_14.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_14.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 15
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_15.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_15.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_15.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_15.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_15.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 16
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_16.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_16.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_16.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_16.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_16.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 17
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_17.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_17.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_17.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_17.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_17.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 18
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_18.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_18.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_18.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_18.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_18.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 19
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_19.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_19.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_19.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_19.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_19.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 20
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_20.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_20.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_20.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_20.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_20.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 21
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_21.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_21.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_21.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_21.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_21.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 22
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_22.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_22.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_22.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_22.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_22.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 23
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_23.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_23.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_23.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_23.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_23.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 24
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_24.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_24.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_24.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_24.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_24.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 25
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_25.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_25.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_25.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_25.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_25.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 26
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_26.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_26.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_26.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_26.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_26.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 27
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_27.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_27.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_27.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_27.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_27.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 28
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_28.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_28.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_28.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_28.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_28.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 29
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_29.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_29.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_29.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_29.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_29.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 30
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_30.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_30.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_30.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_30.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_30.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 31
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_31.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_31.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_31.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_31.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_31.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 32
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_32.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_32.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_32.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_32.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_32.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 33
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_33.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_33.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_33.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_33.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_33.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 34
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_34.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_34.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_34.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_34.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_34.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 35
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_35.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_35.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_35.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_35.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_35.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 36
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_36.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_36.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_36.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_36.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_36.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 37
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_37.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_37.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_37.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_37.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_37.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 38
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_38.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_38.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_38.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_38.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_38.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 39
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_39.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_39.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_39.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_39.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_39.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 40
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_40.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_40.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_40.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_40.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_40.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 41
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_41.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_41.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_41.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_41.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_41.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 42
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_42.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_42.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_42.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_42.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_42.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 43
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_43.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_43.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_43.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_43.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_43.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 44
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_44.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_44.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_44.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_44.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_44.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 45
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_45.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_45.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_45.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_45.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_45.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 46
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_46.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_46.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_46.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_46.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_46.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 47
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_47.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_47.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_47.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_47.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_47.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 48
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_48.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_48.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_48.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_48.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_48.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 49
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_49.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_49.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_49.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_49.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_49.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 50
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_50.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_50.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_50.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_50.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_50.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 51
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_51.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_51.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_51.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_51.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_51.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 52
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_52.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_52.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_52.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_52.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_52.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 53
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_53.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_53.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_53.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_53.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_53.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 54
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_54.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_54.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_54.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_54.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_54.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 55
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_55.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_55.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_55.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_55.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_55.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 56
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_56.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_56.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_56.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_56.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_56.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 57
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_57.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_57.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_57.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_57.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_57.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 58
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_58.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_58.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_58.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_58.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_58.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 59
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_59.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_59.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_59.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_59.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_59.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 60
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_60.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_60.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_60.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_60.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_60.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 61
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_61.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_61.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_61.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_61.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_61.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 62
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_62.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_62.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_62.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_62.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_62.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 63
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_63.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_63.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_63.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_63.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_63.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 64
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_64.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_64.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_64.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_64.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_64.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 65
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_65.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_65.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_65.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_65.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_65.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 66
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_66.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_66.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_66.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_66.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_66.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 67
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_67.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_67.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_67.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_67.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_67.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 68
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_68.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_68.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_68.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_68.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_68.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 69
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_69.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_69.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_69.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_69.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_69.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 70
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_70.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_70.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_70.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_70.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_70.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 71
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_71.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_71.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_71.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_71.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_71.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 72
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_72.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_72.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_72.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_72.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_72.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 73
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_73.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_73.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_73.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_73.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_73.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 74
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_74.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_74.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_74.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_74.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_74.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 75
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_75.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_75.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_75.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_75.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_75.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 76
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_76.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_76.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_76.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_76.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_76.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 77
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_77.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_77.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_77.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_77.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_77.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 78
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_78.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_78.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_78.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_78.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_78.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 79
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_79.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_79.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_79.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_79.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_79.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 80
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_80.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_80.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_80.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_80.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_80.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 81
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_81.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_81.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_81.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_81.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_81.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 82
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_82.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_82.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_82.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_82.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_82.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 83
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_83.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_83.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_83.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_83.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_83.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 84
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_84.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_84.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_84.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_84.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_84.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 85
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_85.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_85.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_85.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_85.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_85.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 86
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_86.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_86.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_86.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_86.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_86.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 87
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_87.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_87.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_87.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_87.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_87.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 88
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_88.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_88.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_88.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_88.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_88.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 89
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_89.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_89.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_89.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_89.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_89.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 90
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_90.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_90.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_90.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_90.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_90.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 91
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_91.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_91.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_91.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_91.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_91.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 92
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_92.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_92.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_92.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_92.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_92.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 93
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_93.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_93.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_93.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_93.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_93.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 94
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_94.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_94.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_94.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_94.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_94.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 95
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_95.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_95.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_95.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_95.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_95.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 96
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_96.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_96.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_96.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_96.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_96.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 97
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_97.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_97.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_97.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_97.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_97.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 98
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_98.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_98.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_98.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_98.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_98.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 99
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_99.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_99.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_99.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_99.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_99.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 100
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_100.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_100.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_100.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_100.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_100.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 101
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_101.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_101.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_101.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_101.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_101.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 102
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_102.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_102.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_102.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_102.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_102.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 103
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_103.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_103.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_103.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_103.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_103.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 104
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_104.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_104.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_104.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_104.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_104.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 105
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_105.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_105.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_105.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_105.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_105.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 106
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_106.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_106.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_106.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_106.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_106.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 107
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_107.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_107.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_107.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_107.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_107.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 108
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_108.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_108.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_108.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_108.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_108.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 109
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_109.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_109.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_109.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_109.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_109.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 110
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_110.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_110.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_110.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_110.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_110.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 111
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_111.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_111.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_111.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_111.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_111.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 112
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_112.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_112.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_112.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_112.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_112.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 113
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_113.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_113.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_113.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_113.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_113.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 114
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_114.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_114.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_114.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_114.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_114.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 115
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_115.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_115.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_115.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_115.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_115.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 116
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_116.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_116.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_116.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_116.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_116.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 117
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_117.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_117.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_117.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_117.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_117.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 118
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_118.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_118.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_118.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_118.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_118.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 119
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_119.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_119.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_119.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_119.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_119.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 120
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_120.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_120.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_120.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_120.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_120.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 121
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_121.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_121.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_121.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_121.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_121.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 122
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_122.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_122.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_122.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_122.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_122.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 123
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_123.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_123.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_123.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_123.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_123.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 124
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_124.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_124.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_124.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_124.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_124.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 125
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_125.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_125.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_125.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_125.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_125.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 126
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_126.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_126.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_126.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_126.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_126.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 127
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_127.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_127.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_127.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_127.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_127.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 128
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_128.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_128.Document.Body.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_128.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_128.Document.Body.ClientWidth, OBJ_MOTOR_GECKOFX_128.Document.Body.ClientHeight)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            




        End Select

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Restaura valores originais ----------------------------------------------------------------------------------------------------------------------------------

        proc_motor_tamanho_original() 'Atualiza o motor para o tamanho original

        V_TAMANHO_DO_MOTOR_ATUALMENTE = Nothing 'Limpando...

        V_TAMANHO_DA_PAGINA_EM_VISUALIZACAO = Nothing 'Limpando...

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Retorno -----------------------------------------------------

        Return OBJ_IMAGEM_TEMP_1 'Retornando imagem gerada

        '-------------------------------------------------------------


    End Function






    '# GERA IMAGEM DE SITE INCOMPLETO

    Public Function func_gerar_imagem_da_pagina_motores_geckofx(ByVal v_numero_da_aba_escolhida As Integer) 'Gera a imagem da página em visualização
        On Error Resume Next

        Dim OBJ_IMAGEM_TEMP_1 As Image = Nothing 'Ojeto imagem temporario 1





        'Selecionando motor geckofx e gerando imagem ---------------------------------------------------------------------------------------------------------------------------------------------------------------

        Select Case v_numero_da_aba_escolhida


            Case 1
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_1.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_1.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_1.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_1.Width, OBJ_MOTOR_GECKOFX_1.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 2
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_2.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_2.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_2.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_2.Width, OBJ_MOTOR_GECKOFX_2.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 3
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_3.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_3.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_3.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_3.Width, OBJ_MOTOR_GECKOFX_3.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 4
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_4.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_4.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_4.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_4.Width, OBJ_MOTOR_GECKOFX_4.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 5
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_5.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_5.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_5.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_5.Width, OBJ_MOTOR_GECKOFX_5.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 6
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_6.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_6.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_6.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_6.Width, OBJ_MOTOR_GECKOFX_6.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 7
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_7.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_7.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_7.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_7.Width, OBJ_MOTOR_GECKOFX_7.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 8
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_8.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_8.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_8.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_8.Width, OBJ_MOTOR_GECKOFX_8.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 9
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_9.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_9.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_9.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_9.Width, OBJ_MOTOR_GECKOFX_9.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 10
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_10.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_10.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_10.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_10.Width, OBJ_MOTOR_GECKOFX_10.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 11
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_11.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_11.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_11.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_11.Width, OBJ_MOTOR_GECKOFX_11.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 12
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_12.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_12.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_12.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_12.Width, OBJ_MOTOR_GECKOFX_12.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 13
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_13.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_13.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_13.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_13.Width, OBJ_MOTOR_GECKOFX_13.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 14
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_14.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_14.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_14.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_14.Width, OBJ_MOTOR_GECKOFX_14.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 15
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_15.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_15.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_15.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_15.Width, OBJ_MOTOR_GECKOFX_15.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 16
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_16.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_16.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_16.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_16.Width, OBJ_MOTOR_GECKOFX_16.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 17
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_17.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_17.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_17.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_17.Width, OBJ_MOTOR_GECKOFX_17.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 18
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_18.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_18.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_18.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_18.Width, OBJ_MOTOR_GECKOFX_18.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 19
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_19.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_19.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_19.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_19.Width, OBJ_MOTOR_GECKOFX_19.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 20
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_20.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_20.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_20.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_20.Width, OBJ_MOTOR_GECKOFX_20.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 21
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_21.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_21.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_21.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_21.Width, OBJ_MOTOR_GECKOFX_21.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 22
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_22.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_22.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_22.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_22.Width, OBJ_MOTOR_GECKOFX_22.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 23
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_23.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_23.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_23.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_23.Width, OBJ_MOTOR_GECKOFX_23.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 24
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_24.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_24.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_24.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_24.Width, OBJ_MOTOR_GECKOFX_24.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 25
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_25.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_25.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_25.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_25.Width, OBJ_MOTOR_GECKOFX_25.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 26
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_26.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_26.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_26.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_26.Width, OBJ_MOTOR_GECKOFX_26.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 27
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_27.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_27.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_27.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_27.Width, OBJ_MOTOR_GECKOFX_27.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 28
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_28.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_28.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_28.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_28.Width, OBJ_MOTOR_GECKOFX_28.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 29
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_29.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_29.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_29.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_29.Width, OBJ_MOTOR_GECKOFX_29.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 30
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_30.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_30.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_30.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_30.Width, OBJ_MOTOR_GECKOFX_30.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 31
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_31.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_31.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_31.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_31.Width, OBJ_MOTOR_GECKOFX_31.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 32
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_32.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_32.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_32.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_32.Width, OBJ_MOTOR_GECKOFX_32.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 33
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_33.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_33.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_33.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_33.Width, OBJ_MOTOR_GECKOFX_33.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 34
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_34.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_34.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_34.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_34.Width, OBJ_MOTOR_GECKOFX_34.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 35
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_35.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_35.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_35.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_35.Width, OBJ_MOTOR_GECKOFX_35.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 36
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_36.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_36.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_36.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_36.Width, OBJ_MOTOR_GECKOFX_36.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 37
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_37.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_37.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_37.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_37.Width, OBJ_MOTOR_GECKOFX_37.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 38
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_38.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_38.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_38.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_38.Width, OBJ_MOTOR_GECKOFX_38.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 39
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_39.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_39.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_39.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_39.Width, OBJ_MOTOR_GECKOFX_39.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 40
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_40.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_40.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_40.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_40.Width, OBJ_MOTOR_GECKOFX_40.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 41
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_41.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_41.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_41.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_41.Width, OBJ_MOTOR_GECKOFX_41.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 42
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_42.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_42.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_42.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_42.Width, OBJ_MOTOR_GECKOFX_42.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 43
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_43.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_43.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_43.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_43.Width, OBJ_MOTOR_GECKOFX_43.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 44
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_44.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_44.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_44.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_44.Width, OBJ_MOTOR_GECKOFX_44.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 45
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_45.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_45.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_45.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_45.Width, OBJ_MOTOR_GECKOFX_45.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 46
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_46.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_46.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_46.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_46.Width, OBJ_MOTOR_GECKOFX_46.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 47
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_47.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_47.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_47.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_47.Width, OBJ_MOTOR_GECKOFX_47.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 48
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_48.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_48.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_48.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_48.Width, OBJ_MOTOR_GECKOFX_48.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 49
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_49.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_49.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_49.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_49.Width, OBJ_MOTOR_GECKOFX_49.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 50
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_50.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_50.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_50.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_50.Width, OBJ_MOTOR_GECKOFX_50.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 51
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_51.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_51.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_51.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_51.Width, OBJ_MOTOR_GECKOFX_51.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 52
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_52.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_52.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_52.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_52.Width, OBJ_MOTOR_GECKOFX_52.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 53
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_53.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_53.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_53.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_53.Width, OBJ_MOTOR_GECKOFX_53.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 54
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_54.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_54.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_54.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_54.Width, OBJ_MOTOR_GECKOFX_54.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 55
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_55.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_55.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_55.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_55.Width, OBJ_MOTOR_GECKOFX_55.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 56
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_56.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_56.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_56.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_56.Width, OBJ_MOTOR_GECKOFX_56.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 57
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_57.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_57.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_57.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_57.Width, OBJ_MOTOR_GECKOFX_57.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 58
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_58.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_58.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_58.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_58.Width, OBJ_MOTOR_GECKOFX_58.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 59
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_59.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_59.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_59.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_59.Width, OBJ_MOTOR_GECKOFX_59.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 60
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_60.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_60.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_60.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_60.Width, OBJ_MOTOR_GECKOFX_60.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 61
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_61.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_61.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_61.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_61.Width, OBJ_MOTOR_GECKOFX_61.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 62
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_62.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_62.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_62.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_62.Width, OBJ_MOTOR_GECKOFX_62.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 63
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_63.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_63.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_63.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_63.Width, OBJ_MOTOR_GECKOFX_63.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 64
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_64.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_64.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_64.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_64.Width, OBJ_MOTOR_GECKOFX_64.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 65
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_65.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_65.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_65.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_65.Width, OBJ_MOTOR_GECKOFX_65.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 66
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_66.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_66.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_66.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_66.Width, OBJ_MOTOR_GECKOFX_66.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 67
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_67.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_67.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_67.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_67.Width, OBJ_MOTOR_GECKOFX_67.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 68
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_68.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_68.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_68.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_68.Width, OBJ_MOTOR_GECKOFX_68.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 69
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_69.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_69.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_69.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_69.Width, OBJ_MOTOR_GECKOFX_69.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 70
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_70.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_70.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_70.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_70.Width, OBJ_MOTOR_GECKOFX_70.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 71
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_71.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_71.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_71.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_71.Width, OBJ_MOTOR_GECKOFX_71.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 72
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_72.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_72.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_72.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_72.Width, OBJ_MOTOR_GECKOFX_72.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 73
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_73.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_73.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_73.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_73.Width, OBJ_MOTOR_GECKOFX_73.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 74
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_74.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_74.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_74.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_74.Width, OBJ_MOTOR_GECKOFX_74.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 75
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_75.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_75.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_75.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_75.Width, OBJ_MOTOR_GECKOFX_75.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 76
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_76.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_76.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_76.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_76.Width, OBJ_MOTOR_GECKOFX_76.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 77
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_77.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_77.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_77.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_77.Width, OBJ_MOTOR_GECKOFX_77.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 78
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_78.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_78.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_78.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_78.Width, OBJ_MOTOR_GECKOFX_78.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 79
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_79.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_79.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_79.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_79.Width, OBJ_MOTOR_GECKOFX_79.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 80
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_80.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_80.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_80.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_80.Width, OBJ_MOTOR_GECKOFX_80.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 81
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_81.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_81.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_81.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_81.Width, OBJ_MOTOR_GECKOFX_81.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 82
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_82.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_82.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_82.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_82.Width, OBJ_MOTOR_GECKOFX_82.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 83
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_83.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_83.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_83.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_83.Width, OBJ_MOTOR_GECKOFX_83.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 84
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_84.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_84.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_84.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_84.Width, OBJ_MOTOR_GECKOFX_84.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 85
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_85.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_85.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_85.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_85.Width, OBJ_MOTOR_GECKOFX_85.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 86
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_86.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_86.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_86.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_86.Width, OBJ_MOTOR_GECKOFX_86.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 87
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_87.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_87.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_87.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_87.Width, OBJ_MOTOR_GECKOFX_87.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 88
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_88.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_88.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_88.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_88.Width, OBJ_MOTOR_GECKOFX_88.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 89
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_89.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_89.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_89.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_89.Width, OBJ_MOTOR_GECKOFX_89.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 90
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_90.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_90.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_90.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_90.Width, OBJ_MOTOR_GECKOFX_90.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 91
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_91.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_91.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_91.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_91.Width, OBJ_MOTOR_GECKOFX_91.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 92
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_92.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_92.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_92.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_92.Width, OBJ_MOTOR_GECKOFX_92.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 93
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_93.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_93.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_93.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_93.Width, OBJ_MOTOR_GECKOFX_93.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 94
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_94.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_94.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_94.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_94.Width, OBJ_MOTOR_GECKOFX_94.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 95
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_95.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_95.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_95.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_95.Width, OBJ_MOTOR_GECKOFX_95.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 96
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_96.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_96.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_96.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_96.Width, OBJ_MOTOR_GECKOFX_96.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 97
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_97.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_97.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_97.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_97.Width, OBJ_MOTOR_GECKOFX_97.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 98
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_98.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_98.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_98.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_98.Width, OBJ_MOTOR_GECKOFX_98.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 99
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_99.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_99.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_99.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_99.Width, OBJ_MOTOR_GECKOFX_99.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 100
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_100.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_100.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_100.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_100.Width, OBJ_MOTOR_GECKOFX_100.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 101
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_101.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_101.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_101.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_101.Width, OBJ_MOTOR_GECKOFX_101.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 102
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_102.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_102.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_102.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_102.Width, OBJ_MOTOR_GECKOFX_102.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 103
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_103.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_103.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_103.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_103.Width, OBJ_MOTOR_GECKOFX_103.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 104
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_104.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_104.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_104.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_104.Width, OBJ_MOTOR_GECKOFX_104.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 105
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_105.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_105.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_105.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_105.Width, OBJ_MOTOR_GECKOFX_105.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 106
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_106.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_106.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_106.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_106.Width, OBJ_MOTOR_GECKOFX_106.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 107
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_107.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_107.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_107.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_107.Width, OBJ_MOTOR_GECKOFX_107.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 108
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_108.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_108.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_108.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_108.Width, OBJ_MOTOR_GECKOFX_108.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 109
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_109.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_109.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_109.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_109.Width, OBJ_MOTOR_GECKOFX_109.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 110
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_110.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_110.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_110.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_110.Width, OBJ_MOTOR_GECKOFX_110.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 111
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_111.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_111.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_111.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_111.Width, OBJ_MOTOR_GECKOFX_111.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 112
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_112.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_112.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_112.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_112.Width, OBJ_MOTOR_GECKOFX_112.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 113
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_113.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_113.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_113.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_113.Width, OBJ_MOTOR_GECKOFX_113.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 114
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_114.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_114.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_114.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_114.Width, OBJ_MOTOR_GECKOFX_114.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 115
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_115.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_115.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_115.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_115.Width, OBJ_MOTOR_GECKOFX_115.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 116
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_116.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_116.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_116.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_116.Width, OBJ_MOTOR_GECKOFX_116.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 117
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_117.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_117.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_117.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_117.Width, OBJ_MOTOR_GECKOFX_117.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 118
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_118.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_118.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_118.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_118.Width, OBJ_MOTOR_GECKOFX_118.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 119
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_119.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_119.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_119.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_119.Width, OBJ_MOTOR_GECKOFX_119.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 120
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_120.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_120.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_120.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_120.Width, OBJ_MOTOR_GECKOFX_120.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 121
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_121.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_121.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_121.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_121.Width, OBJ_MOTOR_GECKOFX_121.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 122
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_122.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_122.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_122.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_122.Width, OBJ_MOTOR_GECKOFX_122.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 123
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_123.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_123.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_123.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_123.Width, OBJ_MOTOR_GECKOFX_123.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 124
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_124.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_124.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_124.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_124.Width, OBJ_MOTOR_GECKOFX_124.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 125
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_125.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_125.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_125.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_125.Width, OBJ_MOTOR_GECKOFX_125.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 126
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_126.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_126.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_126.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_126.Width, OBJ_MOTOR_GECKOFX_126.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 127
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_127.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_127.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_127.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_127.Width, OBJ_MOTOR_GECKOFX_127.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select

            Case 128
                Dim OBJ_IMAGEM_TEMP_2 As New Bitmap(OBJ_MOTOR_GECKOFX_128.Document.DocumentElement.ClientWidth, OBJ_MOTOR_GECKOFX_128.Document.DocumentElement.ClientHeight) 'Gerando imagem do geckofx
                OBJ_MOTOR_GECKOFX_128.DrawToBitmap(OBJ_IMAGEM_TEMP_2, New Rectangle(0, 0, OBJ_MOTOR_GECKOFX_128.Width, OBJ_MOTOR_GECKOFX_128.Height)) 'Criando imagem
                OBJ_IMAGEM_TEMP_1 = OBJ_IMAGEM_TEMP_2 'Igualando imagens
                Exit Select






        End Select

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Nao permite imagem sem pixel --------------------------------------------------------------

        If (OBJ_IMAGEM_TEMP_1.PixelFormat = Nothing) Then


            OBJ_IMAGEM_TEMP_1 = FRM_NAVEGACAO.LST_2.Images.Item(0) 'Imagem em branco


        End If

        '-------------------------------------------------------------------------------------------





        'Retorno -----------------------------------------------------

        Return OBJ_IMAGEM_TEMP_1 'Retornando imagem gerada

        '-------------------------------------------------------------


    End Function

    Public Function func_gerar_favicon_de_web_sites(ByVal V_URL As String) 'Gera o favicon da página visitada
        On Error Resume Next

        Dim URI As New Uri(V_URL) 'Retorna o endereço do site em aberto)

        Dim V_FAVICON_URL As String = "http://" & URI.Host & "/favicon.ico" 'Obtém o endereço do favicon






        'Baixando a imagem ---------------------------------------------------------------------------------------------

        Dim REQUEST As System.Net.WebRequest = System.Net.HttpWebRequest.Create(V_FAVICON_URL) 'Request

        Dim RESPOSTA As System.Net.WebResponse = REQUEST.GetResponse 'Resposta

        Dim STREAM As System.IO.Stream = RESPOSTA.GetResponseStream() 'Dados

        Dim FAVICON_IMAGEM As Image = Image.FromStream(STREAM) 'Imagem

        '---------------------------------------------------------------------------------------------------------------




        'Retorno ----------------------------------------------------------------------------------------

        If (FAVICON_IMAGEM.PixelFormat = Nothing) Then


            FAVICON_IMAGEM = FRM_NAVEGACAO.LST_3.Images.Item(0) 'Imagem em branco


        End If

        '------------------------------------------------------------------------------------------------




        'Gera miniatura da imagem do favicon ------------------------------------------------------------

        FAVICON_IMAGEM = FAVICON_IMAGEM.GetThumbnailImage(16, 16, Nothing, Nothing) 'Miniatura

        '------------------------------------------------------------------------------------------------




        'Retorno ----------------------------------------------------------------------------------------

        Return FAVICON_IMAGEM 'Retorno de imagem

        '------------------------------------------------------------------------------------------------


    End Function






    'Manipuladores da imagem

    Public Function func_gerar_miniatura_de_imagem_obtida(ByVal v_escala As Integer, ByVal obj_imagem_temp As Image) 'Gera a miniatura da imagem baixada pelo navegador
        On Error Resume Next

        Dim OBJ_IMAGEM_TEMP_JA_PROCESSADA As Image 'Imagem já processada






        'Gerando imagem miniatura da informada ------------------------------------------------------------------------------------------------

        OBJ_IMAGEM_TEMP_JA_PROCESSADA = obj_imagem_temp.GetThumbnailImage(v_escala, v_escala, Nothing, Nothing) 'Gerando miniatura

        '--------------------------------------------------------------------------------------------------------------------------------------


        'Retorno ----------------------------------------------------

        Return OBJ_IMAGEM_TEMP_JA_PROCESSADA 'Retorno...

        '------------------------------------------------------------


    End Function












































End Module
